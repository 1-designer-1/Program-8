using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Практическая работа 8 \n" +
               "Серегин Денис\n" +
               "Создать интерфейс - человек, у которого есть имя, функция печати. Создать класс отец, у которого функция печати выводит имя.   \n" +
               "Создать класс ребенок, у которого есть отец, отчество, функция печати выводит имя и отчество." +
               " Классы должны включать конструкторы. Сравнение производить по фамилии.\n", "Задание", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void заполнитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Father father = new Father();
            Children children = new Children();
            father.Name = Convert.ToString(textBox1.Text);
            MessageBox.Show(father.Print());







        }
    }
}
