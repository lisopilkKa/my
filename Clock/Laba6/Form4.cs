using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba6
{
    public partial class Form4 : Form
    {
        public static int j = 15000;
        public  static int o = 15000;
        public Form4(int t)
        {
            Form2 p = new Form2();
            InitializeComponent();
            
            label1.Text = "Level: 1";
            j = t;
            if (j==15000)
            {
                label1.Text = "Level: 1";
                button2.Enabled = true;
                button3.Enabled = true;
                button1.Enabled = false;
            }
            else if (j==10000)
            {
                label1.Text = "Level: 2";
                button2.Enabled = false;
                button3.Enabled = true;
                button1.Enabled = true;
            }
            else if (j==5000)
            {
                label1.Text = "Level: 3";
                button2.Enabled = true;
                button3.Enabled = false;
                button1.Enabled = true;
            }
            
        }
    

        public void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Level: 1";
            o = 15000;
            button2.Enabled = true;
            button3.Enabled = true;
            button1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "Level: 2";
            o = 10000;
            button2.Enabled = false;
            button3.Enabled = true;
            button1.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "Level: 3";
            o = 5000;
            button2.Enabled = true;
            button3.Enabled =false;
            button1.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 p = new Form2(o);
            DialogResult = DialogResult.OK;

        }
    }
}
