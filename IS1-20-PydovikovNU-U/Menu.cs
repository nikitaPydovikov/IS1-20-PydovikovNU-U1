﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IS1_20_PydovikovNU_U
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) // открытие 1 задания
        {
            Task1 T1 = new Task1();
            T1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e) // открытие 2 задания
        {
            
        }
    }
}
