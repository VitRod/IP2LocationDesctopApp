﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IP2LocationDesctopApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strIPAddress = textBox1.Text;
            

            Program prog = new Program();
            string ipData = prog.QueryIP2Location(strIPAddress);
            
            MessageBox.Show(ipData);    


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
