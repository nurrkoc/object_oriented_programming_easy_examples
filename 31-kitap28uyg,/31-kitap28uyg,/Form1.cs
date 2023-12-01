using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _31_kitap28uyg_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayac = 0,toplam=0;
            while (toplam<1000)
            {
                listBox1.Items.Add(sayac);
                toplam += sayac;
                sayac++;                
            }
            MessageBox.Show("Sayac : "+sayac.ToString());
            MessageBox.Show("Tplam : " + toplam.ToString());
        }
    }
}
