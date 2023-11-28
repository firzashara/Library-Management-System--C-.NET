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
    public partial class ManageGenresForm : Form
    {
        public ManageGenresForm()
        {
            InitializeComponent();
        }
        string conn = "datasource=127.0.0.1;port=3306;username=root;password=;database=lms_database";

        private void ManageGenresForm_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Dashboard_Form dash = new Dashboard_Form();
            dash.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(textBox1.Text);
            string Name = textBox2.Text;
            string con = "datasource=127.0.0.1;port=3306;username=root;password=;database=lms_database";

            MySqlConnection conn = new MySqlConnection(con);
            string query = "INSERT INTO genres(id,name) VALUES ('" + ID + "','" + Name + "')";
            MySqlCommand querycmd = new MySqlCommand(query, conn);
            conn.Open();

            MySqlDataReader myreader = querycmd.ExecuteReader();
            conn.Close();

            MessageBox.Show("New genre added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(textBox1.Text);
            string Name = textBox2.Text;

           
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=lms_database";
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "UPDATE genres SET name='" + Name + "' where id='"+ID+"'";
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            MessageBox.Show("Genre updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void button3_Click(object sender, EventArgs e)
        {
            string con = "datasource=127.0.0.1;port=3306;username=root;password=;database=lms_database";
            MySqlConnection conn = new MySqlConnection(con);
            string query = "DELETE FROM genres WHERE id='" + textBox1.Text + "'";
            MySqlCommand querycmd = new MySqlCommand(query, conn);
            conn.Open();
            MySqlDataReader myReader = querycmd.ExecuteReader();
            conn.Close();
            MessageBox.Show("Genre deleted successfully!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void button5_Click(object sender, EventArgs e)
        {
           string con = "datasource=127.0.0.1;port=3306;username=root;password=;database=lms_database";
            MySqlConnection conCmd = new MySqlConnection(con);
            string query1 = "SELECT * FROM genres";
            MySqlCommand queryCmd = new MySqlCommand(query1,conCmd);
           
                conCmd.Open();
                MySqlDataAdapter md = new MySqlDataAdapter(queryCmd);
                DataSet ds = new DataSet();
                md.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0].DefaultView;
                

  


        }

        

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        
    }
}
