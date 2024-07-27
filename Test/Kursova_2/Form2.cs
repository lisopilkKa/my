using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Media;

namespace Kursova_2
{
    public partial class Form2 : Form
    {List<List<string>> variant_vidpv = new List<List<string>>();
        List<List<string>> usl_vidpv = new List<List<string>>();
        List<List<int>> otvet_vidpov= new List<List<int>>();
        public Form2()
        {
            InitializeComponent();
            Zap_usl();
            Zap_img();
            Zap_var();
            Zap_ocen();
            label12.Text = usl[0];
            label11.Text = varianty[0][0];
            label10.Text = varianty[0][1];
            label9.Text = varianty[0][2];
            label8.Text = varianty[0][3];
            pictureBox8.BackgroundImage = img[0];
            ot_pol.Add(false);
            ot_pol.Add(false);
            ot_pol.Add(false);
            ot_pol.Add(false);
            label13.Text = col_vop.ToString();
            draw_pal();
            para1.Add(null);
            para1.Add(null);
            string[] vse = File.ReadAllLines(Path.GetDirectoryName(Application.ExecutablePath) + "tyt.txt");
            int schit = 0;
            //string[] vse1 = File.ReadAllLines(Path.GetDirectoryName(Application.ExecutablePath) + "tyt1.txt");
            //int schit1 = 0;
            //for (int i = 0; i < vse1.Length; i++)
            //{
            //    if (schit1 == 0)
            //    {
            //        List<string> s = new List<string>();
            //        string s1 = "";
            //        string s2 = vse1[i];

            //        for (int j = 0; j < vse1[i].Length; j++)
            //        {
            //            if (s2[j] != '/')
            //            {
            //                s1 += s2[j];
            //            }
            //            else
            //            {
            //                s.Add(cop1(s1));
            //                s1 = "";
            //            }
            //        }
            //        s.Add(cop1(s1));
            //        s1 = "";
            //        variant_vidpv.Add(cop_s(s));
            //        schit1++;
            //    }
            //    else if (schit1==1)
            //    {
            //        List<string> s = new List<string>();
            //        string s1 = "";
            //        string s2 = vse1[i];

            //        for (int j = 0; j < vse1[i].Length; j++)
            //        {
            //            if (s2[j] != '/')
            //            {
            //                s1 += s2[j];
            //            }
            //            else
            //            {
            //                s.Add(cop1(s1));
            //                s1 = "";
            //            }
            //        }
            //        s.Add(cop1(s1));
            //        s1 = "";
            //        usl_vidpv.Add(cop_s(s));
            //        schit1++;
            //    }
            //    else if (schit1==2)
            //    {List<int>a=new List<int>();
            //        a.Add(vse1[i][0]);
            //        a.Add(vse1[i][1]);
            //        a.Add(vse1[i][2]);
            //        otvet_vidpov.Add(a);
            //        schit1 = 0;
            //    }


            //}
            for (int i = 0; i < vse.Length; i++)
            {
                if (schit==0)
                {
                    usl.Add(vse[i]);
                    schit++;
                }
                else if (schit == 1)
                {
                    List<string> s = new List<string>();
                    string s1 = "";
                    string s2 = vse[i];
                    
                    for (int j = 0; j < vse[i].Length; j++)
                    {
                        if ( s2[j]!='/')
                        {
                            s1 += s2[j];
                        }
                        else
                        {
                            s.Add(cop1(s1));
                            s1 = "";
                        }
                    }
                    s.Add(cop1(s1));
                    s1 = "";
                    varianty.Add(cop_s(s));
                    schit++;
                }
                else if (schit == 2)
                {
                    List<bool> n = new List<bool>();
                    for (int j = 0; j < vse[i].Length; j++)
                    {
                        if (vse[i][j]=='1')
                        {
                            n.Add(true);
                        }
                        else
                        {
                            n.Add(false);
                        }
                    }
                    ocen.Add(n);
                    schit++;
                }
                else
                {
                    img.Add(Image.FromFile(Path.GetDirectoryName(Application.ExecutablePath) + vse[i]));
                    schit = 0;
                }


            }
           


        }
        public string cop1(string s)
        {
            string s1 = "";
            for (int i = 0; i < s.Length; i++)
            {
                s1 += s[i];
            }
            return s1;
        }
      public List<bool> cop (List<bool> cop1)
        {
            List < bool > c= new List<bool>();
            for (int i = 0; i < cop1.Count; i++)
            {
                c.Add(cop1[i]);
            }
            return c;
        }
        public List<string> cop_s(List<string> cop1)
        {
            List<string> c = new List<string>();
            for (int i = 0; i < cop1.Count; i++)
            {
                c.Add(cop1[i]);
            }
            return c;
        }
        public void Zap_ocen()
        {
            List<bool> oc = new List<bool>();
            oc.Add(true);
            oc.Add(false);
            oc.Add(false);
            oc.Add(false);
            ocen.Add(oc);
            List<bool> oc1 = new List<bool>();
            oc1.Add(false);
            oc1.Add(false);
            oc1.Add(false);
            oc1.Add(true);
            ocen.Add(oc1);
            List<bool> oc2 = new List<bool>();
            oc2.Add(false);
            oc2.Add(false);
            oc2.Add(true);
            oc2.Add(false);
            ocen.Add(oc2);
            List<bool> oc3 = new List<bool>();
            oc3.Add(false);
            oc3.Add(true);
            oc3.Add(false);
            oc3.Add(false);
            ocen.Add(oc3);
            List<bool> oc4 = new List<bool>();
            oc4.Add(false);
            oc4.Add(false);
            oc4.Add(true);
            oc4.Add(false);
            ocen.Add(oc4);
            List<bool> oc5 = new List<bool>();
            oc5.Add(false);
            oc5.Add(false);
            oc5.Add(false);
            oc5.Add(true);
            ocen.Add(oc5);
            List<bool> oc6 = new List<bool>();
            oc6.Add(false);
            oc6.Add(false);
            oc6.Add(true);
            oc6.Add(false);
            ocen.Add(oc6);


        }
        List<string> usl = new List<string>();
        List<List<string>> varianty = new List<List<string>>();
        List<Image> img = new List<Image>();
        List<List<bool>> ocen = new List<List<bool>>();    
        public void Zap_usl()
        {
            usl.Add("Виберіть певний осередок пам'яті, в який можна записати різні значення. Як правило, цьому осередку пам'яті встановлюють якесь ім'я. ");
            usl.Add("Виберіть користувацький тип даних, який включає в себе змінні і функції.");
            usl.Add("Механізм, який об'єднує дані і код, який маніпулює цими даними, а також захищає і те, і інше від зовнішнього втручання або неправильного використання, це?");
            usl.Add("Як називається змінна, доступ до якої регламентується спеціальними методами читання і запису(get / set)?");
            usl.Add("Як називається фрагмент програмного коду, який вбудований в об’єкт та передбачає виконання деяких дій з ним.");
            usl.Add("Виберіть характеристику яку явно чи неявно надано об'єкту (змінній, функції, полю запису, константі, масиву тощо). ");
            usl.Add("Втілення абстрактної моделі окремої сутності, що має чітко виражене функціональне призначення в деякій області, належить до визначеного класу та характеризується своїми властивостями та поведінкою, це?");
        }
        public void Zap_img()
        {
            img.Add(Resource1._9);
            img.Add(Resource1._380520eng);
            img.Add(Resource1._2835143);
            img.Add(Resource1._6443342641496064);
            img.Add(Resource1.asset_v1_EPAM_JAVA101_YCE_type_asset_block_12865_65fc_4);
            img.Add(Resource1.Computer_science_education);
            img.Add(Resource1.coding);

        }
        public void Zap_var()
        {
            List<string> v = new List<string>();
            v.Add("Змінна");
            v.Add("Тип даних");
            v.Add("Клас");
            v.Add("Метод");
            varianty.Add(v);
            List<string> v1 = new List<string>();
            v1.Add("Змінна");
            v1.Add("Метод");
            v1.Add("Властивості");
            v1.Add("Клас");
            varianty.Add(v1);
            List<string> v2 = new List<string>();
            v2.Add("Поліморфізм");
            v2.Add("Спадкування");
            v2.Add("Інкапсуляція");
            v2.Add("Властивість");
            varianty.Add(v2);
            List<string> v3 = new List<string>();
            v3.Add("Поліморфізм");
            v3.Add("Властивість");
            v3.Add("Спадкування");
            v3.Add("Інкапсуляція");
            varianty.Add(v3);
            List<string> v4 = new List<string>();
            v4.Add("Поліморфізм");
            v4.Add("Змінна");
            v4.Add("Метод");
            v4.Add("Властивості");
            varianty.Add(v4);
            List<string> v5 = new List<string>();
            v5.Add("Змінна");
            v5.Add("Інкапсуляція");
            v5.Add("Метод");
            v5.Add("Тип даних");
            varianty.Add(v5);
            List<string> v6 = new List<string>();
            v6.Add("Метод");
            v6.Add("Змінна");
            v6.Add("Екземпляр класу");
            v6.Add("Тип даних");
            varianty.Add(v6);
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        public int sch = 0;
        
        List<bool> ot_pol = new List<bool>();
        SoundPlayer player = new SoundPlayer(soundFilePath);
        static string soundFilePath = Path.GetDirectoryName(Application.ExecutablePath) + @"\knopka-vyiklyucheniya-na-nastolnoy-lampe1 (mp3cut.net).wav";
        private void PlaySound(string soundFilePath)
        {



            player.Play();


        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PlaySound(soundFilePath);

            if (sch==0)
            {
                pictureBox1.BackgroundImage = Resource1._7;
                sch++;
                ot_pol[0] = true;
                pictureBox1.Tag = 1;
            }
            else if (sch==1 && Convert.ToInt32( pictureBox1.Tag)==1)
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
                ot_pol[1]= false;
                pictureBox2.Tag = 0;
                pictureBox3.BackgroundImage = Resource1._6;
                ot_pol[2]= false;
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
        
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            PlaySound(soundFilePath);

            for (int i = 0; i < perv.Count; i++)
            {
                if (perv[i][0] == "A"&& perv[i][1] == "2"|| perv[i][0] == "2" && perv[i][1] == "A")
                {
                    pravel_otvet++;
                }
                else if (perv[i][0] == "B" && perv[i][1] == "1" || perv[i][0] == "1" && perv[i][1] == "B")
                {
                    pravel_otvet++;
                }
                else if (perv[i][0] == "C" && perv[i][1] == "3" || perv[i][0] == "3" && perv[i][1] == "C")
                {
                    pravel_otvet++;
                }
            }
            vsego_otvet += 3;
            label7.Text = pravel_otvet + " " + vsego_otvet;
            panel1.Visible = false;
            panel5.Visible = true;
            panel5.Top = 8;
            panel5.Left = 3;
            col_vop1++;
        }

        int pravel_otvet = 0;
        int vsego_otvet =0;
        int col_vop = 1;
        int col_vop1 = 1;
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            PlaySound(soundFilePath);

            if (col_vop<usl.Count-1)
            {
                for (int i = 0; i < varianty[col_vop - 1].Count; i++)
                {
                    if (ocen[col_vop - 1][i] == true && ot_pol[i] == true)
                    {
                        pravel_otvet++;
                    }
                    if (ot_pol[i])
                    {
                        vsego_otvet++;
                    }
                }
                label7.Text = pravel_otvet + " " + vsego_otvet;
                ot_pol[0] = false;
                ot_pol[1] = false;
                ot_pol[2] = false;
                ot_pol[3] = false;
                pictureBox1.Tag = 0;
                pictureBox2.Tag = 0;
                pictureBox3.Tag = 0;
                pictureBox4.Tag = 0;
                pictureBox1.BackgroundImage = Resource1._6;
                pictureBox2.BackgroundImage = Resource1._6;
                pictureBox3.BackgroundImage = Resource1._6;
                pictureBox4.BackgroundImage = Resource1._6;
                col_vop++;
                col_vop1++;
                if (col_vop1 == 5)
                {
                    panel1.Top = 8;
                    panel1.Left = 3;
                    panel1.Visible = true;
                }

                label13.Text = col_vop1.ToString();
                label12.Text = usl[col_vop - 1];
                label11.Text = varianty[col_vop - 1][0];
                label10.Text = varianty[col_vop - 1][1];
                label9.Text = varianty[col_vop - 1][2];
                label8.Text = varianty[col_vop - 1][3];
                pictureBox8.BackgroundImage = img[col_vop - 1];
                if (img[col_vop - 1] != null) pictureBox8.BackgroundImage = img[col_vop - 1];
                else pictureBox8.BackgroundImage = null;



            }
            else if (col_vop < usl.Count )
            {
                pictureBox7.BackgroundImage = Resource1._26;
                for (int i = 0; i < varianty[col_vop - 1].Count; i++)
                {
                    if (ocen[col_vop - 1][i] == true && ot_pol[i] == true)
                    {
                        pravel_otvet++;
                    }
                    if (ot_pol[i])
                    {
                        vsego_otvet++;
                    }
                }
                label7.Text = pravel_otvet + " " + vsego_otvet;
                ot_pol[0] = false;
                ot_pol[1] = false;
                ot_pol[2] = false;
                ot_pol[3] = false;
                pictureBox1.Tag = 0;
                pictureBox2.Tag = 0;
                pictureBox3.Tag = 0;
                pictureBox4.Tag = 0;
                pictureBox1.BackgroundImage = Resource1._6;
                pictureBox2.BackgroundImage = Resource1._6;
                pictureBox3.BackgroundImage = Resource1._6;
                pictureBox4.BackgroundImage = Resource1._6;
                col_vop++;
                col_vop1++;
                if (col_vop1 == 5)
                {
                    panel1.Top = 8;
                    panel1.Left = 3;
                    panel1.Visible = true;
                }

                label13.Text = col_vop1.ToString();
                label12.Text = usl[col_vop - 1];
                label11.Text = varianty[col_vop - 1][0];
                label10.Text = varianty[col_vop - 1][1];
                label9.Text = varianty[col_vop - 1][2];
                label8.Text = varianty[col_vop - 1][3];
                pictureBox8.BackgroundImage = img[col_vop - 1];
                if (img[col_vop - 1] != null) pictureBox8.BackgroundImage = img[col_vop - 1];
                else pictureBox8.BackgroundImage = null;
            }
            //else if (variant_vidpv.Count!=0)
            //{
            //    panel1.Top = 8;
            //    panel1.Left = 3;
            //    panel1.Visible = true;
            //}
            else
            {

                for (int i = 0; i < varianty[col_vop - 1].Count; i++)
                {
                    if (ocen[col_vop - 1][i] == true && ot_pol[i] == true)
                    {
                        pravel_otvet++;
                    }
                    if (ot_pol[i])
                    {
                        vsego_otvet++;
                    }
                }
                timer1.Stop();
                label7.Text = pravel_otvet + " " + vsego_otvet;
                Form5 f5 = new Form5();
                f5.pravel_otvet = pravel_otvet;
                f5.vsego_vopros = col_vop + 6;
                f5.vremya = vremya;
                f5.ShowDialog();
                if (f5.DialogResult==DialogResult.OK)
                {
                    this.Close();
                }
                
            }
            

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < varianty[col_vop - 1].Count; i++)
            {
                if (ocen[col_vop-1][i] == true && ot_pol[i] == true)
                {
                    pravel_otvet++;
                }
                if (ot_pol[i])
                {
                    vsego_otvet++;
                }
            }
            label7.Text = pravel_otvet + " " + vsego_otvet;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        int sch_krug = 0;
        int sch_krug1 = 0;
        int sch_krug2 = 0;
        int sch_krug3 = 0;
        int sch_krug4 = 0;
        int sch_krug5 = 0;
        int sch_krug6 = 0;
        List<List<string>> perv = new List<List<string>>();
        string vtor = "";
        List<string> para = new List<string>();
        public void draw_pal()
        {
            para.Add(null);
            para.Add(null);
        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            PlaySound(soundFilePath);

            if (sch_krug1==0&& para[0] == null)
            {
                pictureBox5.Height = pictureBox5.Height + 10;
                pictureBox5.Width = pictureBox5.Width + 10;
                sch_krug1++;
                sch_krug++;
                para[0]="A";
            }
            else if (sch_krug1 == 1)
            {
                pictureBox5.Height = pictureBox5.Height - 10;
                pictureBox5.Width = pictureBox5.Width - 10;
                sch_krug1 = 0;
                sch_krug = 0;
                para[0] = null;
            }
            else if (para[0] != null&& para[0]!="B" && para[0] != "C")
            {
                para[1] = "A";
                pictureBox5.Height = pictureBox5.Height + 10;
                pictureBox5.Width = pictureBox5.Width + 10;
                
                zap_par(para);
            }
        }
        public List<string> perepis(List<string> para)
        {
            List<string> para1 = new List<string>();
            para1.Add(para[0]);
            para1.Add(para[1]);
            return para1;
        }
        public void zap_par(List<string> para)
        {
            if (perv.Count==0)
            {
                panel2.Visible = true;
                label16.Text = para[0] + "," + para[1];
                
            }
            else if(perv.Count == 1)
            {
                panel3.Visible = true;
                label17.Text = para[0] + "," + para[1];
                
            }
            else if (perv.Count == 2)
            {
                panel4.Visible = true;
                label18.Text = para[0] + "," + para[1];
              
            }
            perv.Add(perepis(para));
            para[0] = null;
            para[1] = null;
        }
        private void pictureBox11_Click(object sender, EventArgs e)
        {
            PlaySound(soundFilePath);

            if (sch_krug4 == 0 && para[0] == null)
            {
                pictureBox11.Height = pictureBox11.Height + 10;
                pictureBox11.Width = pictureBox11.Width + 10;
                sch_krug4++;
                sch_krug++;
                para[0] = "1";
            }
            else if (sch_krug4 == 1)
            {
                pictureBox11.Height = pictureBox11.Height - 10;
                pictureBox11.Width = pictureBox11.Width - 10;
                sch_krug4 = 0;
                sch_krug = 0;
                para[0] = null;
            }
            else if (para[0] != null && para[0] != "2" && para[0] != "3")
            {
                para[1] = "1";
                pictureBox11.Height = pictureBox11.Height + 10;
                pictureBox11.Width = pictureBox11.Width + 10;
                
                zap_par(para);
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            PlaySound(soundFilePath);

            if (sch_krug2 == 0 && para[0] == null)
            {
                pictureBox9.Height = pictureBox9.Height + 10;
                pictureBox9.Width = pictureBox9.Width + 10;
                sch_krug2++;
                sch_krug++;
                para[0] = "B";
            }
            else if (sch_krug2 == 1)
            {
                pictureBox9.Height = pictureBox9.Height - 10;
                pictureBox9.Width = pictureBox9.Width - 10;
                sch_krug2 = 0;
                sch_krug = 0;
                para[0] = null;
            }
            else if (para[0] != null && para[0] != "A" && para[0] != "C")
            {
                para[1] = "B";
                pictureBox9.Height = pictureBox9.Height + 10;
                pictureBox9.Width = pictureBox9.Width + 10;
                
                zap_par(para);
            }
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            PlaySound(soundFilePath);

            if (sch_krug5 == 0 && para[0] == null)
            {
                pictureBox13.Height = pictureBox13.Height + 10;
                pictureBox13.Width = pictureBox13.Width + 10;
                sch_krug5++;
                sch_krug++;
                para[0] = "2";
            }
            else if (sch_krug5 == 1)
            {
                pictureBox13.Height = pictureBox13.Height - 10;
                pictureBox13.Width = pictureBox13.Width - 10;
                sch_krug5 = 0;
                sch_krug = 0;
                para[0] = null;
            }
            else if (para[0] != null && para[0] != "1" && para[0] != "3")
            {
                para[1] = "2";
                pictureBox13.Height = pictureBox13.Height + 10;
                pictureBox13.Width = pictureBox13.Width + 10;
                
                zap_par(para);
            }
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            PlaySound(soundFilePath);

            if (sch_krug3 == 0 && para[0] == null)
            {
                pictureBox10.Height = pictureBox10.Height + 10;
                pictureBox10.Width = pictureBox10.Width + 10;
                sch_krug3++;
                sch_krug++;
                para[0] = "C";
            }
            else if (sch_krug3 == 1)
            {
                pictureBox10.Height = pictureBox10.Height - 10;
                pictureBox10.Width = pictureBox10.Width - 10;
                sch_krug3 = 0;
                sch_krug = 0;
                para[0] = null;
            }
            else if (para[0] != null && para[0] != "A" && para[0] != "B")
            {
                para[1] = "C";
                pictureBox10.Height = pictureBox10.Height + 10;
                pictureBox10.Width = pictureBox10.Width + 10;
               
                zap_par(para);
            }
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            PlaySound(soundFilePath);

            if (sch_krug6 == 0 && para[0] == null)
            {
                pictureBox14.Height = pictureBox14.Height + 10;
                pictureBox14.Width = pictureBox14.Width + 10;
                sch_krug6++;
                sch_krug++;
                para[0] = "3";
            }
            else if (sch_krug6 == 1)
            {
                pictureBox14.Height = pictureBox14.Height - 10;
                pictureBox14.Width = pictureBox14.Width - 10;
                sch_krug6 = 0;
                sch_krug = 0;
                para[0] = null;
            }
            else if (para[0] != null && para[0] != "1" && para[0] != "2")
            {
                para[1] = "3";
                pictureBox14.Height = pictureBox14.Height + 10;
                pictureBox14.Width = pictureBox14.Width + 10;
              
                zap_par(para);
            }
        }
        int sch_krug0 = 0;
        int sch_krug11 = 0;
        int sch_krug12 = 0;
        int sch_krug13 = 0;
        int sch_krug14 = 0;
        int sch_krug15 = 0;
        int sch_krug16 = 0;
        List<List<string>> perv1 = new List<List<string>>();
        string vtor1 = "";
        List<string> para1 = new List<string>();
        public void zap_par1(List<string> para)
        {
            if (perv1.Count == 0)
            {
                panel8.Visible = true;
                label21.Text = para[0] + "," + para[1];

            }
            else if (perv1.Count == 1)
            {
                panel7.Visible = true;
                label20.Text = para[0] + "," + para[1];

            }
            else if (perv1.Count == 2)
            {
                panel6.Visible = true;
                label19.Text = para[0] + "," + para[1];

            }
            perv1.Add(perepis(para));
            para[0] = null;
            para[1] = null;
        }
        private void pictureBox19_Click(object sender, EventArgs e)
        {
            PlaySound(soundFilePath);

            if (sch_krug11 == 0 && para1[0] == null)
            {
                pictureBox19.Height = pictureBox19.Height + 10;
                pictureBox19.Width = pictureBox19.Width + 10;
                sch_krug11++;
                sch_krug0++;
                para1[0] = "A";
            }
            else if (sch_krug11 == 1)
            {
                pictureBox19.Height = pictureBox19.Height - 10;
                pictureBox19.Width = pictureBox19.Width - 10;
                sch_krug11 = 0;
                sch_krug0 = 0;
                para1[0] = null;
            }
            else if (para1[0] != null && para1[0] != "B" && para1[0] != "C")
            {
                para[1] = "A";
                pictureBox19.Height = pictureBox19.Height + 10;
                pictureBox19.Width = pictureBox19.Width + 10;

                zap_par1(para1);
            }
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            PlaySound(soundFilePath);

            if (sch_krug12 == 0 && para1[0] == null)
            {
                pictureBox18.Height = pictureBox18.Height + 10;
                pictureBox18.Width = pictureBox18.Width + 10;
                sch_krug12++;
                sch_krug0++;
                para1[0] = "B";
            }
            else if (sch_krug12 == 1)
            {
                pictureBox18.Height = pictureBox18.Height - 10;
                pictureBox18.Width = pictureBox18.Width - 10;
                sch_krug12 = 0;
                sch_krug0 = 0;
                para1[0] = null;
            }
            else if (para1[0] != null && para1[0] != "A" && para1[0] != "C")
            {
                para1[1] = "B";
                pictureBox18.Height = pictureBox18.Height + 10;
                pictureBox18.Width = pictureBox18.Width + 10;

                zap_par1(para1);
            }
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            PlaySound(soundFilePath);

            if (sch_krug13 == 0 && para1[0] == null)
            {
                pictureBox17.Height = pictureBox17.Height + 10;
                pictureBox17.Width = pictureBox17.Width + 10;
                sch_krug13++;
                sch_krug0++;
                para1[0] = "C";
            }
            else if (sch_krug13 == 1)
            {
                pictureBox17.Height = pictureBox17.Height - 10;
                pictureBox17.Width = pictureBox17.Width - 10;
                sch_krug13 = 0;
                sch_krug0 = 0;
                para1[0] = null;
            }
            else if (para1[0] != null && para1[0] != "A" && para1[0] != "B")
            {
                para1[1] = "C";
                pictureBox17.Height = pictureBox17.Height + 10;
                pictureBox17.Width = pictureBox17.Width + 10;

                zap_par1(para1);
            }
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            PlaySound(soundFilePath);

            if (sch_krug14 == 0 && para1[0] == null)
            {
                pictureBox16.Height = pictureBox16.Height + 10;
                pictureBox16.Width = pictureBox16.Width + 10;
                sch_krug14++;
                sch_krug0++;
                para1[0] = "1";
            }
            else if (sch_krug14 == 1)
            {
                pictureBox16.Height = pictureBox16.Height - 10;
                pictureBox16.Width = pictureBox16.Width - 10;
                sch_krug14 = 0;
                sch_krug0 = 0;
                para1[0] = null;
            }
            else if (para1[0] != null && para1[0] != "2" && para1[0] != "3")
            {
                para1[1] = "1";
                pictureBox16.Height = pictureBox16.Height + 10;
                pictureBox16.Width = pictureBox16.Width + 10;

                zap_par1(para1);
            }
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            PlaySound(soundFilePath);

            if (sch_krug16 == 0 && para1[0] == null)
            {
                pictureBox12.Height = pictureBox12.Height + 10;
                pictureBox12.Width = pictureBox12.Width + 10;
                sch_krug16++;
                sch_krug0++;
                para1[0] = "3";
            }
            else if (sch_krug16 == 1)
            {
                pictureBox12.Height = pictureBox12.Height - 10;
                pictureBox12.Width = pictureBox12.Width - 10;
                sch_krug16 = 0;
                sch_krug0 = 0;
                para1[0] = null;
            }
            else if (para1[0] != null && para1[0] != "1" && para1[0] != "2")
            {
                para1[1] = "3";
                pictureBox12.Height = pictureBox12.Height + 10;
                pictureBox12.Width = pictureBox12.Width + 10;

                zap_par1(para1);
            }
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            PlaySound(soundFilePath);

            if (sch_krug15 == 0 && para1[0] == null)
            {
                pictureBox15.Height = pictureBox15.Height + 10;
                pictureBox15.Width = pictureBox15.Width + 10;
                sch_krug15++;
                sch_krug0++;
                para1[0] = "2";
            }
            else if (sch_krug15 == 1)
            {
                pictureBox15.Height = pictureBox15.Height - 10;
                pictureBox15.Width = pictureBox15.Width - 10;
                sch_krug15 = 0;
                sch_krug0 = 0;
                para1[0] = null;
            }
            else if (para1[0] != null && para1[0] != "1" && para1[0] != "3")
            {
                para1[1] = "2";
                pictureBox15.Height = pictureBox15.Height + 10;
                pictureBox15.Width = pictureBox15.Width + 10;

                zap_par1(para1);
            }
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            PlaySound(soundFilePath);

            for (int i = 0; i < perv1.Count; i++)
            {
                if (perv1[i][0] == "A" && perv1[i][1] == "3" || perv1[i][0] == "3" && perv1[i][1] == "A")
                {
                    pravel_otvet++;
                }
                else if (perv1[i][0] == "B" && perv1[i][1] == "1" || perv1[i][0] == "1" && perv1[i][1] == "B")
                {
                    pravel_otvet++;
                }
                else if (perv1[i][0] == "C" && perv1[i][1] == "2" || perv1[i][0] == "2" && perv1[i][1] == "C")
                {
                    pravel_otvet++;
                }
            }
            vsego_otvet += 3;
            label7.Text = pravel_otvet + " " + vsego_otvet;
            panel5.Visible = false;
            
           col_vop1++;
            label13.Text = col_vop1.ToString();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            PlaySound(soundFilePath);


        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            PlaySound(soundFilePath);

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {
            PlaySound(soundFilePath);

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {
            PlaySound(soundFilePath);

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {
            PlaySound(soundFilePath);

        }

        private void panel8_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < perv1.Count; i++)
            {
                if (perv1[i][0] == label21.Text[0].ToString() || perv1[i][1] == label21.Text[0].ToString())
                {
                    perv1.RemoveAt(i); break;
                }

            }
            if (label21.Text[0] == 'A' || label21.Text[2] == 'A')
            {
                pictureBox19.Height = pictureBox19.Height - 10;
                pictureBox19.Width = pictureBox19.Width - 10;
                sch_krug11 = 0;
                sch_krug0 = 0;
            }
            else if (label21.Text[0] == 'B' || label21.Text[2] == 'B')
            {
                pictureBox18.Height = pictureBox18.Height - 10;
                pictureBox18.Width = pictureBox18.Width - 10;
                sch_krug12 = 0;
                sch_krug0 = 0;
            }
            else if (label21.Text[0] == 'C' || label21.Text[2] == 'C')
            {
                pictureBox17.Height = pictureBox17.Height - 10;
                pictureBox17.Width = pictureBox17.Width - 10;
                sch_krug13 = 0;
                sch_krug0 = 0;
            }
            if (label21.Text[0] == '1' || label21.Text[2] == '1')
            {
                pictureBox16.Height = pictureBox16.Height - 10;
                pictureBox16.Width = pictureBox16.Width - 10;
                sch_krug14 = 0;
                sch_krug0 = 0;
            }
            else if (label21.Text[0] == '2' || label21.Text[2] == '2')
            {
                pictureBox15.Height = pictureBox15.Height - 10;
                pictureBox15.Width = pictureBox15.Width - 10;
                sch_krug15 = 0;
                sch_krug0 = 0;
            }
            else if (label21.Text[0] == '3' || label21.Text[2] == '3')
            {
                pictureBox12.Height = pictureBox12.Height - 10;
                pictureBox12.Width = pictureBox12.Width - 10;
                sch_krug16 = 0;
                sch_krug0 = 0;
            }
            if (perv1.Count==2)
            {
                panel6.Visible = false;
            }
            else if (perv1.Count == 1)
            {
                panel6.Visible = false;
                panel7.Visible = false;
            }
            else if (perv1.Count == 0)
            {
                panel6.Visible = false;
                panel7.Visible = false;
                panel8.Visible = false;
               
            }
            
            label21.Text = label20.Text;
            label20.Text = label19.Text;
            label19.Text = "";
        }

        private void panel7_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < perv1.Count; i++)
            {
                if (perv1[i][0] == label20.Text[0].ToString() || perv1[i][1] == label20.Text[0].ToString())
                {
                    perv1.RemoveAt(i); break;
                }

            }
            if (label20.Text[0] == 'A' || label20.Text[2] == 'A')
            {
                pictureBox19.Height = pictureBox19.Height - 10;
                pictureBox19.Width = pictureBox19.Width - 10;
                sch_krug11 = 0;
                sch_krug0 = 0;
            }
            else if (label20.Text[0] == 'B' || label20.Text[2] == 'B')
            {
                pictureBox18.Height = pictureBox18.Height - 10;
                pictureBox18.Width = pictureBox18.Width - 10;
                sch_krug12 = 0;
                sch_krug0 = 0;
            }
            else if (label20.Text[0] == 'C' || label20.Text[2] == 'C')
            {
                pictureBox17.Height = pictureBox17.Height - 10;
                pictureBox17.Width = pictureBox17.Width - 10;
                sch_krug13 = 0;
                sch_krug0 = 0;
            }
            if (label20.Text[0] == '1' || label20.Text[2] == '1')
            {
                pictureBox16.Height = pictureBox16.Height - 10;
                pictureBox16.Width = pictureBox16.Width - 10;
                sch_krug14 = 0;
                sch_krug0 = 0;
            }
            else if (label20.Text[0] == '2' || label20.Text[2] == '2')
            {
                pictureBox15.Height = pictureBox15.Height - 10;
                pictureBox15.Width = pictureBox15.Width - 10;
                sch_krug15 = 0;
                sch_krug0 = 0;
            }
            else if (label20.Text[0] == '3' || label20.Text[2] == '3')
            {
                pictureBox12.Height = pictureBox12.Height - 10;
                pictureBox12.Width = pictureBox12.Width - 10;
                sch_krug16 = 0;
                sch_krug0 = 0;
            }
            if (perv1.Count == 2)
            {
                panel6.Visible = false;
            }
            else if (perv1.Count == 1)
            {
                panel6.Visible = false;
                panel7.Visible = false;
            }
            else if (perv1.Count == 0)
            {
                panel6.Visible = false;
                panel7.Visible = false;
                panel8.Visible = false;

            }


            label20.Text = label19.Text;
            label19.Text = "";
        }

