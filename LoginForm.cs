using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace StudentAttendanceChecker
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {


            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            passwordbox.PasswordChar = '●'; // Optional, for MaskedTextBox
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbUsername_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void passwordbox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            string username = usernamebox.Text.Trim();
            string password = passwordbox.Text.Trim();

            if (username == "" || password == "")
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            // Connection string to your LocalDB
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=AttendanceDB;Integrated Security=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM Users WHERE Username=@username AND Password=@password";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    int result = (int)cmd.ExecuteScalar();

                    if (result > 0)
                    {
                        Form1 mainForm = new Form1();
                        mainForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid credentials. Please try again.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}
