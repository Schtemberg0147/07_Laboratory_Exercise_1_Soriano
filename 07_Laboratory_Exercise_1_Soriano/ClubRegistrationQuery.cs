using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace _07_Laboratory_Exercise_1_Soriano
{
    public class ClubRegistrationQuery
    {
        private SqlConnection sqlConnect;
        private SqlCommand sqlCommand;
        private SqlDataAdapter sqlAdapter;
        private SqlDataReader sqlReader;
        public DataTable dataTable;
        public BindingSource bindingSource;
        private string connectionString;
        public string _FirstName, _LastName, _Gender, _MiddleName, _Program;
        public int _Age;
        public string[] studentIDs = new string[99];
        public ClubRegistrationQuery()
        {
            connectionString = "Data Source=localhost;Initial Catalog=ClubDB;Trusted_Connection=True;TrustServerCertificate=True;";
            sqlConnect = new SqlConnection(connectionString);
            dataTable = new DataTable();
            bindingSource = new BindingSource();
        }

        public bool DisplayList()
        {
            string ViewClubMembers = "SELECT StudentId, FirstName, MiddleName, LastName, Age, Gender, Program FROM ClubMembers;";
            sqlAdapter = new SqlDataAdapter(ViewClubMembers, connectionString);
            dataTable.Clear();
            sqlAdapter.Fill(dataTable);
            bindingSource.DataSource = dataTable;
            return true;
        }

        public bool RegisterStudent(int ID, long StudentID, string FirstName, string MiddleName, string LastName, int Age, string Gender, string Program)
        {
            sqlCommand = new SqlCommand("INSERT INTO ClubMembers VALUES(@ID, @StudentID, @FirstName, @MiddleName, @LastName, @Age, @Gender, @Program)", sqlConnect);
            sqlCommand.Parameters.Add("@ID", SqlDbType.Int).Value = ID; 
            sqlCommand.Parameters.Add("@RegistrationID", SqlDbType.BigInt).Value = StudentID; 
            sqlCommand.Parameters.Add("@StudentID", SqlDbType.VarChar).Value = StudentID; 
            sqlCommand.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = FirstName; 
            sqlCommand.Parameters.Add("@MiddleName", SqlDbType.VarChar).Value = MiddleName; 
            sqlCommand.Parameters.Add("@LastName", SqlDbType.VarChar).Value = LastName; 
            sqlCommand.Parameters.Add("@Age", SqlDbType.Int).Value = Age; 
            sqlCommand.Parameters.Add("@Gender", SqlDbType.VarChar).Value = Gender; 
            sqlCommand.Parameters.Add("@Program", SqlDbType.VarChar).Value = Program;

            sqlConnect.Open(); sqlCommand.ExecuteNonQuery(); sqlConnect.Close();
            return true;
        }

        public bool UpdateStudent(string StudentID, string FirstName, string MiddleName, string LastName, int Age, string Gender, string Program)
        {   
            string query = "UPDATE ClubMembers SET LastName = @lastName, FirstName = @firstName, MiddleName = @middleName, Age = @age, Gender = @gender, Program = @program WHERE StudentId = @studentID";
            sqlCommand = new SqlCommand(query, sqlConnect);
            sqlCommand.Parameters.Add("@firstName", SqlDbType.VarChar).Value = FirstName;
            sqlCommand.Parameters.Add("@middleName", SqlDbType.VarChar).Value = MiddleName;
            sqlCommand.Parameters.Add("@lastName", SqlDbType.VarChar).Value = LastName;
            sqlCommand.Parameters.Add("@age", SqlDbType.Int).Value = Age;
            sqlCommand.Parameters.Add("@gender", SqlDbType.VarChar).Value = Gender;
            sqlCommand.Parameters.Add("@program", SqlDbType.VarChar).Value = Program;
            sqlCommand.Parameters.Add("@studentID", SqlDbType.VarChar).Value = StudentID;

            sqlConnect.Open(); sqlCommand.ExecuteNonQuery(); sqlConnect.Close();
            return true;
        }
    }
}
