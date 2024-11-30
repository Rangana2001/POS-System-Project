using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace SmartBillPosSystem
{
    public partial class FormAddUser : Form
    {
        private string imagepath = "";

        public FormAddUser()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void TextName_TextChanged(object sender, EventArgs e)
        {
  
        }

        private void ButtonReset_Click(object sender, EventArgs e)
        {
            ResetFormData();
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            string user_id = GenerateShortUuid();
            string fullname = TextName.Text.Trim();
            string email = TextEmail.Text.Trim();
            string role = TextRole.Text.Trim();
            string gender = radioButton1.Checked ? "Male" : radioButton2.Checked ? "Female" : string.Empty;
            string nic = TextNICNumber.Text.Trim();

            if (string.IsNullOrEmpty(fullname) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(role) || string.IsNullOrEmpty(gender) || string.IsNullOrEmpty(nic))
            {
                MessageBox.Show("Please fill in all the required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (nic.Length != 12 && !(nic.Length == 10 && char.ToUpper(nic[9]) == 'V' && int.TryParse(nic.Substring(0, 9), out _)))
            {
                MessageBox.Show("NIC Number should have exactly 12 characters or be 9 numbers ending with 'V'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!string.IsNullOrEmpty(imagepath) && File.Exists(imagepath))
            {
                using (SqlConnection connection = MainClass.GetSqlConnection())
                {
                    try
                    {
                        connection.Open();

                        string query = "INSERT INTO Users (user_id, fullname, email, role, gender, nic, image) " +
                                       "VALUES (@user_id, @fullname, @email, @role, @gender, @nic, @image)";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@user_id", user_id);
                            command.Parameters.AddWithValue("@fullname", fullname);
                            command.Parameters.AddWithValue("@email", email);
                            command.Parameters.AddWithValue("@role", role);
                            command.Parameters.AddWithValue("@gender", gender);
                            command.Parameters.AddWithValue("@nic", nic);
                            command.Parameters.AddWithValue("@image", imagepath);

                            command.ExecuteNonQuery();
                            MessageBox.Show("User Registered Successfully..!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Failed Registering User..! {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            ResetFormData();
        }

        private string GenerateShortUuid()
        {
            Guid guid = Guid.NewGuid();
            byte[] bytes = guid.ToByteArray();

            long value = BitConverter.ToInt64(bytes, 0) % 10000000000;

            string shortUuid = value.ToString("D10");

            return "U" + shortUuid;
        }

        private void ResetFormData()
        {
            TextName.Text = string.Empty;
            TextEmail.Text = string.Empty;
            TextRole.Text = string.Empty;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            TextNICNumber.Text = string.Empty;
            imagepath = "";
            PictureUserImage.Image = null;
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


        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void PictureUserImage_Click(object sender, EventArgs e)
        {

        }
    }
}
