using System;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using System.Drawing;

namespace SmartBillPosSystem
{
    public partial class FormAddProduct : Form
    {
        private string imagepath = "";

        public FormAddProduct()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ResetFormData();
        }

        private void ResetFormData()
        {
            TextName.Text = string.Empty;
            TextPrice.Text = string.Empty;
            TextCategory.Text = string.Empty;
            TextQuantity.Text = string.Empty;
            imagepath = "";
            PictureProductImage.Image = null;
        }

        static string GenerateShortUuid()
        {
            Guid guid = Guid.NewGuid();
            byte[] bytes = guid.ToByteArray();

            long value = BitConverter.ToInt64(bytes, 0) % 10000000000;

            string shortUuid = value.ToString("D10");

            return "P" + shortUuid;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string productid = null;
            string productName = TextName.Text;
            string category = TextCategory.Text;
            decimal price;
            int quantity;

            productid = GenerateShortUuid();

            if (!decimal.TryParse(TextPrice.Text, out price) || !int.TryParse(TextQuantity.Text, out quantity))
            {
                MessageBox.Show("Invalid Product Details..!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection connection = MainClass.GetSqlConnection())
            {
                try
                {
                    connection.Open();

                    string query = "INSERT INTO Products (product_id, name, category, price, quantity, image) VALUES (@product_id, @name, @category, @price, @quantity, @image)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        if (!string.IsNullOrEmpty(imagepath))
                        {
                            command.Parameters.AddWithValue("@image", imagepath);
                        }

                        command.Parameters.AddWithValue("@product_id", productid);
                        command.Parameters.AddWithValue("@name", productName);
                        command.Parameters.AddWithValue("@category", category);
                        command.Parameters.AddWithValue("@price", price);
                        command.Parameters.AddWithValue("@quantity", quantity);

                        command.ExecuteNonQuery();
                        MessageBox.Show("Product Added Successfully..!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Failed Adding Product..! {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            ResetFormData();
        }

        private void TextPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextName_TextChanged(object sender, EventArgs e)
        {

        }

        private void ButtonChangeImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog.Title = "Select an Image File";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFileName = openFileDialog.FileName;

                MessageBox.Show(selectedFileName, "Selected Image File", MessageBoxButtons.OK, MessageBoxIcon.Information);

                string destinationDirectory = @"C:\Users\Chamidu Suraweera\Desktop\UVPA Project\Assets\Choosed Photos\Choosed Products";

                string destinationPath = Path.Combine(destinationDirectory, Path.GetFileName(selectedFileName));

                File.Copy(selectedFileName, destinationPath, true);

                imagepath = destinationPath;

                try
                {
                    if (File.Exists(destinationPath))
                    {
                        PictureProductImage.Image = Image.FromFile(destinationPath);
                    }
                    else
                    {
                        MessageBox.Show("Selected image file does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error displaying image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TextCategory_TextChanged(object sender, EventArgs e)
        {

        }

        private void PictureProductImage_Click(object sender, EventArgs e)
        {

        }

        private void TextQuantity_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
