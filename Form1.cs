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
    public partial class Form1 : Form
    {
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=AttendanceDB;Integrated Security=True;";

        public Form1()
        {
            InitializeComponent();
        }

        private void statusbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadStudents();
        }
        private void LoadStudents()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Students", conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvStudents.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading students: " + ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (fullnamebox.Text.Trim() == "" || sectionbox.Text.Trim() == "" || statusbox.Text == "")
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Students (FullName, Section, Status) VALUES (@name, @section, @status)", conn);
                cmd.Parameters.AddWithValue("@name", fullnamebox.Text.Trim());
                cmd.Parameters.AddWithValue("@section", sectionbox.Text.Trim());
                cmd.Parameters.AddWithValue("@status", statusbox.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Student added!");
                LoadStudents();
                ClearFields();
            }
        }
            private void dgvStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvStudents.Rows[e.RowIndex];
                fullnamebox.Text = row.Cells["FullName"].Value.ToString();
                sectionbox.Text = row.Cells["Section"].Value.ToString();
                statusbox.Text = row.Cells["Status"].Value.ToString();
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvStudents.CurrentRow == null) return;

            int id = Convert.ToInt32(dgvStudents.CurrentRow.Cells["StudentID"].Value);

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Students SET FullName=@name, Section=@section, Status=@status WHERE StudentID=@id", conn);
                cmd.Parameters.AddWithValue("@name", fullnamebox.Text.Trim());
                cmd.Parameters.AddWithValue("@section", sectionbox.Text.Trim());
                cmd.Parameters.AddWithValue("@status", statusbox.Text);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Student updated!");
                LoadStudents();
                ClearFields();
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvStudents.CurrentRow == null) return;

            int id = Convert.ToInt32(dgvStudents.CurrentRow.Cells["StudentID"].Value);

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Students WHERE StudentID=@id", conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Student deleted!");
                LoadStudents();
                ClearFields();
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            fullnamebox.Text = "";
            sectionbox.Text = "";
            statusbox.SelectedIndex = -1;
        }

        private void dgvStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvStudents_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}

