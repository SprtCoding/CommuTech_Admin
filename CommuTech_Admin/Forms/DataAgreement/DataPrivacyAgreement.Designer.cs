namespace CommuTech_Admin.Forms.DataAgreement
{
    partial class DataPrivacyAgreement
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            agree_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(72, 35);
            label1.Name = "label1";
            label1.Size = new Size(498, 47);
            label1.TabIndex = 0;
            label1.Text = "Data Privacy agreement (Please read and agree to the terms to proceed)";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(72, 98);
            label2.Name = "label2";
            label2.Size = new Size(498, 74);
            label2.TabIndex = 1;
            label2.Text = "In accordance with Republic Act 10173 of the Data Privacy Act of 2012, I consent to the following terms and conditions on the collection, use and disclosure of my personal data.";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(72, 172);
            label3.Name = "label3";
            label3.Size = new Size(498, 56);
            label3.TabIndex = 2;
            label3.Text = "Please read the Privacy Notice before you click the Agree and continue button. ";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(72, 228);
            label4.Name = "label4";
            label4.Size = new Size(498, 56);
            label4.TabIndex = 3;
            label4.Text = "I am aware that Commu- Tech Admin has collected and stored my personal data during the Registration. These data include my: ";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(72, 284);
            label5.Name = "label5";
            label5.Size = new Size(498, 115);
            label5.TabIndex = 4;
            label5.Text = "1. Demographic profile \r\n2. Exact Address\r\n3. Contact number\r\n4. Francise Number\r\n5. Driver’s License Number and\r\n6. Vehicle Registration Number\r\n";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(72, 399);
            label6.Name = "label6";
            label6.Size = new Size(498, 61);
            label6.TabIndex = 5;
            label6.Text = "I consent to disclose my personal Information for Commu- Tech Software Application.";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(72, 451);
            label7.Name = "label7";
            label7.Size = new Size(498, 61);
            label7.TabIndex = 6;
            label7.Text = "I have read the Commu-Tech Software Application commitment to Data Privacy.";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // agree_btn
            // 
            agree_btn.Active = false;
            agree_btn.Activecolor = Color.FromArgb(46, 139, 87);
            agree_btn.BackColor = Color.SeaGreen;
            agree_btn.BackgroundImageLayout = ImageLayout.Stretch;
            agree_btn.BorderRadius = 5;
            agree_btn.ButtonText = "Agree";
            agree_btn.Cursor = Cursors.Hand;
            agree_btn.DisabledColor = Color.Gray;
            agree_btn.Iconcolor = Color.Transparent;
            agree_btn.Iconimage = null;
            agree_btn.Iconimage_right = null;
            agree_btn.Iconimage_right_Selected = null;
            agree_btn.Iconimage_Selected = null;
            agree_btn.IconMarginLeft = 0;
            agree_btn.IconMarginRight = 0;
            agree_btn.IconRightVisible = true;
            agree_btn.IconRightZoom = 0D;
            agree_btn.IconVisible = true;
            agree_btn.IconZoom = 90D;
            agree_btn.IsTab = false;
            agree_btn.Location = new Point(253, 533);
            agree_btn.Margin = new Padding(4, 3, 4, 3);
            agree_btn.Name = "agree_btn";
            agree_btn.Normalcolor = Color.SeaGreen;
            agree_btn.OnHovercolor = Color.FromArgb(36, 129, 77);
            agree_btn.OnHoverTextColor = Color.White;
            agree_btn.selected = false;
            agree_btn.Size = new Size(135, 40);
            agree_btn.TabIndex = 13;
            agree_btn.Text = "Agree";
            agree_btn.TextAlign = ContentAlignment.MiddleCenter;
            agree_btn.Textcolor = Color.White;
            agree_btn.TextFont = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            agree_btn.Click += agree_btn_Click;
            // 
            // DataPrivacyAgreement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(641, 624);
            Controls.Add(agree_btn);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DataPrivacyAgreement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DataPrivacyAgreement";
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Bunifu.Framework.UI.BunifuFlatButton agree_btn;
    }
}