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
    public partial class teacher : Form
    {
        public teacher()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            add_teacher cs = new add_teacher();
            cs.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            public void DeleteTeacher(int teacherID)
            {
                string connectionString = "YourConnectionString";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM Teachers WHERE TeacherID = @teacherID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@teacherID", teacherID);
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            apdate_teacher cs = new apdate_teacher();
            cs.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            select_teacher cs = new select_teacher();
            cs.Show();
        }
    }
}
