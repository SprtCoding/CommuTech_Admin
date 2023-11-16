using Bunifu.Framework.UI;
using CommuTech_Admin.Classes;
using CommuTech_Admin.Classes.Model;
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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommuTech_Admin.Forms.Dashboard.AddForms
{
    public partial class AddDrivers : Form
    {
        public static bool isAgreed;
        private string? QRCodeImage;
        private string? DriverImage;
        private PrintDocument printDocument = new PrintDocument();
        private BunifuCustomDataGrid? DTG;
        private string id;

        public AddDrivers(BunifuCustomDataGrid DTG, string id, string option)
        {
            InitializeComponent();
            printDocument.PrintPage += new PrintPageEventHandler(PrintImage);
            this.DTG = DTG;
            this.id = id;

            if (!id.Equals(""))
            {
                getDriversInfo();
                update_button.Enabled = true;
                delete_button.Enabled = true;
                save_button.Enabled = false;
                fr_no.Enabled = false;
                generate_button.Enabled = false;
            }

            if (!option.Equals(""))
            {
                title_add.Text = "Update Driver/s";
            }
        }

        private void PrintImage(object sender, PrintPageEventArgs e)
        {
            // Get the image from the PictureBox
            Image imageToPrint = qr_pic.Image;

            if (imageToPrint != null)
            {
                // Calculate the size and position of the image on the printed page
                Rectangle imageRect = e.MarginBounds;

                imageRect.Size = new Size(e.MarginBounds.Width, e.MarginBounds.Height);

                // Set the position of the image based on the selected option
                imageRect.X = (e.MarginBounds.Left + e.MarginBounds.Right - imageRect.Width) / 2;
                imageRect.Y = (e.MarginBounds.Top + e.MarginBounds.Bottom - imageRect.Height) / 2;

                // Draw the image on the printed page
                e.Graphics.DrawImage(imageToPrint, imageRect);
            }
            else
            {
                MessageBox.Show("No QR Code is Selected!");
            }
        }

        void Wait()
        {
            for (int i = 0; i < 200; i++)
            {
                Thread.Sleep(5);
            }
        }

        private void generateQRCode()
        {
            using (FRM_Wait frm_wait = new FRM_Wait(Wait))
            {
                frm_wait.ShowDialog(this);
            }
            string franchiseNo = fr_no.Text;

            if (String.IsNullOrEmpty(franchiseNo))
            {
                MessageBox.Show("Please enter franchise number before generating!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                try
                {
                    // Generate the QR code
                    QRCodeGenerator qrGenerator = new QRCodeGenerator();
                    QRCodeData qrCodeData = qrGenerator.CreateQrCode(franchiseNo, QRCodeGenerator.ECCLevel.Q);
                    QRCode qrCode = new QRCode(qrCodeData);
                    Bitmap qrCodeImage = qrCode.GetGraphic(10);

                    QRCodeImage = ConvertImageToBase64(qrCodeImage);

                    // Display the QR code in PictureBox
                    qr_pic.Image = qrCodeImage;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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

        private void ClearText()
        {
            driver_name.Text = "";
            driver_address.Text = "";
            c_no.Text = "";
            fr_no.Text = "";
            l_no.Text = "";
            reg_no.Text = "";
            qr_pic.Image = null;
            driver_pic.Image = null;
        }

        private void new_button_Click(object sender, EventArgs e)
        {
            ClearText();
            fr_no.Enabled = true;
            generate_button.Enabled = true;
            save_button.Enabled = true;

            update_button.Enabled = false;
            delete_button.Enabled = false;
        }

        private void saveDriver()
        {
            using (FRM_Wait frm_wait = new FRM_Wait(Wait))
            {
                frm_wait.ShowDialog(this);
            }
            string fullname = driver_name.Text;
            string address = driver_address.Text;
            string contact = c_no.Text;
            string franchiseNo = fr_no.Text;
            string driverLicenseNo = l_no.Text;
            string vehicleRegNo = reg_no.Text;
            string img = ImageIntoBase64String(driver_pic);

            if (String.IsNullOrEmpty(fullname))
            {
                MessageBox.Show("sdad" + img, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (String.IsNullOrEmpty(address))
            {
                MessageBox.Show("Please enter address!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (String.IsNullOrEmpty(contact))
            {
                MessageBox.Show("Please enter contact!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (String.IsNullOrEmpty(franchiseNo))
            {
                MessageBox.Show("Please enter franchise number!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (String.IsNullOrEmpty(driverLicenseNo))
            {
                MessageBox.Show("Please enter driver's license number!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (String.IsNullOrEmpty(vehicleRegNo))
            {
                MessageBox.Show("Please enter vehicle registration number!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (qr_pic.Image == null)
            {
                MessageBox.Show("Please generate QR Code!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (driver_pic.Image == null)
            {
                MessageBox.Show("Please select Profile Picture!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (!isAgreed)
                {
                    MessageBox.Show("Please Agree with privacy and policy of Commu-Tech!");
                    DataAgreement.DataPrivacyAgreement dataPrivacyAgreement = new DataAgreement.DataPrivacyAgreement();
                    dataPrivacyAgreement.ShowDialog();
                }

                setDrivers(fullname, address, contact, franchiseNo, driverLicenseNo, vehicleRegNo, QRCodeImage, DriverImage);

            }
        }

        private async void setDrivers(string fullname, string address, string contact, string franchiseNo, string driverLicenseNo, string vehicleRegNo, string qRCodeImage, string d_pic)
        {
            try
            {
                var db = FirestoreHelper.database;

                CollectionReference driverColRef = db.Collection("DRIVERS");
                Dictionary<string, object> data = new Dictionary<string, object>()
                    {
                        {"ID", franchiseNo },
                        {"DRIVERS_NAME", fullname },
                        {"ADDRESS", address },
                        {"CONTACT", contact },
                        {"FRANCHISE_NO", franchiseNo },
                        {"LICENSE_NO", driverLicenseNo },
                        {"REG_NO", vehicleRegNo },
                        {"QR_PHOTO", qRCodeImage },
                        {"DRIVER_PHOTO", d_pic }
                    };

                var info = await driverColRef.Document(franchiseNo).CreateAsync(data);

                MessageBox.Show("Data saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DTG.DataSource = null;
                DTG.Rows.Clear();
                getDrivers();
                ClearText();
                Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private async void getDriversInfo()
        {
            try
            {
                var db = FirestoreHelper.database;

                if (!id.Equals(""))
                {
                    DocumentReference drivers = db.Collection("DRIVERS").Document(id);
                    var snapshot = await drivers.GetSnapshotAsync();

                    if (snapshot.Exists)
                    {
                        var data = snapshot.ToDictionary();
                        if (data.TryGetValue("DRIVERS_NAME", out object driversName))
                        {
                            string value = driversName?.ToString();
                            driver_name.Text = value;
                        }
                        if (data.TryGetValue("FRANCHISE_NO", out object franchiseNo))
                        {
                            string value = franchiseNo?.ToString();
                            fr_no.Text = value;
                        }
                        if (data.TryGetValue("ADDRESS", out object address))
                        {
                            string value = address?.ToString();
                            driver_address.Text = value;
                        }
                        if (data.TryGetValue("LICENSE_NO", out object license))
                        {
                            string value = license?.ToString();
                            l_no.Text = value;
                        }
                        if (data.TryGetValue("CONTACT", out object contact))
                        {
                            string value = contact?.ToString();
                            c_no.Text = value;
                        }
                        if (data.TryGetValue("REG_NO", out object regNo))
                        {
                            string value = regNo?.ToString();
                            reg_no.Text = value;
                        }
                        if (data.TryGetValue("QR_PHOTO", out object qrURL))
                        {
                            string value = qrURL?.ToString();
                            qr_pic.Image = Base64StringIntoImage(value);
                        }
                        if (data.TryGetValue("DRIVER_PHOTO", out object driverURL))
                        {
                            string value = driverURL?.ToString();
                            driver_pic.Image = Base64StringIntoImage(value);
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                        DTG.Rows.Add(
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

        private async void updateDrivers(string fullname, string address, string contact, string franchiseNo, string driverLicenseNo, string vehicleRegNo, string qRCodeImage, string d_pic)
        {
            try
            {
                var db = FirestoreHelper.database;

                CollectionReference driverColRef = db.Collection("DRIVERS");
                Dictionary<string, object> data = new Dictionary<string, object>()
                    {
                        {"ID", franchiseNo },
                        {"DRIVERS_NAME", fullname },
                        {"ADDRESS", address },
                        {"CONTACT", contact },
                        {"FRANCHISE_NO", franchiseNo },
                        {"LICENSE_NO", driverLicenseNo },
                        {"REG_NO", vehicleRegNo },
                        {"QR_PHOTO", qRCodeImage },
                        {"DRIVER_PHOTO", d_pic }
                    };

                await driverColRef.Document(franchiseNo).UpdateAsync(data);

                MessageBox.Show("Data updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DTG.DataSource = null;
                DTG.Rows.Clear();
                fr_no.Enabled = true;
                generate_button.Enabled = true;
                save_button.Enabled = true;
                getDrivers();
                ClearText();
                Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void open_file_button_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image files(*.jpg, *.jpeg, *.bmp, *.png) | *.jpg; *.jpeg; *.bmp; *.png; | All files (*.*) | *.*";
            if (open.ShowDialog() == DialogResult.OK)
            {
                driver_pic.Load(open.FileName);
                using (Bitmap original = new Bitmap(open.FileName))
                {
                    int maxWidth = 800; // Maximum width
                    int maxHeight = 600; // Maximum height

                    Bitmap resizedImage = ResizeImage(original, maxWidth, maxHeight);

                    // Convert the resized image to Base64 and upload it.
                    string base64Image = ConvertImageToBase64(resizedImage);
                    DriverImage = base64Image;
                    // Now, use base64Image for upload.
                }
            }
        }

        private Bitmap ResizeImage(Bitmap image, int maxWidth, int maxHeight)
        {
            int newWidth, newHeight;
            double aspectRatio = (double)image.Width / (double)image.Height;

            if (image.Width <= maxWidth && image.Height <= maxHeight)
            {
                // The image is smaller than the maximum dimensions, no need to resize.
                return image;
            }

            if (aspectRatio > 1)
            {
                // Landscape orientation (wider than tall)
                newWidth = maxWidth;
                newHeight = (int)(maxWidth / aspectRatio);
            }
            else
            {
                // Portrait orientation (taller than wide)
                newHeight = maxHeight;
                newWidth = (int)(maxHeight * aspectRatio);
            }

            Bitmap resizedImage = new Bitmap(newWidth, newHeight);

            using (Graphics graphics = Graphics.FromImage(resizedImage))
            {
                graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                graphics.DrawImage(image, 0, 0, newWidth, newHeight);
            }

            return resizedImage;
        }

        private void printQRCode()
        {
            // Show the Print Dialog
            using (PrintDialog printDialog = new PrintDialog())
            {
                printDialog.Document = printDocument;
                if (printDialog.ShowDialog() == DialogResult.OK)
                {
                    printDocument.Print();
                }
            }
        }

        private void generate_button_Click(object sender, EventArgs e)
        {
            generateQRCode();
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            saveDriver();
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void print_button_Click(object sender, EventArgs e)
        {
            printQRCode();
        }

        private void update_button_Click(object sender, EventArgs e)
        {
            using (FRM_Wait frm_wait = new FRM_Wait(Wait))
            {
                frm_wait.ShowDialog(this);
            }
            string fullname = driver_name.Text;
            string address = driver_address.Text;
            string contact = c_no.Text;
            string franchiseNo = fr_no.Text;
            string driverLicenseNo = l_no.Text;
            string vehicleRegNo = reg_no.Text;
            string img = ImageIntoBase64String(driver_pic);
            string qrImg = ImageIntoBase64String(qr_pic);

            if (String.IsNullOrEmpty(fullname))
            {
                MessageBox.Show("Please enter fullname!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (String.IsNullOrEmpty(address))
            {
                MessageBox.Show("Please enter address!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (String.IsNullOrEmpty(contact))
            {
                MessageBox.Show("Please enter contact!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (String.IsNullOrEmpty(driverLicenseNo))
            {
                MessageBox.Show("Please enter driver's license number!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (String.IsNullOrEmpty(vehicleRegNo))
            {
                MessageBox.Show("Please enter vehicle registration number!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (qr_pic.Image == null)
            {
                MessageBox.Show("Please generate QR Code!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (driver_pic.Image == null)
            {
                MessageBox.Show("Please select Profile Picture!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                updateDrivers(fullname, address, contact, franchiseNo, driverLicenseNo, vehicleRegNo, qrImg, img);

            }
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            using (FRM_Wait frm_wait = new FRM_Wait(Wait))
            {
                frm_wait.ShowDialog(this);
            }
            try
            {
                string franchiseNo = fr_no.Text;

                DialogResult result = MessageBox.Show("Are you sure you want to remove " + driver_name.Text + "?", "Removed", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    var db = FirestoreHelper.database;

                    CollectionReference driverColRef = db.Collection("DRIVERS");

                    driverColRef.Document(franchiseNo).DeleteAsync();

                    MessageBox.Show("Data deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DTG.DataSource = null;
                    DTG.Rows.Clear();
                    fr_no.Enabled = true;
                    generate_button.Enabled = true;
                    save_button.Enabled = true;
                    save_button.Enabled = true;
                    getDrivers();
                    ClearText();
                    Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
