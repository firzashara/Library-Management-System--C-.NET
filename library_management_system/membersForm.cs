﻿using System;
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
    public partial class membersForm : Form
    {
        public membersForm()
        {
            InitializeComponent();
        }
        string conn = "datasource=127.0.0.1;port=3306;username=root;password=;database=lms_database";

        private void button4_Click(object sender, EventArgs e)
        {
            Dashboard_Form dash = new Dashboard_Form();
            dash.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(textBox1.Text);
            string fname = textBox2.Text;
            string lname = textBox3.Text;
            string phone = textBox4.Text;
            string email = textBox5.Text;
            string gender = string.Empty;
            if (radioButton1.Checked)
            {
                gender = "Male";
            }
            else if (radioButton2.Checked)
            {
                gender = "Female";
            }




            string con = "datasource=127.0.0.1;port=3306;username=root;password=;database=lms_database";

            MySqlConnection conn = new MySqlConnection(con);
            string query = "INSERT INTO members(id,first_name,last_name,gender,phone,email) VALUES ('" + ID + "','" + fname + "','" + lname + "','" + gender + "','" + phone + "','" + email + "')";
            MySqlCommand querycmd = new MySqlCommand(query, conn);
            conn.Open();

            MySqlDataReader myreader = querycmd.ExecuteReader();
            conn.Close();

            MessageBox.Show("New member added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(textBox1.Text);
            string fname = textBox2.Text;
            string lname = textBox3.Text;
            string phone = textBox4.Text;
            string email = textBox5.Text;
            string gender = string.Empty;
            if (radioButton1.Checked)
            {
                gender = "Male";
            }
            else if (radioButton2.Checked)
            {
                gender = "Female";
            }

            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=lms_database";
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "UPDATE members SET first_name='" + fname + "'AND last_name='" + lname + "' where id='" + ID + "'";
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            MessageBox.Show("Member updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string con = "datasource=127.0.0.1;port=3306;username=root;password=;database=lms_database";
            MySqlConnection conn = new MySqlConnection(con);
            string query = "DELETE FROM members WHERE id='" + textBox1.Text + "'";
            MySqlCommand querycmd = new MySqlCommand(query, conn);
            conn.Open();
            MySqlDataReader myReader = querycmd.ExecuteReader();
            conn.Close();
            MessageBox.Show("Member deleted successfully!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string con = "datasource=127.0.0.1;port=3306;username=root;password=;database=lms_database";
            MySqlConnection conCmd = new MySqlConnection(con);
            string query1 = "SELECT * FROM members";
            MySqlCommand queryCmd = new MySqlCommand(query1, conCmd);

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
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            radioButton1.Refresh();
            radioButton2.Refresh();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Choose Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(opf.FileName);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
