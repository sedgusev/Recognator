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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recognator
{
    public partial class Settings : Form
    {
        Capture capture;
        private bool flag;
        public string filePath;

        //user settings default
        private string lv_USER = "sedgusev";
        private string lv_PASSWORD = "170396";
        private string lv_IP = "192.168.0.2";
        private string lv_PORT = "8080";

        SqlConnection connection;


        public Settings()
        {
            InitializeComponent();
        }

        #region sidepanel

        private void collapseBtn_Click(object sender, EventArgs e)
        {
            if(sidepanel.Width == 50)
            {
                sidepanel.Visible = false;
                sidepanel.Width = 412;
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
            flag = true;
            SwitchAnimator.Hide(camera_panel);
            SwitchAnimator.Hide(teach_panel);
            SwitchAnimator.Hide(teach_process_panel);
            SwitchAnimator.Hide(demo_panel);
            SwitchAnimator.ShowSync(main_panel);
        }

        private void cameraBtn_Click(object sender, EventArgs e)
        {
            flag = false;
            SwitchAnimator.Hide(teach_panel);
            SwitchAnimator.Hide(teach_process_panel);
            SwitchAnimator.Hide(demo_panel);
            SwitchAnimator.Hide(main_panel);
            SwitchAnimator.ShowSync(camera_panel);
        }
        private void demoBtn_Click(object sender, EventArgs e)
        {
            SwitchAnimator.Hide(teach_panel);
            SwitchAnimator.Hide(teach_process_panel);
            SwitchAnimator.Hide(main_panel);
            SwitchAnimator.Hide(camera_panel);
            SwitchAnimator.ShowSync(demo_panel);
        }
        private void settingsBtn_Click(object sender, EventArgs e)
        {
            SwitchAnimator.Hide(teach_process_panel);
            SwitchAnimator.Hide(main_panel);
            SwitchAnimator.Hide(camera_panel);
            SwitchAnimator.Hide(demo_panel);
            SwitchAnimator.Show(teach_panel);
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception)
            {
            }
        }

        #endregion


        #region camera_panel
        private void okBtn_Click(object sender, EventArgs e)
        {
            lv_USER = this.USER.Text;
            lv_PASSWORD = this.PASSWORD.Text;
            lv_IP = this.IP.Text;
            lv_PORT = this.PORT.Text;
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
            if (flag) capture = new Capture("http://" + USER + ":" + PASSWORD + "@" + IP + ":" + PORT + "/video");
            if (!flag) capture = new Capture(filePath);
            if (capture.QueryFrame() != null)
            {
                //rf = new RecognatorForm(capture, connection);
                //rf.FormClosed += (a, b) =>
                //{
                //    this.panel1.Visible = true;
                //    this.Visible = true;
                //    this.Refresh();
                //};
            }
            else
            {
                backgroundWorker.ReportProgress(5);
            }
        }

        private void worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }

        private void worker_Completed(object sender, RunWorkerCompletedEventArgs e)
        {

        }

        private void formLoad(object sender, EventArgs e)
        {
            try
            {
                connection = new SqlConnection("Server=tcp:sedgusev.database.windows.net,1433;Initial Catalog=recognatordb;Persist Security Info=False;User ID=sedgusev;Password=$IWM13d4;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

                connection.Open();

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
    }
}
