﻿using System;
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
    public partial class Form3 : Form
    {
        public Form3()
        {
            
            InitializeComponent();
          
        }
        public int score = 0;
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close(); DialogResult = DialogResult.OK;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            label2.Text = "Score: " + score;
            this.BackgroundImage = pictureBox1.Image;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close(); DialogResult = DialogResult.OK;

        }
    }
}
