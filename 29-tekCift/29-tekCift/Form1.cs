using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _29_tekCift
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                listBox1.Items.Add(rnd.Next(10,100));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(listBox1.Items.Count.ToString());
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                if ( Convert.ToInt32(listBox1.Items[i])%2==1)
                {
                    listBox2.Items.Add(Convert.ToInt32(listBox1.Items[i]));
                }
                else
                {
                    listBox3.Items.Add(Convert.ToInt32(listBox1.Items[i]));
                }
            }
        }
    }
}
