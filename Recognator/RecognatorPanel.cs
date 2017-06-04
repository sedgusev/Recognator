using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Emgu.CV;
using System.Diagnostics;
using Emgu.CV.Structure;
using Emgu.CV.Util;
using System.Threading;
using System.Text.RegularExpressions;

namespace Recognator
{
    public partial class RecognatorPanel : UserControl
    {
        Settings PARRENT;
        _AddLabelAndImage _addLabelAndImage;
        _ClearPanel _clearPanel;

        public RecognatorPanel(Settings parrent)
        {
            InitializeComponent();
            PARRENT = parrent;
            PARRENT._recognator = new RecognatorBrains();
            _addLabelAndImage = new _AddLabelAndImage(AddLabelAndImage);
            _clearPanel = new _ClearPanel(clearPanel);
            detectWorker.ProgressChanged += (a, b) => {
                workStatus.Visible = true;
            };
        }
        private void panelLoad(object sender, EventArgs e)
        {
            Application.Idle += getFrame;
            try
            {
                SqlCommand query = new SqlCommand("select number from License", PARRENT.connection);
                PARRENT.reader = query.ExecuteReader();
            }
            catch (SqlException sql)
            {

                MessageBox.Show(sql.Message);
            }
            catch (Exception)
            {
                MessageBox.Show("Unknown error");
            }
        }

        private void getFrame(object sender, EventArgs arg)
        {
            try
            {
                PARRENT.m = PARRENT.capture.QueryFrame();
                displayImage(PARRENT.m.Bitmap);
                if (!detectWorker.IsBusy)
                {
                    if (!detectWorker.CancellationPending)
                    {
                        detectWorker.RunWorkerAsync();
                    }
                }
            }
            catch (NullReferenceException e)
            {
                Application.Idle -= getFrame;
                PARRENT.capture.Stop();
                PARRENT.capture.Dispose();
                MessageBox.Show(e.Message);
            }
        }

        private delegate void _displayImage(Bitmap image);
        private void displayImage(Bitmap image)
        {

            if (pictureBox1.InvokeRequired)
            {
                try
                {
                    _displayImage DI = new _displayImage(displayImage);
                    this.BeginInvoke(DI, new object[] { image });
                }
                catch (Exception ex)
                {
                }
            }
            else
            {
                pictureBox1.Image = image;
            }
        }
        private delegate void _ClearPanel();
        private void clearPanel()
        {
            //panel1.Controls.Clear();
        }
        private void ProcessImage(IInputOutputArray image)
        {
            Stopwatch watch = Stopwatch.StartNew(); // time the detection process

            List<IInputOutputArray> licensePlateImagesList = new List<IInputOutputArray>();
            List<IInputOutputArray> filteredLicensePlateImagesList = new List<IInputOutputArray>();
            List<RotatedRect> licenseBoxList = new List<RotatedRect>();
            List<string> words = PARRENT._recognator.DetectLicensePlate(
               image,
               licensePlateImagesList,
               filteredLicensePlateImagesList,
               licenseBoxList);

            watch.Stop(); //stop the timer


            Point startPoint = new Point(10, 10);
            if (words.Count != 0)
            {
                this.Controls.Owner.Invoke(new _ClearPanel(clearPanel));
                for (int i = 0; i < words.Count; i++)
                {
                    Mat dest = new Mat();
                    CvInvoke.VConcat(licensePlateImagesList[i], filteredLicensePlateImagesList[i], dest);

                    this.Controls.Owner.Invoke(_addLabelAndImage,
                                                      startPoint,
                                  String.Format("{0}", words[i]),
                                                     dest, watch);

                    PointF[] verticesF = licenseBoxList[i].GetVertices();
                    Point[] vertices = Array.ConvertAll(verticesF, Point.Round);
                    using (VectorOfPoint pts = new VectorOfPoint(vertices))
                        CvInvoke.Polylines(image, pts, true, new Bgr(Color.Yellow).MCvScalar, 2);

                }
                Thread.Sleep(3000);
            }

        }
        private delegate void _AddLabelAndImage(ref Point startPoint, String labelText, IImage image, Stopwatch watch);
        private void AddLabelAndImage(ref Point startPoint, String labelText, IImage image, Stopwatch watch)
        {
            labelText = labelText.Replace(" ", "");
            string str = PARRENT.regex.Match(labelText).ToString();
            string str2 = Regex.Replace(labelText, str, String.Empty);
            string str3 = PARRENT.regex2.Match(str2).ToString();

            if (str != String.Empty)
            {
                plateMain_textBox.Text = str;
                plateRegion_textBox.Text = str3;

                if (PARRENT.dbConnect.Checked)
                {

                    while (PARRENT.reader.Read())
                    {
                        if (PARRENT.reader[0].ToString().Equals(str + str3))
                        {
                            label1.Visible = true;
                            label2.Visible = false;
                        }
                        else
                        {
                            label2.Visible = true;
                            label1.Visible = false;
                        }
                    }
                }
            }

            //logBox.Text += "\n" + DateTime.Now + ": " + watch.ElapsedMilliseconds + "мс: [" + plateMain_textBox.Text + "|" + plateRegion_textBox.Text + "]";

        }

        #region Worker
        private void startDetect()
        {
            ProcessImage(PARRENT.m);
        }
        private void processWorker(object sender, DoWorkEventArgs e)
        {
            detectWorker.ReportProgress(1);
            startDetect();
        }

        private void completeWorker(object sender, RunWorkerCompletedEventArgs e)
        {
            workStatus.Visible = false;
        }

        private void closingForm(object sender, FormClosingEventArgs e)
        {
            Application.Idle -= getFrame;
        }



        #endregion
    }
}
