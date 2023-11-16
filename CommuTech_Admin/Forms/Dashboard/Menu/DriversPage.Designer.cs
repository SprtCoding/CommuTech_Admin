namespace CommuTech_Admin.Forms.Dashboard.Menu
{
    partial class DriversPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DriversPage));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            groupBox2 = new GroupBox();
            search_tb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            menu_btn = new PictureBox();
            drivers_dtg = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            driver_rad = new Bunifu.Framework.UI.BunifuElipse(components);
            add_new_button = new Bunifu.Framework.UI.BunifuFlatButton();
            DRIVER_NAME = new DataGridViewTextBoxColumn();
            ADDRESS = new DataGridViewTextBoxColumn();
            CONTACT = new DataGridViewTextBoxColumn();
            DRIVER_FRANCHISE_NO = new DataGridViewTextBoxColumn();
            DRIVER_LICENSE = new DataGridViewTextBoxColumn();
            DRIVER_REG_NO = new DataGridViewTextBoxColumn();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)menu_btn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)drivers_dtg).BeginInit();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(search_tb);
            groupBox2.Controls.Add(menu_btn);
            groupBox2.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(9, 8);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(370, 58);
            groupBox2.TabIndex = 14;
            groupBox2.TabStop = false;
            groupBox2.Text = "Search";
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
            // drivers_dtg
            // 
            drivers_dtg.AllowUserToAddRows = false;
            drivers_dtg.AllowUserToDeleteRows = false;
            drivers_dtg.AllowUserToResizeColumns = false;
            drivers_dtg.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(224, 224, 224);
            drivers_dtg.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            drivers_dtg.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            drivers_dtg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            drivers_dtg.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            drivers_dtg.BackgroundColor = Color.WhiteSmoke;
            drivers_dtg.BorderStyle = BorderStyle.None;
            drivers_dtg.CellBorderStyle = DataGridViewCellBorderStyle.None;
            drivers_dtg.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(33, 157, 206);
            dataGridViewCellStyle2.Font = new Font("Poppins", 10F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(107, 189, 222);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(35, 63, 74);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            drivers_dtg.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            drivers_dtg.ColumnHeadersHeight = 40;
            drivers_dtg.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            drivers_dtg.Columns.AddRange(new DataGridViewColumn[] { DRIVER_NAME, ADDRESS, CONTACT, DRIVER_FRANCHISE_NO, DRIVER_LICENSE, DRIVER_REG_NO });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle3.Font = new Font("Poppins", 8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(35, 63, 74);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(107, 189, 222);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(35, 63, 74);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            drivers_dtg.DefaultCellStyle = dataGridViewCellStyle3;
            drivers_dtg.DoubleBuffered = true;
            drivers_dtg.EnableHeadersVisualStyles = false;
            drivers_dtg.GridColor = Color.FromArgb(33, 157, 206);
            drivers_dtg.HeaderBgColor = Color.FromArgb(33, 157, 206);
            drivers_dtg.HeaderForeColor = Color.WhiteSmoke;
            drivers_dtg.Location = new Point(9, 72);
            drivers_dtg.Name = "drivers_dtg";
            drivers_dtg.ReadOnly = true;
            drivers_dtg.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            drivers_dtg.RowHeadersVisible = false;
            drivers_dtg.RowHeadersWidth = 62;
            drivers_dtg.RowTemplate.Height = 25;
            drivers_dtg.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            drivers_dtg.Size = new Size(732, 169);
            drivers_dtg.TabIndex = 15;
            drivers_dtg.CellClick += drivers_dtg_CellClick;
            // 
            // driver_rad
            // 
            driver_rad.ElipseRadius = 5;
            driver_rad.TargetControl = drivers_dtg;
            // 
            // add_new_button
            // 
            add_new_button.Active = false;
            add_new_button.Activecolor = Color.FromArgb(107, 189, 222);
            add_new_button.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            add_new_button.BackColor = Color.FromArgb(33, 157, 206);
            add_new_button.BackgroundImageLayout = ImageLayout.Stretch;
            add_new_button.BorderRadius = 5;
            add_new_button.ButtonText = "Add New";
            add_new_button.Cursor = Cursors.Hand;
            add_new_button.DisabledColor = Color.Gray;
            add_new_button.Iconcolor = Color.Transparent;
            add_new_button.Iconimage = null;
            add_new_button.Iconimage_right = null;
            add_new_button.Iconimage_right_Selected = null;
            add_new_button.Iconimage_Selected = null;
            add_new_button.IconMarginLeft = 0;
            add_new_button.IconMarginRight = 0;
            add_new_button.IconRightVisible = true;
            add_new_button.IconRightZoom = 0D;
            add_new_button.IconVisible = true;
            add_new_button.IconZoom = 90D;
            add_new_button.IsTab = false;
            add_new_button.Location = new Point(605, 23);
            add_new_button.Margin = new Padding(4, 3, 4, 3);
            add_new_button.Name = "add_new_button";
            add_new_button.Normalcolor = Color.FromArgb(33, 157, 206);
            add_new_button.OnHovercolor = Color.FromArgb(107, 189, 222);
            add_new_button.OnHoverTextColor = Color.White;
            add_new_button.selected = false;
            add_new_button.Size = new Size(135, 33);
            add_new_button.TabIndex = 16;
            add_new_button.Text = "Add New";
            add_new_button.TextAlign = ContentAlignment.MiddleCenter;
            add_new_button.Textcolor = Color.White;
            add_new_button.TextFont = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            add_new_button.Click += add_new_button_Click;
            // 
            // DRIVER_NAME
            // 
            DRIVER_NAME.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DRIVER_NAME.HeaderText = "Driver Name";
            DRIVER_NAME.MinimumWidth = 8;
            DRIVER_NAME.Name = "DRIVER_NAME";
            DRIVER_NAME.ReadOnly = true;
            DRIVER_NAME.Width = 127;
            // 
            // ADDRESS
            // 
            ADDRESS.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ADDRESS.HeaderText = "Address";
            ADDRESS.MinimumWidth = 8;
            ADDRESS.Name = "ADDRESS";
            ADDRESS.ReadOnly = true;
            // 
            // CONTACT
            // 
            CONTACT.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            CONTACT.HeaderText = "Contact Number";
            CONTACT.MinimumWidth = 8;
            CONTACT.Name = "CONTACT";
            CONTACT.ReadOnly = true;
            CONTACT.Width = 157;
            // 
            // DRIVER_FRANCHISE_NO
            // 
            DRIVER_FRANCHISE_NO.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DRIVER_FRANCHISE_NO.HeaderText = "Franchise No.";
            DRIVER_FRANCHISE_NO.MinimumWidth = 8;
            DRIVER_FRANCHISE_NO.Name = "DRIVER_FRANCHISE_NO";
            DRIVER_FRANCHISE_NO.ReadOnly = true;
            DRIVER_FRANCHISE_NO.Width = 133;
            // 
            // DRIVER_LICENSE
            // 
            DRIVER_LICENSE.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DRIVER_LICENSE.HeaderText = "Driver's License No.";
            DRIVER_LICENSE.MinimumWidth = 8;
            DRIVER_LICENSE.Name = "DRIVER_LICENSE";
            DRIVER_LICENSE.ReadOnly = true;
            DRIVER_LICENSE.Width = 174;
            // 
            // DRIVER_REG_NO
            // 
            DRIVER_REG_NO.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DRIVER_REG_NO.HeaderText = "Vehicle Registration No.";
            DRIVER_REG_NO.MinimumWidth = 8;
            DRIVER_REG_NO.Name = "DRIVER_REG_NO";
            DRIVER_REG_NO.ReadOnly = true;
            DRIVER_REG_NO.Width = 208;
            // 
            // DriversPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(750, 249);
            Controls.Add(add_new_button);
            Controls.Add(drivers_dtg);
            Controls.Add(groupBox2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DriversPage";
            Text = "DriversPage";
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)menu_btn).EndInit();
            ((System.ComponentModel.ISupportInitialize)drivers_dtg).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox search_tb;
        private PictureBox menu_btn;
        private Bunifu.Framework.UI.BunifuCustomDataGrid drivers_dtg;
        private Bunifu.Framework.UI.BunifuElipse driver_rad;
        private Bunifu.Framework.UI.BunifuFlatButton add_new_button;
        private DataGridViewTextBoxColumn DRIVER_NAME;
        private DataGridViewTextBoxColumn ADDRESS;
        private DataGridViewTextBoxColumn CONTACT;
        private DataGridViewTextBoxColumn DRIVER_FRANCHISE_NO;
        private DataGridViewTextBoxColumn DRIVER_LICENSE;
        private DataGridViewTextBoxColumn DRIVER_REG_NO;
    }
}