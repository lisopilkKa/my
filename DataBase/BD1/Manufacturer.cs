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
    public partial class Manufacturer : Form
    {
        public Manufacturer()
        {
            InitializeComponent();
        }
        public bool oshibka = false;
        private void виробникBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.виробникBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.лБ1DataSet);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                oshibka = true;
            }
           

        }

        private void Manufacturer_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "лБ1DataSet.Країна". При необходимости она может быть перемещена или удалена.
            this.країнаTableAdapter.Fill(this.лБ1DataSet.Країна);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "лБ1DataSet.Виробник". При необходимости она может быть перемещена или удалена.
            this.виробникTableAdapter.Fill(this.лБ1DataSet.Виробник);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void виробникBindingSource_PositionChanged(object sender, EventArgs e)
        {
            DataRow dr = лБ1DataSet.Tables["Виробник"].Rows[виробникBindingSource.Position];

            textBox1.Text = dr["Код"].ToString();
            textBox2.Text = dr["Назва"].ToString();
            textBox4.Text = dr["Засновник"].ToString();
            textBox5.Text = dr["Дата заснування"].ToString();
        }

        private void Prior_Click(object sender, EventArgs e)
        {
            виробникBindingSource.Position--;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            виробникBindingSource.Position++;
        }
        public int k = 55;
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow newr = лБ1DataSet.Tables["Виробник"].NewRow();
                k++;
                newr["Код"] = k;
                лБ1DataSet.Tables["Виробник"].Rows.Add(newr);

                виробникBindingSource.Position = лБ1DataSet.Tables["Виробник"].Rows.Count;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataRow curR = лБ1DataSet.Tables["Виробник"].Rows[виробникBindingSource.Position];
            curR["Код"] = textBox1.Text;
            curR["Назва"] = textBox2.Text;
            curR["Засновник"] = textBox4.Text;
            curR["Дата заснування"] = textBox5.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            лБ1DataSet.Tables["Виробник"].Rows[виробникBindingSource.Position].Delete();
        }

        private void Manufacturer_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!oshibka)
            {
                foreach (DataRow curR in лБ1DataSet.Tables["Виробник"].Rows)
                {
                    if (curR.RowState != DataRowState.Unchanged)
                    {
                        e.Cancel = true;
                        MessageBox.Show("SAFE BEFORE CLOSING!");
                    }
                }
            }
           

        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            textBox11.Visible = true;
            ЛБ1DataSet.ВиробникRow curR = лБ1DataSet.Виробник.FindByКод(Convert.ToByte(textBox10.Text));
            if (curR != null)
            {
                textBox11.Text = "назва - " + curR.Назва + ",   країна = " + curR.Країна;
            }
            else
            {
                MessageBox.Show("NO DATA!");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            textBox11.Visible = false;
            DataRow[] search = лБ1DataSet.Tables["Виробник"].Select("Назва like '" + textBox10.Text + "%'");
            dataGridView1.Rows.Clear();
            if (search.Count() > 0)
            {
                foreach (DataRow db in search)
                {
                    dataGridView1.Rows.Add(db.ItemArray);
                }
            }
            else
            {
                MessageBox.Show("NO DATA!");
            }
        }

      

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                виробникBindingSource.Filter = "Країна = " + comboBox7.SelectedValue.ToString();
            }
            else
            {
                виробникBindingSource.Filter = "";
            }
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkBox2.Checked = false;
        }
    }
}
