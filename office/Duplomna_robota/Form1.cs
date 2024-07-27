using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Duplomna_robota
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "spusok_ychnivDataSet.Джерело_фінансування". При необходимости она может быть перемещена или удалена.
            this.джерело_фінансуванняTableAdapter.Fill(this.spusok_ychnivDataSet.Джерело_фінансування);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "spusok_ychnivDataSet.База". При необходимости она может быть перемещена или удалена.
            this.базаTableAdapter.Fill(this.spusok_ychnivDataSet.База);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "spusok_ychnivDataSet.Стать". При необходимости она может быть перемещена или удалена.
            this.статьTableAdapter.Fill(this.spusok_ychnivDataSet.Стать);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "spusok_ychnivDataSet.Группи". При необходимости она может быть перемещена или удалена.
            this.группиTableAdapter.Fill(this.spusok_ychnivDataSet.Группи);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "spusok_ychnivDataSet.Спеціальності". При необходимости она может быть перемещена или удалена.
            this.спеціальностіTableAdapter.Fill(this.spusok_ychnivDataSet.Спеціальності);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "spusok_ychnivDataSet.Рух_студентів". При необходимости она может быть перемещена или удалена.
            this.рух_студентівTableAdapter.Fill(this.spusok_ychnivDataSet.Рух_студентів);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "spusok_ychnivDataSet.Учні". При необходимости она может быть перемещена или удалена.

        }
        private void button1_Click(object sender, EventArgs e)
        {

            Form6 d = new Form6();
            d.baza = 9;
            d.kyrs = 1;
            d.ShowDialog();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form8 d = new Form8();
            d.ShowDialog();
        }

        private void базаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 d = new Form2();
            d.ShowDialog();
        }

        private void группиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 d = new Form7();
            d.ShowDialog();
        }

        private void джерелоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 d = new Form4();
            d.ShowDialog();
        }

        private void спеціальністьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 d = new Form5();
            d.ShowDialog();
        }

        private void учніToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form6 d = new Form6();
            d.baza = 11;
            d.kyrs = 2;
            d.ShowDialog();
        }

        private void іншеToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 d = new Form3();
            
            d.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form10 d = new Form10();

            d.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form11 d = new Form11();

            d.ShowDialog();
        }
    }
}
