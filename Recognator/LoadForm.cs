using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recognator
{
    public partial class LoadForm : Form
    {
        CaptureHolder ch;
        RecognatorForm rf;
        private bool flag;

        //user settings default
        private string USER = "sedgusev";
        private string PASSWORD = "170396";
        private string IP = "192.168.0.2";
        private string PORT = "8080";

        public LoadForm()
        {
            InitializeComponent();
        }




        #region ListBox_ItemsCLick
        private void radMenuItem1_Click(object sender, EventArgs e)
        {
            flag = true;
            runProcess();
        }

        private void radMenuItem2_Click(object sender, EventArgs e)
        {
            flag = false;
            runProcess();
        } 
        #endregion

        private void runProcess()
        {
            error_label.Visible = false;
            radDropDownButton1.Visible = false;
            progressBar1.Visible = true;
            captureLoadWorker.ProgressChanged += (a, b) =>
            {
                error_label.Visible = true;
                radDropDownButton1.Visible = true;
                progressBar1.Visible = false;
            };
            if (!captureLoadWorker.CancellationPending)
            {
                captureLoadWorker.RunWorkerAsync();
            }
        }

        private void processWorker(object sender, DoWorkEventArgs e)
        {
            if(flag) ch = new CaptureHolder("http://" + USER + ":" + PASSWORD + "@" + IP + ":" + PORT + "/video");
            if (!flag) ch = new CaptureHolder("");
            if (ch.GetCapture.QueryFrame() != null)
            {
                rf = new RecognatorForm(ch.GetCapture);
                rf.FormClosed += (a, b) =>
                {
                    this.Close();
                };
            }
            else
            {
                captureLoadWorker.ReportProgress(5);
            }
        }

        private void completeWorker(object sender, RunWorkerCompletedEventArgs e)
        {
            if (rf != null)
            {
                this.Visible = false;
                rf.Show();
            }
        }
    }
}
