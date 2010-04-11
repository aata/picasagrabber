using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

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
                Grabber.grabberMain(editURL.Text, editPath.Text);
            }
        }
    }
}