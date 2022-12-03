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
        abstract class Components<R>
        {
            public int Price;       // Цена
            public string Year_of_release;      // Год выпуска
            public R Articyl {get; set;}  // Артикул
            public Components(int price, string year_of_release, R articyl)
            {
                Price = price;                               // Цена
                Year_of_release = year_of_release;           // Год выпуска
                Articyl = articyl;                           // Артикул
            }
            public void Display()
            {

            }
        }

        class Hdd<R> : Components<R> 
        {
            int Turnovers {set; get;}     // Количество оборотов жесткого диска
            string Interface {set; get;}  // Интерфейс
            int Volume {set; get; }        // Объём жесткого диска
            public Hdd(int price, string old, R articyl, int turnovers, string face, int volume)
                : base(price, old, articyl)
            {
                Turnovers = turnovers;      // Кол. оборотов
                Interface = face;           // Интерфейс
                Volume = volume;            // Объём жесткого диска
            }

            public new string Display() 
            {
                return ($"Цена: {Price}, Год выпуска: {Year_of_release}, Артикул: {Articyl}, " +
                    $"Количество оборотов: {Turnovers}, Интерфейс: {Interface}, Объем: {Volume} гигабайт.");
            }
        }

        class Videocard<R> : Components<R> 
        {
            int GPU_frequency {set; get;}       // Частота gpu
            string Manufacturer {set; get; }    // Производитель видеокарты
            int Memory {set; get;}              // Объём памяти видеокарты
            public Videocard(int price, string old, R articyl, int gpu, string manufacturer, int memory)
            :base(price, old, articyl)
            {
                GPU_frequency = gpu;            // Частота gpu
                Manufacturer = manufacturer;    // Производитель видеокарты
                Memory = memory;                // Объём памяти видеокарты
            }
            public new string Display() 
            {
            return ($"Цена: {Price}, Год выпуска: {Year_of_release}, Артикул: {Articyl}, Частота CPU: {GPU_frequency}," +
                    $" Производительность: {Manufacturer}, Объем памяти: {Memory} гигабайт.");
            }
        }

        private void Task1_Load(object sender, EventArgs e)
        {

        }


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
                MessageBox.Show("Введите данные");
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
                MessageBox.Show("Введите данные");
            }
        }
    }
}
