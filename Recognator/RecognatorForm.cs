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

namespace Recognator
{
   public partial class RecognatorForm : Form
   {
      private RecognatorBrains _licensePlateDetector;
        Capture capture;
        Mat m;
        _AddLabelAndImage _addLabelAndImage;
        _ClearPanel _clearPanel;
        private bool isStarted = false;

        public RecognatorForm()
        {
            InitializeComponent();
            _licensePlateDetector = new RecognatorBrains();
            capture = new Capture("http://sedgusev:170396@192.168.0.3:8080/video");
            _addLabelAndImage = new _AddLabelAndImage(AddLabelAndImage);
            _clearPanel = new _ClearPanel(clearPanel);
        }
        private delegate void dFillLabels(Stopwatch watch);
        
        private void fill_labels(Stopwatch watch)
        {
            processTimeLabel.Text = String.Format("License Plate Recognition time: {0} milli-seconds", watch.Elapsed.TotalMilliseconds);
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
         List<string> words = _licensePlateDetector.DetectLicensePlate(
            image,
            licensePlateImagesList,
            filteredLicensePlateImagesList,
            licenseBoxList);

         watch.Stop(); //stop the timer

            processTimeLabel.Invoke(new dFillLabels(fill_labels), watch);

            this.Controls.Owner.Invoke(_clearPanel);
         Point startPoint = new Point(10, 10);
         for (int i = 0; i < words.Count; i++)
         {
            Mat dest = new Mat();
            CvInvoke.VConcat(licensePlateImagesList[i], filteredLicensePlateImagesList[i], dest);



                this.Controls.Owner.Invoke(_addLabelAndImage,  startPoint,
               String.Format("License: {0}", words[i]),
               dest);
               // _addLabelAndImage.Invoke(ref startPoint,
               //String.Format("License: {0}", words[i]),
               //dest);



            //AddLabelAndImage(
            //   ref startPoint,
            //   String.Format("License: {0}", words[i]),
            //   dest);
            PointF[] verticesF = licenseBoxList[i].GetVertices();
            Point[] vertices = Array.ConvertAll(verticesF, Point.Round);
            using(VectorOfPoint pts = new VectorOfPoint(vertices))
               CvInvoke.Polylines(image, pts, true, new Bgr(Color.Red).MCvScalar,2  );
            
         }
            Thread.Sleep(5000);

      }


        private delegate void _AddLabelAndImage(ref Point startPoint, String labelText, IImage image);


      private void AddLabelAndImage(ref Point startPoint, String labelText, IImage image)
      {
         Label label = new Label();
         panel1.Controls.Add(label);
         label.Text = labelText;
         label.Width = 100;
         label.Height = 30;
         label.Location = startPoint;
         startPoint.Y += label.Height;

         ImageBox box = new ImageBox();
         panel1.Controls.Add(box);
         box.ClientSize = image.Size;
         box.Image = image;
         box.Location = startPoint;
         startPoint.Y += box.Height + 10;
      }

      private void button1_Click(object sender, EventArgs e)
      {
         DialogResult result = openFileDialog1.ShowDialog();
         if (result == DialogResult.OK)
         {
            try
            {
                    //img = CvInvoke.Imread(openFileDialog1.FileName, LoadImageType.Grayscale);
                    //Image img = new Image(openFileDialog1.FileName);
                    string path = openFileDialog1.FileName;
                    capture = new Capture(path);
               m = capture.QueryFrame();
               //UMat um = m.ToUMat(AccessType.ReadWrite);
               pictureBox1.Image = m.Bitmap;
               //ProcessImage(m);

                }
            catch
            {
               MessageBox.Show(String.Format("Invalide File: {0}", openFileDialog1.FileName.Replace("\\","/")));
               return;
            }

            //UMat uImg = img.ToUMat(AccessType.ReadWrite);
            ProcessImage(m);
         }
      }

        private void button2_Click(object sender, EventArgs e)
        {
            isStarted = !isStarted;
            if (isStarted)
            {
                button2.Text = "STOP";
                try
                {
                    if(capture == null) capture = new Capture("http://sedgusev:170396@192.168.0.3:8080/video");
                }
                catch (Exception)
                {
                }
                Application.Idle += initBrains;
            }
            else
            {
                Application.Idle -= initBrains;
                capture.Stop();
                button2.Text = "START";
            }

        }

        Thread detect;
        private void initBrains(object sender, EventArgs arg)
        {
            m = capture.QueryFrame();
            pictureBox1.Image = m.Bitmap;
            if (detect == null)
            {
                detect = new Thread(() => ProcessImage(m));
                detect.Start();
            }

            if (!detect.IsAlive)
            {
                detect = new Thread(() => ProcessImage(m));
                detect.Start();
            }


        }
    }

}