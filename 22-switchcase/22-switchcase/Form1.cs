using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _22_switchcase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int gun = Convert.ToInt32(DateTime.Now.DayOfWeek);

            //switch (gun)
            //{
            //    case 0:
            //        label1.Text = "HAFTA sonu";
            //        break;
            //    case 1:
            //        label1.Text = "HAFTA İÇİ";
            //        break;
            //    case 2:
            //        label1.Text = "HAFTA İÇİ";
            //        break;
            //    case 3:
            //        label1.Text = "HAFTA İÇİ";
            //        break;
            //    case 4:
            //        label1.Text = "HAFTA İÇİ";
            //        break;
            //    case 5:
            //        label1.Text = "HAFTA İÇİ";
            //        break;
            //    case 6:
            //        label1.Text = "HAFTA sonu";
            //        break;

            //}


            //switch (gun)
            //{

            //    case 1:                    
            //    case 2:                    
            //    case 3:                    
            //    case 4:                    
            //    case 5:
            //        label1.Text = "HAFTA İÇİ";
            //        break;
            //    case 0:
            //    case 6:
            //        label1.Text = "HAFTA sonu";
            //        break;
            //}

            //if (gun==0)
            //{
            //    label1.Text = "HAFTA sonu";
            //}
            //else if(gun<=5)
            //{
            //    label1.Text = "HAFTA İÇİ";
            //}
            //else
            //{
            //    label1.Text = "HAFTA sonu";
            //}
            if (gun == 0 ||gun ==6)
            {
                label1.Text = "HAFTA sonu";
            }
            else
            {
                label1.Text = "HAFTA İÇİ";
            }
            

        }
    }
}
