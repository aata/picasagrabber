using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PicasaGrabber
{
    public partial class StateWindow : Form
    {
        private Guid _id;
        private bool _isValid = false;

        public StateWindow(Guid id)
        {
            _id = id;

            InitializeComponent();

            timer1.Interval = 100;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Grabber grabber;
            if (Grabber.InstanceIds.TryGetValue(_id, out grabber))
            {
                _isValid = true;

                int min, max, val;
                grabber.GetDownloadState(out min, out max, out val);
                pbDownloading.Minimum = min;
                pbDownloading.Maximum = max;
                pbDownloading.Value = val;
            }
            else if (_isValid)
            {
                this.Hide();
                this.Close();
            }
            else
            {
                this.pbDownloading.Minimum = 0;
                this.pbDownloading.Maximum = 100;
                this.pbDownloading.Value = 0;
            }
        }
    }
}