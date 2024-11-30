using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SmartBillPosSystem
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = MainClass.GetSqlConnection())
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("SELECT * FROM Users WHERE role = @username AND password = @password", con);
                cmd.Parameters.AddWithValue("@username", txtUser.Text);
                cmd.Parameters.AddWithValue("@password", txtPass.Text);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    string userRole = dt.Rows[0]["role"].ToString();

                    if (userRole == "Admin")
                    {
                        MessageBox.Show("Admin login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        AdminDashboard adminDashboard = new AdminDashboard();
                        adminDashboard.Show();

                        this.Hide();
                    }
                    else if (userRole == "Cashier")
                    {
                        MessageBox.Show("Cashier login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        CashierDashboard cashierDashboard = new CashierDashboard();
                        cashierDashboard.Show();

                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid role", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Username or password is invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
