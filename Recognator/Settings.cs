using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recognator
{
    public partial class Settings : Form
    {
        LoadForm parrent;

        public Settings(LoadForm parrent)
        {
            InitializeComponent();
            this.parrent = parrent;
            this.USER.Text = parrent.USER;
            this.PASSWORD.Text = parrent.PASSWORD;
            this.IP.Text = parrent.IP;
            this.PORT.Text = parrent.PORT;
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            parrent.USER = this.USER.Text;
            parrent.PASSWORD = this.PASSWORD.Text;
            parrent.IP = this.IP.Text;
            parrent.PORT = this.PORT.Text;
            this.Close();
        }
    }
}
