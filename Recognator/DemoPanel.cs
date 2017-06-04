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
    public partial class DemoPanel : UserControl
    {
        Settings PARRENT;

        public DemoPanel(Settings parrent)
        {
            InitializeComponent();
            PARRENT = parrent;
        }

        private void demo_panel_dialogBtn_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                demo_panel_pathTb.Text = openFileDialog1.FileName;
                PARRENT.filePath = openFileDialog1.FileName;
                PARRENT.flag = false;
                PARRENT.runProcess();
            }
        }
    }
}
