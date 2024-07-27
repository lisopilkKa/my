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
    public partial class Catalog : Form
    {
        public Catalog()
        {
            InitializeComponent();
        }

        private void каталог_косметичних_товарівBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.каталог_косметичних_товарівBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.лБ1DataSet);
            this.каталог_косметичних_товарівTableAdapter.Fill(this.лБ1DataSet.Каталог_косметичних_товарів);
            this.каталог_косметичних_товарівTableAdapter.Fill(this.лБ1DataSet.Каталог_косметичних_товарів);
        }
       
        private void Catalog_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "лБ1DataSet.Країна". При необходимости она может быть перемещена или удалена.
            this.країнаTableAdapter.Fill(this.лБ1DataSet.Країна);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "лБ1DataSet.Характер". При необходимости она может быть перемещена или удалена.
            this.характерTableAdapter.Fill(this.лБ1DataSet.Характер);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "лБ1DataSet.Тип". При необходимости она может быть перемещена или удалена.
            this.типTableAdapter.Fill(this.лБ1DataSet.Тип);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "лБ1DataSet.Виробник". При необходимости она может быть перемещена или удалена.
            this.виробникTableAdapter.Fill(this.лБ1DataSet.Виробник);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "лБ1DataSet.Вид". При необходимости она может быть перемещена или удалена.
            this.видTableAdapter.Fill(this.лБ1DataSet.Вид);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "лБ1DataSet.Каталог_косметичних_товарів". При необходимости она может быть перемещена или удалена.
            this.каталог_косметичних_товарівTableAdapter.Fill(this.лБ1DataSet.Каталог_косметичних_товарів);

            comboBox12.Items.Clear();
            for (int i = 0; i < лБ1DataSet.Країна.Rows.Count; i++)
            {
                comboBox12.Items.Add(лБ1DataSet.Країна.Rows[i][1]);
            }
            DataRow dr_р = лБ1DataSet.Каталог_косметичних_товарів.Rows[0];
            DataRow[] dr_country = лБ1DataSet.Країна.Select("Код=" + dr_р[13].ToString());
            comboBox12.SelectedIndex = comboBox12.FindString(dr_country[0][1].ToString());
        }
        public int k = 0;
        private void Prior_Click(object sender, EventArgs e)
        {
            каталог_косметичних_товарівBindingSource.Position--;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            каталог_косметичних_товарівBindingSource.Position++;
          
        }
        private void button4_Click(object sender, EventArgs e)
        {
            DataRow curR = лБ1DataSet.Tables["Каталог косметичних товарів"].Rows[каталог_косметичних_товарівBindingSource.Position];
            curR["Код"] = textBox1.Text;
            curR["Назва"] = textBox2.Text;
            curR["Опис"] = textBox3.Text;
            curR["Термін придатності"] = textBox4.Text;
            curR["Вартість"] = textBox5.Text;
            curR["Дата виготовлення"] = textBox6.Text;
            curR["Споживачі"] = textBox7.Text;
            curR["Об'єм"] = textBox8.Text;
            curR["Текстура"] = textBox9.Text;
        }
       
        private void button3_Click(object sender, EventArgs e)
        {
            try
           {
                DataRow newr = лБ1DataSet.Tables["Каталог косметичних товарів"].NewRow();
                k++;
                newr["Код"] = k;
                лБ1DataSet.Tables["Каталог косметичних товарів"].Rows.Add(newr);

                каталог_косметичних_товарівBindingSource.Position = лБ1DataSet.Tables["Каталог косметичних товарів"].Rows.Count;
            }
             catch (Exception ex)
             {
                MessageBox.Show(ex.Message);
             }
        }
        
       

        private void button1_Click(object sender, EventArgs e)
        {
            лБ1DataSet.Tables["Каталог косметичних товарів"].Rows[каталог_косметичних_товарівBindingSource.Position].Delete();
        }

        private void Catalog_FormClosing(object sender, FormClosingEventArgs e)
        {
           /* foreach (DataRow curR in лБ1DataSet.Tables["Каталог косметичних товарів"].Rows)
            {
                if (curR.RowState!=DataRowState.Unchanged)
                {
                    e.Cancel = true;
                    MessageBox.Show("SAFE BEFORE CLOSING!");
                }
            }*/
          
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            textBox11.Visible = true;
            ЛБ1DataSet.Каталог_косметичних_товарівRow curR = лБ1DataSet.Каталог_косметичних_товарів.FindByКод(Convert.ToInt32(textBox10.Text));
            if (curR!=null)
            {
                textBox11.Text = "назва - " + curR.Назва + ",   вартість = " + curR.Вартість + "грн";
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
            DataRow[] search = лБ1DataSet.Tables["Каталог косметичних товарів"].Select("Назва like '" + textBox10.Text + "%' and Вартість " + comboBox6.Text + textBox12.Text);
            dataGridView1.Rows.Clear();
            if (search.Count()>0)
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
        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
   

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
           
            checkBox1.Checked = false;
        }

       

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            checkBox2.Checked = false;
        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            checkBox3.Checked = false;
        }

      

        private void button7_Click(object sender, EventArgs e)
        {
            
            dataGridView1.Visible = true;
            textBox11.Visible = false;
            DataRow[] search = лБ1DataSet.Tables["Каталог косметичних товарів"].Select("Назва like '" + textBox10.Text + "%'" );
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
        
        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            checkBox1.Checked = false;
        }

       

        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            checkBox4.Checked = false;
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            каталог_косметичних_товарівBindingSource.Filter = "";
            Stack<char> filtr = new Stack<char>();
            if (checkBox1.Checked)
            {
                filtr.Push('1');
            }
            if (checkBox2.Checked)
            {
                filtr.Push('2');
            }
            if (checkBox3.Checked)
            {
                filtr.Push('3');
            }
            if (checkBox4.Checked)
            {
                filtr.Push('4');
            }
            if (checkBox5.Checked)
            {
                filtr.Push('5');
            }
            int h = filtr.Count;
            for (int i = 1; i <=h; i++)
            {
                switch (filtr.Pop())
                {
                    case '5':
                        {
                            if (каталог_косметичних_товарівBindingSource.Filter == "" || каталог_косметичних_товарівBindingSource.Filter == null)
                                каталог_косметичних_товарівBindingSource.Filter += "[Країна] = " + comboBox10.SelectedValue.ToString();
                            else
                                каталог_косметичних_товарівBindingSource.Filter += " and " + "[Країна] = " + comboBox10.SelectedValue.ToString();
                            break;
                        }
                    case '4':
                        {
                            
                            if (каталог_косметичних_товарівBindingSource.Filter == "" || каталог_косметичних_товарівBindingSource.Filter == null)
                                каталог_косметичних_товарівBindingSource.Filter += "Тип = " + comboBox9.SelectedValue.ToString();
                            else
                                каталог_косметичних_товарівBindingSource.Filter += " and " + "[Тип] = " + comboBox9.SelectedValue.ToString();
                            break;
                        }
                    case '3':
                        {
                            if (каталог_косметичних_товарівBindingSource.Filter == "" || каталог_косметичних_товарівBindingSource.Filter == null)
                                каталог_косметичних_товарівBindingSource.Filter += "Виробник = " + comboBox8.SelectedValue.ToString();
                            else
                                каталог_косметичних_товарівBindingSource.Filter += " and " + "[Виробник] = " + comboBox8.SelectedValue.ToString();
                            break;
                        }
                    case '2':
                        {
                            if (каталог_косметичних_товарівBindingSource.Filter == "" || каталог_косметичних_товарівBindingSource.Filter == null)
                                каталог_косметичних_товарівBindingSource.Filter += "Вид = " + comboBox7.SelectedValue.ToString();
                            else
                                каталог_косметичних_товарівBindingSource.Filter += " and " + "[Вид] = " + comboBox7.SelectedValue.ToString();
                            break;
                        }
                    case '1':
                        {
                            if (каталог_косметичних_товарівBindingSource.Filter == "" || каталог_косметичних_товарівBindingSource.Filter == null)
                                каталог_косметичних_товарівBindingSource.Filter += "Вартість " + comboBox6.Text + textBox12.Text;
                            else
                                каталог_косметичних_товарівBindingSource.Filter += " and " + "Вартість " + comboBox6.Text + textBox12.Text;
                            break;
                        }
                }
            }
          
        }

        private void comboBox10_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            checkBox5.Checked = false;
        }

        private void каталог_косметичних_товарівDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox12_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRow dr_р = лБ1DataSet.Каталог_косметичних_товарів.Rows[каталог_косметичних_товарівBindingSource.Position];
            DataRow[] dr_country = лБ1DataSet.Країна.Select("Назва='" + comboBox12.Text+"'");
            dr_р[13] = dr_country[0][0].ToString();
          

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form1 fChoice = new Form1();
            DataRow dr_р = лБ1DataSet.Каталог_косметичних_товарів.Rows[каталог_косметичних_товарівBindingSource.Position];
            fChoice.dataGridView1.DataSource = лБ1DataSet.Характер;
            int r;
            for ( r = 0; r < fChoice.dataGridView1.Rows.Count; r++)
            {
                if (fChoice.dataGridView1.Rows[r].Cells[0].Value.ToString() == dr_р["Характер товару"].ToString()) break;
                
            }
            fChoice.dataGridView1.CurrentCell = fChoice.dataGridView1[0, r];

          // 
            if (fChoice.ShowDialog()==DialogResult.OK)
            {
                int code_pr = Convert.ToInt32(fChoice.dataGridView1.CurrentRow.Cells[0].Value);
                textBox13.Text = fChoice.dataGridView1.CurrentRow.Cells[1].Value.ToString() + "(" +
                    fChoice.dataGridView1.CurrentRow.Cells[2].Value.ToString() + ")";
                dr_р["Характер товару"] = code_pr;
              
            }


        }
        private void каталог_косметичних_товарівBindingSource_PositionChanged(object sender, EventArgs e)
        {
            //DataRow curR = лБ1DataSet.Tables["Каталог косметичних товарів"].Rows[каталог_косметичних_товарівBindingSource.Position];
            DataRow dr = лБ1DataSet.Tables["Каталог косметичних товарів"].Rows[каталог_косметичних_товарівBindingSource.Position];//запись

            textBox1.Text = dr["Код"].ToString();
            textBox2.Text = dr["Назва"].ToString();
            textBox3.Text = dr["Опис"].ToString();
            textBox4.Text = dr["Термін придатності"].ToString();
            textBox5.Text = dr["Вартість"].ToString();
            textBox6.Text = dr["Дата виготовлення"].ToString();
            textBox7.Text = dr["Споживачі"].ToString();
            textBox8.Text = dr["Об'єм"].ToString();
            textBox9.Text = dr["Текстура"].ToString();


            DataRow dr_р = лБ1DataSet.Каталог_косметичних_товарів.Rows[каталог_косметичних_товарівBindingSource.Position];
            DataRow[] dr_country = лБ1DataSet.Країна.Select("Код=" + dr_р[13].ToString());
            comboBox12.SelectedIndex = comboBox12.FindString(dr_country[0][1].ToString());

            DataRow[] dr_har = лБ1DataSet.Характер.Select("Код=" + dr_р[11].ToString());
            textBox13.Text = dr_har[0][1].ToString() + "(" +
                   dr_har[0][2].ToString() + ")";
            DataRow[] dr_vyr = лБ1DataSet.Виробник.Select("Код=" + dr_р[5].ToString());
            textBox14.Text = dr_vyr[0][1].ToString() + "(" +
                   dr_vyr[0][2].ToString() + ")";

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form1 fChoice = new Form1();
            DataRow dr_р = лБ1DataSet.Каталог_косметичних_товарів.Rows[каталог_косметичних_товарівBindingSource.Position];
            fChoice.dataGridView1.DataSource = лБ1DataSet.Виробник;
            int r;
            for (r = 0; r < fChoice.dataGridView1.Rows.Count; r++)
            {
                if (fChoice.dataGridView1.Rows[r].Cells[0].Value.ToString() == dr_р["Виробник"].ToString()) break;

            }
            fChoice.dataGridView1.CurrentCell = fChoice.dataGridView1[0, r];

            // 
            if (fChoice.ShowDialog() == DialogResult.OK)
            {
                int code_pr = Convert.ToInt32(fChoice.dataGridView1.CurrentRow.Cells[0].Value);
                textBox14.Text = fChoice.dataGridView1.CurrentRow.Cells[1].Value.ToString() + "(" +
                    fChoice.dataGridView1.CurrentRow.Cells[3].Value.ToString() + ")";
                dr_р["Виробник"] = code_pr;

            }
        }
    }
}
