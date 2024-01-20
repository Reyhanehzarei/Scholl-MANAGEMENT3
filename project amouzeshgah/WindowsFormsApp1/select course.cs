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
    public partial class select_course : Form
    {
        public select_course()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            public List<Course> GetCourses()
            {
                List<Course> courses = new List<Course>();
                string connectionString = "schoolmanage";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT CourseID, CourseName, TeacherName FROM Courses";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Course course = new Course
                                {
                                    CourseID = Convert.ToInt32(reader["CourseID"]),
                                    CourseName = reader["CourseName"].ToString(),
                                    TeacherName = reader["TeacherName"].ToString()
                                };
                                courses.Add(course);
                            }
                        }
                    }
                }
                return courses;
            }
        }
    }
}
