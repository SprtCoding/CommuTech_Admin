namespace CommuTech_Admin.Forms
{
    partial class SplashScreen
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashScreen));
            pictureBox1 = new PictureBox();
            splash_rad = new Bunifu.Framework.UI.BunifuElipse(components);
            progress = new Bunifu.Framework.UI.BunifuProgressBar();
            progress_timer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(395, 203);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(210, 180);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // splash_rad
            // 
            splash_rad.ElipseRadius = 30;
            splash_rad.TargetControl = this;
            // 
            // progress
            // 
            progress.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            progress.BackColor = Color.Silver;
            progress.BorderRadius = 5;
            progress.Location = new Point(43, 541);
            progress.Margin = new Padding(4, 3, 4, 3);
            progress.MaximumValue = 100;
            progress.Name = "progress";
            progress.ProgressColor = Color.FromArgb(72, 114, 203);
            progress.Size = new Size(914, 12);
            progress.TabIndex = 1;
            progress.Value = 0;
            // 
            // progress_timer
            // 
            progress_timer.Tick += progress_timer_Tick;
            // 
            // SplashScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(999, 584);
            Controls.Add(progress);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SplashScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SplashScreen";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuElipse splash_rad;
        private Bunifu.Framework.UI.BunifuProgressBar progress;
        private System.Windows.Forms.Timer progress_timer;
    }
}