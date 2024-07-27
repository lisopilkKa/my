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
    public partial class Vhid : Form
    {
        public Vhid()
        {
            InitializeComponent();
          
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        public int k;
        private void button1_Click(object sender, EventArgs e)
        {
           
            DataRow[] search = лБ1DataSet.Tables["UsersInfo"].Select("Логин  ='" + textBox1.Text + "' and Пароль ='" + textBox2.Text+ "'");
            if (search.Count() > 0)
            {
                foreach (DataRow db in search)
                {
                    k = Convert.ToInt32(db["Роль"]);
                    MessageBox.Show("Hello, "+ db["ФИО"]);
                }
            }
            else
            {
                MessageBox.Show("WRONG AUTORIZATING DATA!");
            }
        }

        private void Vhid_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "лБ1DataSet.UsersInfo". При необходимости она может быть перемещена или удалена.
            this.usersInfoTableAdapter.Fill(this.лБ1DataSet.UsersInfo);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

       
    }
}
