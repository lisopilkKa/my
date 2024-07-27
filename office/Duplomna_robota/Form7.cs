using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace Duplomna_robota
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "spusok_ychnivDataSet.Спеціальності". При необходимости она может быть перемещена или удалена.
            this.спеціальностіTableAdapter.Fill(this.spusok_ychnivDataSet.Спеціальності);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "spusok_ychnivDataSet.Рух_студентів". При необходимости она может быть перемещена или удалена.
            this.рух_студентівTableAdapter.Fill(this.spusok_ychnivDataSet.Рух_студентів);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "spusok_ychnivDataSet.Группи". При необходимости она может быть перемещена или удалена.
            this.группиTableAdapter.Fill(this.spusok_ychnivDataSet.Группи);
           // comboBox1.Items.Add(comboBox2.Items);

        }        

        private void button1_Click(object sender, EventArgs e)
        {
            DataRow dr = spusok_ychnivDataSet.Группи.NewRow();
            dr[0] = textBox1.Text;
            dr[1] = comboBox1.Text;
            dr[2] = 1;
            dr[3] = "Навчаються";
            spusok_ychnivDataSet.Группи.Rows.Add(dr);
            this.Validate();
            this.группиBindingSource.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.spusok_ychnivDataSet);
            this.группиTableAdapter.Fill(this.spusok_ychnivDataSet.Группи);
        }
        string change_group, change_name;
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                группиBindingSource.Filter = null;
                for (int i = 1; i < dataGridView1.Rows.Count - 1; i++)
                {
                    DataRow dr = spusok_ychnivDataSet.Группи[i];
                    if (dr[0].ToString() == change_group)
                    {
                        dr[0] = textBox1.Text;
                        dr[1] = comboBox1.Text;
                        dr[2] = Convert.ToInt16(textBox3.Text);
                        dr[3] = comboBox5.Text;
                    }
                }
                this.Validate();
                this.группиBindingSource.EndEdit();
                this.tableAdapterManager1.UpdateAll(this.spusok_ychnivDataSet);
                this.группиTableAdapter.Fill(this.spusok_ychnivDataSet.Группи);
                 for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
                 {
                     DataRow drr = spusok_ychnivDataSet.Рух_студентів[i];
                     if (drr[3].ToString() == change_name)
                     {
                         drr[3] = comboBox1.Text + "-" + textBox1.Text;
                     }
                 }
                 this.Validate();
                 this.рухСтудентівBindingSource.EndEdit();
                 this.tableAdapterManager1.UpdateAll(this.spusok_ychnivDataSet);
                 this.рух_студентівTableAdapter.Fill(this.spusok_ychnivDataSet.Рух_студентів); 
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                if (группиBindingSource.Filter == null)
                {
                    группиBindingSource.Filter += "[курс] = " + comboBox3.Text;
                }
                else
                {
                    группиBindingSource.Filter += " And [курс] = " + comboBox3.Text;
                }                
            }
            catch (Exception q)
            {
                MessageBox.Show(q.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string filterValue = comboBox2.Text;
            filterValue = filterValue.Replace("'", "''");
            if (группиBindingSource.Filter == null)
            {
                группиBindingSource.Filter += "[Спеціальність] like '%" + filterValue + "%'";
            }
            else
            {
                группиBindingSource.Filter += " And [Спеціальність] like '%" + filterValue + "%'";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            группиBindingSource.Filter = null;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                if (selectedRow.Cells[0].Value != null)
                {
                    textBox1.Text = selectedRow.Cells[0].Value.ToString();
                    change_group = selectedRow.Cells[0].Value.ToString();
                    change_name = selectedRow.Cells[1].Value.ToString()+"-"+ selectedRow.Cells[0].Value.ToString();
                    comboBox1.Text = selectedRow.Cells[1].Value.ToString();
                    textBox3.Text = selectedRow.Cells[2].Value.ToString();
                    comboBox5.Text = selectedRow.Cells[3].Value.ToString();
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                if (группиBindingSource.Filter == null)
                {
                    группиBindingSource.Filter += "[Стан] like '%" + comboBox4.Text + "%'";
                }
                else
                {
                    группиBindingSource.Filter += " And [Стан] like  '%" + comboBox4.Text + "%'";
                }
            }
            catch (Exception q)
            {
                MessageBox.Show(q.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            spusok_ychnivDataSet.Группи[группиBindingSource.Position].Delete();
        }
    }
}
