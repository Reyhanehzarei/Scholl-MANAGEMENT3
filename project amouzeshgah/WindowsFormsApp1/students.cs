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
    public partial class students : Form
    {
        public students()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addstudent cs = new addstudent();
            cs.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            public void DeleteStudent(int studentID)
            {
                string connectionString = "YourConnectionString"; // جایگزین کردن YourConnectionString با اطلاعات اتصال واقعی شما
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM Students WHERE StudentID = @studentID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@studentID", studentID);

                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
