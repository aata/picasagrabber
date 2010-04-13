using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace PicasaGrabber
{
    public partial class MainFrame : Form
    {
        public MainFrame()
        {
            InitializeComponent();
            this.editPath.Text = Directory.GetCurrentDirectory();
        }

        private void buttonDownload_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                editPath.Text = fbd.SelectedPath;
                Grabber grabObj = new Grabber(editURL.Text,editPath.Text);
                Thread th = new Thread(grabObj.grabberMain);
                th.Start();
            }
        }
    }
}