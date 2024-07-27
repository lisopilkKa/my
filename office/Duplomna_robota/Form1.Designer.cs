namespace Duplomna_robota
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.іншеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.базаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.группиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.джерелоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.спеціальністьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.spusok_ychnivDataSet = new Duplomna_robota.Spusok_ychnivDataSet();
            this.рухСтудентівBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.рух_студентівTableAdapter = new Duplomna_robota.Spusok_ychnivDataSetTableAdapters.Рух_студентівTableAdapter();
            this.спеціальностіBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.группиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.статьBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.базаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.джерелоФінансуванняBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.спеціальностіTableAdapter = new Duplomna_robota.Spusok_ychnivDataSetTableAdapters.СпеціальностіTableAdapter();
            this.tableAdapterManager1 = new Duplomna_robota.Spusok_ychnivDataSetTableAdapters.TableAdapterManager();
            this.базаTableAdapter = new Duplomna_robota.Spusok_ychnivDataSetTableAdapters.БазаTableAdapter();
            this.группиTableAdapter = new Duplomna_robota.Spusok_ychnivDataSetTableAdapters.ГруппиTableAdapter();
            this.статьTableAdapter = new Duplomna_robota.Spusok_ychnivDataSetTableAdapters.СтатьTableAdapter();
            this.учніTableAdapter = new Duplomna_robota.Spusok_ychnivDataSetTableAdapters.УчніTableAdapter();
            this.джерело_фінансуванняTableAdapter = new Duplomna_robota.Spusok_ychnivDataSetTableAdapters.Джерело_фінансуванняTableAdapter();
            this.учніBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spusok_ychnivDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.рухСтудентівBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.спеціальностіBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.группиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.статьBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.базаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.джерелоФінансуванняBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.учніBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(48, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 45);
            this.button1.TabIndex = 10;
            this.button1.Text = "Зарахувати на перший курс";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.іншеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(279, 24);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // іншеToolStripMenuItem
            // 
            this.іншеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.базаToolStripMenuItem,
            this.группиToolStripMenuItem,
            this.джерелоToolStripMenuItem,
            this.спеціальністьToolStripMenuItem});
            this.іншеToolStripMenuItem.Name = "іншеToolStripMenuItem";
            this.іншеToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.іншеToolStripMenuItem.Text = "Інше";
            this.іншеToolStripMenuItem.Click += new System.EventHandler(this.іншеToolStripMenuItem_Click);
            // 
            // базаToolStripMenuItem
            // 
            this.базаToolStripMenuItem.Name = "базаToolStripMenuItem";
            this.базаToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.базаToolStripMenuItem.Text = "База";
            this.базаToolStripMenuItem.Click += new System.EventHandler(this.базаToolStripMenuItem_Click);
            // 
            // группиToolStripMenuItem
            // 
            this.группиToolStripMenuItem.Name = "группиToolStripMenuItem";
            this.группиToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.группиToolStripMenuItem.Text = "Группи";
            this.группиToolStripMenuItem.Click += new System.EventHandler(this.группиToolStripMenuItem_Click);
            // 
            // джерелоToolStripMenuItem
            // 
            this.джерелоToolStripMenuItem.Name = "джерелоToolStripMenuItem";
            this.джерелоToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.джерелоToolStripMenuItem.Text = "Джерело";
            this.джерелоToolStripMenuItem.Click += new System.EventHandler(this.джерелоToolStripMenuItem_Click);
            // 
            // спеціальністьToolStripMenuItem
            // 
            this.спеціальністьToolStripMenuItem.Name = "спеціальністьToolStripMenuItem";
            this.спеціальністьToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.спеціальністьToolStripMenuItem.Text = "Спеціальність";
            this.спеціальністьToolStripMenuItem.Click += new System.EventHandler(this.спеціальністьToolStripMenuItem_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(48, 158);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(183, 45);
            this.button3.TabIndex = 32;
            this.button3.Text = "Карта руху";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(48, 107);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(183, 45);
            this.button2.TabIndex = 34;
            this.button2.Text = "Зарахувати на другий курс";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // spusok_ychnivDataSet
            // 
            this.spusok_ychnivDataSet.DataSetName = "Spusok_ychnivDataSet";
            this.spusok_ychnivDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // рухСтудентівBindingSource
            // 
            this.рухСтудентівBindingSource.DataMember = "Рух студентів";
            this.рухСтудентівBindingSource.DataSource = this.spusok_ychnivDataSet;
            // 
            // рух_студентівTableAdapter
            // 
            this.рух_студентівTableAdapter.ClearBeforeFill = true;
            // 
            // спеціальностіBindingSource
            // 
            this.спеціальностіBindingSource.DataMember = "Спеціальності";
            this.спеціальностіBindingSource.DataSource = this.spusok_ychnivDataSet;
            // 
            // группиBindingSource
            // 
            this.группиBindingSource.DataMember = "Группи";
            this.группиBindingSource.DataSource = this.spusok_ychnivDataSet;
            // 
            // статьBindingSource
            // 
            this.статьBindingSource.DataMember = "Стать";
            this.статьBindingSource.DataSource = this.spusok_ychnivDataSet;
            // 
            // базаBindingSource
            // 
            this.базаBindingSource.DataMember = "База";
            this.базаBindingSource.DataSource = this.spusok_ychnivDataSet;
            // 
            // джерелоФінансуванняBindingSource
            // 
            this.джерелоФінансуванняBindingSource.DataMember = "Джерело фінансування";
            this.джерелоФінансуванняBindingSource.DataSource = this.spusok_ychnivDataSet;
            // 
            // спеціальностіTableAdapter
            // 
            this.спеціальностіTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.UpdateOrder = Duplomna_robota.Spusok_ychnivDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.БазаTableAdapter = this.базаTableAdapter;
            this.tableAdapterManager1.ГруппиTableAdapter = this.группиTableAdapter;
            this.tableAdapterManager1.Джерело_фінансуванняTableAdapter = null;
            this.tableAdapterManager1.Рух_студентівTableAdapter = this.рух_студентівTableAdapter;
            this.tableAdapterManager1.СпеціальностіTableAdapter = this.спеціальностіTableAdapter;
            this.tableAdapterManager1.СтатьTableAdapter = this.статьTableAdapter;
            this.tableAdapterManager1.УчніTableAdapter = this.учніTableAdapter;
            // 
            // базаTableAdapter
            // 
            this.базаTableAdapter.ClearBeforeFill = true;
            // 
            // группиTableAdapter
            // 
            this.группиTableAdapter.ClearBeforeFill = true;
            // 
            // статьTableAdapter
            // 
            this.статьTableAdapter.ClearBeforeFill = true;
            // 
            // учніTableAdapter
            // 
            this.учніTableAdapter.ClearBeforeFill = true;
            // 
            // джерело_фінансуванняTableAdapter
            // 
            this.джерело_фінансуванняTableAdapter.ClearBeforeFill = true;
            // 
            // учніBindingSource
            // 
            this.учніBindingSource.DataMember = "Учні";
            this.учніBindingSource.DataSource = this.spusok_ychnivDataSet;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(32, 222);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(69, 69);
            this.button4.TabIndex = 35;
            this.button4.Text = "Аркуш успішності";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(107, 222);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(69, 69);
            this.button5.TabIndex = 36;
            this.button5.Text = "Відомість обліку успішності";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(182, 222);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(69, 69);
            this.button6.TabIndex = 37;
            this.button6.Text = "Заліково-екзаменаційна домість";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 329);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spusok_ychnivDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.рухСтудентівBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.спеціальностіBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.группиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.статьBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.базаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.джерелоФінансуванняBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.учніBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Spusok_ychnivDataSet spusok_ychnivDataSet;
        private System.Windows.Forms.BindingSource рухСтудентівBindingSource;
        private Spusok_ychnivDataSetTableAdapters.Рух_студентівTableAdapter рух_студентівTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem іншеToolStripMenuItem;
        private System.Windows.Forms.BindingSource спеціальностіBindingSource;
        private Spusok_ychnivDataSetTableAdapters.СпеціальностіTableAdapter спеціальностіTableAdapter;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Spusok_ychnivDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private Spusok_ychnivDataSetTableAdapters.ГруппиTableAdapter группиTableAdapter;
        private System.Windows.Forms.BindingSource группиBindingSource;
        private Spusok_ychnivDataSetTableAdapters.СтатьTableAdapter статьTableAdapter;
        private System.Windows.Forms.BindingSource статьBindingSource;
        private Spusok_ychnivDataSetTableAdapters.БазаTableAdapter базаTableAdapter;
        private System.Windows.Forms.BindingSource базаBindingSource;
        private System.Windows.Forms.ToolStripMenuItem группиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem джерелоToolStripMenuItem;
        private System.Windows.Forms.BindingSource джерелоФінансуванняBindingSource;
        private Spusok_ychnivDataSetTableAdapters.Джерело_фінансуванняTableAdapter джерело_фінансуванняTableAdapter;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ToolStripMenuItem спеціальністьToolStripMenuItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStripMenuItem базаToolStripMenuItem;
        private Spusok_ychnivDataSetTableAdapters.УчніTableAdapter учніTableAdapter;
        private System.Windows.Forms.BindingSource учніBindingSource;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}

