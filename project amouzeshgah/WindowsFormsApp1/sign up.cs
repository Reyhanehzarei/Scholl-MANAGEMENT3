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
    public partial class sign_up : Form
    {
        public sign_up()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fullname = textBox1.Text;
            int idnum = int.Parse(textBox2.Text);
            string username = textBox3.Text;
            string password = textBox4.Text;
            string pcnof = textBox5.Text;
            sqlconnection sc = new sqlconnection(@"This PC\Documents\scollmanage");
);
            sc.open();
            sqlcommand cmd =new sqlcommand("INSERT INTO[dbo].[Table](username, password)
            cmd.parameters.ADDWITHVALU(@"user", username);
            cmd.parameters.ADDWITHVALU(@"pass", password);
            if (password !=pcnof)
            {
                MessageBox.Show($"your password dont match!");

            }
            else if(username =="" || password == "" || pcnof == "")
            {
                MessageBox.Show("something went wrong! please try again");
            }
            else
            {
                cmd.executenonquery();
                MessageBox.Show("account successfuly created!");
                main.show();
                this.Hide();
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();

            }
            sc.close();
        }
    }
}
