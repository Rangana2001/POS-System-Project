using System;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using System.Drawing;

namespace SmartBillPosSystem
{

    public partial class FormUpdateProduct : Form
    {
        private string imagepath = "";
        String selectedProductId = null;

        public FormUpdateProduct(string productId)
        {
            InitializeComponent();
            selectedProductId = productId.Trim();

            productName.Text = selectedProductId;

            RetrieveProductDetails(selectedProductId);
        }

        private void RetrieveProductDetails(string productId)
        {
            try
            {
                using (SqlConnection connection = MainClass.GetSqlConnection())
                {
                    connection.Open();

                    string query = "SELECT name, category, price, quantity, image FROM products WHERE product_id = @ProductId";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ProductId", productId);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                productName.Text = reader["name"].ToString();
                                productCategory.Text = reader["category"].ToString();
                                productPrice.Text = reader["price"].ToString();
                                productQuantity.Text = reader["quantity"].ToString();

                                string imagePath = reader["image"].ToString();

                                if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
                                {
                                    PictureProductImage.ImageLocation = imagePath;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving product details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void productName_TextChanged(object sender, EventArgs e)
        {

        }

        private void PictureProductImage_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Image Files (*.bmp;*.jpg;*.jpeg;*.gif;*.png)|*.bmp;*.jpg;*.jpeg;*.gif;*.png";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    PictureProductImage.ImageLocation = openFileDialog.FileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error selecting image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonReset_Click_1(object sender, EventArgs e)
        {
            productName.Text = string.Empty;
            productCategory.Text = string.Empty;
            productPrice.Text = string.Empty;
            productQuantity.Text = string.Empty;

            PictureProductImage.ImageLocation = null;

            MessageBox.Show("Form reset successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonUpdate_Click_1(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = MainClass.GetSqlConnection())
                {
                    connection.Open();

                    string query = "UPDATE products SET name = @Name, category = @Category, price = @Price, quantity = @Quantity, image = @Image WHERE product_id = @ProductId";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Name", productName.Text);
                        command.Parameters.AddWithValue("@Category", productCategory.Text);
                        command.Parameters.AddWithValue("@Price", decimal.Parse(productPrice.Text));
                        command.Parameters.AddWithValue("@Quantity", int.Parse(productQuantity.Text));
                        command.Parameters.AddWithValue("@Image", PictureProductImage.ImageLocation);
                        command.Parameters.AddWithValue("@ProductId", selectedProductId);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Product updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            RetrieveProductDetails(selectedProductId);

                        }
                        else
                        {
                            MessageBox.Show("Update failed. Please check your input and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating product: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       

        private void FormUpdateProduct_Load(object sender, EventArgs e)
        {
            
        }

    }
}
