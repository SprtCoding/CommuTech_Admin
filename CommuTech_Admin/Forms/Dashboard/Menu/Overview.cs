using CommuTech_Admin.Forms.AuthForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommuTech_Admin.Forms.Dashboard.Menu
{
    public partial class Overview : Form
    {
        public Overview(string info)
        {
            InitializeComponent();

            if (!info.Equals(""))
            {
                next_btn.Visible = false;
                close_btn.Visible = true;
            }
            else
            {
                next_btn.Visible = true;
                close_btn.Visible = false;
            }
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void next_btn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            Hide();
        }
    }
}
