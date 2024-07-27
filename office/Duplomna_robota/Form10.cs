using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
using System.IO;

using System.Runtime.InteropServices;
using System.Threading;

namespace Duplomna_robota
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "spusok_ychnivDataSet.Спеціальності". При необходимости она может быть перемещена или удалена.
            this.спеціальностіTableAdapter.Fill(this.spusok_ychnivDataSet.Спеціальності);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "spusok_ychnivDataSet.Группи". При необходимости она может быть перемещена или удалена.
            this.группиTableAdapter.Fill(this.spusok_ychnivDataSet.Группи);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "spusok_ychnivDataSet.База". При необходимости она может быть перемещена или удалена.
            this.базаTableAdapter.Fill(this.spusok_ychnivDataSet.База);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "spusok_ychnivDataSet.Рух_студентів". При необходимости она может быть перемещена или удалена.
            this.рух_студентівTableAdapter.Fill(this.spusok_ychnivDataSet.Рух_студентів);
            for (int i = 0; i < spusok_ychnivDataSet.Группи.Count; i++)
            {
                comboBox1.Items.Add(spusok_ychnivDataSet.Группи[i].Спеціальність.ToString() + "-" + spusok_ychnivDataSet.Группи[i].Номер.ToString());
            }
        }
        Word.Application word;
        Word.Document doc;
        Word.Range r;
        FileInfo fi;
        public void need()
        {
            Object wrap = Word.WdFindWrap.wdFindContinue;
            Object replace = Word.WdReplace.wdReplaceAll;
            find.Execute(FindText: Type.Missing,
                MatchCase: false,
                MatchWholeWord: false,
                MatchWildcards: false,
                MatchSoundsLike: missing,
                MatchAllWordForms: false,
                Forward: true,
                Wrap: wrap,
                Format: false,
                ReplaceWith: missing, Replace: replace);
        }
        string fn = "";
        Word.Find find;
        Object missing;
        Word.Range range;
        Word.Table table;
        Word.Selection currentSelection;
        private void button4_Click(object sender, EventArgs e)
        {

            try
            {
                fn = "";
                fi = new FileInfo(Path.GetDirectoryName(Application.ExecutablePath) + "ВІДОМІСТЬ_П_бігунок_складання_академ_заборгованості_більше_1_особи — копия (2).doc");
                word = new Word.Application();
                //word.Documents.Close();
                //word.Visible = true;
                Object file = fi.FullName;
                missing = Type.Missing;

                //
                doc = word.Documents.Open(file);
                //word.Visible = true;
                currentSelection = word.Application.Selection;

                find = word.Selection.Find;
                find.Text = "<Word1>";
                find.Replacement.Text = textBox1.Text;
                need();
                find.Text = "<Word2>";
                find.Replacement.Text = textBox2.Text;
                need();
                find.Text = "<Word3>";
                find.Replacement.Text = textBox4.Text;
                need();
                find.Text = "<Word4>";
                find.Replacement.Text = textBox5.Text;
                need();
                find.Text = "<Word5>";
                if (comboBox2.Text == "1")
                {
                    find.Replacement.Text = "I";
                }
                else if (comboBox2.Text == "2")
                {
                    find.Replacement.Text = "II";
                }
                else if (comboBox2.Text == "3")
                {
                    find.Replacement.Text = "III";
                }
                else if (comboBox2.Text == "4")
                {
                    find.Replacement.Text = "IV";
                }
                need();
                find.Text = "<Word6>";
                find.Replacement.Text = comboBox1.Text;
                need();
                find.Text = "<Word7>";
                find.Replacement.Text = textBox8.Text;
                need();
                find.Text = "<Word8>";
                find.Replacement.Text = textBox3.Text;
                need();
                find.Text = "<Word9>";
                find.Replacement.Text = textBox9.Text;
                need();
                find.Text = "<Word10>";
                find.Replacement.Text = textBox20.Text;
                need();
                find.Text = "<Word11>";
                find.Replacement.Text = textBox21.Text;
                need();
                find.Text = "<Word12>";
                find.Replacement.Text = textBox11.Text;
                need();
                find.Text = "<d>";
                find.Replacement.Text = textBox15.Text;
                need();
                find.Text = "<Word13>";
                find.Replacement.Text = textBox16.Text;
                need();
                find.Text = "<d1>";
                find.Replacement.Text = textBox17.Text;
                need();
                find.Text = "<Word14>";
                find.Replacement.Text = textBox18.Text;
                need();
                find.Text = "<Word17>";
                find.Replacement.Text = textBox10.Text;
                need();
                find.Text = "<Word18>";
                find.Replacement.Text = textBox19.Text;
                need();
                find.Text = "<Word19>";
                find.Replacement.Text = " ";
                need();
                find.Text = "Table";
                bool found = find.Execute();

                if (found)
                {
                    // Переход к концу найденного слова
                    currentSelection.MoveEndUntil(" ", Word.WdMovementType.wdMove);
                    currentSelection.MoveRight();

                    // Вставка таблицы
                    range = currentSelection.Range;
                    table = doc.Tables.Add(range, dataGridView4.Rows.Count + 2, 7);
                    table.Borders.InsideLineStyle = Word.WdLineStyle.wdLineStyleSingle;
                    table.Borders.OutsideLineStyle = Word.WdLineStyle.wdLineStyleSingle;

                    table.Columns[1].Width = 25f;
                    table.Columns[2].Width = 185f;
                    table.Columns[3].Width = 95f;
                    table.Columns[4].Width = 57f;
                    table.Columns[5].Width = 57f;
                    table.Columns[6].Width = 57f;
                    table.Columns[7].Width = 55f;
                    // Заполнение заголовков столбцов и данных в таблице
                    table.Cell(1, 1).Range.Text = "№ з/п";
                    table.Cell(2, 1).Merge(table.Cell(1, 1));
                    table.Cell(1, 2).Range.Text = "Прізвище, ім’я,по батькові здобувача освіти";
                    table.Cell(2, 2).Merge(table.Cell(1, 2));
                    table.Cell(1, 3).Range.Text = "№ індивідуального навчального плану";

                    table.Cell(1, 4).Range.Text = "Оцінка";
                    table.Cell(1, 7).Range.Text = "Підпис викладача";
                    table.Cell(2, 7).Merge(table.Cell(1, 7));
                    table.Cell(2, 3).Merge(table.Cell(1, 3));
                    table.Cell(1, 4).Merge(table.Cell(1, 5));
                    table.Cell(1, 4).Merge(table.Cell(1, 5));
                    // Выделение заголовков жирным шрифтом
                    table.Cell(1, 1).Range.Bold = 1;
                    table.Cell(1, 2).Range.Bold = 1;
                    table.Cell(1, 3).Range.Bold = 1;
                    table.Cell(1, 4).Range.Bold = 1;
                    table.Cell(1, 5).Range.Bold = 1;
                    table.Cell(2, 4).Range.Font.Size = 7;
                    table.Cell(2, 5).Range.Font.Size = 7;
                    table.Cell(2, 6).Range.Font.Size = 7;
                    table.Cell(2, 4).Range.Text = "за національною/12-бальною шкалою";
                    table.Cell(2, 5).Range.Text = "за 100 бальною шкалою";
                    table.Cell(2, 6).Range.Text = "ECTS(літера)";
                    table.Cell(2, 4).Range.Bold = 1;
                    table.Cell(2, 5).Range.Bold = 1;
                    table.Cell(2, 6).Range.Bold = 1;
                    table.Cell(1, 1).VerticalAlignment = Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;
                    table.Cell(1, 2).VerticalAlignment = Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;
                    table.Cell(1, 3).VerticalAlignment = Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;
                    table.Cell(1, 4).VerticalAlignment = Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;
                    table.Cell(1, 5).VerticalAlignment = Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;

                    table.Cell(1, 1).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                    table.Cell(1, 2).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                    table.Cell(1, 3).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                    table.Cell(1, 4).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                    table.Cell(1, 5).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;

                    table.Cell(2, 4).VerticalAlignment = Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;
                    table.Cell(2, 5).VerticalAlignment = Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;
                    table.Cell(2, 6).VerticalAlignment = Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;

                    table.Cell(2, 4).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                    table.Cell(2, 5).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                    table.Cell(2, 6).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                    for (int i = 3; i < dataGridView4.Rows.Count + 2; i++)
                    {
                        table.Cell(i, 1).Range.Text = dataGridView4.Rows[i - 3].Cells[0].Value.ToString();
                        table.Cell(i, 2).Range.Text = dataGridView4.Rows[i - 3].Cells[1].Value.ToString();
                        table.Cell(i, 3).Range.Text = dataGridView4.Rows[i - 3].Cells[2].Value.ToString();
                        table.Cell(i, 4).Range.Text = dataGridView4.Rows[i - 3].Cells[3].Value.ToString();
                        table.Cell(i, 5).Range.Text = dataGridView4.Rows[i - 3].Cells[4].Value.ToString();
                        table.Cell(i, 6).Range.Text = dataGridView4.Rows[i - 3].Cells[5].Value.ToString();
                        table.Cell(i, 7).Range.Text = dataGridView4.Rows[i - 3].Cells[6].Value.ToString();
                        //table.Cell(i, 1).VerticalAlignment = Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;
                        //table.Cell(i, 1).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                        //table.Cell(i, 2).VerticalAlignment = Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;
                        //table.Cell(i, 2).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                        //table.Cell(i, 3).VerticalAlignment = Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;
                        //table.Cell(i, 3).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                        //table.Cell(i, 1).VerticalAlignment = Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;
                        //table.Cell(i, 1).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                        //table.Cell(i, 1).VerticalAlignment = Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;
                        //table.Cell(i, 1).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                        //table.Cell(i, 1).VerticalAlignment = Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;
                        //table.Cell(i, 1).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                    }


                    find.Text = "Table";
                    find.Replacement.Text = " ";
                    need();
                    // Установка ориентации страницы на горизонтальную

                    // Object newFileName = Path.Combine(fi.DirectoryName, "1" + fi.Name);
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        fn = saveFileDialog1.FileName + ".doc";
                        word.ActiveDocument.SaveAs2(saveFileDialog1.FileName + ".doc");
                    }
                    else
                    {

                        //word.Documents.Save(false);
                        // word.Documents.Close();
                    }
                    // word.ActiveDocument.SaveAs2(newFileName);


                    //word.Documents.Close();
                }
                else
                {
                    // Если слово "word" не найдено, выполните действия по вашему усмотрению
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                if (fn == "")
                {
                    word.ActiveDocument.SaveAs2((Path.GetDirectoryName(Application.ExecutablePath) + "2.doc"));
                    word.Quit();
                    word = null;
                    doc = null;
                    Thread.Sleep(200);
                    File.Delete((Path.GetDirectoryName(Application.ExecutablePath) + "2.doc"));

                }
                else
                {
                    word.Quit();
                }
                //word.Documents.Save(false);

                word = null;
                doc = null;
            }
            finally
            {

                if (fn == "")
                {
                    word.ActiveDocument.SaveAs2((Path.GetDirectoryName(Application.ExecutablePath) + "2.doc"));
                    word.Quit();
                    word = null;
                    doc = null;
                    Thread.Sleep(200);
                    File.Delete((Path.GetDirectoryName(Application.ExecutablePath) + "2.doc"));

                }
                else
                {
                    word.Quit();
                }

                word = null;
                doc = null;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            группиBindingSource.Filter = "[курс] = " + comboBox2.Text;
            comboBox1.Items.Clear();

            for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
            {

                DataGridViewRow row = dataGridView2.Rows[i];

                comboBox1.Items.Add(row.Cells["спеціальністьDataGridViewTextBoxColumn"].Value.ToString() + "-" + row.Cells["номерDataGridViewTextBoxColumn"].Value.ToString());

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string s = comboBox1.Text[0].ToString();

            спеціальностіBindingSource.Filter = "[Буква] like '%" + s + "%'";
            textBox1.Text = dataGridView3.Rows[0].Cells[3].Value.ToString();
            textBox2.Text = dataGridView3.Rows[0].Cells[4].Value.ToString();
            textBox4.Text = dataGridView3.Rows[0].Cells[1].Value.ToString();
            textBox5.Text = dataGridView3.Rows[0].Cells[5].Value.ToString();
            рухСтудентівBindingSource.Filter = "група like '%" + comboBox1.Text + "%'";
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                int b = i;
                b++;
                dataGridView4.Rows.Add();
                dataGridView4.Rows[i].Cells[0].Value = b.ToString();
                dataGridView4.Rows[i].Cells[1].Value = dataGridView1.Rows[i].Cells[2].Value;
                dataGridView4.Rows[i].Cells[2].Value = dataGridView1.Rows[i].Cells[3].Value;
                dataGridView4.Rows[i].Cells[3].Value = "";
                dataGridView4.Rows[i].Cells[4].Value = "";
                dataGridView4.Rows[i].Cells[5].Value = "";
                dataGridView4.Rows[i].Cells[6].Value = "";

            }
        }
    }
}
