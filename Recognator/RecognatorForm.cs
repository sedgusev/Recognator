using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.UI;
using System.Diagnostics;
using Emgu.CV.Util;
using System.Threading;
using System.Text.RegularExpressions;
using System.ComponentModel;
using System.Data.SqlClient;

namespace Recognator
{
   public partial class RecognatorForm : Form
   {
        private RecognatorBrains _recognator;
        Emgu.CV.Capture capture;
        Mat m;
        _AddLabelAndImage _addLabelAndImage;
        _ClearPanel _clearPanel;
        Regex regex;
        Regex regex2;
        string pattern = @"[A-Z][0-9][0-9][0-9][A-Z][A-Z]";
        string pattern2 = @"[0-9]{2,3}";
        Thread detect;
        //Sql
        SqlConnection connection;
        SqlDataReader reader;

        public RecognatorForm(Emgu.CV.Capture capture, SqlConnection connection)
        {
            this.capture = capture;
            this.connection = connection;
            InitializeComponent();
            initialLocals();

            //login_textBox.Text = "sedgusev";
            //passw_textBox.Text = "170396";
            //ip_textBox.Text = "192.168.0.2";
            //port_textBox.Text = "8080";
        }
        private void initialLocals()
        {
            _recognator = new RecognatorBrains();
            _addLabelAndImage = new _AddLabelAndImage(AddLabelAndImage);
            _clearPanel = new _ClearPanel(clearPanel);
            regex = new Regex(pattern, RegexOptions.IgnoreCase);
            regex2 = new Regex(pattern2, RegexOptions.IgnoreCase);
            detectWorker.ProgressChanged += (a, b) => {
                workStatus.Visible = true;
            };
        }
        private void formLoad(object sender, EventArgs e)
        {
            Application.Idle += getFrame;
            try
            {
                SqlCommand query = new SqlCommand("select number from License", connection);
                reader = query.ExecuteReader();
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

        private delegate void _ClearPanel();
        private void clearPanel()
        {
            panel1.Controls.Clear();
        }
        private void ProcessImage(IInputOutputArray image)
      {
         Stopwatch watch = Stopwatch.StartNew(); // time the detection process

         List<IInputOutputArray> licensePlateImagesList = new List<IInputOutputArray>();
         List<IInputOutputArray> filteredLicensePlateImagesList = new List<IInputOutputArray>();
         List<RotatedRect> licenseBoxList = new List<RotatedRect>();
         List<string> words = _recognator.DetectLicensePlate(
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
            string str = regex.Match(labelText).ToString();
            string str2 = Regex.Replace(labelText, str, String.Empty);
            string str3 = regex2.Match(str2).ToString();

            if (str != String.Empty)
            {
                plateMain_textBox.Text = str;
                plateRegion_textBox.Text = str3;

                PictureBox box = new PictureBox();
                panel1.Controls.Add(box);
                box.ClientSize = image.Size;
                box.Image = image.Bitmap;
                box.Location = startPoint;
                startPoint.Y += box.Height;
                panel1.Visible = true;

                while (reader.Read())
                {
                    if (reader[0].ToString().Equals(str + str3))
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

            //logBox.Text += "\n" + DateTime.Now + ": " + watch.ElapsedMilliseconds + "��: [" + plateMain_textBox.Text + "|" + plateRegion_textBox.Text + "]";

        }  
        
        
        private void getFrame(object sender, EventArgs arg)
        {
            try
            {
                m = capture.QueryFrame();
                displayImage(m.Bitmap);
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
                capture.Stop();
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


        #region Worker
        private void startDetect()
        {
            ProcessImage(m);
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

        //private void stop_button_Click(object sender, EventArgs e)
        //{
        //    if (stop_button.Text == "�����")
        //    {
        //        if (!detectWorker.IsBusy)
        //        {
        //            stop_button.Text = "����";
        //            detectWorker.RunWorkerAsync();
        //        }
        //    }
        //    if (stop_button.Text == "����")
        //    {
        //        if (!detectWorker.CancellationPending)
        //        {
        //            detectWorker.CancelAsync();
        //            stop_button.Text = "�����";
        //        }
        //    }
        //}
    }

}