using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba6
{
    public partial class Form2 : Form
    {
        public  int t1 = 80;
        public static int j = 15000;
        public int l =0;
        public int s1 = 0;

        public Form2(int j)
        {
            InitializeComponent();
            label1.Text = $"Time:{t1}";
            label2.Text = $"Score: {s1}";
           
            pictureBox2.Image = pictureBox4.Image;
            pictureBox1.Image = pictureBox14.Image;
            timer1.Interval = j;
        }
        public Form2()
        {
            InitializeComponent();
            label1.Text = $"Time:{t1}";
            label2.Text = $"Score: {s1}";
           
            pictureBox2.Image = pictureBox4.Image;
            pictureBox1.Image = pictureBox14.Image;
            timer1.Interval = j;
        }
        Random r = new Random();
        public void pictureBox3_Click(object sender, EventArgs e)
        {

        }
        int sch = 0;
        private void change()
        {
            switch (r.Next(1, 11))
            {
                case 1:
                    pictureBox2.Image = pictureBox4.Image;
                    break;
                case 2:
                    pictureBox2.Image = pictureBox5.Image;
                    break;
                case 3:
                    pictureBox2.Image = pictureBox6.Image;
                    break;
                case 4:
                    pictureBox2.Image = pictureBox7.Image;
                    break;
                case 5:
                    pictureBox2.Image = pictureBox8.Image;
                    break;
                case 6:
                    pictureBox2.Image = pictureBox9.Image;
                    break;
                case 7:
                    pictureBox2.Image = pictureBox10.Image;
                    break;
                case 8:
                    pictureBox2.Image = pictureBox11.Image;
                    break;
                case 9:
                    pictureBox2.Image = pictureBox12.Image;
                    break;
                case 10:
                    pictureBox2.Image = pictureBox13.Image;
                    break;
                case 11:
                    pictureBox2.Image = pictureBox16.Image;
                    break;
            }
            switch (r.Next(1, 3))
            {
                case 1:
                    pictureBox1.Image = pictureBox14.Image;
                    break;
                case 2:
                    pictureBox1.Image = pictureBox15.Image;
                    break;
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            
            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (t1 == 0)
            {
                timer2.Stop();
                Form3 p = new Form3();
                p.score = s1;
                if (p.ShowDialog() == DialogResult.OK)
                {
                    this.Close(); DialogResult = DialogResult.OK;
                }
        
            }
            else
            {
                t1--;
                label1.Text = $"Time:{t1}";
            }
            
           
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
          
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            change();
            this.BackgroundImage = pictureBox1.Image;
            timer1.Start();
           // button6.FlatStyle = FlatStyle.Flat; // Устанавливаем плоский стиль
           // button6.FlatAppearance.BorderSize = 4; // Устанавливаем размер рамки
           // button6.FlatAppearance.BorderColor = Color.OliveDrab;

        }
        int i = 10;
        private void button1_Click(object sender, EventArgs e)
        {
            
            if (i == 23)
            {
                i = 0;
            }
            else
            {
                i++;
            }
            if (i < 10)
            {
                label3.Text = "0" + i.ToString();
            }
            else
            {
                label3.Text = i.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (i1 == 55)
            {
                i1 = 0;
            }
            else
            {
                i1+=5;
            }
            if (i1 < 10)
            {
                label5.Text = "0" + i1.ToString();
            }
            else
            {
                label5.Text = i1.ToString();
            }
        }
        int i1 = 30;
        private void button4_Click(object sender, EventArgs e)
        {

            if (i == 0)
            {
                i = 23;
            }
            else
            {
                i--;
            }
            if (i < 10)
            {
                label3.Text = "0" + i.ToString();
            }
            else
            {
                label3.Text = i.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (i1 == 0)
            {
                i1 = 55;
            }
            else
            {
                i1-=5;

            }
            if (i1<10)
            {
                label5.Text = "0"+i1.ToString();
            }
            else
            {
                label5.Text = i1.ToString();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            t1 = 80;
            s1 = 0;
            label2.Text = $"Score: {s1}";
            
        }

        private void button5_Click(object sender, EventArgs e)
        {

              if (label3.Text=="15"&& label5.Text=="50" && pictureBox2.Image == pictureBox16.Image && pictureBox1.Image == pictureBox15.Image)
                {
                    change();
                    s1++;
                }
                if (label3.Text == "03" && label5.Text == "50" && pictureBox2.Image == pictureBox16.Image && pictureBox1.Image == pictureBox14.Image)
                {
                    change();
                    s1++;
                }
                if (label3.Text == "15" && label5.Text == "00" && pictureBox2.Image == pictureBox4.Image & pictureBox1.Image == pictureBox15.Image)
                {
                    change();
                    s1++;
                }
                if (label3.Text == "03" && label5.Text == "00" && pictureBox2.Image == pictureBox4.Image && pictureBox1.Image == pictureBox14.Image)
                {
                    change();
                    s1++;
                }
                if (label3.Text == "17" && label5.Text == "00"  && pictureBox2.Image == pictureBox5.Image && pictureBox1.Image == pictureBox15.Image)
                {
                    change();
                    s1++;
                }
                if (label3.Text == "05" && label5.Text == "00"&& pictureBox2.Image == pictureBox5.Image && pictureBox1.Image == pictureBox14.Image)
                {
                    change();
                    s1++;
                }
                if (label3.Text == "19" && label5.Text == "00" && pictureBox2.Image == pictureBox6.Image && pictureBox1.Image == pictureBox14.Image)
                {
                    change();
                    s1++;
                }
                if (label3.Text == "07" && label5.Text == "00"  && pictureBox2.Image == pictureBox6.Image && pictureBox1.Image == pictureBox15.Image)
                {
                    change();
                    s1++;
                }
                if (label3.Text == "20" && label5.Text == "00"&& pictureBox2.Image == pictureBox7.Image && pictureBox1.Image == pictureBox14.Image)
                {
                    change();
                    s1++;
                }
                if (label3.Text == "08" && label5.Text == "00"&& pictureBox2.Image == pictureBox7.Image && pictureBox1.Image == pictureBox15.Image)
                {
                    change();
                    s1++;
                }
                if (label3.Text == "20" && label5.Text == "30" && pictureBox2.Image == pictureBox8.Image && pictureBox1.Image == pictureBox14.Image)
                {
                    change();
                    s1++;
                }
                if (label3.Text == "08" && label5.Text == "30" && pictureBox2.Image == pictureBox8.Image && pictureBox1.Image == pictureBox15.Image)
                {
                    change();
                    s1++;
                }
                if (label3.Text == "22" && label5.Text == "30" && pictureBox2.Image == pictureBox9.Image && pictureBox1.Image == pictureBox14.Image)
                {
                    change();
                    s1++;
                }
                if (label3.Text == "10" && label5.Text == "30" && pictureBox2.Image == pictureBox9.Image && pictureBox1.Image == pictureBox15.Image)
                {
                    change();
                    s1++;
                }
                if (label3.Text == "14" && label5.Text == "30"  && pictureBox2.Image == pictureBox10.Image && pictureBox1.Image == pictureBox15.Image)
                {
                    change();
                    s1++;
                }
                if (label3.Text == "02" && label5.Text == "30"  && pictureBox2.Image == pictureBox10.Image && pictureBox1.Image == pictureBox14.Image)
                {
                    change();
                    s1++;
                }
                if (label3.Text == "15" && label5.Text == "30" && pictureBox2.Image == pictureBox11.Image && pictureBox1.Image == pictureBox15.Image)
                {
                    change();
                    s1++;
                }
                if (label3.Text == "03" && label5.Text == "30" && pictureBox2.Image == pictureBox11.Image && pictureBox1.Image == pictureBox14.Image)
                {
                    change();
                    s1++;
                }
                if (label3.Text == "17" && label5.Text == "50"  && pictureBox2.Image == pictureBox12.Image && pictureBox1.Image == pictureBox15.Image)
                {
                    change();
                    s1++;
                }
                if (label3.Text == "05" && label5.Text == "50"  && pictureBox2.Image == pictureBox12.Image && pictureBox1.Image == pictureBox14.Image)
                {
                    change();
                    s1++;
                }
                if (label3.Text == "23" && label5.Text == "50" && pictureBox2.Image == pictureBox13.Image && pictureBox1.Image == pictureBox14.Image)
                {
                    change();
                    s1++;
                }
                if (label3.Text == "11" && label5.Text == "50" && pictureBox2.Image == pictureBox13.Image && pictureBox1.Image == pictureBox15.Image)
                {
                    change();
                    s1++;
                }
                label2.Text = $"Score: {s1}";
                l++;
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
