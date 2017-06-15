using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recognator
{
    public partial class LoginPanel : UserControl
    {
        MainForm PARRENT;
        //autorized data
        public string LOGIN = "admin";
        public string PASSWORD = "admin";

        public LoginPanel(MainForm parent)
        {
            InitializeComponent();
            PARRENT = parent;
        }

        private void main_panel_loginBtn_Click(object sender, EventArgs e)
        {
        }
    }
}