        private void panel6_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < perv1.Count; i++)
            {
                if (perv1[i][0] == label19.Text[0].ToString() || perv1[i][1] == label19.Text[0].ToString())
                {
                    perv1.RemoveAt(i); break;
                }

            }
            if (label19.Text[0] == 'A' || label19.Text[2] == 'A')
            {
                pictureBox19.Height = pictureBox19.Height - 10;
                pictureBox19.Width = pictureBox19.Width - 10;
                sch_krug11 = 0;
                sch_krug0 = 0;
            }
            else if (label19.Text[0] == 'B' || label19.Text[2] == 'B')
            {
                pictureBox18.Height = pictureBox18.Height - 10;
                pictureBox18.Width = pictureBox18.Width - 10;
                sch_krug12 = 0;
                sch_krug0 = 0;
            }
            else if (label19.Text[0] == 'C' || label19.Text[2] == 'C')
            {
                pictureBox17.Height = pictureBox17.Height - 10;
                pictureBox17.Width = pictureBox17.Width - 10;
                sch_krug13 = 0;
                sch_krug0 = 0;
            }
            if (label19.Text[0] == '1' || label19.Text[2] == '1')
            {
                pictureBox16.Height = pictureBox16.Height - 10;
                pictureBox16.Width = pictureBox16.Width - 10;
                sch_krug14 = 0;
                sch_krug0 = 0;
            }
            else if (label19.Text[0] == '2' || label19.Text[2] == '2')
            {
                pictureBox15.Height = pictureBox15.Height - 10;
                pictureBox15.Width = pictureBox15.Width - 10;
                sch_krug15 = 0;
                sch_krug0 = 0;
            }
            else if (label19.Text[0] == '3' || label19.Text[2] == '3')
            {
                pictureBox12.Height = pictureBox12.Height - 10;
                pictureBox12.Width = pictureBox12.Width - 10;
                sch_krug16 = 0;
                sch_krug0 = 0;
            }
            if (perv1.Count == 2)
            {
                panel6.Visible = false;
            }
            else if (perv1.Count == 1)
            {
                panel6.Visible = false;
                panel7.Visible = false;
            }
            else if (perv1.Count == 0)
            {
                panel6.Visible = false;
                panel7.Visible = false;
                panel8.Visible = false;

            }



