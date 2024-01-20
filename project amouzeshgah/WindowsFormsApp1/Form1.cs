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
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        mainform main = new mainform();
        
        private void button1_Click(object sender, EventArgs e)
        {
            string user = textBox1.Text;
            string pass = textBox2.Text;
            string password = "";
            sqlConnection sc = new SqlConnection(@"
             ");
            sc.Open();
            SqlCommand cmd = new SqlCommand("SELECT password FROM Admin WHERE UserName=@user", sc);
            cmd.Parameters.AddWithValue("user", user);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                password = reader["password"].ToString();
            }
            if (pass != password)
            {
                MessageBox.Show($"wrong password! try another password");
            }
            else if(user == "")
            {
                MessageBox.Show("what is your username?");
            }
            else if (pass=="")
            {
                MessageBox.Show("what about your password?");
            }
            else
            {
                MessageBox.Show($"welcome back, {user}!");
                main.show();


                textBox1.Clear();
                textBox2.Clear();
            }
            sc.close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sign up cs =new sgin up();
            cs.show();
            


           
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
