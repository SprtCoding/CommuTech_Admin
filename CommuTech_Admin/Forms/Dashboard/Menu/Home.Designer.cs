namespace CommuTech_Admin.Forms.Dashboard.Menu
{
    partial class Home
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            driver_rad = new Bunifu.Framework.UI.BunifuElipse(components);
            user_rad = new Bunifu.Framework.UI.BunifuElipse(components);
            bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(components);
            bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(components);
            chart_sms = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)chart_sms).BeginInit();
            SuspendLayout();
            // 
            // driver_rad
            // 
            driver_rad.ElipseRadius = 5;
            driver_rad.TargetControl = this;
            // 
            // user_rad
            // 
            user_rad.ElipseRadius = 5;
            user_rad.TargetControl = this;
            // 
            // bunifuElipse1
            // 
            bunifuElipse1.ElipseRadius = 5;
            bunifuElipse1.TargetControl = this;
            // 
            // bunifuElipse2
            // 
            bunifuElipse2.ElipseRadius = 5;
            bunifuElipse2.TargetControl = this;
            // 
            // chart_sms
            // 
            chart_sms.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            chart_sms.BackColor = Color.WhiteSmoke;
            chartArea1.Name = "ChartArea1";
            chart_sms.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart_sms.Legends.Add(legend1);
            chart_sms.Location = new Point(12, 12);
            chart_sms.Name = "chart_sms";
            chart_sms.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            chart_sms.Size = new Size(1048, 391);
            chart_sms.TabIndex = 9;
            chart_sms.Text = "chart1";
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1072, 415);
            Controls.Add(chart_sms);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "Home";
            Text = "Home";
            ((System.ComponentModel.ISupportInitialize)chart_sms).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Bunifu.Framework.UI.BunifuElipse driver_rad;
        private Bunifu.Framework.UI.BunifuElipse user_rad;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_sms;
    }
}