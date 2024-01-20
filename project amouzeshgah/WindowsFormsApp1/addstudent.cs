using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class addstudent : Form
    {
        public addstudent()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            public void AddStudent(string firstName, string lastName, DateTime dateOfBirth, int gradeLevel)
            {
                string connectionString = "schoolmanage"; 
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO Students (FirstName, LastName, DateOfBirth, GradeLevel) VALUES (@firstName, @lastName, @dateOfBirth, @gradeLevel)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@firstName", firstName);
                        command.Parameters.AddWithValue("@lastName", lastName);
                        command.Parameters.AddWithValue("@dateOfBirth", dateOfBirth);
                        command.Parameters.AddWithValue("@gradeLevel", gradeLevel);

                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
            }
        }
    }
}
