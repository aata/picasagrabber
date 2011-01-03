namespace PicasaGrabber
{
    partial class StateWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblDownloading = new System.Windows.Forms.Label();
            this.pbDownloading = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblDownloading
            // 
            this.lblDownloading.AutoSize = true;
            this.lblDownloading.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDownloading.Location = new System.Drawing.Point(12, 9);
            this.lblDownloading.Name = "lblDownloading";
            this.lblDownloading.Size = new System.Drawing.Size(113, 20);
            this.lblDownloading.TabIndex = 0;
            this.lblDownloading.Text = "Downloading...";
            // 
            // pbDownloading
            // 
            this.pbDownloading.Location = new System.Drawing.Point(12, 32);
            this.pbDownloading.Name = "pbDownloading";
            this.pbDownloading.Size = new System.Drawing.Size(234, 44);
            this.pbDownloading.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // StateWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 88);
            this.ControlBox = false;
            this.Controls.Add(this.pbDownloading);
            this.Controls.Add(this.lblDownloading);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "StateWindow";
            this.Text = "StateWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDownloading;
        private System.Windows.Forms.ProgressBar pbDownloading;
        private System.Windows.Forms.Timer timer1;
    }
}