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
    public partial class TeachPanel : UserControl
    {
        private string path;
        private bool radChecked = false;
        MainForm PARRENT;

        public TeachPanel(MainForm parrent)
        {
            InitializeComponent();
            PARRENT = parrent;
        }

        private void teach_panel_dialogBtn_Click(object sender, EventArgs e)
        {
            if (selectFolder.ShowDialog() == DialogResult.OK)
            {
                teach_panel_pathTb.Text = selectFolder.SelectedPath;
                path = selectFolder.SelectedPath;
            }

            if ((path != String.Empty || path != null) && radChecked) teach_panel_teachBtn.Visible = true;
        }

        private void selectRadBtn(object sender, EventArgs e)
        {
            radChecked = true;
            if (teach_panel_pathTb.Text != String.Empty) teach_panel_teachBtn.Visible = true;
        }

        private void teach_panel_teachBtn_Click(object sender, EventArgs e)
        {
            PARRENT.container.Controls.Clear();
            PARRENT.container.Controls.Add(new TeachingPanel(path));

        }
    }
}
