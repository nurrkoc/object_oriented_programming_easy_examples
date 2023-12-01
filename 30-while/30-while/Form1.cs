using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _30_while
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <11; i++)
            {
                listBox1.Items.Add(i);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i = 1;
            while (i<11)
            {              
                listBox2.Items.Add(i);
                i++;
            }
        }
        Random rnd = new Random();
        private void button3_Click(object sender, EventArgs e)
        {
            listBox3.Items.Clear();
            
            int i = 1,toplam=0;

            while (i <= 5)
            {
                int rndSayi = rnd.Next(1, 10);
                listBox3.Items.Add(rndSayi);
                toplam += rndSayi;
                i++;
            }
            //while (i <= 5)
            //{
            //    int rndSayi = rnd.Next(1, 10);
            //    listBox3.Items.Add(rndSayi);               
            //    i++;
            //}
            //int j = 0;
            //while (j<listBox3.Items.Count)
            //{
            //    toplam +=Convert.ToInt32(listBox3.Items[j]);
            //    j++;
            //}

            MessageBox.Show(toplam.ToString());
        }
    }
}
