﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 fm1 = new Form1();
            fm1.Show();
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == 'администратор'&& textBox1.Text=='1234')
            {
                Form20 fm20 = new Form20();
                fm20.Show();
            }
            
        }
    }
}
