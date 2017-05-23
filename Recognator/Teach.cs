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
    public partial class Teach : Form
    {
        private string path;
        private bool radChecked = false;


        public Teach()
        {
            InitializeComponent();
        }


        //select directory dialog
        private void radButton1_Click(object sender, EventArgs e)
        {
            if (selectFolder.ShowDialog() == DialogResult.OK)
            {
                radTextBox1.Text = selectFolder.SelectedPath;
                path = selectFolder.SelectedPath;
            }

            if ((path != String.Empty || path != null) && radChecked) teachBtn.Visible = true;

        }

        private void radButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radButtonsSelect(object sender, EventArgs e)
        {
            radChecked = true;
            if (radTextBox1.Text != String.Empty) teachBtn.Visible = true;
        }

        private void teachBtn_Click(object sender, EventArgs e)
        {
            if (path != string.Empty && radChecked) panel1.Visible = false;
              
        }

        private void tanRadBtn_ToggleStateChanging(object sender, Telerik.WinControls.UI.StateChangingEventArgs args)
        {

        }

        private void formLoad(object sender, EventArgs e)
        {
        }
    }
}
