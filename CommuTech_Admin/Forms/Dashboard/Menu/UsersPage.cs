using CommuTech_Admin.Classes;
using CommuTech_Admin.Classes.Model;
using Google.Cloud.Firestore;
using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class UsersPage : Form
    {
        public UsersPage()
        {
            InitializeComponent();
            getUsers();
        }

        private async void getUsers()
        {
            try
            {
                var db = FirestoreHelper.database;
                Query userQuery = db.Collection("USERS");
                QuerySnapshot snap = await userQuery.GetSnapshotAsync();

                foreach (DocumentSnapshot snapshot in snap.Documents)
                {
                    if (snapshot.Exists)
                    {
                        UserData users = snapshot.ConvertTo<UserData>(); // Make sure "Users" class is defined correctly
                        if (snapshot.ContainsField("ACCOUNT_TYPE"))
                        {
                            user_dtg.Rows.Add(
                                users.USERNAME,
                                users.NAME,
                                users.ADDRESS,
                                users.CONTACT_NUMBER,
                                users.EMAIL_ID,
                                users.ACCOUNT_TYPE);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void search_tb_OnValueChanged(object sender, EventArgs e)
        {
            string searchText = search_tb.Text.ToLower();
            bool rowsFound = false;

            foreach (DataGridViewRow row in user_dtg.Rows)
            {
                bool matchFound = false;

                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null && cell.Value.ToString().ToLower().Contains(searchText))
                    {
                        matchFound = true;
                        break;
                    }
                }

                if (matchFound)
                {
                    row.Visible = true;
                    rowsFound = true;
                }
                else
                {
                    row.Visible = false;
                }
            }

            if (!rowsFound)
            {
                MessageBox.Show("No rows were found that match the search criteria.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
