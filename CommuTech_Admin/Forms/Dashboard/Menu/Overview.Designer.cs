namespace CommuTech_Admin.Forms.Dashboard.Menu
{
    partial class Overview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Overview));
            splash_rad = new Bunifu.Framework.UI.BunifuElipse(components);
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            next_btn = new PictureBox();
            close_btn = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)next_btn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)close_btn).BeginInit();
            SuspendLayout();
            // 
            // splash_rad
            // 
            splash_rad.ElipseRadius = 30;
            splash_rad.TargetControl = this;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(8, 7);
            pictureBox1.Margin = new Padding(2, 2, 2, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(414, 569);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins Medium", 21F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(72, 114, 203);
            label1.Location = new Point(442, 130);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(159, 50);
            label1.TabIndex = 6;
            label1.Text = "Overview";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(39, 50, 56);
            label2.Location = new Point(442, 180);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(220, 28);
            label2.TabIndex = 8;
            label2.Text = "Welcome to CommuTech";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(39, 50, 56);
            label3.Location = new Point(442, 223);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(536, 139);
            label3.TabIndex = 9;
            label3.Text = resources.GetString("label3.Text");
            // 
            // next_btn
            // 
            next_btn.Cursor = Cursors.Hand;
            next_btn.Image = (Image)resources.GetObject("next_btn.Image");
            next_btn.Location = new Point(442, 364);
            next_btn.Margin = new Padding(2, 2, 2, 2);
            next_btn.Name = "next_btn";
            next_btn.Size = new Size(46, 37);
            next_btn.SizeMode = PictureBoxSizeMode.Zoom;
            next_btn.TabIndex = 10;
            next_btn.TabStop = false;
            next_btn.Click += next_btn_Click;
            // 
            // close_btn
            // 
            close_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            close_btn.Cursor = Cursors.Hand;
            close_btn.Image = (Image)resources.GetObject("close_btn.Image");
            close_btn.Location = new Point(963, 7);
            close_btn.Margin = new Padding(2, 2, 2, 2);
            close_btn.Name = "close_btn";
            close_btn.Size = new Size(25, 25);
            close_btn.SizeMode = PictureBoxSizeMode.Zoom;
            close_btn.TabIndex = 11;
            close_btn.TabStop = false;
            close_btn.Visible = false;
            close_btn.Click += close_btn_Click;
            // 
            // Overview
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(999, 584);
            Controls.Add(close_btn);
            Controls.Add(next_btn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2, 2, 2, 2);
            Name = "Overview";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Overview";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)next_btn).EndInit();
            ((System.ComponentModel.ISupportInitialize)close_btn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse splash_rad;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label3;
        private Label label2;
        private PictureBox next_btn;
        private PictureBox close_btn;
    }
}