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
    public partial class add_grade : Form
    {
        public add_grade()
        {
            InitializeComponent();
        }

        private void course_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            public void AddGrade(int studentID, string course, int score)
            {
                string connectionString = "schoolmanage";  
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO Grades (StudentID, Course, Score) VALUES (@studentID, @course, @score)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@studentID", studentID);
                        command.Parameters.AddWithValue("@course", course);
                        command.Parameters.AddWithValue("@score", score);

                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
            }
        }
    }
}
