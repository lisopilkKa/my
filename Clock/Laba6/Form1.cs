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
    public partial class Form1 : Form
    {
        public int tim = 15000;
        public int s = 0;
        public Form1()
        {
            InitializeComponent();
            label2.Text = $"Best score: {s}";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
           
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
          
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button7.FlatStyle = FlatStyle.Flat; 
          button7.FlatAppearance.BorderSize = 4; // Устанавливаем размер рамки
          button7.FlatAppearance.BorderColor = Color.OliveDrab;
            this.BackgroundImage = pictureBox1.Image;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form2 p = new Form2();
            if (p.ShowDialog() == DialogResult.OK)
            {
                if (p.s1 > s)
                {
                    s = p.s1;
                    label2.Text = $"Best score: {s}";
                }
            }
        }
    }
}
