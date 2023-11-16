using CommuTech_Admin.Forms.AuthForms;
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
using static Google.Rpc.Context.AttributeContext.Types;

namespace CommuTech_Admin.Forms
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
            progress_timer.Start();
            progress.MaximumValue = 100;
        }

        private void progress_timer_Tick(object sender, EventArgs e)
        {
            const int maxProgressValue = 100;
            const int increment = 6;

            if (progress.Value + increment <= maxProgressValue)
            {
                progress.Value += increment;
            }
            else
            {
                progress.Value = maxProgressValue; // Set to the maximum value if it exceeds the limit.
                progress_timer.Stop();

                Overview overview = new Overview("");
                overview.Show();
                Hide();
            }
        }
    }
}
