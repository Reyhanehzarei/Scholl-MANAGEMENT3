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
    public partial class select_teacher : Form
    {
        public select_teacher()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            public List<Teacher> GetTeachersBySubject(string subject)
            {
                List<Teacher> teachers = new List<Teacher>();
                string connectionString = "schoolmanage";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT FirstName, LastName, Subject FROM Teachers WHERE Subject = @subject";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@subject", subject);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Teacher teacher = new Teacher
                                {
                                    FirstName = reader["FirstName"].ToString(),
                                    LastName = reader["LastName"].ToString(),
                                    Subject = reader["Subject"].ToString()
                                };
                                teachers.Add(teacher);
                            }
                        }
                    }
                }
                return teachers;
            }
        }
    }
}
