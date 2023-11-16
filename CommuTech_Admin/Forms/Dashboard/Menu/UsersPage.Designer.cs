namespace CommuTech_Admin.Forms.Dashboard.Menu
{
    partial class UsersPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsersPage));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            groupBox1 = new GroupBox();
            search_tb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            menu_btn = new PictureBox();
            user_dtg = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            dtg_rad = new Bunifu.Framework.UI.BunifuElipse(components);
            USERNAME = new DataGridViewTextBoxColumn();
            FULLNAME = new DataGridViewTextBoxColumn();
            ADDRESS = new DataGridViewTextBoxColumn();
            CONTACT_NUMBER = new DataGridViewTextBoxColumn();
            EMAIL_ID = new DataGridViewTextBoxColumn();
            ACCOUNT_TYPE = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)menu_btn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)user_dtg).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(search_tb);
            groupBox1.Controls.Add(menu_btn);
            groupBox1.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(9, 8);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(370, 58);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Search";
            // 
            // search_tb
            // 
            search_tb.AutoCompleteMode = AutoCompleteMode.None;
            search_tb.AutoCompleteSource = AutoCompleteSource.None;
            search_tb.characterCasing = CharacterCasing.Normal;
            search_tb.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            search_tb.ForeColor = Color.WhiteSmoke;
            search_tb.HintForeColor = Color.Empty;
            search_tb.HintText = "";
            search_tb.isPassword = false;
            search_tb.LineFocusedColor = Color.FromArgb(72, 114, 203);
            search_tb.LineIdleColor = Color.Gray;
            search_tb.LineMouseHoverColor = Color.FromArgb(72, 114, 203);
            search_tb.LineThickness = 2;
            search_tb.Location = new Point(35, 15);
            search_tb.Margin = new Padding(4);
            search_tb.MaxLength = 32767;
            search_tb.Name = "search_tb";
            search_tb.Size = new Size(328, 33);
            search_tb.TabIndex = 10;
            search_tb.TextAlign = HorizontalAlignment.Left;
            search_tb.OnValueChanged += search_tb_OnValueChanged;
            // 
            // menu_btn
            // 
            menu_btn.Cursor = Cursors.Hand;
            menu_btn.Image = (Image)resources.GetObject("menu_btn.Image");
            menu_btn.Location = new Point(10, 28);
            menu_btn.Name = "menu_btn";
            menu_btn.Size = new Size(20, 20);
            menu_btn.SizeMode = PictureBoxSizeMode.Zoom;
            menu_btn.TabIndex = 7;
            menu_btn.TabStop = false;
            // 
            // user_dtg
            // 
            user_dtg.AllowUserToAddRows = false;
            user_dtg.AllowUserToDeleteRows = false;
            user_dtg.AllowUserToResizeColumns = false;
            user_dtg.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(224, 224, 224);
            user_dtg.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            user_dtg.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            user_dtg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            user_dtg.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            user_dtg.BackgroundColor = Color.WhiteSmoke;
            user_dtg.BorderStyle = BorderStyle.None;
            user_dtg.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(43, 47, 84);
            dataGridViewCellStyle2.Font = new Font("Poppins", 10F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(120, 126, 146);
            dataGridViewCellStyle2.SelectionForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            user_dtg.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            user_dtg.ColumnHeadersHeight = 40;
            user_dtg.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            user_dtg.Columns.AddRange(new DataGridViewColumn[] { USERNAME, FULLNAME, ADDRESS, CONTACT_NUMBER, EMAIL_ID, ACCOUNT_TYPE });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(255, 251, 245);
            dataGridViewCellStyle3.Font = new Font("Poppins", 8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(36, 40, 70);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(120, 126, 146);
            dataGridViewCellStyle3.SelectionForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            user_dtg.DefaultCellStyle = dataGridViewCellStyle3;
            user_dtg.DoubleBuffered = true;
            user_dtg.EnableHeadersVisualStyles = false;
            user_dtg.GridColor = Color.WhiteSmoke;
            user_dtg.HeaderBgColor = Color.FromArgb(43, 47, 84);
            user_dtg.HeaderForeColor = Color.WhiteSmoke;
            user_dtg.Location = new Point(9, 73);
            user_dtg.Name = "user_dtg";
            user_dtg.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            user_dtg.RowHeadersVisible = false;
            user_dtg.RowHeadersWidth = 62;
            user_dtg.RowTemplate.Height = 25;
            user_dtg.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            user_dtg.Size = new Size(738, 120);
            user_dtg.TabIndex = 10;
            // 
            // dtg_rad
            // 
            dtg_rad.ElipseRadius = 5;
            dtg_rad.TargetControl = user_dtg;
            // 
            // USERNAME
            // 
            USERNAME.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            USERNAME.HeaderText = "Username";
            USERNAME.MinimumWidth = 8;
            USERNAME.Name = "USERNAME";
            USERNAME.Width = 111;
            // 
            // FULLNAME
            // 
            FULLNAME.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            FULLNAME.HeaderText = "Full Name";
            FULLNAME.MinimumWidth = 8;
            FULLNAME.Name = "FULLNAME";
            FULLNAME.Width = 108;
            // 
            // ADDRESS
            // 
            ADDRESS.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ADDRESS.HeaderText = "Address";
            ADDRESS.MinimumWidth = 8;
            ADDRESS.Name = "ADDRESS";
            // 
            // CONTACT_NUMBER
            // 
            CONTACT_NUMBER.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            CONTACT_NUMBER.HeaderText = "Contact Number";
            CONTACT_NUMBER.MinimumWidth = 8;
            CONTACT_NUMBER.Name = "CONTACT_NUMBER";
            CONTACT_NUMBER.Width = 157;
            // 
            // EMAIL_ID
            // 
            EMAIL_ID.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            EMAIL_ID.HeaderText = "Email";
            EMAIL_ID.MinimumWidth = 8;
            EMAIL_ID.Name = "EMAIL_ID";
            EMAIL_ID.Width = 76;
            // 
            // ACCOUNT_TYPE
            // 
            ACCOUNT_TYPE.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ACCOUNT_TYPE.HeaderText = "Account Type";
            ACCOUNT_TYPE.MinimumWidth = 8;
            ACCOUNT_TYPE.Name = "ACCOUNT_TYPE";
            ACCOUNT_TYPE.Width = 133;
            // 
            // UsersPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(757, 201);
            Controls.Add(user_dtg);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UsersPage";
            Text = "UsersPage";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)menu_btn).EndInit();
            ((System.ComponentModel.ISupportInitialize)user_dtg).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox search_tb;
        private PictureBox menu_btn;
        private Bunifu.Framework.UI.BunifuCustomDataGrid user_dtg;
        private Bunifu.Framework.UI.BunifuElipse dtg_rad;
        private DataGridViewTextBoxColumn USERNAME;
        private DataGridViewTextBoxColumn FULLNAME;
        private DataGridViewTextBoxColumn ADDRESS;
        private DataGridViewTextBoxColumn CONTACT_NUMBER;
        private DataGridViewTextBoxColumn EMAIL_ID;
        private DataGridViewTextBoxColumn ACCOUNT_TYPE;
    }
}