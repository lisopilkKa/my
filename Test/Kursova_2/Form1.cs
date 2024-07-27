using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Microsoft.PowerBI.Api.Models;
using System.Media;

namespace Kursova_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Form f = new Form(Form2);
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            PlaySound(soundFilePath);
            Form2 f1 = new Form2();
            f1.ShowDialog();
        }
        
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            PlaySound(soundFilePath);


            Form3 f2 = new Form3();
            f2.ShowDialog();
        }
        SoundPlayer player = new SoundPlayer(soundFilePath);
        static string soundFilePath = Path.GetDirectoryName(Application.ExecutablePath) + @"\knopka-vyiklyucheniya-na-nastolnoy-lampe1 (mp3cut.net).wav";
        private void PlaySound(string soundFilePath)
        {
            
            
               
                player.Play();
            

        }
            private void Form1_Load(object sender, EventArgs e)
        {
            player.Load();

            this.FormBorderStyle = FormBorderStyle.None;
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Table". При необходимости она может быть перемещена или удалена.
            this.tableTableAdapter.Fill(this.database1DataSet.Table);

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            PlaySound(soundFilePath);

            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            f6.ShowDialog();
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {

        }

        private void Form1_MouseEnter(object sender, EventArgs e)
        {
           
        }
        private void enter(PictureBox p)
        {
            p.Left -= 3;
            p.Top -= 5;
            p.Height += 5;
            p.Width += 5;
        }
        private void leave(PictureBox p)
        {
            p.Left += 3;
            p.Top += 5;
            p.Height -= 5;
            p.Width -= 5;
        }
        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            enter(pictureBox2);
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            leave(pictureBox2);
        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            enter((PictureBox)sender);
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            leave((PictureBox)sender);
        }
    }
}
