using System;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;

namespace SmartBillPosSystem
{
    public partial class FormManageProduct : Form
    {
        private readonly SqlConnection connection;

        private String clickedProductID = null;
        private String clickedCategory = null;

        public FormManageProduct()
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

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void RefreshData()
        {
            RetrieveAllProducts();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns["productIdFromDb"].Index)
            {
                clickedProductID = dataGridView1.Rows[e.RowIndex].Cells["productIdFromDb"].Value.ToString();
                
            }
        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            clickedCategory = "Food";
            clickedProductID = null;
            Load("Food");
        }

        private void ButtonDrinks_CheckedChanged(object sender, EventArgs e)
        {
            clickedCategory = "DRINKS";
            clickedProductID = null;
            Load("DRINKS");
        }

        private void ButtonDesserts_CheckedChanged(object sender, EventArgs e)
        {
            clickedCategory = "DESSERTS";
            clickedProductID = null;
            Load("DESSERTS");
        }

        private void ButtonSnacks_CheckedChanged(object sender, EventArgs e)
        {
            clickedCategory = "SNACKS";
            clickedProductID = null;
            Load("SNACKS");
        }

        private void ButtonPackages_CheckedChanged(object sender, EventArgs e)
        {
            clickedCategory = "PACKAGES";
            clickedProductID = null;
            Load("PACKAGES");
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {

            if (clickedProductID == null)
            {
                MessageBox.Show($"Please select a product before update!");
            } else
            {
                FormUpdateProduct formUpdateProduct = new FormUpdateProduct(clickedProductID);

                formUpdateProduct.FormClosed += FormUpdateProduct_FormClosed;

                formUpdateProduct.ShowDialog();

            }

           
        }

        private void FormUpdateProduct_FormClosed(object sender, FormClosedEventArgs e)
        {
            reloadProductForSelectedCategory();
            if (sender is FormUpdateProduct formUpdateProduct)
            {
                formUpdateProduct.FormClosed -= FormUpdateProduct_FormClosed;
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (clickedProductID == null)
            {
                MessageBox.Show($"Please select a product before delete!");
            }
            else
            {
                using (SqlConnection connection = MainClass.GetSqlConnection())
                {
                    try
                    {
                        connection.Open();

                        string query = "DELETE FROM products WHERE product_id = @productId";
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@productId", clickedProductID);

                            command.ExecuteNonQuery();
                            MessageBox.Show("Product Deleted Successfully..!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            Load(clickedCategory);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Failed to Delete the Product..! {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
                

        }

        public void reloadProductForSelectedCategory()
        {
            Load(clickedCategory);
        }
    }
}
