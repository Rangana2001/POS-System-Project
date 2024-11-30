using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartBillPosSystem
{
    public partial class FormUpdateUser : Form
    {
        private string imagepath = "";
        private String clickedUserId = null;

        public FormUpdateUser(string clickedUserId)
        {
            InitializeComponent();
            this.clickedUserId = clickedUserId;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RetrieveUserDetails()
        {
            try
            {
                using (SqlConnection connection = MainClass.GetSqlConnection())
                {
                    connection.Open();

                    string query = "SELECT fullname, email, role, nic, image, gender FROM users WHERE user_id = @user_id";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@user_id", clickedUserId);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {

                                TextName.Text = reader["fullname"].ToString();
                                TextEmail.Text = reader["email"].ToString();
                                TextRole.Text = reader["role"].ToString();
                                TextNICNumber.Text = reader["nic"].ToString();

                                string imagePath = reader["image"].ToString();

                                string gender = reader["gender"].ToString();

                                if(gender == "Female")
                                {
                                    radioButton2.Checked = true;
                                    radioButton1.Checked = false;
                                } else
                                {
                                    radioButton2.Checked = false;
                                    radioButton1.Checked = true;
                                }

                                if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
                                {
                                    PictureUserImage.ImageLocation = imagePath;
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

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = MainClass.GetSqlConnection())
                {
                    connection.Open();

                    string query = "UPDATE users SET fullname = @fullname, email = @email, role = @role, nic = @nic, image = @image, gender = @gender WHERE user_id = @user_id";


                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@fullname", TextName.Text);
                        command.Parameters.AddWithValue("@email", TextEmail.Text);
                        command.Parameters.AddWithValue("@role", TextRole.Text);
                        command.Parameters.AddWithValue("@image", PictureUserImage.ImageLocation);
                        command.Parameters.AddWithValue("@nic", TextNICNumber.Text);
                        if(radioButton1.Checked)
                        {
                            command.Parameters.AddWithValue("@gender", "Male");
                        } else if (radioButton2.Checked)
                        {
                            command.Parameters.AddWithValue("@gender", "Female");
                        }

                        command.Parameters.AddWithValue("@user_id", clickedUserId);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("User updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


                            RetrieveUserDetails();

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
                MessageBox.Show($"Error updating user: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonChangeImage_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog.Title = "Select an Image File";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFileName = openFileDialog.FileName;

                string destinationDirectory = @"C:\Users\Chamidu Suraweera\Desktop\UVPA Project\Assets\Choosed Photos\Choosed Users\";

                string destinationPath = Path.Combine(destinationDirectory, Path.GetFileName(selectedFileName));

                File.Copy(selectedFileName, destinationPath, true);

                imagepath = destinationPath;


                try
                {
                    if (File.Exists(destinationPath))
                    {
                        PictureUserImage.Image = Image.FromFile(destinationPath);
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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ButtonReset_Click(object sender, EventArgs e)
        {

        }

        private void TextName_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextRole_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextNICNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormUpdateUser_Load(object sender, EventArgs e)
        {
            RetrieveUserDetails();
        }

        private void PictureUserImage_Click(object sender, EventArgs e)
        {
            try
            {

                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Image Files (*.bmp;*.jpg;*.jpeg;*.gif;*.png)|*.bmp;*.jpg;*.jpeg;*.gif;*.png";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {

                    PictureUserImage.ImageLocation = openFileDialog.FileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error selecting image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    //MEKA HRIMA DeKAAAA
}
