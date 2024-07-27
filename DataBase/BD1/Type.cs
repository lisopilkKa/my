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
    public partial class Type : Form
    {
        public Type()
        {
            InitializeComponent();
        }
        public bool oshibka = false;
        private void типBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.типBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.лБ1DataSet);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                oshibka = true;
            }
           

        }
       
        private void Type_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "лБ1DataSet.Тип". При необходимости она может быть перемещена или удалена.
            this.типTableAdapter.Fill(this.лБ1DataSet.Тип);

        }

        private void Prior_Click(object sender, EventArgs e)
        {
            типBindingSource.Position--;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            типBindingSource.Position++;

        }
        public int k = 3;
        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                DataRow newr = лБ1DataSet.Tables["Тип"].NewRow();
                k++;
                newr["Код"] = k;
                лБ1DataSet.Tables["Тип"].Rows.Add(newr);

                типBindingSource.Position = лБ1DataSet.Tables["Тип"].Rows.Count;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataRow dr = лБ1DataSet.Tables["Тип"].Rows[типBindingSource.Position];

            dr["Код"] = textBox1.Text;
            dr["Назва"] = textBox2.Text;
            dr["Опис"] = textBox3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            лБ1DataSet.Tables["Тип"].Rows[типBindingSource.Position].Delete();
        }

        private void типBindingSource_PositionChanged(object sender, EventArgs e)
        {
            DataRow dr = лБ1DataSet.Tables["Тип"].Rows[типBindingSource.Position];

            textBox1.Text = dr["Код"].ToString();
            textBox2.Text = dr["Назва"].ToString();
            textBox3.Text = dr["Опис"].ToString();
        }

        private void Type_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!oshibka)
            {
                foreach (DataRow curR in лБ1DataSet.Tables["Тип"].Rows)
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
            ЛБ1DataSet.ТипRow curR = лБ1DataSet.Тип.FindByКод(Convert.ToByte(textBox10.Text));
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
            DataRow[] search = лБ1DataSet.Tables["Тип"].Select("Назва like '" + textBox10.Text + "%' " );
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
