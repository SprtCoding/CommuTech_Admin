using CommuTech_Admin.Classes;
using CommuTech_Admin.Classes.Model;
using CommuTech_Admin.Forms.Dashboard.AddForms;
using CommuTech_Admin.Forms.Loader;
using Google.Cloud.Firestore;
using QRCoder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static QRCoder.PayloadGenerator.SwissQrCode;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CommuTech_Admin.Forms.Dashboard.Menu
{
    public partial class DriversPage : Form
    {
        public DriversPage()
        {
            InitializeComponent();
            getDrivers();
        }

        void Wait()
        {
            for (int i = 0; i < 200; i++)
            {
                Thread.Sleep(5);
            }
        }

        //get image base64 string and set to firebase
        public static string ImageIntoBase64String(PictureBox pbox)
        {
            MemoryStream ms = new MemoryStream();
            pbox.Image.Save(ms, pbox.Image.RawFormat);
            return Convert.ToBase64String(ms.ToArray());
        }

        private string ConvertImageToBase64(Bitmap image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, ImageFormat.Png);
                byte[] imageBytes = ms.ToArray();
                return Convert.ToBase64String(imageBytes);
            }
        }

        //get image base64 string and get to firebase
        public static Image Base64StringIntoImage(string str)
        {
            byte[] img = Convert.FromBase64String(str);
            MemoryStream ms = new MemoryStream(img);
            return Image.FromStream(ms);
        }

        private async void getDrivers()
        {
            try
            {
                var db = FirestoreHelper.database;
                Query userQuery = db.Collection("DRIVERS");
                QuerySnapshot snap = await userQuery.GetSnapshotAsync();

                foreach (DocumentSnapshot snapshot in snap.Documents)
                {
                    if (snapshot.Exists)
                    {
                        DriversData records = snapshot.ConvertTo<DriversData>(); // Make sure "Users" class is defined correctly
                        drivers_dtg.Rows.Add(
                            records.DRIVERS_NAME,
                            records.ADDRESS,
                            records.CONTACT,
                            records.FRANCHISE_NO,
                            records.LICENSE_NO,
                            records.REG_NO);
                    }
                    else
                    {
                        MessageBox.Show("No data found!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void drivers_dtg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            using (FRM_Wait frm_wait = new FRM_Wait(Wait))
            {
                frm_wait.ShowDialog(this);
            }

            // Get the data from the selected row and column
            DataGridViewRow selectedRow = drivers_dtg.Rows[e.RowIndex];
            string _fullname = selectedRow.Cells["DRIVER_NAME"].Value.ToString();
            string _address = selectedRow.Cells["ADDRESS"].Value.ToString();
            string _cNo = selectedRow.Cells["CONTACT"].Value.ToString();
            string _franchise = selectedRow.Cells["DRIVER_FRANCHISE_NO"].Value.ToString();
            string _license = selectedRow.Cells["DRIVER_LICENSE"].Value.ToString();
            string _vihecle = selectedRow.Cells["DRIVER_REG_NO"].Value.ToString();

            try
            {
                var db = FirestoreHelper.database;
                DocumentReference userDocRef = db.Collection("DRIVERS").Document(_franchise);
                DriversData data = userDocRef.GetSnapshotAsync().Result.ConvertTo<DriversData>();

                if (data != null)
                {
                    //pb_qr_code.Image = Base64StringIntoImage(data.QR_PHOTO);
                    //profile_pic.Image = Base64StringIntoImage(data.DRIVER_PHOTO);
                    AddDrivers driver = new AddDrivers(drivers_dtg, _franchise, "Update");
                    driver.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void add_new_button_Click(object sender, EventArgs e)
        {
            AddDrivers addDrivers = new AddDrivers(drivers_dtg, "", "");
            addDrivers.ShowDialog();
        }

        //private void delete_btn_Click(object sender, EventArgs e)
        //{
        //    using (FRM_Wait frm_wait = new FRM_Wait(Wait))
        //    {
        //        frm_wait.ShowDialog(this);
        //    }
        //    try
        //    {
        //        string franchiseNo = f_no_tb.Text;
        //
        //        DialogResult result = MessageBox.Show("Are you sure you want to remove " + driver_name_tb.Text + "?", "Removed", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        //        if (result == DialogResult.Yes)
        //        {
        //            var db = FirestoreHelper.database;
        //
        //            CollectionReference driverColRef = db.Collection("DRIVERS");
        //
        //            driverColRef.Document(franchiseNo).DeleteAsync();
        //
        //            MessageBox.Show("Data deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //            drivers_dtg.DataSource = null;
        //            drivers_dtg.Rows.Clear();
        //            f_no_tb.Enabled = true;
        //            generate_btn.Enabled = true;
        //            save_btn.Enabled = true;
        //            getDrivers();
        //            ClearText();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}
    }
}
