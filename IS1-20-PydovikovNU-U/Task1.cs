using System;
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
        abstract class Accessories<T>// Абстрактный класс "Комплектующие" с обобщённым типом данных.
        {
            public int Price;       // Цена
            public string Old;      // Год выпуска
            public T Articyl {get; set;}  // Артикул
            public Accessories(int price, string old, T articyl)
            {
                Price = price;       // Цена
                Old = old;           // Год выпуска
                Articyl = articyl;   // Артикул
            }
            public void Display()
            {

            }
        }

        class Hdd<T> : Accessories<T> // Класс "Жёсткие диски" + наследование класса "Комплектующие"
        {
            int Turnovers {set; get;}     // Количество оборотов
            string Interface {set; get;}  // Интерфейс
            int Volume {set; get;}        // Объём
            public Hdd(int price, string old, T articyl, int turnovers, string face, int volume)
                : base(price, old, articyl)
            {
                Turnovers = turnovers;      // Кол. оборотов
                Interface = face;           // Интерфейс
                Volume = volume;            // Объём
            }

            public new string Display() // Вывод информации
            {
                return ($"Цена: {Price}, Год выпуска: {Old}, Артикул: {Articyl}, Количество оборотов: {Turnovers}, Интерфейс: {Interface}, Объем: {Volume} гигабайт.");
            }
        }

        class Videocard<T> : Accessories<T> // Класс "Видеокарта" + наследование класса "Комплектующие"
        {
            int GPU_frequency {set; get;}     // Частота gpu
            string Manufacturer {set; get;}   // Производитель
            int Memory {set; get;}            // Объём памяти
            public Videocard(int price, string old, T articyl, int gpu, string manufacturer, int memory)
            :base(price, old, articyl)
            {
                GPU_frequency = gpu;            // Частота gpu
                Manufacturer = manufacturer;    // Производитель
                Memory = memory;                // Объём памяти
            }
            public new string Display() // Вывод информации
            {
            return ($"Цена: {Price}, Год выпуска: {Old}, Артикул: {Articyl}, Частота CPU: {GPU_frequency}, Производительность: {Manufacturer}, Объем памяти: {Memory} гигабайт.");
            }
        }

        private void Task1_Load(object sender, EventArgs e)
        {

        }

        //private void button1_Click(object sender, EventArgs e) // Очистить листбокс
        //{
        
        //}

        //private void button2_Click(object sender, EventArgs e) // Вывести hdd
        //{
            
        //}

        //private void button3_Click(object sender, EventArgs e) // Вывести cpu
        //{
            
        //}

        private void button1_Click_1(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button2_Click_1(object sender, EventArgs e)
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

        private void button3_Click_1(object sender, EventArgs e)
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
