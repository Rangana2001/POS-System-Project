using System;
using System.Windows.Forms;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;

namespace SmartBillPosSystem
{
    public partial class FormUsers : Form
    {
        private SqlConnection connection;
        private String clickedUserID = null;

        public FormUsers()
        {
            InitializeComponent();
            // Initialize the database connection
            connection = MainClass.GetSqlConnection();
        }

        private void FormUsers_Load(object sender, EventArgs e)
        {
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn.HeaderText = "imagex";
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridView1.Columns.Add(imageColumn);

            RefreshUserData();
            LoadImages();
        }

        private void LoadImages()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["userImagePathFromDb"].Value != null)
                {
                    string imagePath = row.Cells["userImagePathFromDb"].Value.ToString();

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

        private void RefreshUserData()
        {
            try
            {
                connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM users", connection);

                DataTable dataTable = new DataTable();

                adapter.Fill(dataTable);

                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }

        private void ButtonAddUser_Click(object sender, EventArgs e)
        {
            FormAddUser formAddUser = new FormAddUser();

            this.Hide();

            formAddUser.ShowDialog();

            this.Show();

            RefreshUserData();
            LoadImages();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns["user_id"].Index)
            {
                clickedUserID = dataGridView1.Rows[e.RowIndex].Cells["user_id"].Value.ToString();

            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (clickedUserID == null)
            {
                MessageBox.Show($"Please select a user before delete!");
            }
            else
            {
                using (SqlConnection connection = MainClass.GetSqlConnection())
                {
                    try
                    {
                        connection.Open();

                        string query = "DELETE FROM users WHERE user_id = @user_id";
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@user_id", clickedUserID);

                            command.ExecuteNonQuery();
                            MessageBox.Show("User Deleted Successfully..!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            RefreshUserData();
                            LoadImages();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Failed to Delete the User..! {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (clickedUserID == null)
            {
                MessageBox.Show($"Please select a user before update!");
            } else
            {
                FormUpdateUser formUpdateUser = new FormUpdateUser(clickedUserID);

                formUpdateUser.FormClosed += FormUpdateUsert_FormClosed;

                formUpdateUser.ShowDialog();

            }
            
        }

        private void FormUpdateUsert_FormClosed(object sender, FormClosedEventArgs e)
        {
            RefreshUserData();
            LoadImages();
            if (sender is FormUpdateUser formUpdateUser)
            {
                formUpdateUser.FormClosed -= FormUpdateUsert_FormClosed;
            }
        }
    }
}
