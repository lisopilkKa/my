using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursova_2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            PlaySound(soundFilePath);
            if (textBox1.Text == "admin" && textBox2.Text == "admin")
            {
                Form4 f1 = new Form4();
                f1.ShowDialog();
                this.DialogResult = DialogResult.OK;
            }
            
            
            

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            PlaySound(soundFilePath);
            this.DialogResult = DialogResult.Cancel;
        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {
            PlaySound(soundFilePath);
            this.Close();
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
        SoundPlayer player = new SoundPlayer(soundFilePath);
        static string soundFilePath = Path.GetDirectoryName(Application.ExecutablePath) + @"\knopka-vyiklyucheniya-na-nastolnoy-lampe1 (mp3cut.net).wav";
        private void PlaySound(string soundFilePath)
        {
            player.Play();

        }
        private void Form3_Load(object sender, EventArgs e)
        {
            player.Load();
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            enter((PictureBox)sender);
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            leave((PictureBox)sender);
        }
    }
}
