using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace Recognator
{
    public partial class TeachingPanel : UserControl
    {
        private string path;
        private int count;
        public TeachingPanel(string path)
        {
            this.path = path;
            InitializeComponent();
            count =Directory.GetFiles(path).Count();

        }

        private void doWork(object sender, DoWorkEventArgs e)
        {
            _changeLabel cl = new _changeLabel(changeLabel);
            foreach (var item in Directory.GetFiles(path))
            {
                if(item.Length > 7) nameOfImage.Invoke(cl, item);
                Thread.Sleep(200);
            }
        }


        private delegate void _changeLabel(string item);
        private void changeLabel(string item)
        {
            nameOfImage.Text = Path.GetFileNameWithoutExtension(item);
            if(teach_process_panel_progressbar.Value != count)
                teach_process_panel_progressbar.Value++;
        }



        private void completeWorker(object sender, RunWorkerCompletedEventArgs e)
        {
        }

        private void loadPanel(object sender, EventArgs e)
        {
            teach_process_panel_progressbar.MaxValue = count;
            if (!teachProcess.IsBusy) teachProcess.RunWorkerAsync();

        }

        private void changeProgress(object sender, ProgressChangedEventArgs e)
        {

            
        }
    }
}
