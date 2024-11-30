using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace SmartBillPosSystem
{
    public partial class FormSalesReport : Form
    {
        public FormSalesReport()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormSalesReport_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = MainClass.GetSqlConnection())
            {
                connection.Open();

                // SQL query to retrieve data
                string query = "SELECT [order_date], [total_amount] FROM [smartbill].[dbo].[orders]";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // Clear existing series in the chart
                        chart1.Series.Clear();

                        // Create a new series
                        Series series = new Series("Sales");
                        series.ChartType = SeriesChartType.Bar; // Set default chart type to Bar

                        // Use a Dictionary to store and sum total sales for each date
                        Dictionary<DateTime, decimal> totalSalesByDate = new Dictionary<DateTime, decimal>();

                        // Populate the series with data from the database
                        while (reader.Read())
                        {
                            // Parse the order date from string to DateTime
                            DateTime orderDate = DateTime.ParseExact(reader.GetString(0), "yyyy-MM-dd", null);
                            decimal totalAmount = reader.GetInt32(1);

                            // Update total sales for the date in the dictionary
                            if (totalSalesByDate.ContainsKey(orderDate))
                            {
                                totalSalesByDate[orderDate] += totalAmount;
                            }
                            else
                            {
                                totalSalesByDate.Add(orderDate, totalAmount);
                            }
                        }

                        // Add data points to the series from the dictionary
                        foreach (var kvp in totalSalesByDate)
                        {
                            series.Points.AddXY(kvp.Key, kvp.Value);
                        }

                        // Add the series to the chart
                        chart1.Series.Add(series);
                    }
                }
            }

            // Set chart properties (you can customize these as needed)
            chart1.ChartAreas[0].AxisX.Title = "Order Date";
            chart1.ChartAreas[0].AxisY.Title = "Total Sales";
            chart1.Titles.Add("Sales Trend Report");
        }

        private void chart1_Click(object sender, EventArgs e)
        {
            // Handle chart click event if needed
        }
    }
}


//meka thamai harima eka