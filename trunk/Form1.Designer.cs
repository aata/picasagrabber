namespace PicasaGrabber
{
    partial class MainFrame
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrame));
            this.editURL = new System.Windows.Forms.TextBox();
            this.buttonDownload = new System.Windows.Forms.Button();
            this.editPath = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // editURL
            // 
            this.editURL.Location = new System.Drawing.Point(12, 12);
            this.editURL.Name = "editURL";
            this.editURL.Size = new System.Drawing.Size(516, 20);
            this.editURL.TabIndex = 0;
            // 
            // buttonDownload
            // 
            this.buttonDownload.Location = new System.Drawing.Point(12, 38);
            this.buttonDownload.Name = "buttonDownload";
            this.buttonDownload.Size = new System.Drawing.Size(516, 23);
            this.buttonDownload.TabIndex = 1;
            this.buttonDownload.Text = "Download pictures to...";
            this.buttonDownload.UseVisualStyleBackColor = true;
            this.buttonDownload.Click += new System.EventHandler(this.buttonDownload_Click);
            // 
            // editPath
            // 
            this.editPath.Location = new System.Drawing.Point(12, 67);
            this.editPath.Name = "editPath";
            this.editPath.ReadOnly = true;
            this.editPath.Size = new System.Drawing.Size(516, 20);
            this.editPath.TabIndex = 2;
            // 
            // MainFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 97);
            this.Controls.Add(this.editPath);
            this.Controls.Add(this.buttonDownload);
            this.Controls.Add(this.editURL);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainFrame";
            this.Text = "Picasa Grabber";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox editURL;
        private System.Windows.Forms.Button buttonDownload;
        private System.Windows.Forms.TextBox editPath;
    }
}

