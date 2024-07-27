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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            
        }

        public int pravel_otvet;
        public int vsego_vopros;
        public double ocenka (int pravel_otvet, int vsego_vopros)
        {
            double oc1 = ((100 /Convert.ToDouble( vsego_vopros)) * Convert.ToDouble(pravel_otvet)) / (100 / 12);
            
            return Math.Round(oc1);
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            PlaySound(soundFilePath);
            this.DialogResult = DialogResult.OK;
        }
        SoundPlayer player = new SoundPlayer(soundFilePath);
        static string soundFilePath = Path.GetDirectoryName(Application.ExecutablePath) + @"\knopka-vyiklyucheniya-na-nastolnoy-lampe1 (mp3cut.net).wav";
        private void PlaySound(string soundFilePath)
        {



            player.Play();


        }
        private void Form5_Load(object sender, EventArgs e)
        {
            player.Load();
            this.FormBorderStyle = FormBorderStyle.None;
            label1.Text = "Правильних відповідей: " + pravel_otvet + "/" + vsego_vopros;
            label2.Text = "Ваша оцінка - " + ocenka(pravel_otvet, vsego_vopros);
            string sg = (vremya).ToString();
            string sg1 = "";
            sg1 += sg[3];
            sg1 += sg[4];
            sg1 += sg[5];
            sg1 += sg[6];
            sg1 += sg[7];
            label3.Text = "Час виконання: " + sg1;
        }
        public TimeSpan vremya; 
        private void pictureBox24_Click(object sender, EventArgs e)
        {
            PlaySound(soundFilePath);
            this.Close();
            this.DialogResult = DialogResult.OK;
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

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            enter((PictureBox)sender);
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            leave((PictureBox)sender);
        }
    }
}
