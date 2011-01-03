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
        }

        private void buttonChooseFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
                editPath.Text = fbd.SelectedPath;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (editURL.Text == string.Empty)
            {
                MessageBox.Show("You must enter a valid picasa album rss url");
                return;
            }

            if (editPath.Text == string.Empty || !Directory.Exists(editPath.Text))
            {
                MessageBox.Show("Invalid path");
                return;
            }

            Guid id = Guid.NewGuid();

            StateWindow window = new StateWindow(id);
            window.Show();

            Grabber grabObj = new Grabber(id, editURL.Text, editPath.Text);
            Thread th = new Thread(grabObj.grabberMain);
            th.Start();
        }
    }
}