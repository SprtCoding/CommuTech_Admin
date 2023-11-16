namespace CommuTech_Admin.Forms.Loader
{
    partial class FRM_Wait
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
            label1 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Image = Properties.Resources.loading_anim;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(469, 274);
            label1.TabIndex = 0;
            // 
            // FRM_Wait
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(493, 292);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FRM_Wait";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FRM_Wait";
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
    }
}