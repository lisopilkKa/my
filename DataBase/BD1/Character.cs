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
    public partial class Character : Form
    {
        public Character()
        {
            InitializeComponent();
        }

     
        private void Character_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "лБ1DataSet.Характер". При необходимости она может быть перемещена или удалена.
            this.характерTableAdapter.Fill(this.лБ1DataSet.Характер);
        

        }
        public bool oshibka = false;
        private void характерBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.характерBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.лБ1DataSet);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                oshibka = true;
            }
           

        }

        private void характерDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void характерBindingSource_PositionChanged(object sender, EventArgs e)
        {

            DataRow dr = лБ1DataSet.Tables["Характер"].Rows[характерBindingSource.Position];

            textBox1.Text = dr["Код"].ToString();
            textBox2.Text = dr["Назва"].ToString();
            textBox3.Text = dr["Опис"].ToString();
        }

        private void Prior_Click(object sender, EventArgs e)
        {
            характерBindingSource.Position--;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            характерBindingSource.Position++;
        }
        public int k = 55;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow newr = лБ1DataSet.Tables["Характер"].NewRow();
                k++;
                newr["Код"] = k;
                лБ1DataSet.Tables["Характер"].Rows.Add(newr);

                характерBindingSource.Position = лБ1DataSet.Tables["Характер"].Rows.Count;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataRow dr = лБ1DataSet.Tables["Характер"].Rows[характерBindingSource.Position];

            dr["Код"] = textBox1.Text;
            dr["Назва"] = textBox2.Text;
            dr["Опис"] = textBox3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            лБ1DataSet.Tables["Характер"].Rows[характерBindingSource.Position].Delete();
        }

        private void Character_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!oshibka)
            {
                foreach (DataRow curR in лБ1DataSet.Tables["Характер"].Rows)
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
            ЛБ1DataSet.ХарактерRow curR = лБ1DataSet.Характер.FindByКод(Convert.ToByte(textBox10.Text));
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
            DataRow[] search = лБ1DataSet.Tables["Характер"].Select("Назва like '" + textBox10.Text + "%' ");
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

        private void характерBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }
    }
}
