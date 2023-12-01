using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double boy, kilo,indx;
            kilo = Convert.ToDouble(textBox1.Text);
            boy = Convert.ToDouble(textBox2.Text);
            indx = kilo / (boy * boy);
            this.Text = indx.ToString();

            if (indx<18.5)
            {
                MessageBox.Show("İDEAL KİLONUN ALTINDA");
            }
            else if (indx>=18.5 && indx<25)
            {
                MessageBox.Show("İDEAL KİLODA");
            }
            else if (indx >= 25 && indx < 30)
            {
                MessageBox.Show("İDEAL KİLONUN üstünde");
            }
            else if (indx >= 30 && indx < 40)
            {
                MessageBox.Show("OBEZ");
            }
            else
            {
                MessageBox.Show("MORBİD OBEZ");
            }


        }
    }
}
