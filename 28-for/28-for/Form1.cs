using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _28_for
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int bas, bit, artım,sayaç=0;
            double ort, toplam = 0;
            bas = int.Parse(textBox1.Text);
            bit = int.Parse(textBox2.Text);
            artım = int.Parse(textBox3.Text);
            if (bas<=bit)
            {
                for (int i = bas; i <= bit; i = i + artım)
                {
                    listBox1.Items.Add(i);
                    sayaç++;
                    toplam += i;
                }
            }
            else
            {
                for (int i = bas; i >= bit; i=i-artım)
                {
                    listBox1.Items.Add(i);
                    sayaç++;
                    toplam += i;
                }
            }
            textBox4.Text = toplam.ToString();
            ort = toplam / sayaç;
            textBox5.Text = ort.ToString();

            
        }
    }
}
