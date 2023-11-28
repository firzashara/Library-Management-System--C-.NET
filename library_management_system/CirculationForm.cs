using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace library_management_system
{
    public partial class CirculationForm : Form
    {
        public CirculationForm()
        {
            InitializeComponent();
        }
       


        private void button4_Click(object sender, EventArgs e)
        {
            Dashboard_Form dash = new Dashboard_Form();
            dash.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int bookid = Convert.ToInt32(textBox1.Text);
            int memid = Convert.ToInt32(textBox1.Text);
            string available = string.Empty;
            if (radioButton1.Checked)
            {
                available = "Yes";
            }
            else if (radioButton2.Checked)
            {
                available = "No";
            }
            string issue = dateTimePicker1.Value.ToString("YYYY-MM-DD");
            string retu = dateTimePicker2.Value.ToString("YYYY-MM-DD");
            string note = richTextBox1.Text;

            

            MessageBox.Show("The book is issued", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int bookid = Convert.ToInt32(textBox1.Text);
            int memid = Convert.ToInt32(textBox2.Text);
            string available = string.Empty;
            if (radioButton1.Checked)
            {
                available = "Yes";
            }
            else if (radioButton2.Checked)
            {
                available = "No";
            }
            string issue = dateTimePicker1.Value.ToString("YYYY-MM-DD");
            string retu = dateTimePicker2.Value.ToString("YYYY-MM-DD");
            string note = richTextBox1.Text;



            MessageBox.Show("The book is returned", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            radioButton1.Refresh();
            radioButton2.Refresh();
            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker2.Value = DateTime.Today;


        }
    }
}
