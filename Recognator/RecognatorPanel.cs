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
using System.Diagnostics;
using System.Threading;
using System.Text.RegularExpressions;

namespace Recognator
{
    public partial class RecognatorPanel : UserControl
    {
        MainForm PARRENT;
        _AddLabelAndImage _addLabelAndImage;
        _ClearPanel _clearPanel;

        public RecognatorPanel(MainForm parrent)
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
                Thread.Sleep(2);
            }
            catch (NullReferenceException)
            {
                Application.Idle -= getFrame;
                PARRENT.capture.Stop();
                PARRENT.capture.Dispose();
                
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
        private void ProcessImage(Emgu.CV.IInputOutputArray image)
        {
            Stopwatch watch = Stopwatch.StartNew(); // time the detection process

            List<Emgu.CV.IInputOutputArray> licensePlateImagesList = new List<Emgu.CV.IInputOutputArray>();
            List<Emgu.CV.IInputOutputArray> filteredLicensePlateImagesList = new List<Emgu.CV.IInputOutputArray>();
            List<Emgu.CV.Structure.RotatedRect> licenseBoxList = new List<Emgu.CV.Structure.RotatedRect>();
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
                    Emgu.CV.Mat dest = new Emgu.CV.Mat();
                    Emgu.CV.CvInvoke.VConcat(licensePlateImagesList[i], filteredLicensePlateImagesList[i], dest);

                    this.Controls.Owner.Invoke(_addLabelAndImage,
                                                      startPoint,
                                  String.Format("{0}", words[i]),
                                                     dest, watch);

                    PointF[] verticesF = licenseBoxList[i].GetVertices();
                    Point[] vertices = Array.ConvertAll(verticesF, Point.Round);
                    using (Emgu.CV.Util.VectorOfPoint pts = new Emgu.CV.Util.VectorOfPoint(vertices))
                        Emgu.CV.CvInvoke.Polylines(image, pts, true, new Emgu.CV.Structure.Bgr(Color.Yellow).MCvScalar, 2);

                }
                Thread.Sleep(500);
            }

        }
        private delegate void _AddLabelAndImage(ref Point startPoint, String labelText, Emgu.CV.IImage image, Stopwatch watch);
        private void AddLabelAndImage(ref Point startPoint, String labelText, Emgu.CV.IImage image, Stopwatch watch)
        {
            labelText = labelText.Replace(" ", "");
            labelText = labelText.Replace("\n", "");
            labelText = labelText.Replace("\r", "");
            labelText = labelText.Replace("-", "");
            if (!labelText.Equals(String.Empty) && labelText.Length >= 6)
            {
                string str = PARRENT.regex.Match(labelText).ToString();
                str = str.Replace("Y", "У");
                labelText = labelText.Replace("Y", "У");
                string str2 = Regex.Replace(labelText, str, String.Empty);
                string str3 = PARRENT.regex2.Match(str2).ToString();

                if (str != String.Empty)
                {
                    plateMain_textBox.Text = str;
                    plateRegion_textBox.Text = str3;

                    if (PARRENT.usData)
                    {
                        PARRENT.reader = PARRENT.query.ExecuteReader();
                        if (PARRENT.reader != null)
                        {
                            while (PARRENT.reader.Read())
                            {
                                if (PARRENT.reader[0].ToString().Substring(0,6).Equals(str)) //для первой части номера, для начала
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
                        PARRENT.reader.Close();
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

        private void removed(object sender, ControlEventArgs e)
        {
            PARRENT.capture.Dispose();
            PARRENT.m.Dispose();
            pictureBox1.Dispose();
        }
    }
}
