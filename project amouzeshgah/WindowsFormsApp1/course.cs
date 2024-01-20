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
    public partial class course : Form
    {
        public course()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            add_course cs = new add_course();
            cs.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            apdate_course cs = new apdate_course();
            cs.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            public void DeleteCourse(int courseID)
            {
                string connectionString = "YourConnectionString";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM Courses WHERE CourseID = @courseID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@courseID", courseID);
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            select_course cs = new select_course();
            cs.Show();
        }
    }
}
