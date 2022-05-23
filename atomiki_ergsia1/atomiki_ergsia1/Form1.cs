using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atomiki_ergsia1
{
    public partial class Form1 : Form
    { 

        public static int difficulty ;
        public static string name;
        public static string level;
        public Form1()
        {
            InitializeComponent();
            string line = "";
            using (StreamReader sr = new StreamReader("usersandscores.txt"))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    label13.Text = line;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (label12.Text == "-")
            {
                MessageBox.Show("Login First");
            }
            else
            {
                if (radioButton1.Checked == true)
                {
                    difficulty = 1000;
                    level = "LEVEL 1";
                }
                if (radioButton2.Checked == true)
                {
                    difficulty = 750;
                    level = "LEVEL 2";
                }
                if (radioButton3.Checked==true)
                {
                    difficulty = 500;
                    level = "LEVEL 3";
                }

                Form2 f2 = new Form2();
                f2.Show();
                this.Hide();
            }
        }
        int i = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            i++;
            label2.Text = i.ToString() + "   Seconds";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label12.Text = textBox1.Text;
            name = textBox1.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}