using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atomiki_ergsia1
{
    public partial class Form2 : Form
    {
        string username;
        Image image;
        Rectangle rect;
        public static int score;
        public object MoveImage { get; private set; }
        string filepath = "usersandscores.txt";

        public Form2()
        {
            InitializeComponent();

            rect = new Rectangle(20, 20, 70, 70);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            timer1.Interval = Form1.difficulty;
            label4.Text = Form1.name;
            label5.Text = Form1.level;
            

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random ra = new Random();
            pictureBox1.Location = new Point(ra.Next(this.groupBox1.Width - pictureBox1.Width)/2, ra.Next(this.groupBox1.Height - pictureBox1.Height)/2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 fl = new Form1();
            fl.Show();
            this.Hide();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            score = score + 1;
            label6.Text = score.ToString();
            using (StreamWriter sw = new StreamWriter(filepath))
            {
                sw.WriteLine(Form1.name + "        " + score);
            }
        }
        int j = 10;
        private void timer2_Tick(object sender, EventArgs e)
        {
            j--;
            label8.Text = j.ToString() + "   Seconds";
            if (j == 0)
            {
                MessageBox.Show("Game over. Go see your score");
                Form1 f1 = new Form1();
                f1.Show();

                this.Hide();
                string line = "";
                using (StreamReader sr = new StreamReader("usersandscores.txt"))
                {
                    while ((line = sr.ReadLine()) != null)
                    {
                        MessageBox.Show(line);
                    }
                }

            }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }
    }
}