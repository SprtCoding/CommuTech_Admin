using Bunifu.Framework.UI;
using CommuTech_Admin.Classes;
using CommuTech_Admin.Forms.AuthForms;
using CommuTech_Admin.Forms.Dashboard.Menu;
using CommuTech_Admin.Forms.Loader;
using Google.Cloud.Firestore;
using Microsoft.VisualBasic.Logging;
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

namespace CommuTech_Admin.Forms.Dashboard
{
    public partial class MainDashboard : Form
    {
        //bool sidebarExpand;
        //private Panel? leftBorderBtn;
        //private BunifuFlatButton? currentBtn;
        public static bool isDriverUpdated;

        public MainDashboard(String id)
        {
            InitializeComponent();
            getDriversCount();
            getRecordsCount();
            getEmergencyRecordsCount();
            getUserCount();
            getNormalRecordsCount();

            //if (!id.Equals(""))
            //{
            //    getUserName(id);
            //}

            //leftBorderBtn = new Panel();
            //leftBorderBtn.Size = new Size(3, home_btn.Height);
            //nav_menu_panel.Controls.Add(leftBorderBtn);
        }

        //private async void getUserName(string id)
        //{
        //    try
        //    {
        //        var db = FirestoreHelper.database;
        //        // Reference to your Firestore collection
        //        CollectionReference collectionRef = db.Collection("USERS");
        //        var document = await collectionRef.Document(id).GetSnapshotAsync();
        //
        //        if (document.Exists)
        //        {
        //            // Check if the document with the given ID exists
        //            var data = document.ToDictionary();
        //            if (data.ContainsKey("USERNAME") && data["USERNAME"] is string)
        //            {
        //                string username = data["USERNAME"].ToString();
        //                username_lbl.Text = username;
        //            }
        //            else
        //            {
        //                // Handle the case where the "username" field is missing or not a string
        //                username_lbl.Text = "Username not found";
        //            }
        //        }
        //        else
        //        {
        //            // Handle the case where the document with the given ID does not exist
        //            username_lbl.Text = "User not found";
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        // Handle any exceptions that may occur during the Firestore operation
        //        MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        private Form? activeForm = null;

        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            menus_panel.Controls.Add(childForm);
            menus_panel.Tag = childForm;
            childForm.SendToBack();
            childForm.Show();
        }

        //private void activeButton(object senderBtn)
        //{
        //
        //    if (senderBtn != null)
        //    {
        //        currentBtn = (BunifuFlatButton)senderBtn;
        //        leftBorderBtn.BackColor = Color.WhiteSmoke;
        //        leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
        //        leftBorderBtn.Visible = true;
        //        leftBorderBtn.BringToFront();
        //    }
        //}

        private void logout_btn_Click(object sender, EventArgs e)
        {
            //activeButton(sender);
            DialogResult result = MessageBox.Show("Are you sure you want Logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Login loginfrm = new Login();
                loginfrm.Show();
                this.Hide();
            }
        }

        private void MainDashboard_Load(object sender, EventArgs e)
        {
            header_title.Text = "Home";
            openChildForm(new Home());

            date_time_timer.Start();
        }

        //private void home_btn_Click(object sender, EventArgs e)
        //{
        //    openChildForm(new Home());
        //}
        //
        private void MainDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        //
        //private void users_btn_Click(object sender, EventArgs e)
        //{
        //    openChildForm(new UsersPage());
        //}
        //
        //private void records_btn_Click(object sender, EventArgs e)
        //{
        //    openChildForm(new RecordsPage());
        //}
        //
        //private void drivers_btn_Click(object sender, EventArgs e)
        //{
        //    openChildForm(new DriversPage());
        //}
        //
        //private void about_btn_Click(object sender, EventArgs e)
        //{
        //    openChildForm(new AboutPage());
        //}

        //private void nav_timer_Tick(object sender, EventArgs e)
        //{
        //    if (sidebarExpand)
        //    {
        //        nav_panel.Width -= 10;
        //        if (nav_panel.Width == nav_panel.MinimumSize.Width)
        //        {
        //            sidebarExpand = false;
        //            logo.Visible = false;
        //            home_btn.Text = "";
        //            drivers_btn.Text = "";
        //            users_btn.Text = "";
        //            records_btn.Text = "";
        //            about_btn.Text = "";
        //            logout_btn.Text = "";
        //            //nav_timer.Stop();
        //        }
        //    }
        //    else
        //    {
        //        nav_panel.Width += 10;
        //        if (nav_panel.Width == nav_panel.MaximumSize.Width)
        //        {
        //            sidebarExpand = true;
        //            logo.Visible = true;
        //            home_btn.Text = "     Dashboard";
        //            drivers_btn.Text = "     Drivers";
        //            users_btn.Text = "     Users";
        //            records_btn.Text = "     Records";
        //            about_btn.Text = "     About";
        //            logout_btn.Text = "     Logout";
        //            //nav_timer.Stop();
        //        }
        //    }
        //}

        //private void menu_btn_Click(object sender, EventArgs e)
        //{
        //    nav_timer.Start();
        //}

