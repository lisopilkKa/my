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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "spusok_ychnivDataSet.Спеціальності". При необходимости она может быть перемещена или удалена.
            this.спеціальностіTableAdapter.Fill(this.spusok_ychnivDataSet.Спеціальності);

        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            DataRow dr = spusok_ychnivDataSet.Спеціальності.NewRow();
            dr[0] = textBox1.Text;
            dr[1] = textBox2.Text;
            dr[2] = textBox3.Text;
            dr[3] = textBox4.Text;
            dr[4] = textBox5.Text;
            dr[5] = textBox6.Text;
            spusok_ychnivDataSet.Спеціальності.Rows.Add(dr);
            this.Validate();
            this.спеціальностіBindingSource.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.spusok_ychnivDataSet);
            this.спеціальностіTableAdapter.Fill(this.spusok_ychnivDataSet.Спеціальності);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            spusok_ychnivDataSet.Спеціальності[спеціальностіBindingSource.Position].Delete();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            DataRow dr = spusok_ychnivDataSet.Спеціальності[спеціальностіBindingSource.Position];
            dr[0] = textBox1.Text;
            dr[1] = textBox2.Text;
            dr[2] = textBox3.Text;
            dr[3] = textBox4.Text;
            dr[4] = textBox5.Text;
            dr[5] = textBox6.Text;
            this.Validate();
            this.спеціальностіBindingSource.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.spusok_ychnivDataSet);
            this.спеціальностіTableAdapter.Fill(this.spusok_ychnivDataSet.Спеціальності);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                if (selectedRow.Cells[0].Value != null)
                {
                    textBox1.Text = selectedRow.Cells[0].Value.ToString();
                    textBox2.Text = selectedRow.Cells[1].Value.ToString();
                    textBox3.Text = selectedRow.Cells[2].Value.ToString();
                    textBox4.Text = selectedRow.Cells[3].Value.ToString();
                    textBox5.Text = selectedRow.Cells[4].Value.ToString();
                    textBox6.Text = selectedRow.Cells[5].Value.ToString();
                }
            }
        }
    }
}
