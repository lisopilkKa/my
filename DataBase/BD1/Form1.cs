using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BD1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "лБ1DataSet.Каталог_косметичних_товарів". При необходимости она может быть перемещена или удалена.
            this.каталог_косметичних_товарівTableAdapter.Fill(this.лБ1DataSet.Каталог_косметичних_товарів);

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
