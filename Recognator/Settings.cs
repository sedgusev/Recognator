using Emgu.CV;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recognator
{
    public partial class Settings : Form
    {
        //screens
        public LoginPanel lp;
        public CameraPanel cp;
        public DemoPanel dp;
        public TeachPanel tp;
        public TeachingPanel tgp;
        public RecognatorPanel rp;

        //global objects
        public Emgu.CV.Capture capture;
        public bool flag;
        public string filePath;
        public SqlConnection connection;
        public RecognatorBrains _recognator;
        public Mat m;
        public Regex regex;
        public Regex regex2;
        public string pattern = @"[A-Z][0-9][0-9][0-9][A-Z][A-Z]";
        public string pattern2 = @"[0-9]{2,3}";
        public SqlDataReader reader;
        public string PAthToVideo;


        //user settings default
        private string lv_USER = "sedgusev";
        private string lv_PASSWORD = "170396";
        private string lv_IP = "192.168.0.2";
        private string lv_PORT = "8080";


        public Settings()
        {
            InitializeComponent();
            initialLocals();
        }

        private void initialLocals()
        {
            regex = new Regex(pattern, RegexOptions.IgnoreCase);
            regex2 = new Regex(pattern2, RegexOptions.IgnoreCase);
        }

        #region sidepanel

        private void collapseBtn_Click(object sender, EventArgs e)
        {
            if(sidepanel.Width == 50)
            {
                sidepanel.Visible = false;
                sidepanel.Width = 212;
                animator1.ShowSync(sidepanel);
            }
            else
            {
                sidepanel.Visible = false;
                sidepanel.Width = 50;
                animator1.ShowSync(sidepanel);
            }
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            container.Controls.Clear();
            container.Controls.Add(lp);


        }

        private void cameraBtn_Click(object sender, EventArgs e)
        {
            container.Controls.Clear();
            container.Controls.Add(cp);
        }
        private void demoBtn_Click(object sender, EventArgs e)
        {
            container.Controls.Clear();
            container.Controls.Add(dp);
        }
        private void settingsBtn_Click(object sender, EventArgs e)
        {
            container.Controls.Clear();
            container.Controls.Add(tp);
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception close)
            {
                MessageBox.Show(close.Message);
            }
        }

        #endregion

        #region camera_panel
        private void okBtn_Click(object sender, EventArgs e)
        {
            //lv_USER = this.USER.Text;
            //lv_PASSWORD = this.PASSWORD.Text;
            //lv_IP = this.IP.Text;
            //lv_PORT = this.PORT.Text;
        }
        #endregion

        #region teach_panel

        #endregion

        #region teach_process_panel

        #endregion

        #region demo_panel

        #endregion

        #region main_panel

        #endregion

        #region Drag&Drop

        private Point mouseOffset;
        private bool isMouseDown = false;

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) this.Close();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            int xOffset;
            int yOffset;

            if (e.Button == MouseButtons.Left)
            {
                xOffset = -e.X - SystemInformation.FrameBorderSize.Width;
                yOffset = -e.Y - SystemInformation.CaptionHeight -
                  SystemInformation.FrameBorderSize.Height;
                mouseOffset = new Point(xOffset, yOffset);
                isMouseDown = true;
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouseOffset.X, mouseOffset.Y);
                Location = mousePos;
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            // Changes the isMouseDown field so that the form does
            // not move unless the user is pressing the left mouse button.
            if (e.Button == MouseButtons.Left)
            {
                isMouseDown = false;
            }
        }




        #endregion

        #region form
        private void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            if (capture != null) capture.Dispose();
            if (flag) capture = new Emgu.CV.Capture("http://" + lv_USER + ":" + lv_PASSWORD + "@" + lv_IP + ":" + lv_PORT + "/video");
            if (!flag) capture = new Emgu.CV.Capture(filePath);
            if (capture.QueryFrame() != null)
            {
                //rf.FormClosed += (a, b) =>
                //{
                //    this.panel1.Visible = true;
                //    this.Visible = true;
                //    this.Refresh();
                //};
            }
            else
            {
                captureLoadWorker.ReportProgress(5);
            }
        }

        private void worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            errorPanel.Visible = true;
            if (flag)
            {
                container.Controls.Clear();
                container.Controls.Add(cp);
            }
            if (!flag)
            {
                container.Controls.Clear();
                container.Controls.Add(dp);
            }

        }

        private void worker_Completed(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!errorPanel.Visible)
            {
                container.Controls.Clear();
                if (rp == null) rp = new RecognatorPanel(this);
                container.Controls.Add(rp);
            }

        }

        private void formLoad(object sender, EventArgs e)
        {
            lp = new LoginPanel(this);
            cp = new CameraPanel(this);
            dp = new DemoPanel(this);
            tp = new TeachPanel(this);

            try
            {
                if (dbConnect.Checked)
                {
                    connection = new SqlConnection("Server=tcp:sedgusev.database.windows.net,1433;Initial Catalog=recognatordb;Persist Security Info=False;User ID=sedgusev;Password=$IWM13d4;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

                    connection.Open();

                    SqlCommand query = new SqlCommand("select number from License", connection);
                    reader = query.ExecuteReader();
                }

            }
            catch (SqlException exc)
            {
                MessageBox.Show(exc.Message);
            }
            catch (Exception)
            {
                MessageBox.Show("Unknown error");
            }
        }


        #endregion


        #region Logic
        public void runProcess()
        {
            errorPanel.Visible = false;
            container.Controls.Clear();
            container.Controls.Add(new waiting());
            if (!captureLoadWorker.CancellationPending)
            {
                captureLoadWorker.RunWorkerAsync();
            }
        }

        #endregion

        private void formCLosing(object sender, FormClosingEventArgs e)
        {
            capture.Dispose();
            connection.Close();
        }
    }
}
