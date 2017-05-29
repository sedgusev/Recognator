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
using System.Reflection;
using System.IO.Compression;
using Recognator.Properties;

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

        private void loadForm(object sender, EventArgs e)
        {
            AppDomain.CurrentDomain.AssemblyResolve += AppDomain_AssemblyResolve;
        }

        private Assembly AppDomain_AssemblyResolve(object sender, ResolveEventArgs args)
        {
            if (args.Name.Contains("cvextern"))
            {
                Console.WriteLine("Resolving assembly: {0}", args.Name);

                // Загрузка запакованной сборки из ресурсов, ее распаковка и подстановка
                using (var resource = new MemoryStream(Resources.cvextern))
                using (var deflated = new DeflateStream(resource, CompressionMode.Decompress))
                using (var reader = new BinaryReader(deflated))
                {
                    var one_megabyte = 1024 * 1024;
                    var buffer = reader.ReadBytes(one_megabyte);
                    return Assembly.Load(buffer);
                }
            }
            if (args.Name.Contains("opencv_ffmpeg310"))
            {
                Console.WriteLine("Resolving assembly: {0}", args.Name);

                // Загрузка запакованной сборки из ресурсов, ее распаковка и подстановка
                using (var resource = new MemoryStream(Resources.opencv_ffmpeg310))
                using (var deflated = new DeflateStream(resource, CompressionMode.Decompress))
                using (var reader = new BinaryReader(deflated))
                {
                    var one_megabyte = 1024 * 1024;
                    var buffer = reader.ReadBytes(one_megabyte);
                    return Assembly.Load(buffer);
                }
            }

            return null;

        }
    }
}
