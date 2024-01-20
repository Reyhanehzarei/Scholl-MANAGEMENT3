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
    public partial class select_grade : Form
    {
        public select_grade()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            public List<Grade> GetGradesByStudent(int studentID)
            {
                List<Grade> grades = new List<Grade>();
                string connectionString = "schoolmanage";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT GradeID, Course, Score FROM Grades WHERE StudentID = @studentID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@studentID", studentID);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Grade grade = new Grade
                                {
                                    GradeID = Convert.ToInt32(reader["GradeID"]),
                                    Course = reader["Course"].ToString(),
                                    Score = Convert.ToInt32(reader["Score"])
                                };
                                grades.Add(grade);
                            }
                        }
                    }
                }
                return grades;
            }
        }
    }
}
