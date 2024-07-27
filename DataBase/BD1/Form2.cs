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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        
        public Catalog catalog = new Catalog();
        private void button1_Click(object sender, EventArgs e)
        {
           
            catalog.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Manufacturer manufacturer = new Manufacturer();
            manufacturer.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Vyd vyd = new Vyd();
            vyd.ShowDialog();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Type type = new Type();
            type.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Character character = new Character();
            character.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Country country = new Country();
            country.ShowDialog();
        }

        private void вхідToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vhid vhid = new Vhid();
            
            if (vhid.ShowDialog()==DialogResult.OK)
            {
                if (vhid.k == 100)
                {
                    button2.Enabled = true;
                    button3.Enabled = true;
                    button4.Enabled = true;
                    button5.Enabled = true;
                    button6.Enabled = true;
                    catalog.panel1.Enabled = true;
                    catalog.panel2.Enabled = true;
                    вхідToolStripMenuItem.Visible = false;
                    виходToolStripMenuItem.Visible = true;
                    catalog.каталог_косметичних_товарівBindingNavigator.Enabled = true;
                }
                else
                {
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    catalog.panel1.Enabled = false;
                    catalog.panel2.Enabled = true;
                    вхідToolStripMenuItem.Visible = false;
                    виходToolStripMenuItem.Visible = true;
                    catalog.каталог_косметичних_товарівBindingNavigator.Enabled = false;
                }
            }
            else
            {
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                catalog.panel1.Enabled = false;
                catalog.panel2.Enabled = false;
                вхідToolStripMenuItem.Visible = true;
                виходToolStripMenuItem.Visible =false;
                catalog.каталог_косметичних_товарівBindingNavigator.Enabled = false;
            }
        }

        private void виходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            catalog.panel1.Enabled = false;
            catalog.panel2.Enabled = false;
            вхідToolStripMenuItem.Visible = true;
            виходToolStripMenuItem.Visible = false;
        }
    }
}
