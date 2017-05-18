using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        string user = "admin";
        string password = "password";
        public Form1()
        {
            InitializeComponent();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == user && textBox2.Text == password)
            {
                panel1.Hide();
                button1.Text = "Sign Out";
                textBox1.Clear();
                textBox2.Clear();
            }
            else
            {
                MessageBox.Show("Username or Password invalid");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Sign In")
            {
                panel1.Show();
            }
            else
            {
                panel2.Show();
            }
                   
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button1.Text = "Sign In";
            panel2.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel2.Hide();
        }
    }
}
