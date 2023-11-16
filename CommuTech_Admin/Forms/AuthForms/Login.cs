using CommuTech_Admin.Classes;
using CommuTech_Admin.Classes.Model;
using CommuTech_Admin.Forms.Dashboard;
using CommuTech_Admin.Forms.Loader;
using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommuTech_Admin.Forms.AuthForms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        void Wait()
        {
            for (int i = 0; i < 200; i++)
            {
                Thread.Sleep(5);
            }
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit the application?", "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void show_pass_cb_CheckedChanged(object sender, EventArgs e)
        {
            if (show_pass_cb.Checked)
            {
                password_tb.isPassword = false;
            }
            else
            {
                password_tb.isPassword = true;
            }
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            using (FRM_Wait frm_wait = new FRM_Wait(Wait))
            {
                frm_wait.ShowDialog(this);
            }
            string username = username_tb.Text.Trim();
            string password = password_tb.Text;

            if (username.Equals(""))
            {
                MessageBox.Show("Username is empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (password.Equals(""))
            {
                MessageBox.Show("Password is empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var db = FirestoreHelper.database;
                if (db != null)
                {
                    DocumentReference userDocRef = db.Collection("USERS").Document(username);
                    UserData data = userDocRef.GetSnapshotAsync().Result.ConvertTo<UserData>();

                    if (data != null)
                    {
                        if (password == data.PASSWORD && username == data.USERNAME)
                        {
                            MessageBox.Show("Login successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            MainDashboard dashboard = new MainDashboard(username);
                            dashboard.Show();
                            Hide();
                        }
                        else
                        {
                            MessageBox.Show("Incorrect username and password.", "Auth Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Incorrect username and password.", "Auth Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void password_tb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                using (FRM_Wait frm_wait = new FRM_Wait(Wait))
                {
                    frm_wait.ShowDialog(this);
                }
                string username = username_tb.Text.Trim();
                string password = password_tb.Text;

                if (username.Equals(""))
                {
                    MessageBox.Show("Username is empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (password.Equals(""))
                {
                    MessageBox.Show("Password is empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    var db = FirestoreHelper.database;
                    if (db != null)
                    {
                        DocumentReference userDocRef = db.Collection("USERS").Document(username);
                        UserData data = userDocRef.GetSnapshotAsync().Result.ConvertTo<UserData>();

                        if (data != null)
                        {
                            if (password == data.PASSWORD && username == data.USERNAME)
                            {
                                MessageBox.Show("Login successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                MainDashboard dashboard = new MainDashboard(username);
                                dashboard.Show();
                                Hide();
                            }
                            else
                            {
                                MessageBox.Show("Incorrect username and password.", "Auth Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Incorrect username and password.", "Auth Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
        }
    }
}
