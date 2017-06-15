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
    public partial class CameraPanel : UserControl
    {
        MainForm PARRENT;

        public CameraPanel(MainForm parrent)
        {
            InitializeComponent();
            PARRENT = parrent;
        }

        private void camera_panel_okBtn_Click(object sender, EventArgs e)
        {
            PARRENT.flag = true;
            PARRENT.runProcess();
        }
    }
}
