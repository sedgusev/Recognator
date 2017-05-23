using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Recognator
{
    public partial class LoadFIle : Form
    {
        private LoadForm form;
        public LoadFIle(LoadForm form)
        {
            this.form = form;
            InitializeComponent();
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                radTextBox1.Text = openFileDialog1.FileName;
                form.filePath = openFileDialog1.FileName;
                this.Close();
            }
        }

        private void radButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
