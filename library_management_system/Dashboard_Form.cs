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
    public partial class Dashboard_Form : Form
    {
        
        public Dashboard_Form()
        {
            InitializeComponent();
        }

        private void Dashboard_Form_Load(object sender, EventArgs e)
        {
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.BorderSize = 0;
            button2.BackColor = Color.Transparent;
            button2.FlatAppearance.BorderSize = 0;
            button3.BackColor = Color.Transparent;
            button3.FlatAppearance.BorderSize = 0;
            button4.BackColor = Color.Transparent;
            button4.FlatAppearance.BorderSize = 0;
            
            button6.BackColor = Color.Transparent;
            button6.FlatAppearance.BorderSize = 0;
            button7.BackColor = Color.Transparent;
            button7.FlatAppearance.BorderSize = 0;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            MessageBox.Show("You have been logged out successfully.");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ManageGenresForm genres = new ManageGenresForm();
            genres.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AuthorsForm auth = new AuthorsForm();
            auth.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BooksForm books = new BooksForm();
            books.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            membersForm members = new membersForm();
            members.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CirculationForm cir = new CirculationForm();
            cir.Show();
            this.Hide();
        }

        
    }
}
