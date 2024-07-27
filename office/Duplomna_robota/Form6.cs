using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Text.RegularExpressions;
using ClosedXML.Excel;
using Microsoft.Office.Interop.Excel;
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml.Office2016.Excel;

namespace Duplomna_robota
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        public int baza, kyrs;
        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "spusok_ychnivDataSet.Джерело_фінансування". При необходимости она может быть перемещена или удалена.
            this.джерело_фінансуванняTableAdapter.Fill(this.spusok_ychnivDataSet.Джерело_фінансування);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "spusok_ychnivDataSet.База". При необходимости она может быть перемещена или удалена.
            this.базаTableAdapter.Fill(this.spusok_ychnivDataSet.База);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "spusok_ychnivDataSet.Стать". При необходимости она может быть перемещена или удалена.
            this.статьTableAdapter.Fill(this.spusok_ychnivDataSet.Стать);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "spusok_ychnivDataSet.Группи". При необходимости она может быть перемещена или удалена.
            this.группиTableAdapter.Fill(this.spusok_ychnivDataSet.Группи);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "spusok_ychnivDataSet.Спеціальності". При необходимости она может быть перемещена или удалена.
            this.спеціальностіTableAdapter.Fill(this.spusok_ychnivDataSet.Спеціальності);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "spusok_ychnivDataSet.Рух_студентів". При необходимости она может быть перемещена или удалена.
            this.рух_студентівTableAdapter.Fill(this.spusok_ychnivDataSet.Рух_студентів);
            dateTimePicker2.Value = DateTime.Now;
            textBox2.Select();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form8 d = new Form8();
            d.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kod = dataGridView2.RowCount + 8;
            try
            {
                richTextBox1.Text += comboBox2.Text + "\n";               
                DataRow drr = spusok_ychnivDataSet.Рух_студентів.NewRow();
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
                drr[6] = comboBox3.Text;
                drr[7] = baza;
                drr[8] = comboBox5.Text;
                drr[21] = kyrs;
                drr[22] = "Навчається";
                drr[24] = textBox4.Text;
                spusok_ychnivDataSet.Рух_студентів.Rows.Add(drr);
                this.Validate();
                this.рухСтудентівBindingSource.EndEdit();
                this.tableAdapterManager1.UpdateAll(this.spusok_ychnivDataSet);
                this.рух_студентівTableAdapter.Fill(this.spusok_ychnivDataSet.Рух_студентів);
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

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            { textBox1.Select(); }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            { textBox3.Select(); }
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            { textBox6.Select(); }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                группиBindingSource.Filter = "[Спеціальність] like '%" + spusok_ychnivDataSet.Спеціальності[comboBox1.SelectedIndex].Буква.ToString() + "%'" + " And [Курс] = " + kyrs + ""; ;
                comboBox2.Items.Clear();
                HashSet<string> uniqueValues = new HashSet<string>();
                for (int i = 0; i < dataGridView3.Rows.Count - 1; i++)
                {
                    DataGridViewRow row = dataGridView3.Rows[i];
                    string cellValue = row.Cells["спеціальністьDataGridViewTextBoxColumn1"].Value.ToString()+"-"+ row.Cells["номерDataGridViewTextBoxColumn"].Value.ToString();
                    uniqueValues.Add(cellValue);
                }
                foreach (string value in uniqueValues)
                {
                    comboBox2.Items.Add(value);
                }

            }
            catch (Exception q)
            {

                    richTextBox1.Text+=q + "\n";
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Файлы Excel|*.xlsx;*.xls";
                openFileDialog.Title = "Выберите файл Excel";

                // Показываем диалоговое окно и проверяем результат выбора файла
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Создаем экземпляр приложения Excel
                    Excel.Application excelApp = new Excel.Application();

                    // Открываем книгу Excel
                    Excel.Workbook workbook = excelApp.Workbooks.Open(openFileDialog.FileName);

                    // Получаем ссылку на лист в книге Excel
                    Excel.Worksheet worksheet = workbook.Sheets[1]; // Индекс листа (1 для первого листа)
                    for (int i = 6; i < 50; i++)
                    {
                          DataRow drr = spusok_ychnivDataSet.Рух_студентів.NewRow();
                          drr[0] = dataGridView2.RowCount + 8;
                          drr[1] = Regex.Replace(worksheet.Cells[i, 1].Value.ToString(), @"[^0-9]", "");
                          drr[2] = worksheet.Cells[i, 2].Value.ToString();
                          drr[3] = worksheet.Cells[i, 3].Value.ToString();
                          drr[4] = worksheet.Cells[i, 4].Value.ToString();
                          drr[5] = worksheet.Cells[i, 5].Value.ToString();
                          drr[6] = worksheet.Cells[i, 6].Value.ToString();
                          drr[7] = worksheet.Cells[i, 7].Value.ToString();
                          drr[8] = worksheet.Cells[i, 8].Value.ToString();
                        if (worksheet.Cells[i, 9].Value != null)
                            drr[9] = worksheet.Cells[i, 9].Value.ToString();
                        if (worksheet.Cells[i, 10].Value != null)
                            drr[10] = worksheet.Cells[i, 10].Value.ToString();
                        if (worksheet.Cells[i, 11].Value != null)
                            drr[11] = worksheet.Cells[i, 11].Value.ToString();
                        if (worksheet.Cells[i, 12].Value != null)
                            drr[12] = worksheet.Cells[i, 12].Value.ToString();
                        if (worksheet.Cells[i, 13].Value != null)
                            drr[13] = worksheet.Cells[i, 13].Value.ToString();
                        if (worksheet.Cells[i, 14].Value != null)
                            drr[14] = worksheet.Cells[i, 14].Value.ToString();
                        if (worksheet.Cells[i, 15].Value != null)
                            drr[15] = worksheet.Cells[i, 15].Value.ToString();
                        if (worksheet.Cells[i, 16].Value != null)
                            drr[16] = worksheet.Cells[i, 16].Value.ToString();
                        if (worksheet.Cells[i, 17].Value != null)
                            drr[17] = worksheet.Cells[i, 17].Value.ToString();
                        if (worksheet.Cells[i, 18].Value != null)
                            drr[18] = worksheet.Cells[i, 18].Value.ToString();
                        if (worksheet.Cells[i, 19].Value != null)
                            drr[19] = worksheet.Cells[i, 19].Value.ToString();
                        if (worksheet.Cells[i, 20].Value != null)
                            drr[20] = worksheet.Cells[i, 20].Value.ToString();
                        drr[21] = worksheet.Cells[i, 25].Value.ToString();
                          drr[22] = "Навчається";
                        spusok_ychnivDataSet.Рух_студентів.Rows.Add(drr);
                        this.Validate();
                        this.рухСтудентівBindingSource.EndEdit();
                        this.tableAdapterManager1.UpdateAll(this.spusok_ychnivDataSet);
                        this.рух_студентівTableAdapter.Fill(this.spusok_ychnivDataSet.Рух_студентів);

                    }


                    // Закрываем книгу Excel
                    workbook.Close();

                    // Завершаем работу приложения Excel
                    excelApp.Quit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());  
            }
        }
        
    }
}

