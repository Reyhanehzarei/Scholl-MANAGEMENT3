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
    public partial class grade : Form
    {
        public grade()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            add_grade cs = new add_grade();
            cs.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            public void DeleteGrade(int gradeID)
            {
                string connectionString = "YourConnectionString";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM Grades WHERE GradeID = @gradeID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@gradeID", gradeID);
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            select_grade cs = new select_grade();
            cs.Show();
        }
    }
}
