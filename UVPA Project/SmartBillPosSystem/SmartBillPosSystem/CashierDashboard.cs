using System;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.Remoting.Messaging;
using System.Collections.Generic;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace SmartBillPosSystem
{
    public partial class CashierDashboard : Form
    {
        private readonly SqlConnection connection;

        string[] selectedProducts = Array.Empty<string>();

        // Add ListBox field
        private ListBox listBox1;

        public CashierDashboard()
        {
            InitializeComponent();
            connection = MainClass.GetSqlConnection();


        }

        private void Load(string category)
        {
            LoadProductsByCategory(category);
            LoadImages();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn.HeaderText = "imagex";
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridView1.Columns.Add(imageColumn);

            RetrieveAllProducts();
            LoadImages();

        }

        private void LoadImages()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["productImagePathFromDb"].Value != null)
                {
                    string imagePath = row.Cells["productImagePathFromDb"].Value.ToString();

                    if (System.IO.File.Exists(imagePath))
                    {
                        Image image = Image.FromFile(imagePath);
                        row.Cells["imagex"].Value = image;
                    }
                    else
                    {
                        row.Cells["imagex"].Value = null;
                    }
                }
            }
        }

        private void CashierDashboard_Load(object sender, EventArgs e)
        {
            RetrieveAllProducts();
        }

        private void ButtonDrinks_CheckedChanged(object sender, EventArgs e)
        {
            Load("Drinks");
        }

        private void ButtonPackages_CheckedChanged(object sender, EventArgs e)
        {
            Load("Packages");
        }

        private void ButtonFoods_CheckedChanged(object sender, EventArgs e)
        {
            Load("Food");
        }

        private void ButtonSnacks_CheckedChanged(object sender, EventArgs e)
        {
            Load("Snacks");
        }

        private void ButtonDesserts_CheckedChanged(object sender, EventArgs e)
        {
            Load("Desserts");
        }

        private void ButtonPackages_CheckedChanged_1(object sender, EventArgs e)
        {
            Load("Packages");
        }

        private void LoadProductsByCategory(string category)
        {
            RetrieveProductsByCategory(category);
        }

        private void RetrieveProductsByCategory(string category)
        {
            try
            {
                connection.Open();

                string query = $"SELECT * FROM products WHERE category = '{category}'";
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void RetrieveAllProducts()
        {
            try
            {
                connection.Open();

                string query = "SELECT * FROM products";
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        static T[] PushItem<T>(T[] array, T item)
        {
            T[] newArray = new T[array.Length + 1];
            Array.Copy(array, newArray, array.Length);
            newArray[array.Length] = item;
            return newArray;
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns["product_id"].Index)
            {
                if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns["product_id"].Index)
                {
                    string clickedProductID = dataGridView1.Rows[e.RowIndex].Cells["product_id"].Value.ToString();
                    RetrieveProductDetails(clickedProductID);
                }

            }
        }


        private void RetrieveProductDetails(string productID)
        {
            try
            {
                connection.Open();

                string query = $"SELECT * FROM products WHERE product_id = '{productID}'";
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    DataGridViewRow existingRow = null;
                    foreach (DataGridViewRow row in dataGridView2.Rows)
                    {
                        if (row.Cells["name"].Value != null &&
                            row.Cells["name"].Value.ToString() == reader["name"].ToString())
                        {
                            existingRow = row;
                            break;
                        }
                    }

                    if (existingRow != null)
                    {
                        int currentQuantity = Convert.ToInt32(existingRow.Cells["quantity"].Value);
                        currentQuantity++;
                        existingRow.Cells["quantity"].Value = currentQuantity;

                        existingRow.Cells["amount"].Value = Convert.ToInt32(existingRow.Cells["quantity"].Value) * Convert.ToInt32(reader["price"]);

                        UpdateTotalAmount();
                    }
                    else
                    {
                        dataGridView2.Rows.Add(
                            reader["name"].ToString(),
                            reader["price"].ToString(),
                            "1",
                            Convert.ToInt32(reader["price"]) * 1
                        );
                        UpdateTotalAmount();
                    }
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }


        private void UpdateTotalAmount()
        {
            int totalAmount = 0;

            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                if (row.Cells["amount"].Value != null)
                {
                    totalAmount += Convert.ToInt32(row.Cells["amount"].Value);
                }
            }

            totalAmountValue.Text = totalAmount.ToString();
        }


        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void totalAmountValue_Click(object sender, EventArgs e)
        {

        }

        private void buttonOrderProcess_Click(object sender, EventArgs e)
        {
            if(customerNameInput.Text == null || customerNameInput.Text == "")
            {
                MessageBox.Show("Please enter customer name");
            }

            if (customerMobileInput.Text == null || customerMobileInput.Text == "")
            {
                MessageBox.Show("Please enter customer mobile");
            }

            string[][] productDataArray = GetDataGridViewValues();
            if (productDataArray == null)
            {
                MessageBox.Show("Please add some products");
            }
            else
            {
                string[] productList = new string[0];

                foreach (var row in productDataArray)
                {
                    //Console.WriteLine(string.Join(",", row));
                    productList = PushItem(productList, string.Join(",", row));
                }

                string productListString = string.Join(",", productList);

                using (SqlConnection connection = MainClass.GetSqlConnection())
                {
                    try
                    {
                        connection.Open();

                        string query = "INSERT INTO orders (order_id, order_date, product_list, total_amount, customer_name, customer_mobile) " +
                                       "VALUES (@order_id, @order_date, @product_list, @total_amount, @customer_name, @customer_mobile)";

                        DateTime currentDate = DateTime.Now;
                        string orderDate = currentDate.ToString("yyyy-MM-dd");
                        string totalAmount = totalAmountValue.Text;


                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@order_id", "O"+GenerateShortUuid());
                            command.Parameters.AddWithValue("@order_date", orderDate);
                            command.Parameters.AddWithValue("@product_list", productListString);
                            command.Parameters.AddWithValue("@total_amount", Convert.ToInt32(totalAmount));
                            command.Parameters.AddWithValue("@customer_name", customerNameInput.Text);
                            command.Parameters.AddWithValue("@customer_mobile", customerMobileInput.Text);

                            command.ExecuteNonQuery();
                            //MessageBox.Show("Order Placed Successfully..!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            ReceiptForm receiptForm = new ReceiptForm("O" + GenerateShortUuid(), currentDate.ToString("yyyy-MM-dd"), productListString, Convert.ToInt32(totalAmount), customerNameInput.Text, customerMobileInput.Text);
                            receiptForm.ShowDialog();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Failed placing order..! {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }


        private string GenerateShortUuid()
        {
            Guid guid = Guid.NewGuid();
            byte[] bytes = guid.ToByteArray();

            long value = BitConverter.ToInt64(bytes, 0) % 10000000000;

            string shortUuid = value.ToString("D10");

            return shortUuid;
        }


        private string[][] GetDataGridViewValues()
        {
            List<string[]> valuesList = new List<string[]>();

            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                if (row.IsNewRow) continue;

                List<string> rowValues = new List<string>();

                // Loop through cells excluding the last one
                for (int i = 0; i < row.Cells.Count - 1; i++)
                {
                    DataGridViewCell cell = row.Cells[i];

                    if (cell.Value != null)
                    {
                        rowValues.Add(cell.Value.ToString());
                    }
                    else
                    {
                        rowValues.Add(""); // Add an empty string if the cell value is null
                    }
                }

                valuesList.Add(rowValues.ToArray());
            }

            return valuesList.ToArray();
        }

        private void customerNameInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOrderCancel_Click(object sender, EventArgs e)
        {

        }
    }

    //Final One
}