        private async void getDriversCount()
        {
            try
            {
                var db = FirestoreHelper.database;
                // Reference to your Firestore collection
                CollectionReference collectionRef = db.Collection("DRIVERS");

                // Fetch the documents
                QuerySnapshot snapshot = await collectionRef.GetSnapshotAsync();

                int documentCount = snapshot.Documents.Count;
                drivers_count.Text = documentCount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void getRecordsCount()
        {
            try
            {
                var db = FirestoreHelper.database;
                // Reference to your Firestore collection
                CollectionReference collectionRef = db.Collection("SMS_RECORDS");

                // Fetch the documents
                QuerySnapshot snapshot = await collectionRef.GetSnapshotAsync();

                int documentCount = snapshot.Documents.Count;
                sms_count.Text = documentCount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void getEmergencyRecordsCount()
        {
            try
            {
                var db = FirestoreHelper.database;
                // Reference to your Firestore collection
                CollectionReference collectionRef = db.Collection("SMS_RECORDS");

                // Create a query to filter documents with "sms_type" equal to "emergency"
                Query query = collectionRef.WhereEqualTo("SMS_TYPE", "emergency");

                // Fetch the documents that match the query
                QuerySnapshot snapshot = await query.GetSnapshotAsync();

                int documentCount = snapshot.Documents.Count;
                emergency_count.Text = documentCount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void getNormalRecordsCount()
        {
            try
            {
                var db = FirestoreHelper.database;
                // Reference to your Firestore collection
                CollectionReference collectionRef = db.Collection("SMS_RECORDS");

                // Create a query to filter documents with "sms_type" equal to "emergency"
                Query query = collectionRef.WhereEqualTo("SMS_TYPE", "normal");

                // Fetch the documents that match the query
                QuerySnapshot snapshot = await query.GetSnapshotAsync();

                int documentCount = snapshot.Documents.Count;
                normal_sms_lbl.Text = documentCount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void getUserCount()
        {
            try
            {
                var db = FirestoreHelper.database;
                // Reference to your Firestore collection
                CollectionReference collectionRef = db.Collection("USERS");

                // Fetch the documents
                QuerySnapshot snapshot = await collectionRef.GetSnapshotAsync();

                int documentCount = 0;

                foreach (DocumentSnapshot document in snapshot.Documents)
                {
                    if (document.ContainsField("ACCOUNT_TYPE"))
                    {
                        documentCount++;
                    }
                }

                user_count.Text = documentCount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void Wait()
        {
            for (int i = 0; i < 200; i++)
            {
                Thread.Sleep(5);
            }
        }

        private void drivers_panel_Click(object sender, EventArgs e)
        {
            using (FRM_Wait frm_wait = new FRM_Wait(Wait))
            {
                frm_wait.ShowDialog(this);
            }
            header_title.Text = "Driver/s";
            openChildForm(new DriversPage());
        }

        private void home_btn_Click(object sender, EventArgs e)
        {
            using (FRM_Wait frm_wait = new FRM_Wait(Wait))
            {
                frm_wait.ShowDialog(this);
            }
            header_title.Text = "Home";
            openChildForm(new Home());
        }

        private void MainDashboard_ParentChanged(object sender, EventArgs e)
        {
            if (isDriverUpdated)
            {
                getDriversCount();
            }
        }

        private void refresh()
        {
            getDriversCount();
            getRecordsCount();
            getEmergencyRecordsCount();
            getUserCount();
            getNormalRecordsCount();
            openChildForm(new Home());
        }

        private void refresh_button_Click(object sender, EventArgs e)
        {
            using (FRM_Wait frm_wait = new FRM_Wait(Wait))
            {
                frm_wait.ShowDialog(this);
            }
            refresh();
        }

        private void sms_panel_Click(object sender, EventArgs e)
        {
            using (FRM_Wait frm_wait = new FRM_Wait(Wait))
            {
                frm_wait.ShowDialog(this);
            }
            header_title.Text = "All SMS";
            openChildForm(new RecordsPage("All SMS"));
        }

        private void emergency_panel_Click(object sender, EventArgs e)
        {
            using (FRM_Wait frm_wait = new FRM_Wait(Wait))
            {
                frm_wait.ShowDialog(this);
            }
            header_title.Text = "Emergency SMS";
            openChildForm(new RecordsPage("Emergency SMS"));
        }

        private void about_panel_Click(object sender, EventArgs e)
        {
            using (FRM_Wait frm_wait = new FRM_Wait(Wait))
            {
                frm_wait.ShowDialog(this);
            }
            header_title.Text = "About Us";
            AboutUs about = new AboutUs();
            about.ShowDialog();
        }

        private void normal_sms_panel_Click_1(object sender, EventArgs e)
        {
            using (FRM_Wait frm_wait = new FRM_Wait(Wait))
            {
                frm_wait.ShowDialog(this);
            }
            header_title.Text = "Normal SMS";
            openChildForm(new RecordsPage("Normal SMS"));
        }

        private void user_panel_Click(object sender, EventArgs e)
        {
            using (FRM_Wait frm_wait = new FRM_Wait(Wait))
            {
                frm_wait.ShowDialog(this);
            }
            header_title.Text = "Users";
            openChildForm(new UsersPage());
        }

        private void date_time_timer_Tick(object sender, EventArgs e)
        {
            date_lbl.Text = DateTime.Now.ToLongDateString();
            time_lbl.Text = DateTime.Now.ToLongTimeString();
        }

        private void refresh_tooltip_Popup(object sender, PopupEventArgs e)
        {
            refresh_tooltip.SetToolTip(refresh_button, "Refresh Data.");
        }

        private void refresh_button_MouseEnter(object sender, EventArgs e)
        {
            refresh_tooltip.SetToolTip(refresh_button, "Refresh Data.");
        }

        private void overview_panel_Click(object sender, EventArgs e)
        {
            using (FRM_Wait frm_wait = new FRM_Wait(Wait))
            {
                frm_wait.ShowDialog(this);
            }
            header_title.Text = "Overview";
            Overview overview = new Overview("Overview Click");
            overview.ShowDialog();
        }
    }
}
