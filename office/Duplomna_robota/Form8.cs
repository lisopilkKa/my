using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using ClosedXML.Excel;
using Microsoft.Office.Interop.Excel;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using System.Globalization;
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml.Wordprocessing;

namespace Duplomna_robota
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "spusok_ychnivDataSet.База". При необходимости она может быть перемещена или удалена.
            this.базаTableAdapter.Fill(this.spusok_ychnivDataSet.База);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "spusok_ychnivDataSet.Стать". При необходимости она может быть перемещена или удалена.
            this.статьTableAdapter.Fill(this.spusok_ychnivDataSet.Стать);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "spusok_ychnivDataSet.Джерело_фінансування". При необходимости она может быть перемещена или удалена.
            this.джерело_фінансуванняTableAdapter.Fill(this.spusok_ychnivDataSet.Джерело_фінансування);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "spusok_ychnivDataSet.Группи". При необходимости она может быть перемещена или удалена.
            this.группиTableAdapter.Fill(this.spusok_ychnivDataSet.Группи);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "spusok_ychnivDataSet.Спеціальності". При необходимости она может быть перемещена или удалена.
            this.спеціальностіTableAdapter.Fill(this.spusok_ychnivDataSet.Спеціальності);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "spusok_ychnivDataSet.Рух_студентів". При необходимости она может быть перемещена или удалена.
            this.рух_студентівTableAdapter.Fill(this.spusok_ychnivDataSet.Рух_студентів);
            for (int i = 0; i < dataGridView1.RowCount-1;i++)
            {
                checkedListBox1.Items.Add(spusok_ychnivDataSet.Рух_студентів[i]._Призвіщя_Ім_я_По_батькові.ToString());
            }
            for (int i = 0; i < spusok_ychnivDataSet.Группи.Count; i++)
            {
                comboBox5.Items.Add(spusok_ychnivDataSet.Группи[i].Спеціальність.ToString()+" "+spusok_ychnivDataSet.Группи[i].Номер.ToString());
            }
            HashSet<string> uniqueItems = new HashSet<string>();
            for (int i = 0; i < spusok_ychnivDataSet.Рух_студентів.Count; i++)
            {
                string рік_вступу = spusok_ychnivDataSet.Рух_студентів[i].Рік_вступу.ToString();

                if (!uniqueItems.Contains(рік_вступу)) 
                {
                    comboBox6.Items.Add(рік_вступу);
                    uniqueItems.Add(рік_вступу); 
                }
            }
            for (int i = 0; i < spusok_ychnivDataSet.Спеціальності.Count; i++)
            {
                comboBox2.Items.Add(spusok_ychnivDataSet.Спеціальності[i].Назва.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Nakaz_zmina_kursa(9,2);
        }

    
        public void add(int q)
        {
            рухСтудентівBindingSource.Filter = null;
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                if (checkedListBox1.GetItemChecked(i))
                {
                    string itemText = checkedListBox1.Items[i].ToString();
                    for (int i2 = 0; i2 < dataGridView1.Rows.Count - 1; i2++)
                    {
                        DataRow dr = spusok_ychnivDataSet.Рух_студентів[i2];
                        if (dr[4].ToString() == itemText)
                        {
                            dr[q] = textBox1.Text + "-ст від " + dateTimePicker1.Value.ToShortDateString();
                        }
                    }
                }
            }
            this.Validate();
            this.рухСтудентівBindingSource.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.spusok_ychnivDataSet);
            this.рух_студентівTableAdapter.Fill(this.spusok_ychnivDataSet.Рух_студентів);
        }
        public void Nakaz_zmina_kursa(int q, int kurz)
        {
            рухСтудентівBindingSource.Filter = null;
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                if (checkedListBox1.GetItemChecked(i))
                {
                    string itemText = checkedListBox1.Items[i].ToString();
                    for (int i2 = 0; i2 < dataGridView1.Rows.Count - 1; i2++)
                    {
                        DataRow dr = spusok_ychnivDataSet.Рух_студентів[i2];
                        if (dr[4].ToString() == itemText)
                        {
                            dr[q] = textBox1.Text + "-ст від " + dateTimePicker1.Value.ToShortDateString();
                            dr[21] = kurz;
                        }
                    }
                }
            }
            this.Validate();
            this.рухСтудентівBindingSource.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.spusok_ychnivDataSet);
            this.рух_студентівTableAdapter.Fill(this.spusok_ychnivDataSet.Рух_студентів);
        }
        public void Nakaz_zmina_stany(int q, string stan)
        {
            рухСтудентівBindingSource.Filter = null;
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                if (checkedListBox1.GetItemChecked(i))
                {
                    string itemText = checkedListBox1.Items[i].ToString();
                    for (int i2 = 0; i2 < dataGridView1.Rows.Count - 1; i2++)
                    {
                        DataRow dr = spusok_ychnivDataSet.Рух_студентів[i2];
                        if (dr[4].ToString() == itemText)
                        {
                            dr[q] = textBox1.Text + "-ст від " + dateTimePicker1.Value.ToShortDateString();
                            dr[22] = stan;
                        }
                    }
                }
            }
            this.Validate();
            this.рухСтудентівBindingSource.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.spusok_ychnivDataSet);
            this.рух_студентівTableAdapter.Fill(this.spusok_ychnivDataSet.Рух_студентів);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Nakaz_zmina_kursa(11, 4);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection selectedRows = dataGridView1.SelectedRows;

            foreach (DataGridViewRow row in selectedRows)
            {
                int id = Convert.ToInt32(row.Cells[0].Value);
                DataRow dr = spusok_ychnivDataSet.Рух_студентів[--id];
                dr[10] = textBox1.Text;
            }
            this.Validate();
            this.рухСтудентівBindingSource.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.spusok_ychnivDataSet);
            this.рух_студентівTableAdapter.Fill(this.spusok_ychnivDataSet.Рух_студентів);
        }

        private void варіант1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            checkedListBox1.Visible = true;
            panel1.Visible = true;
            button6.Visible = false;
            button25.Visible = false;
        }

        private void варіант2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            checkedListBox1.Visible = false;
            panel1.Visible = false;
            button6.Visible =true;
            button25.Visible =true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Nakaz_zmina_kursa(10, 3);
        }
       
        private void button6_Click(object sender, EventArgs e)
        {
            Excel.Application excelApp = null;
            Excel.Workbook wkbk;
            Excel.Worksheet sheet;
            string fileName = string.Empty;
            try
            {
                excelApp = new Excel.Application();
                excelApp.Visible = true;
                wkbk = excelApp.Workbooks.Add();
                sheet = wkbk.Sheets.Add();
                sheet.Name = "Sample Worksheet";
                for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
                {
                    sheet.Cells[i] = dataGridView1.Columns[i - 1].HeaderText;
                }
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {

                    for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    {
                       
                        if (dataGridView1.Rows[i].Cells[j].Value != null)
                        {
                            sheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Nakaz_zmina_stany(14, "Навчається");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            рухСтудентівBindingSource.Filter = null;
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                if (checkedListBox1.GetItemChecked(i))
                {
                    string itemText = checkedListBox1.Items[i].ToString();
                    for (int i2 = 0; i2 < dataGridView1.Rows.Count - 1; i2++)
                    {
                        DataRow dr = spusok_ychnivDataSet.Рух_студентів[i2];
                        if (dr[4].ToString() == itemText)
                        {
                            dr[15] = textBox1.Text + "-ст від " + dateTimePicker1.Value.ToShortDateString();
                            if (dr[8].ToString() == "б")
                            {
                                dr[8] = "к";
                            }
                            else
                            {
                                dr[8] = "б";
                            }
                        }
                    }
                }
            }
            this.Validate();
            this.рухСтудентівBindingSource.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.spusok_ychnivDataSet);
            this.рух_студентівTableAdapter.Fill(this.spusok_ychnivDataSet.Рух_студентів);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            try
            {
                if (рухСтудентівBindingSource.Filter == null)
                {
                    рухСтудентівBindingSource.Filter += "[Стан]  like '%" + comboBox7.Text + "%'";
                }
                else
                {
                    рухСтудентівBindingSource.Filter += " And [Стан] like '%" + comboBox7.Text + "%'";
                }
                checkedListBox1.Items.Clear();
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        var cellValue = row.Cells[4].Value;
                        if (cellValue != null)
                        {
                            checkedListBox1.Items.Add(cellValue.ToString());
                        }
                    }
                }

            }
            catch (Exception q)
            {
                richTextBox1.Text += q.Message + "\n";
            }
        }
        private void button17_Click(object sender, EventArgs e)
        {
            try
            {
                string filterValue = comboBox2.Text;
                filterValue = filterValue.Replace("'", "''");
                if (рухСтудентівBindingSource.Filter==null)
                {
                  рухСтудентівBindingSource.Filter += "[Спеціальність] like '%" + filterValue + "%'";
                }
                else 
                {
                    рухСтудентівBindingSource.Filter += " And [Спеціальність] like '%" + filterValue + "%'"; 
                }
                checkedListBox1.Items.Clear();
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        var cellValue = row.Cells[4].Value;
                        if (cellValue != null)
                        {
                            checkedListBox1.Items.Add(cellValue.ToString());
                        }
                    }
                }
                группиBindingSource.Filter = "[Спеціальність] like '%" + spusok_ychnivDataSet.Спеціальності[comboBox2.SelectedIndex].Буква.ToString() + "%'";
                comboBox5.Items.Clear();
                HashSet<string> uniqueValues = new HashSet<string>();

                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    DataGridViewRow row = dataGridView1.Rows[i];
                    string cellValue = row.Cells["групаDataGridViewTextBoxColumn"].Value.ToString();
                    uniqueValues.Add(cellValue);
                }

                foreach (string value in uniqueValues)
                {
                    comboBox5.Items.Add(value);
                }

            }
            catch (Exception q)
            {
                richTextBox1.Text += q.Message + "\n";
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
           try
           {
                if (рухСтудентівBindingSource.Filter == null)
                {
                    рухСтудентівBindingSource.Filter += "група like '%" + comboBox5.Text + "%'";
                }
                else
                { 
                    рухСтудентівBindingSource.Filter += " And група like '%" + comboBox5.Text + "%'"; 
                }
                checkedListBox1.Items.Clear();
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        var cellValue = row.Cells[4].Value;
                        if (cellValue != null)
                        {
                            checkedListBox1.Items.Add(cellValue.ToString());
                        }
                    }
                }

           }
           catch (Exception q)
           {
                    richTextBox1.Text += q.Message + "\n";
           }
        }

        private void button19_Click(object sender, EventArgs e)
        {
                try
                {
                if (рухСтудентівBindingSource.Filter == null)
                {
                    рухСтудентівBindingSource.Filter = "[джерело фінансування] like '%" + comboBox1.Text + "%'";
                }
                else
                {
                    рухСтудентівBindingSource.Filter += " And [джерело фінансування] like '%" + comboBox1.Text + "%'";
                }
                    checkedListBox1.Items.Clear();
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        var cellValue = row.Cells[4].Value;
                        if (cellValue != null)
                        {
                            checkedListBox1.Items.Add(cellValue.ToString());
                        }
                    }
                }
            }
                catch (Exception q)
                {
                    richTextBox1.Text += q.Message + "\n";
                }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            checkedListBox1.Items.Clear();
            рухСтудентівBindingSource.Filter = null;
            for (int i = 0; i < dataGridView1.RowCount - 1; i++)
            {
                checkedListBox1.Items.Add(spusok_ychnivDataSet.Рух_студентів[i]._Призвіщя_Ім_я_По_батькові.ToString());
            }
            for (int i = 0; i < spusok_ychnivDataSet.Группи.Count; i++)
            {
                comboBox5.Items.Add(spusok_ychnivDataSet.Группи[i].Номер.ToString() + " " + spusok_ychnivDataSet.Группи[i].Спеціальність.ToString());
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            рухСтудентівBindingSource.Filter = "[Призвіщя,Ім'я,По батькові] like '%" + textBox2.Text + "%'";
            checkedListBox1.Items.Clear();            
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow)
                {
                    var cellValue = row.Cells[4].Value;
                    if (cellValue != null)
                    {
                        checkedListBox1.Items.Add(cellValue.ToString());
                    }
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {            
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            add(12);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Nakaz_zmina_stany(13, "Призупинено");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form9 d = new Form9();
            if (d.ShowDialog() == DialogResult.OK)
            {
                рухСтудентівBindingSource.Filter = null;
                for (int i = 0; i < checkedListBox1.Items.Count; i++)
                {
                    if (checkedListBox1.GetItemChecked(i))
                    {
                        string itemText = checkedListBox1.Items[i].ToString();
                        for (int i2 = 0; i2 < dataGridView1.Rows.Count - 1; i2++)
                        {
                            DataRow dr = spusok_ychnivDataSet.Рух_студентів[i2];
                            if (dr[4].ToString() == itemText)
                            {
                                dr[2] = d.comboBox1.Text;
                                dr[3] = d.comboBox2.Text;
                                dr[16] = textBox1.Text + "-ст від " + dateTimePicker1.Value.ToShortDateString();
                                dr[21] = d.comboBox3.Text;
                            }
                        }
                    }
                }
                this.Validate();
                this.рухСтудентівBindingSource.EndEdit();
                this.tableAdapterManager1.UpdateAll(this.spusok_ychnivDataSet);
                this.рух_студентівTableAdapter.Fill(this.spusok_ychnivDataSet.Рух_студентів);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Nakaz_zmina_stany(17, "Завершив навчання");

        }

        private void button15_Click(object sender, EventArgs e)
        {
            Nakaz_zmina_stany(26, "Відраховано");////!!!!!!!!!!
        }

        private void button14_Click(object sender, EventArgs e)
        {
            add(18);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            add(19);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            add(20);
        }

        private void Form8_SizeChanged(object sender, EventArgs e)
        {
            dataGridView1.Height=this.Height * 3/4;
            checkedListBox1.Height= this.Height * 3 / 4;
        }
        private void button23_Click(object sender, EventArgs e)
        {
            try
            {
                if (рухСтудентівBindingSource.Filter == null)
            {
                рухСтудентівBindingSource.Filter += "[хлопець/дівчина] like '" + comboBox3.Text + "'";
            }
            else
            {
                рухСтудентівBindingSource.Filter += " And [хлопець/дівчина] like '" + comboBox3.Text + "'";
            }
           checkedListBox1.Items.Clear();
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        var cellValue = row.Cells[4].Value;
                        if (cellValue != null)
                        {
                            checkedListBox1.Items.Add(cellValue.ToString());
                        }
                    }
                }
            }
            catch (Exception q)
            {
                richTextBox1.Text += q.Message + "\n";
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            try
            {
                if (рухСтудентівBindingSource.Filter == null)
                {
                    рухСтудентівBindingSource.Filter += "[Рік вступу] = " + Convert.ToInt32(comboBox6.Text) + "";
                }
                else
                {
                    рухСтудентівBindingSource.Filter += " And [Рік вступу] = " + Convert.ToInt32(comboBox6.Text) + "";
                }
                checkedListBox1.Items.Clear();
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        var cellValue = row.Cells[4].Value;
                        if (cellValue != null)
                        {
                            checkedListBox1.Items.Add(cellValue.ToString());
                        }
                    }
                }

            }
            catch (Exception q)
            {
                richTextBox1.Text += q.Message + "\n";
            }
        }
      
        private void button22_Click(object sender, EventArgs e)
        {
            try
            {
                if (рухСтудентівBindingSource.Filter == null)
                {
                    рухСтудентівBindingSource.Filter += "[на базі 9 класів/11 класів] = " + comboBox4.Text + "";
                }
                else
                {
                    рухСтудентівBindingSource.Filter += " And [на базі 9 класів/11 класів] = " + comboBox4.Text + "";
                }
                checkedListBox1.Items.Clear();
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        var cellValue = row.Cells[4].Value;
                        if (cellValue != null)
                        {
                            checkedListBox1.Items.Add(cellValue.ToString());
                        }
                    }
                }

            }
            catch (Exception q)
            {
                richTextBox1.Text += q.Message + "\n";
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                группиBindingSource.Filter = "[Спеціальність] like '%" + spusok_ychnivDataSet.Спеціальності[comboBox2.SelectedIndex].Буква.ToString() + "%'";
                comboBox5.Items.Clear();
                HashSet<string> uniqueValues = new HashSet<string>();
                for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
                {
                    DataGridViewRow row = dataGridView2.Rows[i];
                    string cellValue = row.Cells["спеціальністьDataGridViewTextBoxColumn1"].Value.ToString() + " " + row.Cells["номерDataGridViewTextBoxColumn"].Value.ToString();
                    uniqueValues.Add(cellValue);
                }
                foreach (string value in uniqueValues)
                {
                    comboBox5.Items.Add(value);
                }

            }
            catch (Exception q)
            {

                richTextBox1.Text += q + "\n";
            }
        }
        private BindingSource secondComboBoxBindingSource = new BindingSource();
        private void button25_Click(object sender, EventArgs e)
        {
            string filePath = Path.Combine(System.Windows.Forms.Application.StartupPath, "Example.xlsx");

            XLWorkbook workbook = new XLWorkbook(filePath);

            IXLWorksheet sourceWorksheet = workbook.Worksheet("Example");
            IXLWorksheet newWorksheet = sourceWorksheet.CopyTo(dateTimePicker1.Value.ToShortDateString());

                // Змінюємо назву нового листа
                newWorksheet.Name = dateTimePicker1.Value.ToShortDateString();
                int b9 = 0, k9 = 0, b11 = 0, k11 = 0, x = 0, specialnist=10;
                foreach (var item in comboBox2.Items)
                {
                string filterValue = item.ToString();
                filterValue = filterValue.Replace("'", "''");
                рухСтудентівBindingSource.Filter = "Спеціальність like '%" + filterValue + "%'";
                    группиBindingSource.Filter = "[Спеціальність] like '%" + spusok_ychnivDataSet.Спеціальності[x].Буква.ToString() + "%'";
                    comboBox5.Items.Clear();

                   

                    for (int kurs = 1; kurs < 4; kurs++)
                    {
                        int columnIndex = 4;
                        группиBindingSource.Filter = "[Спеціальність] like '%" + spusok_ychnivDataSet.Спеціальності[x].Буква.ToString() + "%'";
                        comboBox5.Items.Clear();
                        HashSet<string> uniqueValues = new HashSet<string>();
                        for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                        {
                            DataGridViewRow row = dataGridView1.Rows[i];
                            string cellValue = row.Cells["групаDataGridViewTextBoxColumn"].Value.ToString();
                            uniqueValues.Add(cellValue);
                        }
                        foreach (string value in uniqueValues)
                        {
                            comboBox5.Items.Add(value);
                        }
                        foreach (var group in comboBox5.Items)
                        {
                            рухСтудентівBindingSource.Filter = "Спеціальність like '%" + filterValue + "%'" + " And група like '%" + group.ToString() + "%'" + " And [Курс] = " + kurs + "";
                            for (int i = 0; i < dataGridView1.RowCount-1; i++)
                            {
                                if (dataGridView1[8, i].Value.ToString() == "б" && dataGridView1[7, i].Value.ToString() == "9")
                                {
                                    b9++;
                                }
                                else if (dataGridView1[8, i].Value.ToString() == "к" && dataGridView1[7, i].Value.ToString() == "9")
                                {
                                    k9++;
                                }
                                else if(dataGridView1[8, i].Value.ToString() == "б"  && dataGridView1[7, i].Value.ToString() == "11")
                                {
                                    b11++;
                                }
                                else if (dataGridView1[8, i].Value.ToString() == "к" && dataGridView1[7, i].Value.ToString() == "11")
                                {
                                    k11++;
                                }
                            }
                            var cellB9 = newWorksheet.Cell(specialnist + kurs, columnIndex);
                            var cellK9 = newWorksheet.Cell(specialnist + kurs, columnIndex + 1);
                            var cellB11 = newWorksheet.Cell(specialnist + kurs, columnIndex + 2);
                            var cellK11 = newWorksheet.Cell(specialnist + kurs, columnIndex + 3);

                            cellB9.Value = b9;
                            cellK9.Value = k9;
                            cellB11.Value = b11;
                            cellK11.Value = k11;
                            b9 =0; k9=0; b11 = 0; k11 = 0;
                            columnIndex += 4;

                        }
                    }
                    specialnist += 11;
                    x++;
                }
                    SaveFileDialog saveDialog = new SaveFileDialog();
                    saveDialog.Filter = "Файл Excel|*.xlsx";
                    if (saveDialog.ShowDialog() == DialogResult.OK)
                    {
                        workbook.SaveAs(saveDialog.FileName);
                        MessageBox.Show("Новий лист створений та збережений успішно!");
                    }
                
            
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button26_Click(object sender, EventArgs e)
        {
            рухСтудентівBindingSource.Filter = "Спеціальність like '%" + comboBox2.Text + "%'";
            группиBindingSource.Filter = "[Спеціальність] like '%" + spusok_ychnivDataSet.Спеціальності[comboBox2.SelectedIndex].Буква.ToString() + "%'";
            comboBox5.Items.Clear();

            HashSet<string> uniqueValues = new HashSet<string>();

            for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
            {
                DataGridViewRow row = dataGridView1.Rows[i];
                string cellValue = row.Cells["групаDataGridViewTextBoxColumn"].Value.ToString();

                // Добавление значения в HashSet
                uniqueValues.Add(cellValue);
            }

            // Добавление уникальных значений из HashSet в ComboBox
            foreach (string value in uniqueValues)
            {
                comboBox5.Items.Add(value);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Nakaz_zmina_stany(25, "Відраховано");
        }

        private void button26_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (рухСтудентівBindingSource.Filter == null)
                {
                    рухСтудентівBindingSource.Filter += "[курс] = " + comboBox8.Text;
                }
                else
                {
                    рухСтудентівBindingSource.Filter += " And [курс] = " + comboBox8.Text;
                }
                checkedListBox1.Items.Clear();
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        var cellValue = row.Cells[4].Value;
                        if (cellValue != null)
                        {
                            checkedListBox1.Items.Add(cellValue.ToString());
                        }
                    }
                }             
                comboBox5.Items.Clear();
                HashSet<string> uniqueValues = new HashSet<string>();
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    DataGridViewRow row = dataGridView1.Rows[i];
                    string cellValue = row.Cells["групаDataGridViewTextBoxColumn"].Value.ToString();
                    uniqueValues.Add(cellValue);
                }

                foreach (string value in uniqueValues)
                {
                    comboBox5.Items.Add(value);
                }
            }
            catch (Exception q)
            {
                richTextBox1.Text += q.Message + "\n";
            }
        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
