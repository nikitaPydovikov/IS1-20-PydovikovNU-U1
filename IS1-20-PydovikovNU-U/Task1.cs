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
    public partial class Task1 : Form
    {
        public Task1()
        {
            InitializeComponent();
        }
        Hdd<int> hdd;
        Videocard<string> videocard;
        abstract class Accessories<T>// абстрактный класс "Комплектующие" с обобщённым типом данных.
        {
            public int Price;       // цена
            public string Old;      // год выпуска
            public T Articyl { get; set; }  // артикул
            public Accessories(int price, string old, T articyl)
            {
                Price = price;       // цена
                Old = old;           // год выпуска
                Articyl = articyl;   // артикул
            }
            public void Display()
            {

            }
        }

        class Hdd<T> : Accessories<T> // класс "Жёсткие диски" + наследование класса "Комплектующие"
        {
            int Turnovers { set; get; }     // кол. оборотов
            string Interface { set; get; }  // интерфейс
            int Volume { set; get; }        // объём
            public Hdd(int price, string old, T articyl, int turnovers, string face, int volume)
                : base(price, old, articyl)
            {
                Turnovers = turnovers;      // кол. оборотов
                Interface = face;           // интерфейс
                Volume = volume;            // объём
            }

            public new string Display() // вывод информации
            {
                return ($"Цена: {Price}, Год выпуска: {Old}, Артикул: {Articyl}, Количество оборотов: {Turnovers}, Интерфейс: {Interface}, Объем: {Volume} гигабайт.");
            }
        }

        class Videocard<T> : Accessories<T> // класс "Видеокарта" + наследование класса "Комплектующие"
        {
            int GPU_frequency { set; get; }     // частота gpu
            string Manufacturer { set; get; }   // производитель
            int Memory { set; get; }            // объём памяти
            public Videocard(int price, string old, T articyl, int gpu, string manufacturer, int memory)
                : base(price, old, articyl)
            {
                GPU_frequency = gpu;            // частота gpu
                Manufacturer = manufacturer;    // производитель
                Memory = memory;                // объём памяти
            }
            public new string Display() // вывод информации
            {
                return ($"Цена: {Price}, Год выпуска: {Old}, Артикул: {Articyl}, Частота CPU: {GPU_frequency}, Производительность: {Manufacturer}, Объем памяти: {Memory} гигабайт.");
            }
        }

        private void Task1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) // очистить листбокс
        {
            listBox1.Items.Clear();
        }

        private void button2_Click(object sender, EventArgs e) // вывести hdd
        {
            try
            {
                hdd = new Hdd<int>(Convert.ToInt32(textBox1.Text), textBox2.Text, Convert.ToInt32(textBox3.Text),
                    Convert.ToInt32(textBox4.Text), textBox5.Text, Convert.ToInt32(textBox6.Text));
                listBox1.Items.Add(hdd.Display());
            }
            catch
            {
                MessageBox.Show("Нужно ввести данные");
            }
        }

        private void button3_Click(object sender, EventArgs e) // вывести cpu
        {
            try
            {
                videocard = new Videocard<string>(Convert.ToInt32(textBox1.Text), textBox2.Text, textBox7.Text,
                    Convert.ToInt32(textBox8.Text), textBox9.Text, Convert.ToInt32(textBox10.Text));
                listBox1.Items.Add(videocard.Display());
            }
            catch
            {
                MessageBox.Show("Нужно ввести данные");
            }
        }
    }
}
