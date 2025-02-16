﻿using Emgu.CV;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recognator
{
    public partial class LoadForm : Form
    {
        Capture capture;
        RecognatorForm rf;
        private bool flag;
        public string filePath;

        //user settings default
        public string USER = "sedgusev";
        public string PASSWORD = "170396";
        public string IP = "192.168.0.2";
        public string PORT = "8080";

        SqlConnection connection;
        public LoadForm()
        {
            InitializeComponent();
        }




        #region ListBox_ItemsCLick
        private void radMenuItem1_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings(this);
            settings.ShowDialog();
            flag = true;
            runProcess();
        }

        private void radMenuItem2_Click(object sender, EventArgs e)
        {
            flag = false;
            LoadFIle lf = new LoadFIle(this);
            lf.ShowDialog();
            if (filePath != string.Empty)
            {
                runProcess();
            }
        } 
        #endregion

        private void runProcess()
        {
            panel1.Visible = false;
            panel2.Visible = true;
            captureLoadWorker.ProgressChanged += (a, b) =>
            {
                error_label.Visible = true;
                panel1.Visible = true;
                panel2.Visible = false;
            };
            if (!captureLoadWorker.CancellationPending)
            {
                captureLoadWorker.RunWorkerAsync();
            }
        }

        private void processWorker(object sender, DoWorkEventArgs e)
        {
            if (capture != null) capture.Dispose();
            if (flag) capture = new Capture("http://" + USER + ":" + PASSWORD + "@" + IP + ":" + PORT + "/video");
            if (!flag) capture = new Capture(filePath);
            if (capture.QueryFrame() != null)
            {
                rf = new RecognatorForm(capture, connection);
                rf.FormClosed += (a, b) =>
                {
                    this.panel1.Visible = true;
                    this.Visible = true;
                    this.Refresh();
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
                panel1.Visible = true;
                rf.Show();
            }
        }

        private void radMenuItem3_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings(this);
            settings.ShowDialog();
        }

        private void radMenuItem4_Click(object sender, EventArgs e)
        {
            Teach tc = new Teach();
            tc.ShowDialog();
        }

        private void closingForm(object sender, FormClosingEventArgs e)
        {
            if (capture != null)
            {
                capture.Dispose();
            }
            connection.Close();
        }

        private void formLoad(object sender, EventArgs e)
        {


            try
            {
                connection = new SqlConnection("Server=tcp:sedgusev.database.windows.net,1433;Initial Catalog=recognatordb;Persist Security Info=False;User ID=sedgusev;Password=$IWM13d4;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

                connection.Open();

                SqlDataReader reader;
                SqlCommand command = new SqlCommand("select * from Person",connection);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    MessageBox.Show(reader[2].ToString());
                }
                
            }
            catch (SqlException exc)
            {
                MessageBox.Show(exc.Message);
            }
            catch(Exception)
            {
                MessageBox.Show("Unknown error");
            }
        }

        private void radMenuItem5_Click(object sender, EventArgs e)
        {

        }
    }
}
