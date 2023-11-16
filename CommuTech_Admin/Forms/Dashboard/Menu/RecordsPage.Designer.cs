namespace CommuTech_Admin.Forms.Dashboard.Menu
{
    partial class RecordsPage
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecordsPage));
            records_dtg = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            groupBox1 = new GroupBox();
            search_tb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            menu_btn = new PictureBox();
            record_rad = new Bunifu.Framework.UI.BunifuElipse(components);
            SMS_TYPE = new DataGridViewTextBoxColumn();
            FULLNAME = new DataGridViewTextBoxColumn();
            LOCATION = new DataGridViewTextBoxColumn();
            DRIVER_NAME = new DataGridViewTextBoxColumn();
            DRIVER_LICENSE = new DataGridViewTextBoxColumn();
            DRIVER_REG_NO = new DataGridViewTextBoxColumn();
            DRIVER_FRANCHISE_NO = new DataGridViewTextBoxColumn();
            DATE = new DataGridViewTextBoxColumn();
            TIME = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)records_dtg).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)menu_btn).BeginInit();
            SuspendLayout();
            // 
            // records_dtg
            // 
            records_dtg.AllowUserToAddRows = false;
            records_dtg.AllowUserToDeleteRows = false;
            records_dtg.AllowUserToResizeColumns = false;
            records_dtg.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(224, 224, 224);
            records_dtg.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            records_dtg.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            records_dtg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            records_dtg.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            records_dtg.BackgroundColor = Color.WhiteSmoke;
            records_dtg.BorderStyle = BorderStyle.None;
            records_dtg.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(35, 106, 66);
            dataGridViewCellStyle2.Font = new Font("Poppins", 10F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(107, 151, 126);
            dataGridViewCellStyle2.SelectionForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            records_dtg.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            records_dtg.ColumnHeadersHeight = 40;
            records_dtg.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            records_dtg.Columns.AddRange(new DataGridViewColumn[] { SMS_TYPE, FULLNAME, LOCATION, DRIVER_NAME, DRIVER_LICENSE, DRIVER_REG_NO, DRIVER_FRANCHISE_NO, DATE, TIME });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(34, 99, 62);
            dataGridViewCellStyle3.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(107, 151, 126);
            dataGridViewCellStyle3.SelectionForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            records_dtg.DefaultCellStyle = dataGridViewCellStyle3;
            records_dtg.DoubleBuffered = true;
            records_dtg.EnableHeadersVisualStyles = false;
            records_dtg.GridColor = Color.FromArgb(35, 106, 66);
            records_dtg.HeaderBgColor = Color.FromArgb(35, 106, 66);
            records_dtg.HeaderForeColor = Color.WhiteSmoke;
            records_dtg.Location = new Point(9, 73);
            records_dtg.Name = "records_dtg";
            records_dtg.ReadOnly = true;
            records_dtg.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            records_dtg.RowHeadersVisible = false;
            records_dtg.RowHeadersWidth = 62;
            records_dtg.RowTemplate.Height = 25;
            records_dtg.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            records_dtg.Size = new Size(740, 120);
            records_dtg.TabIndex = 13;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(search_tb);
            groupBox1.Controls.Add(menu_btn);
            groupBox1.Font = new Font("Poppins Medium", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(9, 8);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(370, 58);
            groupBox1.TabIndex = 12;
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
            // record_rad
            // 
            record_rad.ElipseRadius = 5;
            record_rad.TargetControl = records_dtg;
            // 
            // SMS_TYPE
            // 
            SMS_TYPE.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            SMS_TYPE.HeaderText = "SMS TYPE";
            SMS_TYPE.MinimumWidth = 8;
            SMS_TYPE.Name = "SMS_TYPE";
            SMS_TYPE.ReadOnly = true;
            SMS_TYPE.Width = 103;
            // 
            // FULLNAME
            // 
            FULLNAME.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            FULLNAME.HeaderText = "Student Name";
            FULLNAME.MinimumWidth = 8;
            FULLNAME.Name = "FULLNAME";
            FULLNAME.ReadOnly = true;
            FULLNAME.Width = 141;
            // 
            // LOCATION
            // 
            LOCATION.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            LOCATION.HeaderText = "Location";
            LOCATION.MinimumWidth = 8;
            LOCATION.Name = "LOCATION";
            LOCATION.ReadOnly = true;
            LOCATION.Width = 97;
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
            // DRIVER_FRANCHISE_NO
            // 
            DRIVER_FRANCHISE_NO.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DRIVER_FRANCHISE_NO.HeaderText = "Franchise No.";
            DRIVER_FRANCHISE_NO.MinimumWidth = 8;
            DRIVER_FRANCHISE_NO.Name = "DRIVER_FRANCHISE_NO";
            DRIVER_FRANCHISE_NO.ReadOnly = true;
            DRIVER_FRANCHISE_NO.Width = 133;
            // 
            // DATE
            // 
            DATE.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DATE.HeaderText = "Date";
            DATE.MinimumWidth = 8;
            DATE.Name = "DATE";
            DATE.ReadOnly = true;
            DATE.Width = 70;
            // 
            // TIME
            // 
            TIME.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            TIME.HeaderText = "time";
            TIME.MinimumWidth = 8;
            TIME.Name = "TIME";
            TIME.ReadOnly = true;
            TIME.Width = 69;
            // 
            // RecordsPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(757, 201);
            Controls.Add(records_dtg);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RecordsPage";
            Text = "RecordsPage";
            ((System.ComponentModel.ISupportInitialize)records_dtg).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)menu_btn).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid records_dtg;
        private GroupBox groupBox1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox search_tb;
        private PictureBox menu_btn;
        private Bunifu.Framework.UI.BunifuElipse record_rad;
        private DataGridViewTextBoxColumn SMS_TYPE;
        private DataGridViewTextBoxColumn FULLNAME;
        private DataGridViewTextBoxColumn LOCATION;
        private DataGridViewTextBoxColumn DRIVER_NAME;
        private DataGridViewTextBoxColumn DRIVER_LICENSE;
        private DataGridViewTextBoxColumn DRIVER_REG_NO;
        private DataGridViewTextBoxColumn DRIVER_FRANCHISE_NO;
        private DataGridViewTextBoxColumn DATE;
        private DataGridViewTextBoxColumn TIME;
    }
}