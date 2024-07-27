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
    public partial class Country : Form
    {
        public Country()
        {
            InitializeComponent();
        }
        public bool oshibka = false;
        private void країнаBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.країнаBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.лБ1DataSet);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                oshibka = true;
            }
           

        }

        private void Country_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "лБ1DataSet.Країна". При необходимости она может быть перемещена или удалена.
            this.країнаTableAdapter.Fill(this.лБ1DataSet.Країна);

        }

        private void Prior_Click(object sender, EventArgs e)
        {
            країнаBindingSource.Position--;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            країнаBindingSource.Position++;
        }
        public int k = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow newr = лБ1DataSet.Tables["Країна"].NewRow();
                k++;
                newr["Код"] = k;
                лБ1DataSet.Tables["Країна"].Rows.Add(newr);

                країнаBindingSource.Position = лБ1DataSet.Tables["Країна"].Rows.Count;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataRow curR = лБ1DataSet.Tables["Країна"].Rows[країнаBindingSource.Position];
            curR["Код"] = textBox1.Text;
            curR["Назва"] = textBox2.Text;
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            лБ1DataSet.Tables["Країна"].Rows[країнаBindingSource.Position].Delete();
        }

        private void Country_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!oshibka)
            {
                foreach (DataRow curR in лБ1DataSet.Tables["Країна"].Rows)
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
            ЛБ1DataSet.КраїнаRow curR = лБ1DataSet.Країна.FindByКод(textBox10.Text);
            if (curR != null)
            {
                textBox11.Text = "назва - " + curR.Назва;
            }
            else
            {
                MessageBox.Show("NO DATA!");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            textBox11.Visible = false;
            DataRow[] search = лБ1DataSet.Tables["Країна"].Select("Назва like '" + textBox10.Text + "%' ");
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
    }
}
