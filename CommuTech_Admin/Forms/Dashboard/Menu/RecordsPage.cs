using CommuTech_Admin.Classes.Model;
using CommuTech_Admin.Classes;
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

namespace CommuTech_Admin.Forms.Dashboard.Menu
{
    public partial class RecordsPage : Form
    {
        public RecordsPage(string type)
        {
            InitializeComponent();
            if (type.Equals("All SMS"))
            {
                getRecords();
            }
            else if (type.Equals("Emergency SMS"))
            {
                getEmergencyRecords();
            }
            else if (type.Equals("Normal SMS"))
            {
                getNormalRecords();
            }
        }

        private async void getNormalRecords()
        {
            try
            {
                var db = FirestoreHelper.database;
                Query userQuery = db.Collection("SMS_RECORDS").WhereEqualTo("SMS_TYPE", "normal"); // Add the filter condition here
                QuerySnapshot snap = await userQuery.GetSnapshotAsync();

                records_dtg.HeaderBgColor = Color.FromArgb(56, 103, 143);
                records_dtg.GridColor = Color.FromArgb(56, 103, 143);

                // Change the header color
                records_dtg.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(56, 103, 143);

                // Change the selection background color and selection forecolor
                records_dtg.DefaultCellStyle.SelectionBackColor = Color.FromArgb(122, 153, 180);
                records_dtg.DefaultCellStyle.SelectionForeColor = Color.FromArgb(39, 50, 56);

                foreach (DocumentSnapshot snapshot in snap.Documents)
                {
                    if (snapshot.Exists)
                    {
                        RecordsData records = snapshot.ConvertTo<RecordsData>(); // Make sure "RecordsData" class is defined correctly
                        records_dtg.Rows.Add(
                            records.SMS_TYPE,
                            records.STUDENT_NAME,
                            records.LOCATION,
                            records.DRIVER_NAME,
                            records.DRIVER_LICENSE,
                            records.DRIVER_REG_NO,
                            records.DRIVER_FRANCHISE_NO,
                            records.DATE,
                            records.TIME);

                        // Check the value of SMS_TYPE and set row color accordingly
                        int rowIndex = records_dtg.Rows.Count - 1;
                        DataGridViewRow row = records_dtg.Rows[rowIndex];

                        if (records.SMS_TYPE == "emergency")
                        {
                            row.DefaultCellStyle.BackColor = Color.FromArgb(255, 115, 92);
                        }
                        else
                        {
                            row.DefaultCellStyle.BackColor = Color.FromArgb(49, 149, 91);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void getEmergencyRecords()
        {
            try
            {
                var db = FirestoreHelper.database;
                Query userQuery = db.Collection("SMS_RECORDS").WhereEqualTo("SMS_TYPE", "emergency"); // Add the filter condition here
                QuerySnapshot snap = await userQuery.GetSnapshotAsync();

                records_dtg.HeaderBgColor = Color.FromArgb(77, 155, 129);
                records_dtg.GridColor = Color.FromArgb(77, 155, 129);

                // Change the header color
                records_dtg.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(77, 155, 129);

                // Change the selection background color and selection forecolor
                records_dtg.DefaultCellStyle.SelectionBackColor = Color.FromArgb(136, 188, 171);
                records_dtg.DefaultCellStyle.SelectionForeColor = Color.FromArgb(39, 50, 56);

                foreach (DocumentSnapshot snapshot in snap.Documents)
                {
                    if (snapshot.Exists)
                    {
                        RecordsData records = snapshot.ConvertTo<RecordsData>(); // Make sure "RecordsData" class is defined correctly
                        records_dtg.Rows.Add(
                            records.SMS_TYPE,
                            records.STUDENT_NAME,
                            records.LOCATION,
                            records.DRIVER_NAME,
                            records.DRIVER_LICENSE,
                            records.DRIVER_REG_NO,
                            records.DRIVER_FRANCHISE_NO,
                            records.DATE,
                            records.TIME);

                        // Check the value of SMS_TYPE and set row color accordingly
                        int rowIndex = records_dtg.Rows.Count - 1;
                        DataGridViewRow row = records_dtg.Rows[rowIndex];

                        if (records.SMS_TYPE == "emergency")
                        {
                            row.DefaultCellStyle.BackColor = Color.FromArgb(255, 115, 92);
                        }
                        else
                        {
                            row.DefaultCellStyle.BackColor = Color.FromArgb(49, 149, 91);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void getRecords()
        {
            try
            {
                var db = FirestoreHelper.database;
                Query userQuery = db.Collection("SMS_RECORDS");
                QuerySnapshot snap = await userQuery.GetSnapshotAsync();

                foreach (DocumentSnapshot snapshot in snap.Documents)
                {
                    if (snapshot.Exists)
                    {
                        RecordsData records = snapshot.ConvertTo<RecordsData>(); // Make sure "Users" class is defined correctly
                        records_dtg.Rows.Add(
                            records.SMS_TYPE,
                            records.STUDENT_NAME,
                            records.LOCATION,
                            records.DRIVER_NAME,
                            records.DRIVER_LICENSE,
                            records.DRIVER_REG_NO,
                            records.DRIVER_FRANCHISE_NO,
                            records.DATE,
                            records.TIME);

                        // Check the value of SMS_TYPE and set row color accordingly
                        int rowIndex = records_dtg.Rows.Count - 1;
                        DataGridViewRow row = records_dtg.Rows[rowIndex];

                        if (records.SMS_TYPE == "emergency")
                        {
                            row.DefaultCellStyle.BackColor = Color.FromArgb(255, 115, 92);
                        }
                        else
                        {
                            row.DefaultCellStyle.BackColor = Color.FromArgb(49, 149, 91);
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

            foreach (DataGridViewRow row in records_dtg.Rows)
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
