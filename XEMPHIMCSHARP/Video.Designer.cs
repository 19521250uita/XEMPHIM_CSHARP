namespace XEMPHIMCSHARP
{
    partial class Video
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Video));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.video1 = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.video1)).BeginInit();
            this.SuspendLayout();
            // 
            // video1
            // 
            this.video1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.video1.Enabled = true;
            this.video1.Location = new System.Drawing.Point(0, 0);
            this.video1.Name = "video1";
            this.video1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("video1.OcxState")));
            this.video1.Size = new System.Drawing.Size(1058, 589);
            this.video1.TabIndex = 0;
            // 
            // Video
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 589);
            this.Controls.Add(this.video1);
            this.Name = "Video";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Video";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Video_FormClosing);
            this.Load += new System.EventHandler(this.Video_Load);
            ((System.ComponentModel.ISupportInitialize)(this.video1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        public AxWMPLib.AxWindowsMediaPlayer video1;
    }
}