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

        public RecognatorForm(Emgu.CV.Capture capture)
        {
            this.capture = capture;
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
            Label label = new Label();
            labelText = labelText.Replace(" ", "");
            string str = regex.Match(labelText).ToString();
            plateMain_textBox.Text = regex.Match(labelText).ToString();
            string str2 = Regex.Replace(labelText, str, String.Empty);
            plateRegion_textBox.Text = regex2.Match(str2).ToString();


            startPoint.Y += plateNumber.Height + 100;

            ImageBox box = new ImageBox();
            panel1.Controls.Add(box);
            box.ClientSize = image.Size;
            box.Image = image;
            box.Location = startPoint;
            startPoint.Y += box.Height + 10;
            //logBox.Text += "\n" + DateTime.Now + ": " + watch.ElapsedMilliseconds + "ìñ: [" + plateMain_textBox.Text + "|" + plateRegion_textBox.Text + "]";

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



        #endregion

        private void stop_button_Click(object sender, EventArgs e)
        {
            if (stop_button.Text == "ÑÒÀÐÒ")
            {
                if (!detectWorker.IsBusy)
                {
                    stop_button.Text = "ÑÒÎÏ";
                    detectWorker.RunWorkerAsync();
                }
            }
            if (stop_button.Text == "ÑÒÎÏ")
            {
                if (!detectWorker.CancellationPending)
                {
                    detectWorker.CancelAsync();
                    stop_button.Text = "ÑÒÀÐÒ";
                }
            }
        }
    }

}