            label19.Text = "";
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < perv.Count; i++)
            {
                if (perv[i][0] == label16.Text[0].ToString() || perv[i][1] == label16.Text[0].ToString())
                {
                    perv.RemoveAt(i); break;
                }

            }
            if (label16.Text[0] == 'A' || label16.Text[2] == 'A')
            {
                pictureBox5.Height = pictureBox5.Height - 10;
                pictureBox5.Width = pictureBox5.Width - 10;
                sch_krug1 = 0;
                sch_krug0 = 0;
            }
            else if (label16.Text[0] == 'B' || label16.Text[2] == 'B')
            {
                pictureBox9.Height = pictureBox9.Height - 10;
                pictureBox9.Width = pictureBox9.Width - 10;
                sch_krug2 = 0;
                sch_krug0 = 0;
            }
            else if (label16.Text[0] == 'C' || label16.Text[2] == 'C')
            {
                pictureBox10.Height = pictureBox10.Height - 10;
                pictureBox10.Width = pictureBox10.Width - 10;
                sch_krug3 = 0;
                sch_krug0 = 0;
            }
            if (label16.Text[0] == '1' || label16.Text[2] == '1')
            {
                pictureBox11.Height = pictureBox11.Height - 10;
                pictureBox11.Width = pictureBox11.Width - 10;
                sch_krug4 = 0;
                sch_krug0 = 0;
            }
            else if (label16.Text[0] == '2' || label16.Text[2] == '2')
            {
                pictureBox13.Height = pictureBox13.Height - 10;
                pictureBox13.Width = pictureBox13.Width - 10;
                sch_krug5 = 0;
                sch_krug0 = 0;
            }
            else if (label16.Text[0] == '3' || label16.Text[2] == '3')
            {
                pictureBox14.Height = pictureBox14.Height - 10;
                pictureBox14.Width = pictureBox14.Width - 10;
                sch_krug6 = 0;
                sch_krug0 = 0;
            }
            if (perv.Count == 2)
            {
                panel4.Visible = false;
            }
            else if (perv.Count == 1)
            {
                panel4.Visible = false;
                panel3.Visible = false;
            }
            else if (perv.Count == 0)
            {
                panel4.Visible = false;
                panel3.Visible = false;
                panel2.Visible = false;

            }

           
            label16.Text = label17.Text;
            if (label18.Text != "")
            {
                label17.Text = label18.Text;
            }
            label18.Text = "";
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < perv.Count; i++)
            {
                if (perv[i][0] == label17.Text[0].ToString() || perv[i][1] == label17.Text[0].ToString())
                {
                    perv.RemoveAt(i); break;
                }

            }
            if (label17.Text[0] == 'A' || label17.Text[2] == 'A')
            {
                pictureBox5.Height = pictureBox5.Height - 10;
                pictureBox5.Width = pictureBox5.Width - 10;
                sch_krug1 = 0;
                sch_krug0 = 0;
            }
            else if (label17.Text[0] == 'B' || label17.Text[2] == 'B')
            {
                pictureBox9.Height = pictureBox9.Height - 10;
                pictureBox9.Width = pictureBox9.Width - 10;
                sch_krug2 = 0;
                sch_krug0 = 0;
            }
            else if (label17.Text[0] == 'C' || label17.Text[2] == 'C')
            {
                pictureBox10.Height = pictureBox10.Height - 10;
                pictureBox10.Width = pictureBox10.Width - 10;
                sch_krug3 = 0;
                sch_krug0 = 0;
            }
            if (label17.Text[0] == '1' || label17.Text[2] == '1')
            {
                pictureBox11.Height = pictureBox11.Height - 10;
                pictureBox11.Width = pictureBox11.Width - 10;
                sch_krug4 = 0;
                sch_krug0 = 0;
            }
            else if (label17.Text[0] == '2' || label17.Text[2] == '2')
            {
                pictureBox13.Height = pictureBox13.Height - 10;
                pictureBox13.Width = pictureBox13.Width - 10;
                sch_krug5 = 0;
                sch_krug0 = 0;
            }
            else if (label17.Text[0] == '3' || label17.Text[2] == '3')
            {
                pictureBox14.Height = pictureBox14.Height - 10;
                pictureBox14.Width = pictureBox14.Width - 10;
                sch_krug6 = 0;
                sch_krug0 = 0;
            }
            if (perv.Count == 2)
            {
                panel4.Visible = false;
            }
            else if (perv.Count == 1)
            {
                panel4.Visible = false;
                panel3.Visible = false;
            }
            else if (perv.Count == 0)
            {
                panel4.Visible = false;
                panel3.Visible = false;
                panel2.Visible = false;

            }
            if (label18.Text!="")
            {
                label17.Text = label18.Text;
            }
           
           
            label18.Text = "";
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < perv.Count; i++)
            {
                if (perv[i][0] == label18.Text[0].ToString() || perv[i][1] == label18.Text[0].ToString())
                {
                    perv.RemoveAt(i); break;
                }

            }
            if (label18.Text[0] == 'A' || label18.Text[2] == 'A')
            {
                pictureBox5.Height = pictureBox5.Height - 10;
                pictureBox5.Width = pictureBox5.Width - 10;
                sch_krug1 = 0;
                sch_krug0 = 0;
            }
            else if (label18.Text[0] == 'B' || label18.Text[2] == 'B')
            {
                pictureBox9.Height = pictureBox9.Height - 10;
                pictureBox9.Width = pictureBox9.Width - 10;
                sch_krug2 = 0;
                sch_krug0 = 0;
            }
            else if (label18.Text[0] == 'C' || label18.Text[2] == 'C')
            {
                pictureBox10.Height = pictureBox10.Height - 10;
                pictureBox10.Width = pictureBox10.Width - 10;
                sch_krug3 = 0;
                sch_krug0 = 0;
            }
            if (label18.Text[0] == '1' || label18.Text[2] == '1')
            {
                pictureBox11.Height = pictureBox11.Height - 10;
                pictureBox11.Width = pictureBox11.Width - 10;
                sch_krug4 = 0;
                sch_krug0 = 0;
            }
            else if (label18.Text[0] == '2' || label18.Text[2] == '2')
            {
                pictureBox13.Height = pictureBox13.Height - 10;
                pictureBox13.Width = pictureBox13.Width - 10;
                sch_krug5 = 0;
                sch_krug0 = 0;
            }
            else if (label18.Text[0] == '3' || label18.Text[2] == '3')
            {
                pictureBox14.Height = pictureBox14.Height - 10;
                pictureBox14.Width = pictureBox14.Width - 10;
                sch_krug6 = 0;
                sch_krug0 = 0;
            }
            if (perv.Count == 2)
            {
                panel4.Visible = false;
            }
            else if (perv.Count == 1)
            {
                panel4.Visible = false;
                panel3.Visible = false;
            }
            else if (perv.Count == 0)
            {
                panel4.Visible = false;
                panel3.Visible = false;
                panel2.Visible = false;

            }

            

            label18.Text = "";
        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {
            PlaySound(soundFilePath);

            this.Close();
        }
        DateTime t = DateTime.Now;

        private void Form2_Load(object sender, EventArgs e)
        {
            player.Load();

            this.FormBorderStyle = FormBorderStyle.None;
            timer1.Start();
        }
        TimeSpan vremya;
        private void timer1_Tick(object sender, EventArgs e)
        {
            //  DateTime t =  DateTime.Now;
            vremya = DateTime.Now - t;
            string sg = (vremya).ToString();
            string sg1 = "";
            sg1 += sg[3];
            sg1 += sg[4];
            sg1 += sg[5];
            sg1 += sg[6];
            sg1 += sg[7];

            label22.Text = sg1;
            
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_DoubleClick(object sender, EventArgs e)
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

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            enter((PictureBox)sender);
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            leave((PictureBox)sender);

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            PlaySound(soundFilePath);

        }

        private void label21_Click(object sender, EventArgs e)
        {
            PlaySound(soundFilePath);

        }

        private void label20_Click(object sender, EventArgs e)
        {
            PlaySound(soundFilePath);

        }

        private void label19_Click(object sender, EventArgs e)
        {
            PlaySound(soundFilePath);

        }
    }
}
