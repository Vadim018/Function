using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        /*
            За допомогою цих команд ви очищаєте вміст текстового поля і графіка перед тим, 
            як вони будуть заповнені новими даними при кожному натисканні кнопки.
            Це допомагає уникнути накопичення старих даних і відображає тільки поточні результати обчислень.
        */
            richTextBox1.Clear(); // очищає вміст текстового поля
            chart1.Series[0].Points.Clear(); // очищає дані в першому рядку
            chart1.Series[1].Points.Clear(); // очищає дані в другому рядку

            double x, y, z, A, B, h;
            A = Convert.ToDouble(textBox1.Text);
            B = Convert.ToDouble(textBox2.Text);
            h = Convert.ToDouble(textBox3.Text);

            for (x = A; x <= B + 0.1 * h; x += h)
            {
                // обчислення значень функцій
                y = Math.Exp(3 * (x - 0.6));
                z = Math.Asin(x);

                // додавання точок до графіків
                chart1.Series[0].Points.AddXY(x, y);
                chart1.Series[1].Points.AddXY(x, z);

                // додавання результатів до richTextBox
                richTextBox1.Text += "x = " + x.ToString("0.00") + " y(x) = " + y.ToString("0.00") + " z(x) = " + z.ToString("0.00") + Environment.NewLine;
            }
        }

        private void довідкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutBox = new AboutBox1();
            aboutBox.ShowDialog(this);
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}