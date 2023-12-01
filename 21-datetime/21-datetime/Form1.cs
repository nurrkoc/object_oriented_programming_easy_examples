﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21_datetime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.Date.ToString();
            label2.Text = DateTime.Now.Day.ToString();
            label3.Text = DateTime.Now.Year.ToString();
            label4.Text = DateTime.Now.DayOfYear.ToString();
            label5.Text = DateTime.Now.DayOfWeek.ToString();            
            label6.Text = (Convert.ToInt32(DateTime.Now.DayOfWeek)).ToString();
            label7.Text = DateTime.Now.Month.ToString();


        }
    }
}
