using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursova_2
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            string[] vse = new string[3];
            
            vse[0] = textBox4.Text + "/" + textBox6.Text + "/" + textBox7.Text;
            vse[1] = textBox1.Text + "/" + textBox2.Text + "/" + textBox3.Text;
            vse[2] = textBox5.Text+textBox8.Text + textBox9.Text;
            File.AppendAllLines(Path.GetDirectoryName(Application.ExecutablePath) + "tyt1.txt", vse);
            this.DialogResult = DialogResult.OK;
        }
    }
}
