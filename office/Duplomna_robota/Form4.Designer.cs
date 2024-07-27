namespace Duplomna_robota
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.кодDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.джерелоФінансуванняDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.джерелоФінансуванняBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spusok_ychnivDataSet = new Duplomna_robota.Spusok_ychnivDataSet();
            this.джерело_фінансуванняTableAdapter = new Duplomna_robota.Spusok_ychnivDataSetTableAdapters.Джерело_фінансуванняTableAdapter();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tableAdapterManager1 = new Duplomna_robota.Spusok_ychnivDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.джерелоФінансуванняBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spusok_ychnivDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодDataGridViewTextBoxColumn,
            this.джерелоФінансуванняDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.джерелоФінансуванняBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(247, 198);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // кодDataGridViewTextBoxColumn
            // 
            this.кодDataGridViewTextBoxColumn.DataPropertyName = "Код";
            this.кодDataGridViewTextBoxColumn.HeaderText = "Код";
            this.кодDataGridViewTextBoxColumn.Name = "кодDataGridViewTextBoxColumn";
            // 
            // джерелоФінансуванняDataGridViewTextBoxColumn
            // 
            this.джерелоФінансуванняDataGridViewTextBoxColumn.DataPropertyName = "Джерело фінансування";
            this.джерелоФінансуванняDataGridViewTextBoxColumn.HeaderText = "Джерело фінансування";
            this.джерелоФінансуванняDataGridViewTextBoxColumn.Name = "джерелоФінансуванняDataGridViewTextBoxColumn";
            // 
            // джерелоФінансуванняBindingSource
            // 
            this.джерелоФінансуванняBindingSource.DataMember = "Джерело фінансування";
            this.джерелоФінансуванняBindingSource.DataSource = this.spusok_ychnivDataSet;
            // 
            // spusok_ychnivDataSet
            // 
            this.spusok_ychnivDataSet.DataSetName = "Spusok_ychnivDataSet";
            this.spusok_ychnivDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // джерело_фінансуванняTableAdapter
            // 
            this.джерело_фінансуванняTableAdapter.ClearBeforeFill = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(173, 243);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 59;
            this.button3.Text = "Редагувати";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(93, 242);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 58;
            this.button2.Text = "Видалити";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 243);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 57;
            this.button1.Text = "Додати";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 216);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 55;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.UpdateOrder = Duplomna_robota.Spusok_ychnivDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.БазаTableAdapter = null;
            this.tableAdapterManager1.ГруппиTableAdapter = null;
            this.tableAdapterManager1.Джерело_фінансуванняTableAdapter = this.джерело_фінансуванняTableAdapter;
            this.tableAdapterManager1.Рух_студентівTableAdapter = null;
            this.tableAdapterManager1.СпеціальностіTableAdapter = null;
            this.tableAdapterManager1.СтатьTableAdapter = null;
            this.tableAdapterManager1.УчніTableAdapter = null;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.джерелоФінансуванняBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spusok_ychnivDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Spusok_ychnivDataSet spusok_ychnivDataSet;
        private System.Windows.Forms.BindingSource джерелоФінансуванняBindingSource;
        private Spusok_ychnivDataSetTableAdapters.Джерело_фінансуванняTableAdapter джерело_фінансуванняTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn джерелоФінансуванняDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private Spusok_ychnivDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
    }
}