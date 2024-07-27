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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }
        HashSet<string> uniqueValues = new HashSet<string>();
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            группиBindingSource.Filter = "[Спеціальність] like '%" + comboBox1.SelectedValue + "%'";
            comboBox2.Items.Clear();
            uniqueValues.Clear();
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                DataGridViewRow row = dataGridView1.Rows[i];
                string cellValue = row.Cells["спеціальністьDataGridViewTextBoxColumn"].Value.ToString()+"-" + row.Cells["номерDataGridViewTextBoxColumn"].Value.ToString();
                uniqueValues.Add(cellValue);
            }

            foreach (string value in uniqueValues)
            {
                comboBox2.Items.Add(value);
            }
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "spusok_ychnivDataSet.Спеціальності". При необходимости она может быть перемещена или удалена.
            this.спеціальностіTableAdapter.Fill(this.spusok_ychnivDataSet.Спеціальності);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "spusok_ychnivDataSet.Группи". При необходимости она может быть перемещена или удалена.
            this.группиTableAdapter.Fill(this.spusok_ychnivDataSet.Группи);
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            группиBindingSource.Filter += " And [курс] = " + comboBox3.Text;        
            comboBox2.Items.Clear();
            uniqueValues.Clear();
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                DataGridViewRow row = dataGridView1.Rows[i];
                string cellValue = row.Cells["спеціальністьDataGridViewTextBoxColumn"].Value.ToString() + "-" + row.Cells["номерDataGridViewTextBoxColumn"].Value.ToString();
                uniqueValues.Add(cellValue);
            }
            foreach (string value in uniqueValues)
            {
                comboBox2.Items.Add(value);
            }
        }
    }
}
