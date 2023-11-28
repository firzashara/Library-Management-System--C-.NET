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
    public partial class BooksForm : Form
    {
        public BooksForm()
        {
            InitializeComponent();
        }
        string conn = "datasource=127.0.0.1;port=3306;username=root;password=;database=lms_database";


        private void button1_Click(object sender, EventArgs e)
        {
            Dashboard_Form dash = new Dashboard_Form();
            dash.Show();
            this.Hide();
        }

        private void BooksForm_Load(object sender, EventArgs e)
        {
            string con = "datasource=127.0.0.1;port=3306;username=root;password=;database=lms_database";
            MySqlConnection conn = new MySqlConnection(con);
            string query = "SELECT first_name FROM authors";
            MySqlCommand queryCmd = new MySqlCommand(query, conn);

            string query1 = "SELECT name FROM genres";
            MySqlCommand queryCmd1 = new MySqlCommand(query1, conn);

            conn.Open();
            MySqlDataReader myReader = queryCmd.ExecuteReader();
            

            while (myReader.Read()) {
                comboBox1.Items.Add(myReader["first_name"].ToString());
            }
            conn.Close();
            conn.Open();

             MySqlDataReader myReader1 = queryCmd1.ExecuteReader();

            while (myReader1.Read())
            {
                comboBox2.Items.Add(myReader1["name"].ToString());
            }
            conn.Close();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Choose Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (opf.ShowDialog() == DialogResult.OK) {
                pictureBox1.Image = Image.FromFile(opf.FileName);
            
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(textBox1.Text);
            string isbn = textBox2.Text;
            string title = textBox3.Text;
            string author = comboBox1.Text;
            string genre = comboBox2.Text;
            int quantity = Convert.ToInt32(numericUpDown1.Text);
            string price = textBox7.Text;
            string publisher = textBox8.Text;
            string date = dateTimePicker1.Value.ToString("YYYY-MM-DD");
           
            
           string conn = "datasource=127.0.0.1;port=3306;username=root;password=;database=lms_database";



            MySqlConnection con = new MySqlConnection(conn);
            string query = "INSERT INTO books(id,ISBN,title,author_id,genre_id,quantity,price,date_received,description) VALUES ('" + ID + "','" + isbn + "','" + title + "','" + author + "','" + genre + "','" + quantity + "','" + price + "','" + publisher + "','" + date + "')";
            MySqlCommand querycmd = new MySqlCommand(query, con);
            con.Open();

            MySqlDataReader myreader = querycmd.ExecuteReader();
            con.Close();

            MessageBox.Show("New book added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(textBox1.Text);
            string isbn = textBox2.Text;
            string title = textBox3.Text;
            string author = comboBox1.Text;
            string genre = comboBox2.Text;
            int quantity = Convert.ToInt32(numericUpDown1.Text);
            string price = textBox7.Text;
            string publisher = textBox8.Text;
            string date = dateTimePicker1.Value.ToString("YYYY-MM-DD");

            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=lms_database";
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "UPDATE books SET title='" + title + "' where id='" + ID + "'";
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            MessageBox.Show("Book updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string con = "datasource=127.0.0.1;port=3306;username=root;password=;database=lms_database";
            MySqlConnection conn = new MySqlConnection(con);
            string query = "DELETE FROM books WHERE id='" + textBox1.Text + "'";
            MySqlCommand querycmd = new MySqlCommand(query, conn);
            conn.Open();
            MySqlDataReader myReader = querycmd.ExecuteReader();
            conn.Close();
            MessageBox.Show("Book deleted successfully!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            comboBox1.Refresh();
            comboBox2.Refresh();
            numericUpDown1.Refresh();
            textBox7.Clear();
            textBox8.Clear();
            dateTimePicker1.Refresh();
            richTextBox1.Clear();
            pictureBox1.Refresh();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

      
    }
}
