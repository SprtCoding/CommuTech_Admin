namespace CommuTech_Admin.Forms.AuthForms
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            login_rad = new Bunifu.Framework.UI.BunifuElipse(components);
            pictureBox2 = new PictureBox();
            bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            show_pass_cb = new CheckBox();
            login_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            password_tb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            label4 = new Label();
            username_tb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox3 = new PictureBox();
            close_btn = new PictureBox();
            label5 = new Label();
            label7 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            bunifuCards1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)close_btn).BeginInit();
            SuspendLayout();
            // 
            // login_rad
            // 
            login_rad.ElipseRadius = 30;
            login_rad.TargetControl = this;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(55, 105);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(399, 391);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // bunifuCards1
            // 
            bunifuCards1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            bunifuCards1.BackColor = Color.FromArgb(43, 47, 84);
            bunifuCards1.BorderRadius = 15;
            bunifuCards1.BottomSahddow = true;
            bunifuCards1.color = Color.FromArgb(43, 47, 84);
            bunifuCards1.Controls.Add(show_pass_cb);
            bunifuCards1.Controls.Add(login_btn);
            bunifuCards1.Controls.Add(password_tb);
            bunifuCards1.Controls.Add(label4);
            bunifuCards1.Controls.Add(username_tb);
            bunifuCards1.Controls.Add(label3);
            bunifuCards1.Controls.Add(label2);
            bunifuCards1.Controls.Add(label1);
            bunifuCards1.Controls.Add(pictureBox3);
            bunifuCards1.LeftSahddow = false;
            bunifuCards1.Location = new Point(510, 34);
            bunifuCards1.Name = "bunifuCards1";
            bunifuCards1.RightSahddow = true;
            bunifuCards1.ShadowDepth = 20;
            bunifuCards1.Size = new Size(430, 517);
            bunifuCards1.TabIndex = 3;
            // 
            // show_pass_cb
            // 
            show_pass_cb.AutoSize = true;
            show_pass_cb.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            show_pass_cb.ForeColor = Color.WhiteSmoke;
            show_pass_cb.Location = new Point(30, 358);
            show_pass_cb.Name = "show_pass_cb";
            show_pass_cb.Size = new Size(122, 26);
            show_pass_cb.TabIndex = 12;
            show_pass_cb.Text = "Show Password";
            show_pass_cb.UseVisualStyleBackColor = true;
            show_pass_cb.CheckedChanged += show_pass_cb_CheckedChanged;
            // 
            // login_btn
            // 
            login_btn.Active = false;
            login_btn.Activecolor = Color.FromArgb(133, 161, 220);
            login_btn.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            login_btn.BackColor = Color.FromArgb(72, 114, 203);
            login_btn.BackgroundImageLayout = ImageLayout.Stretch;
            login_btn.BorderRadius = 5;
            login_btn.ButtonText = "Login";
            login_btn.Cursor = Cursors.Hand;
            login_btn.DisabledColor = Color.Gray;
            login_btn.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            login_btn.Iconcolor = Color.Transparent;
            login_btn.Iconimage = null;
            login_btn.Iconimage_right = null;
            login_btn.Iconimage_right_Selected = null;
            login_btn.Iconimage_Selected = null;
            login_btn.IconMarginLeft = 0;
            login_btn.IconMarginRight = 0;
            login_btn.IconRightVisible = true;
            login_btn.IconRightZoom = 0D;
            login_btn.IconVisible = true;
            login_btn.IconZoom = 90D;
            login_btn.IsTab = false;
            login_btn.Location = new Point(30, 421);
            login_btn.Margin = new Padding(5, 4, 5, 4);
            login_btn.Name = "login_btn";
            login_btn.Normalcolor = Color.FromArgb(72, 114, 203);
            login_btn.OnHovercolor = Color.FromArgb(133, 161, 220);
            login_btn.OnHoverTextColor = Color.White;
            login_btn.selected = false;
            login_btn.Size = new Size(370, 41);
            login_btn.TabIndex = 11;
            login_btn.Text = "Login";
            login_btn.TextAlign = ContentAlignment.MiddleCenter;
            login_btn.Textcolor = Color.White;
            login_btn.TextFont = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            login_btn.Click += login_btn_Click;
            // 
            // password_tb
            // 
            password_tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            password_tb.AutoCompleteMode = AutoCompleteMode.None;
            password_tb.AutoCompleteSource = AutoCompleteSource.None;
            password_tb.characterCasing = CharacterCasing.Normal;
            password_tb.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            password_tb.ForeColor = Color.WhiteSmoke;
            password_tb.HintForeColor = Color.WhiteSmoke;
            password_tb.HintText = "";
            password_tb.isPassword = true;
            password_tb.LineFocusedColor = Color.FromArgb(72, 114, 203);
            password_tb.LineIdleColor = Color.WhiteSmoke;
            password_tb.LineMouseHoverColor = Color.FromArgb(72, 114, 203);
            password_tb.LineThickness = 2;
            password_tb.Location = new Point(30, 305);
            password_tb.Margin = new Padding(5, 6, 5, 6);
            password_tb.MaxLength = 32767;
            password_tb.Name = "password_tb";
            password_tb.Padding = new Padding(0, 5, 0, 0);
            password_tb.Size = new Size(370, 33);
            password_tb.TabIndex = 10;
            password_tb.TextAlign = HorizontalAlignment.Left;
            password_tb.KeyDown += password_tb_KeyDown;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Poppins", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.WhiteSmoke;
            label4.Location = new Point(30, 274);
            label4.Name = "label4";
            label4.Size = new Size(70, 22);
            label4.TabIndex = 9;
            label4.Text = "Password";
            // 
            // username_tb
            // 
            username_tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            username_tb.AutoCompleteMode = AutoCompleteMode.None;
            username_tb.AutoCompleteSource = AutoCompleteSource.None;
            username_tb.characterCasing = CharacterCasing.Normal;
            username_tb.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            username_tb.ForeColor = Color.WhiteSmoke;
            username_tb.HintForeColor = Color.WhiteSmoke;
            username_tb.HintText = "";
            username_tb.isPassword = false;
            username_tb.LineFocusedColor = Color.FromArgb(72, 114, 203);
            username_tb.LineIdleColor = Color.WhiteSmoke;
            username_tb.LineMouseHoverColor = Color.FromArgb(72, 114, 203);
            username_tb.LineThickness = 2;
            username_tb.Location = new Point(30, 223);
            username_tb.Margin = new Padding(4, 7, 4, 7);
            username_tb.MaxLength = 32767;
            username_tb.Name = "username_tb";
            username_tb.Padding = new Padding(0, 5, 0, 0);
            username_tb.Size = new Size(370, 33);
            username_tb.TabIndex = 8;
            username_tb.TextAlign = HorizontalAlignment.Left;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Poppins", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.WhiteSmoke;
            label3.Location = new Point(30, 194);
            label3.Name = "label3";
            label3.Size = new Size(73, 22);
            label3.TabIndex = 7;
            label3.Text = "Username";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Poppins Black", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(177, 71);
            label2.Name = "label2";
            label2.Size = new Size(182, 42);
            label2.TabIndex = 6;
            label2.Text = "CommuTech";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(177, 35);
            label1.Name = "label1";
            label1.Size = new Size(74, 28);
            label1.TabIndex = 5;
            label1.Text = "Login to";
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(32, 27);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(139, 108);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // close_btn
            // 
            close_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            close_btn.Cursor = Cursors.Hand;
            close_btn.Image = (Image)resources.GetObject("close_btn.Image");
            close_btn.Location = new Point(965, 8);
            close_btn.Name = "close_btn";
            close_btn.Size = new Size(25, 25);
            close_btn.SizeMode = PictureBoxSizeMode.Zoom;
            close_btn.TabIndex = 5;
            close_btn.TabStop = false;
            close_btn.Click += close_btn_Click;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Poppins Black", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(72, 114, 203);
            label5.Location = new Point(55, 25);
            label5.Name = "label5";
            label5.Size = new Size(146, 42);
            label5.TabIndex = 7;
            label5.Text = "Welcome,";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Poppins", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(72, 114, 203);
            label7.Location = new Point(55, 61);
            label7.Name = "label7";
            label7.Size = new Size(172, 36);
            label7.TabIndex = 9;
            label7.Text = "to CommuTech";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Poppins", 17F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(72, 114, 203);
            label6.Location = new Point(55, 511);
            label6.Name = "label6";
            label6.Size = new Size(230, 40);
            label6.TabIndex = 11;
            label6.Text = "Admin Login Page";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(999, 584);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(close_btn);
            Controls.Add(bunifuCards1);
            Controls.Add(pictureBox2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            FormClosed += Login_FormClosed;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            bunifuCards1.ResumeLayout(false);
            bunifuCards1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)close_btn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse login_rad;
        private PictureBox close_btn;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private CheckBox show_pass_cb;
        private Bunifu.Framework.UI.BunifuFlatButton login_btn;
        private Bunifu.Framework.UI.BunifuMaterialTextbox password_tb;
        private Label label4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox username_tb;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Label label5;
        private Label label7;
        private Label label6;
    }
}