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
    public partial class add_teacher : Form
    {
        public add_teacher()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            public void AddTeacher(string firstName, string lastName, string subject)
            {
                string connectionString = "schoolmanage";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO Teachers (FirstName, LastName, Subject) VALUES (@firstName, @lastName, @subject)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@firstName", firstName);
                        command.Parameters.AddWithValue("@lastName", lastName);
                        command.Parameters.AddWithValue("@subject", subject);

                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
            }
        }
    }
}
