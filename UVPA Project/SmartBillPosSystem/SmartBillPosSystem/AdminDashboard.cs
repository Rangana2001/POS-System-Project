using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartBillPosSystem
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void ButtonLogout_Click(object sender, EventArgs e)
        {
            // Close the current form
            this.Close();

            // Open the FormLogin
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
        }

        private void UpdateStatistics()
        {
            // Connect to the database
            using (SqlConnection connection = MainClass.GetSqlConnection())
            {
                connection.Open();

                // Update total orders
                string ordersCountQuery = "SELECT COUNT(*) FROM orders";
                SqlCommand ordersCountCommand = new SqlCommand(ordersCountQuery, connection);
                int totalOrdersX = Convert.ToInt32(ordersCountCommand.ExecuteScalar());
                totalOrders.Text = totalOrdersX.ToString();

                // Update total sales
                string totalSalesQuery = "SELECT SUM(total_amount) FROM orders";
                SqlCommand totalSalesCommand = new SqlCommand(totalSalesQuery, connection);
                object totalSalesResultX = totalSalesCommand.ExecuteScalar();
                totalSales.Text = totalSalesResultX != DBNull.Value ? Convert.ToDecimal(totalSalesResultX).ToString() : "0";

                // Update total customers
                string uniqueCustomersQuery = "SELECT COUNT(DISTINCT customer_name) FROM orders";
                SqlCommand uniqueCustomersCommand = new SqlCommand(uniqueCustomersQuery, connection);
                int totalCustomersX = Convert.ToInt32(uniqueCustomersCommand.ExecuteScalar());
                totalCustomers.Text = totalCustomersX.ToString();

                // Close the connection
                connection.Close();
            }
        }



        private void ButtonAddProduct_Click(object sender, EventArgs e)
        {
            {
                // Create an instance of the FormAddProduct
                FormAddProduct formAddProduct = new FormAddProduct();

                // Hide the current form
                this.Hide();

                // Show the FormAddProduct
                formAddProduct.ShowDialog();

                // After the FormAddProduct is closed, show the current form again
                this.Show();
            }

        }

        private void ButtonManageProduct_Click(object sender, EventArgs e)
        {
            {
                // Create an instance of the FormManageProduct
                FormManageProduct formManageProduct = new FormManageProduct();

                // Hide the current form
                this.Hide();

                // Show the FormManageProduct
                formManageProduct.ShowDialog();

                // After the FormManageProduct is closed, show the current form again
                this.Show();
            }
        }

        private void ButtonUsers_Click(object sender, EventArgs e)
        {
            // Create an instance of the FormUsers
            FormUsers formUsers = new FormUsers();

            // Hide the current form
            this.Hide();

            // Show the FormUsers
            formUsers.ShowDialog();

            // After the FormUsers is closed, show the current form again
            this.Show();

        }

        private void ButtonTransactionHistroy_Click(object sender, EventArgs e)
        {
            {
                // Create an instance of the FormTransaction
                FormTransactions formTransactions = new FormTransactions();

                // Hide the current form
                this.Hide();

                // Show the FormTransaction
                formTransactions.ShowDialog();

                // After the FormTransaction is closed, show the current form again
                this.Show();
            }
        }

        private void ButtonSalesReport_Click(object sender, EventArgs e)
        {
            {
                // Create an instance of the FormSalesReport
                FormSalesReport formSalesReport = new FormSalesReport();

                // Hide the current form
                this.Hide();

                // Show the FormTransaction
                formSalesReport.ShowDialog();

                // After the FormTransaction is closed, show the current form again
                this.Show();
            }
            
        }

        private void ButtonDashboard_Click(object sender, EventArgs e)
        {

        }

        private void totalOrders_Click(object sender, EventArgs e)
        {

        }

        private void totalSales_Click(object sender, EventArgs e)
        {

        }

        private void totalCustomers_Click(object sender, EventArgs e)
        {

        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            UpdateStatistics();
        }
    }
}
