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
    public partial class apdate_course : Form
    {
        public apdate_course()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            public void UpdateCourse(int courseID, string courseName, string teacherName)
            {
                string connectionString = "schoolmanage";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "UPDATE Courses SET CourseName = @courseName, TeacherName = @teacherName WHERE CourseID = @courseID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@courseID", courseID);
                        command.Parameters.AddWithValue("@courseName", courseName);
                        command.Parameters.AddWithValue("@teacherName", teacherName);

                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
            }
        }
    }
}
