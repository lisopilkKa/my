using Duplomna_robota.Spusok_ychnivDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Duplomna_robota
{
    internal class Administrator
    {
       // private Рух_студентівTableAdapter рух_студентівTableAdapter;
        private BindingSource рухСтудентівBindingSource;
       // private TableAdapterManager tableAdapterManager1;
        private Spusok_ychnivDataSet ds;
        public void MyMethod(DataGridView dataGridView2, RichTextBox richTextBox1, ComboBox comboBox2,
       TextBox textBox1, TextBox textBox2, TextBox textBox3, TextBox textBox6, DateTimePicker dateTimePicker2,
       ComboBox comboBox1, string baza, ComboBox comboBox5, int kyrs, string comboBox3, TextBox textBox4)
        {
            int kod = dataGridView2.RowCount + 8;
            try
            {
                richTextBox1.Text += comboBox2.Text + "\n";
                DataRow drr = ds.Рух_студентів.NewRow();
                string q = "";
                q += textBox1.Text + " ";
                q += textBox2.Text + " ";
                q += textBox3.Text;
                drr[0] = kod;
                drr[1] = dateTimePicker2.Value.Year;
                drr[2] = comboBox1.Text;
                drr[3] = comboBox2.Text;
                drr[4] = q;
                drr[5] = textBox6.Text + "-ст від " + dateTimePicker2.Value.ToShortDateString();
                drr[6] = comboBox3;
                drr[7] = baza;
                drr[8] = comboBox5.Text;
                drr[21] = kyrs;
                drr[22] = "Навчається";
                drr[24] = textBox4.Text;
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                рухСтудентівBindingSource.Position = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
