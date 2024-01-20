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
    public partial class apdate_teacher : Form
    {
        public apdate_teacher()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            public void UpdateTeacher(int teacherID, string firstName, string lastName, string subject)
            {
                string connectionString = "schoolmanage";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "UPDATE Teachers SET FirstName = @firstName, LastName = @lastName, Subject = @subject WHERE TeacherID = @teacherID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@teacherID", teacherID);
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
