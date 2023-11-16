using CommuTech_Admin.Forms.Dashboard.AddForms;
using CommuTech_Admin.Forms.Dashboard.Menu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommuTech_Admin.Forms.DataAgreement
{
    public partial class DataPrivacyAgreement : Form
    {
        public DataPrivacyAgreement()
        {
            InitializeComponent();
        }

        private void agree_btn_Click(object sender, EventArgs e)
        {
            AddDrivers.isAgreed = true;
            Hide();
        }
    }
}
