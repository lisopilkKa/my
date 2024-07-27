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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "spusok_ychnivDataSet.Джерело_фінансування". При необходимости она может быть перемещена или удалена.
            this.джерело_фінансуванняTableAdapter.Fill(this.spusok_ychnivDataSet.Джерело_фінансування);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataRow dr = spusok_ychnivDataSet.Джерело_фінансування.NewRow();
            dr[1] = textBox1.Text;
            spusok_ychnivDataSet.Джерело_фінансування.Rows.Add(dr);
            this.Validate();
            this.джерелоФінансуванняBindingSource.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.spusok_ychnivDataSet);
            this.джерело_фінансуванняTableAdapter.Fill(this.spusok_ychnivDataSet.Джерело_фінансування);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            spusok_ychnivDataSet.Джерело_фінансування[джерелоФінансуванняBindingSource.Position].Delete();
            this.Validate();
            this.джерелоФінансуванняBindingSource.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.spusok_ychnivDataSet);
            this.джерело_фінансуванняTableAdapter.Fill(this.spusok_ychnivDataSet.Джерело_фінансування);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataRow dr = spusok_ychnivDataSet.Джерело_фінансування[джерелоФінансуванняBindingSource.Position];
            dr[1] = textBox1.Text;
            this.Validate();
            this.джерелоФінансуванняBindingSource.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.spusok_ychnivDataSet);
            this.джерело_фінансуванняTableAdapter.Fill(this.spusok_ychnivDataSet.Джерело_фінансування);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                if (selectedRow.Cells[0].Value != null)
                {
                    textBox1.Text = selectedRow.Cells[1].Value.ToString();
                }
            }
        }
    }
}
