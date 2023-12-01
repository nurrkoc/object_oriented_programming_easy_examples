using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _26_YarisAti
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Left = pictureBox1.Left + 10;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox2.Left += 10;
        }
        Random rnd = new Random();
        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Left = pictureBox1.Left + rnd.Next(10);
            pictureBox2.Left += rnd.Next(10);
            if (pictureBox1.Left >= 700 || pictureBox2.Left>=700)
            {
                timer1.Stop();
                if (pictureBox1.Left>pictureBox2.Left)
                {
                    MessageBox.Show("Kazanan AT");
                }
                else if(pictureBox1.Left == pictureBox2.Left)
                {
                    MessageBox.Show("Berabere");
                }
                else
                {
                    MessageBox.Show("Kazanan Mobilet");
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                timer1.Start();
            }
            else
            {
                timer1.Stop();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button3.Width = 10;
            button3.Height = 350;
            button3.Left = 800;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            pictureBox1.Left = 56;
            pictureBox2.Left = 56;
            checkBox1.Checked = false;
        }
    }
}
