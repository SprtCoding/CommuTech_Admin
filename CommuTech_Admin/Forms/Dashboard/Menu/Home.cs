using CommuTech_Admin.Classes;
using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace CommuTech_Admin.Forms.Dashboard.Menu
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            showSmsRecordsPerMonthChart();
        }

        private async void showSmsRecordsPerMonthChart()
        {
            try
            {
                var db = FirestoreHelper.database;
                CollectionReference collectionRef = db.Collection("SMS_RECORDS");

                // Fetch all SMS records
                QuerySnapshot snapshot = await collectionRef.GetSnapshotAsync();

                // Initialize dictionaries to store counts
                Dictionary<string, int> monthlyCounts = new Dictionary<string, int>();
                int emergencyCount = 0;
                int normalCount = 0;

                foreach (DocumentSnapshot doc in snapshot.Documents)
                {
                    object dateValue;
                    if (doc.TryGetValue("DATE", out dateValue) && dateValue is string)
                    {
                        string dateStr = (string)dateValue; // Cast to string

                        if (DateTime.TryParseExact(dateStr, "MMMM dd, yyyy", null, DateTimeStyles.None, out DateTime date))
                        {
                            string monthYear = date.ToString("MMMM, yyyy");

                            if (!monthlyCounts.ContainsKey(monthYear))
                            {
                                monthlyCounts[monthYear] = 0;
                            }

                            monthlyCounts[monthYear]++;

                            object smsTypeValue;
                            if (doc.TryGetValue("SMS_TYPE", out smsTypeValue) && smsTypeValue is string)
                            {
                                string smsType = (string)smsTypeValue; // Cast to string

                                if (smsType == "emergency")
                                {
                                    emergencyCount++;
                                }
                                else if (smsType == "normal")
                                {
                                    normalCount++;
                                }
                            }
                        }
                    }
                }

                // Create a series for monthly SMS counts
                Series monthlySeries = new Series("All SMS Counts");
                monthlySeries.ChartType = SeriesChartType.Column;
                monthlySeries.Points.AddXY("All SMS", emergencyCount + normalCount);

                //foreach (var entry in monthlyCounts)
                //{
                //    DataPoint point = new DataPoint();
                //    point.AxisLabel = entry.Key;
                //    point.SetValueY(entry.Value);
                //    monthlySeries.Points.Add(point);
                //}

                // Create a series for emergency SMS count
                Series emergencySeries = new Series("Emergency SMS Count");
                emergencySeries.ChartType = SeriesChartType.Column;
                emergencySeries.Points.AddXY("Emergency", emergencyCount);

                // Create a series for normal SMS count
                Series normalSeries = new Series("Normal SMS Count");
                normalSeries.ChartType = SeriesChartType.Column;
                normalSeries.Points.AddXY("Normal", normalCount);

                chart_sms.Series.Add(monthlySeries);
                chart_sms.Series.Add(emergencySeries);
                chart_sms.Series.Add(normalSeries);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
