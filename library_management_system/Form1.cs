using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace library_management_system
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();



            textBox1.Text = "Username";
            textBox2.Text = "Password";
          
        }

        string conn = "datasource=127.0.0.1;port=3306;username=root;password=;database=lms_database";

       

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;
           

            if (username == "") {
                MessageBox.Show("Enter the username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (password == "")
            {
                MessageBox.Show("Enter the password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (password == "Password")
            {
                MessageBox.Show("Enter the password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (username == "Username")
            {
                MessageBox.Show("Enter the username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
            else {
                MySqlConnection conn = new MySqlConnection();
                string query = "SELECT * FROM login where username='"+username+"' and password='"+password+"'" ;
                MySqlCommand querycmd = new MySqlCommand(query,conn);


                Dashboard_Form login = new Dashboard_Form();
                login.Show();
                MessageBox.Show("Login Successfull!");
                
            
            
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

           

        }
    }
}
