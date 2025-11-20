using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace _07_Laboratory_Exercise_1_Soriano
{
    public partial class FrmUpdateMember : Form
    {
        private ClubRegistrationQuery clubRegistrationQuery;
        string connectionString;
        public FrmUpdateMember()
        {
            InitializeComponent();
            clubRegistrationQuery = new ClubRegistrationQuery();
            connectionString = "Data Source=localhost;Initial " +
                "Catalog=ClubDB;Trusted_Connection=True;TrustServerCertificate=True;";
        }

        private void FrmUpdateMember_Load(object sender, EventArgs e)
        {
            LoadStudentIDs();
        }

        private void LoadStudentIDs()
        {
            List<string> ids = new List<string>();

            string query = "SELECT StudentID FROM ClubMembers";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ids.Add(reader.GetInt64(0).ToString());
                    }
                }
            }
            cbStudentID.Items.Clear();
            cbStudentID.Items.AddRange(ids.ToArray());
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedID = cbStudentID.Text;

            string query = "SELECT FirstName, MiddleName, LastName, Age, Gender, Program FROM ClubMembers WHERE StudentID = @id";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", selectedID);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtFirstName.Text = reader["FirstName"].ToString();
                            txtMiddleName.Text = reader["MiddleName"].ToString();
                            txtLastName.Text = reader["LastName"].ToString();
                            txtAge.Text = reader["Age"].ToString();
                            cbGender.Text = reader["Gender"].ToString();
                            cbProgram.Text = reader["Program"].ToString();
                        }
                    }
                }
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            clubRegistrationQuery.UpdateStudent(cbStudentID.Text, txtFirstName.Text, txtMiddleName.Text, txtLastName.Text, int.Parse(txtAge.Text), cbGender.Text, cbProgram.Text);
            MessageBox.Show("Successfully updated!");
            this.Close();
        }
    }
}
