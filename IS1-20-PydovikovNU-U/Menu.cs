using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Task2;
using Task3;
using Task4;


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

        private void button2_Click(object sender, EventArgs e) // открытие 2 задания
        {
            //Task2 T2 = new Task2();
            //T2.ShowDialog();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Task1 T1 = new Task1();
            T1.ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Task2 T2 = new Task2();
            T2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Task3 T3 = new Task3();
            T3.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Task4z T4 = new Task4z();
            T4.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
