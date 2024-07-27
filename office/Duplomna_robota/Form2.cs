using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Duplomna_robota
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "spusok_ychnivDataSet.База". При необходимости она может быть перемещена или удалена.
            this.базаTableAdapter.Fill(this.spusok_ychnivDataSet.База);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataRow dr = spusok_ychnivDataSet.База.NewRow();
            dr[1] = textBox1.Text;
            spusok_ychnivDataSet.База.Rows.Add(dr);
            this.Validate();
            this.базаBindingSource.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.spusok_ychnivDataSet);
            this.базаTableAdapter.Fill(this.spusok_ychnivDataSet.База);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            spusok_ychnivDataSet.База[базаBindingSource.Position].Delete();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataRow dr = spusok_ychnivDataSet.База[базаBindingSource.Position];
            dr[1] = textBox1.Text;
            this.Validate();
            this.базаBindingSource.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.spusok_ychnivDataSet);
            this.базаTableAdapter.Fill(this.spusok_ychnivDataSet.База);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
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
