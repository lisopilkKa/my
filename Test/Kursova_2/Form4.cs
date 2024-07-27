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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            ot_pol.Add(false);
            ot_pol.Add(false);
            ot_pol.Add(false);
            ot_pol.Add(false);
            pictureBox1.Tag = 0;
            pictureBox2.Tag = 0;
            pictureBox3.Tag = 0;
            pictureBox4.Tag = 0;
        }
        int id = 0;
        Image img;
        SoundPlayer player = new SoundPlayer(soundFilePath);
        static string soundFilePath = Path.GetDirectoryName(Application.ExecutablePath) + @"\knopka-vyiklyucheniya-na-nastolnoy-lampe1 (mp3cut.net).wav";
        private void PlaySound(string soundFilePath)
        {



            player.Play();


        }
        private void Form4_Load(object sender, EventArgs e)
        {
            player.Load();
            this.FormBorderStyle = FormBorderStyle.None;
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet1.Table". При необходимости она может быть перемещена или удалена.
            this.tableTableAdapter.Fill(this.database1DataSet1.Table);
           

        }
        string puth;
        int number_img = 0;
        private void pictureBox8_Click(object sender, EventArgs e)
        {
            PlaySound(soundFilePath);
            var ofd = new OpenFileDialog();
            if (ofd.ShowDialog(this)==DialogResult.OK)
            {
                number_img++;
                pictureBox8.BackgroundImage = Image.FromFile(ofd.FileName);
                img= pictureBox8.BackgroundImage;
                img.Save(Path.GetDirectoryName(Application.ExecutablePath) + ofd.SafeFileName);
                puth = ofd.SafeFileName;
            }
        }
        public int sch = 0;

        List<bool> ot_pol = new List<bool>();
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PlaySound(soundFilePath);
            if (sch == 0)
            {
                pictureBox1.BackgroundImage = Resource1._7;
                sch++;
                ot_pol[0] = true;
                pictureBox1.Tag = 1;
            }
            else if (sch == 1 && Convert.ToInt32(pictureBox1.Tag) == 1)
            {
                pictureBox1.BackgroundImage = Resource1._6;
                ot_pol[0] = false;
                pictureBox1.Tag = 0;
                sch = 0;
            }
            else
            {
                pictureBox1.BackgroundImage = Resource1._7;
                pictureBox1.Tag = 1;
                ot_pol[0] = true;
                pictureBox2.BackgroundImage = Resource1._6;
                ot_pol[1] = false;
                pictureBox2.Tag = 0;
                pictureBox3.BackgroundImage = Resource1._6;
                ot_pol[2] = false;
                pictureBox3.Tag = 0;
                pictureBox4.BackgroundImage = Resource1._6;
                ot_pol[3] = false;
                pictureBox4.Tag = 0;

            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            PlaySound(soundFilePath);
            if (sch == 0)
            {
                pictureBox2.BackgroundImage = Resource1._7;
                sch++;
                ot_pol[1] = true;
                pictureBox2.Tag = 1;
            }
            else if (sch == 1 && Convert.ToInt32(pictureBox2.Tag) == 1)
            {
                pictureBox2.BackgroundImage = Resource1._6;
                ot_pol[1] = false;
                pictureBox2.Tag = 0;
                sch = 0;
            }
            else
            {
                pictureBox2.BackgroundImage = Resource1._7;
                ot_pol[1] = true;
                pictureBox2.Tag = 1;
                pictureBox1.BackgroundImage = Resource1._6;
                ot_pol[0] = false;
                pictureBox1.Tag = 0;
                pictureBox3.BackgroundImage = Resource1._6;
                ot_pol[2] = false;
                pictureBox3.Tag = 0;
                pictureBox4.BackgroundImage = Resource1._6;
                ot_pol[3] = false;
                pictureBox4.Tag = 0;

            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            PlaySound(soundFilePath);
            if (sch == 0)
            {
                pictureBox3.BackgroundImage = Resource1._7;
                sch++;
                ot_pol[2] = true;
                pictureBox3.Tag = 1;
            }
            else if (sch == 1 && Convert.ToInt32(pictureBox3.Tag) == 1)
            {
                pictureBox3.BackgroundImage = Resource1._6;
                ot_pol[2] = false;
                pictureBox3.Tag = 0;
                sch = 0;
            }
            else
            {
                pictureBox3.BackgroundImage = Resource1._7;
                ot_pol[2] = true;
                pictureBox3.Tag = 1;
                pictureBox2.BackgroundImage = Resource1._6;
                ot_pol[1] = false;
                pictureBox2.Tag = 0;
                pictureBox1.BackgroundImage = Resource1._6;
                ot_pol[0] = false;
                pictureBox1.Tag = 0;
                pictureBox4.BackgroundImage = Resource1._6;
                ot_pol[3] = false;
                pictureBox4.Tag = 0;

            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            PlaySound(soundFilePath);
            if (sch == 0)
            {
                pictureBox4.BackgroundImage = Resource1._7;
                ot_pol[3] = true;
                sch++;
                pictureBox4.Tag = 1;
            }
            else if (sch == 1 && Convert.ToInt32(pictureBox4.Tag) == 1)
            {
                pictureBox4.BackgroundImage = Resource1._6;
                ot_pol[3] = false;
                pictureBox4.Tag = 0;
                sch = 0;
            }
            else
            {
                pictureBox4.BackgroundImage = Resource1._7;
                ot_pol[3] = true;
                pictureBox4.Tag = 1;
                pictureBox2.BackgroundImage = Resource1._6;
                ot_pol[1] = false;
                pictureBox2.Tag = 0;
                pictureBox1.BackgroundImage = Resource1._6;
                ot_pol[0] = false;
                pictureBox1.Tag = 0;
                pictureBox3.BackgroundImage = Resource1._6;
                ot_pol[2] = false;
                pictureBox3.Tag = 0;

            }
        }
        public static byte[] ConvertImage(System.Drawing.Image imgC)
        {
            byte[] Ret;
            try
            {
                using(MemoryStream ms = new MemoryStream())
                {
                    imgC.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    Ret = ms.ToArray();
                }
            }
            catch (Exception)
            {

                throw;
            }
            return Ret;
        }
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            PlaySound(soundFilePath);
            string[] vse = new string[4];
            vse[0] = textBox1.Text;
            vse[1] = textBox2.Text + "/" + textBox3.Text + "/" + textBox4.Text + "/" + textBox5.Text;
            vse[2] = pictureBox1.Tag.ToString() + pictureBox2.Tag.ToString() + pictureBox3.Tag.ToString() + pictureBox4.Tag.ToString();
            vse[3] = puth;
            
            File.AppendAllLines(Path.GetDirectoryName(Application.ExecutablePath)+"tyt.txt", vse);
            this.DialogResult = DialogResult.OK;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            PlaySound(soundFilePath);
            this.DialogResult = DialogResult.Cancel;
        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {
            PlaySound(soundFilePath);
            this.Close();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            PlaySound(soundFilePath);
            string[] vse = File.ReadAllLines(Path.GetDirectoryName(Application.ExecutablePath) + "tyt.txt");
            string[] vse1 = new string[vse.Length - 4];

            for (int i = 0; i < vse.Length; i++)
            {
                if (vse[i]!=textBox1.Text)
                {
                    vse1[i] = vse[i];
                }
                else
                {
                    i += 3;
                }
            }
            File.WriteAllLines(Path.GetDirectoryName(Application.ExecutablePath) + "tyt.txt", vse1);
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

        private void pictureBox6_MouseEnter(object sender, EventArgs e)
        {
            enter((PictureBox)sender);
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            leave((PictureBox)sender);
        }
    }
}
