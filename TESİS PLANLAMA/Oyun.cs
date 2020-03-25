using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TESİS_PLANLAMA
{
    public partial class Oyun : Form
    {

        #region Değişkenler

        int ua1, ua2, ua3, ua4;

        int yh1, yh2, yh3, yh4;

        int yd1, yd2, yd3;

        int g1, g2,g3,g4;

        int top1, top2, top3, top4, toplam5;

        int toplamharcama;



        #endregion


        #region Tanımlamalar

        int[] matris1=new int[4];
        int[] matris2 = new int[4];
        int[] matris3 = new int[4];
        int[] matris4 = new int[4];
        int[] matris5 = new int[4];
        int[] matris6 = new int[4];
        int[] matris7 = new int[4];
        int[] matris8 = new int[4];
        int[] matris9 = new int[4];
        int[] matris10 = new int[4];
        int[] matris11 = new int[4];
        int[] matris12 = new int[4];

        


        #endregion

        #region Metodlar
 
        #endregion



        public Oyun()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            groupBox29.BackColor = Color.CornflowerBlue;
            groupBox30.BackColor = Color.CornflowerBlue;
            groupBox35.BackColor = Color.CornflowerBlue;
            groupBox40.BackColor = Color.CornflowerBlue;

            groupBox49.BackColor = Color.Teal;
            groupBox48.BackColor = Color.Teal;
            groupBox47.BackColor = Color.Teal;
            groupBox46.BackColor = Color.Teal;

            groupBox14.BackColor = Color.Transparent;
            groupBox15.BackColor = Color.Transparent;
            groupBox16.BackColor = Color.Transparent;
            groupBox17.BackColor = Color.Transparent;
            groupBox18.BackColor = Color.Transparent;

            groupBox8.BackColor = Color.Transparent;
            groupBox9.BackColor = Color.Transparent;
            groupBox10.BackColor = Color.Transparent;
            groupBox11.BackColor = Color.Transparent;
            groupBox12.BackColor = Color.Transparent;

            ua1 = 0;
            ua2 = int.Parse(textBox7.Text);
            ua3 = int.Parse(textBox8.Text);
            ua4 = int.Parse(textBox9.Text);

            yh1 = int.Parse(textBox10.Text);
            yh2 = int.Parse(textBox11.Text);
            yh3 = int.Parse(textBox12.Text);
            yh4 = int.Parse(textBox13.Text);

            yd1 = int.Parse(textBox14.Text);
            yd2 = int.Parse(textBox15.Text);
            yd3 = int.Parse(textBox16.Text);

            toplamharcama = yh1 + yh2 + yh3 + yh4;

            #region G1 A da

            // G1 ve G2 aynı Yerde Dükkan Açarsa

            label21.Text = ((toplamharcama * 60) / 100).ToString();
            label27.Text = ((toplamharcama * 60) / 100).ToString();
            label33.Text = ((toplamharcama * 60) / 100).ToString();
            label39.Text = ((toplamharcama * 60) / 100).ToString();
            matris1[0] = int.Parse(label21.Text);
            matris2[1] = int.Parse(label27.Text);
            matris3[2] = int.Parse(label33.Text);
            matris4[3] = int.Parse(label39.Text);
            matris5[0] = int.Parse(label21.Text);
            matris6[1] = int.Parse(label27.Text);
            matris7[2] = int.Parse(label33.Text);
            matris8[3] = int.Parse(label39.Text);

            // G1 A da İken G2 B de Dükkan Açarsa

            top1 = ((yh1 * yd1) / 100);
            top2 = ((yh2 * yd3) / 100);
            top3 = ((yh3 * yd3) / 100);
            top4 = ((yh4 * yd3) / 100);
            toplam5 = top1 + top2 + top3 + top4;
            label22.Text = toplam5.ToString();
            matris1[1] = toplam5;
            matris6[0] = toplam5;

            // G1 A da İken G2 C de İse

            g1 = ua2;
            g2 = ua3;

            top1 = ((yh1 * yd1) / 100);

            if (g1 < g2)
            {
                top2 = ((yh2 * yd1) / 100);
            }

            else if (g1 == g2)
            {
                top2 = ((yh2 * yd2) / 100);
            }

            else
            {
                top2 = ((yh2 * yd3) / 100);
            }

            top3 = ((yh3 * yd3) / 100);
            top4 = ((yh4 * yd3) / 100);

            toplam5 = top1 + top2 + top3 + top4;
            label23.Text = toplam5.ToString();
            matris1[2] = toplam5;
            matris7[0] = toplam5;
            // G1 A da iken G2 D de İse

            g1 = ua2;
            g2 = ua3 + ua4;
            g3 = ua4;

            top1 = ((yh1 * yd1) / 100);

            if (g1 < g2)
            {
                top2 = ((yh2 * yd1) / 100);
            }

            else if (g1 == g2)
            {
                top2 = ((yh2 * yd2) / 100);
            }

            else
            {
                top2 = ((yh2 * yd3) / 100);
            }

            if (g1 < g3)
            {
                top3 = ((yh3 * yd1) / 100);
            }

            else if (g1 == g3)
            {
                top3 = ((yh3 * yd2) / 100);
            }

            else
            {
                top3 = ((yh3 * yd3) / 100);
            }

            top4 = ((yh4 * yd3) / 100);
            toplam5 = top1 + top2 + top3 + top4;
            label24.Text = toplam5.ToString();
            matris1[3] = toplam5;
            matris8[0] = toplam5;
            #endregion


            #region G1 B de

            // G1 B de G2 A da İse

            top1 = ((yh1 * yd3) / 100);
            top2 = ((yh2 * yd1) / 100);
            top3 = ((yh3 * yd1) / 100);
            top4 = ((yh4 * yd1) / 100);
            toplam5 = top1 + top2 + top3 + top4;
            label26.Text = toplam5.ToString();
            matris2[0] = toplam5;
            matris5[1] = toplam5;
            // G1 B de G2 de C de ise

            top1 = ((yh1 * yd1) / 100);
            top2 = ((yh2 * yd1) / 100);
            top3 = ((yh3 * yd3) / 100);
            top4 = ((yh4 * yd3) / 100);
            toplam5 = top1 + top2 + top3 + top4;
            label28.Text = toplam5.ToString();
            matris2[2] = toplam5;
            matris7[1] = toplam5;
            // G1 B de G2 D de İse

            g1 = ua3;
            g2 = ua4;


            top1 = ((yh1 * yd1) / 100);
            top2 = ((yh2 * yd1) / 100);

            if (g1 < g2)
            {
                top3 = ((yh3 * yd1) / 100);
            }

            else if (g1 == g2)
            {
                top3 = ((yh3 * yd2) / 100);
            }

            else
            {
                top3 = ((yh3 * yd3) / 100);
            }

            top4 = ((yh4 * yd3) / 100);
            toplam5 = top1 + top2 + top3 + top4;
            label29.Text = toplam5.ToString();
            matris2[3] = toplam5;
            matris8[1] = toplam5;
            #endregion

            #region G1 C de

            // G1 C de G2 A da İse

            g1 = ua2;
            g2 = ua3;

            top1 = ((yh1 * yd3) / 100);

            if (g2 < g1)
            {
                top2 = ((yh2 * yd1) / 100);
            }

            else if (g2 == g1)
            {
                top2 = ((yh2 * yd2) / 100);
            }

            else
            {
                top2 = ((yh2 * yd3) / 100);
            }

            top3 = ((yh3 * yd1) / 100);
            top4 = ((yh4 * yd1) / 100);
            toplam5 = top1 + top2 + top3 + top4;
            label31.Text = toplam5.ToString();
            matris3[0] = toplam5;
            matris5[2] = toplam5;
            // G1 C de G2 B de İse

            top1 = ((yh1 * yd3) / 100);
            top2 = ((yh2 * yd3) / 100);
            top3 = ((yh3 * yd1) / 100);
            top4 = ((yh4 * yd1) / 100);
            toplam5 = top1 + top2 + top3 + top4;
            label32.Text = toplam5.ToString();
            matris3[1] = toplam5;
            matris6[2] = toplam5;
            // G1 C de G2 D de İse

            top1 = ((yh1 * yd1) / 100);
            top2 = ((yh2 * yd1) / 100);
            top3 = ((yh3 * yd1) / 100);
            top4 = ((yh4 * yd3) / 100);
            toplam5 = top1 + top2 + top3 + top4;
            label34.Text = toplam5.ToString();
            matris3[3] = toplam5;
            matris8[2] = toplam5;

            #endregion

            #region G1 D de

            // G1 D de G2 A da İse


            g1 = ua2;
            g2 = ua3 + ua4;

            top1 = ((yh1 * yd3) / 100);

            if (g2 < g1)
            {
                top2 = ((yh2 * yd1) / 100);
            }

            else if (g2 == g1)
            {
                top2 = ((yh2 * yd2) / 100);
            }

            else
            {
                top2 = ((yh2 * yd3) / 100);
            }

            g1 = ua2 + ua3;
            g2 = ua4;

            if (g2 < g1)
            {
                top3 = ((yh3 * yd1) / 100);
            }

            else if (g2 == g1)
            {
                top3 = ((yh3 * yd2) / 100);
            }

            else
            {
                top3 = ((yh3 * yd3) / 100);
            }

            top4 = ((yh4 * yd1) / 100);
            toplam5 = top1 + top2 + top3 + top4;
            label36.Text = toplam5.ToString();
            matris4[0] = toplam5;
            matris5[3] = toplam5;
            // G1 D de G2 B de İse

            g1 = ua3;
            g2 = ua4;

            top1 = ((yh1 * yd3) / 100);
            top2 = ((yh2 * yd3) / 100);

            if (g2 < g1)
            {
                top3 = ((yh3 * yd1) / 100);
            }

            else if (g2 == g1)
            {
                top3 = ((yh3 * yd2) / 100);
            }

            else
            {
                top3 = ((yh3 * yd3) / 100);
            }

            top4 = ((yh4 * yd1) / 100);
            toplam5 = top1 + top2 + top3 + top4;
            label37.Text = toplam5.ToString();
            matris4[1] = toplam5;
            matris6[3] = toplam5;

            // G1 D de G2 C de ise
            top1 = ((yh1 * yd3) / 100);
            top2 = ((yh2 * yd3) / 100);
            top3 = ((yh3 * yd3) / 100);
            top4 = ((yh4 * yd1) / 100);
            toplam5 = top1 + top2 + top3 + top4;
            label38.Text = toplam5.ToString();
            matris4[2] = toplam5;
            matris7[3] = toplam5;
            #endregion

            #region Sıralama İşlemleri

            Array.Sort(matris1);
            Array.Sort(matris2);
            Array.Sort(matris3);
            Array.Sort(matris4);
            Array.Sort(matris5);
            Array.Sort(matris6);
            Array.Sort(matris7);
            Array.Sort(matris8);


            label25.Text = matris1[0].ToString();
            label30.Text = matris2[0].ToString();
            label35.Text = matris3[0].ToString();
            label40.Text = matris4[0].ToString();

            label41.Text = matris5[3].ToString();
            label42.Text = matris6[3].ToString();
            label43.Text = matris7[3].ToString();
            label44.Text = matris8[3].ToString();

            #endregion

            matris9[0] = matris1[0];
            matris9[1] = matris2[0];
            matris9[2] = matris3[0];
            matris9[3] = matris4[0];

            matris11[0] = matris1[0];
            matris11[1] = matris2[0];
            matris11[2] = matris3[0];
            matris11[3] = matris4[0];

            matris10[0] = matris5[3];
            matris10[1] = matris6[3];
            matris10[2] = matris7[3];
            matris10[3] = matris8[3];

            matris12[0] = matris5[3];
            matris12[1] = matris6[3];
            matris12[2] = matris7[3];
            matris12[3] = matris8[3];


            Array.Sort(matris9);
            Array.Reverse(matris9);

            Array.Sort(matris10);

            int b = 0;
            int c = 0;

            foreach (int xx in matris11)
            {
                if (xx == matris9[0])
                {
                    break;
                }

                b++;
            }


            foreach (int xx in matris12)
            {
                if (xx == matris10[0])
                {
                    break;
                }

                c++;
            }

            if (b == 0)
            {
                groupBox29.BackColor = Color.Yellow;
            }

            else if (b == 1)
            {
                groupBox30.BackColor = Color.Yellow;
            }

            else if (b == 2)
            {
                groupBox35.BackColor = Color.Yellow;
            }

            else if (b == 3)
            {
                groupBox40.BackColor = Color.Yellow;
            }

            if (c == 0)
            {
                groupBox49.BackColor = Color.Yellow;
            }

            else if (c == 1)
            {
                groupBox48.BackColor = Color.Yellow;
            }

            else if (c == 2)
            {
                groupBox47.BackColor = Color.Yellow;
            }

            else if (c == 3)
            {
                groupBox46.BackColor = Color.Yellow;
            }

            if (b == 0 && c == 0 && int.Parse(label25.Text) == int.Parse(label41.Text))
            {
                groupBox9.BackColor = Color.Yellow;
                groupBox14.BackColor = Color.Yellow;
            }

            else if (b == 0 && c == 1)
            {
                groupBox9.BackColor = Color.Yellow;
                groupBox18.BackColor = Color.Yellow;
            }
            else if (b == 0 && c == 2)
            {
                groupBox9.BackColor = Color.Yellow;
                groupBox17.BackColor = Color.Yellow;
            }

            else if (b == 0 && c == 2)
            {
                groupBox9.BackColor = Color.Yellow;
                groupBox16.BackColor = Color.Yellow;
            }

            else if (b == 1 && c == 0)
            {
                groupBox10.BackColor = Color.Yellow;
                groupBox14.BackColor = Color.Yellow;
            }

            else if (b == 1 && c == 1)
            {
                groupBox10.BackColor = Color.Yellow;
                groupBox18.BackColor = Color.Yellow;
            }

            else if (b == 1 && c == 2)
            {
                groupBox10.BackColor = Color.Yellow;
                groupBox17.BackColor = Color.Yellow;
            }

            else if (b == 1 && c == 3)
            {
                groupBox10.BackColor = Color.Yellow;
                groupBox16.BackColor = Color.Yellow;
            }

            else if (b == 2 && c == 0)
            {
                groupBox11.BackColor = Color.Yellow;
                groupBox14.BackColor = Color.Yellow;
            }
            else if (b == 2 && c == 1)
            {
                groupBox11.BackColor = Color.Yellow;
                groupBox18.BackColor = Color.Yellow;
            }
            else if (b == 2 && c == 2)
            {
                groupBox11.BackColor = Color.Yellow;
                groupBox17.BackColor = Color.Yellow;
            }
            else if (b == 2 && c == 3)
            {
                groupBox11.BackColor = Color.Yellow;
                groupBox16.BackColor = Color.Yellow;
            }


            else if (b == 3 && c == 0)
            {
                groupBox8.BackColor = Color.Yellow;
                groupBox14.BackColor = Color.Yellow;
            }
            else if (b == 3 && c == 1)
            {
                groupBox8.BackColor = Color.Yellow;
                groupBox18.BackColor = Color.Yellow;
            }
            else if (b == 3 && c == 2)
            {
                groupBox8.BackColor = Color.Yellow;
                groupBox17.BackColor = Color.Yellow;
            }
            else if (b == 3 && c == 3)
            {
                groupBox8.BackColor = Color.Yellow;
                groupBox16.BackColor = Color.Yellow;
            }

            tabControl1.SelectedIndex = 1;
        }

        private void Oyun_Load(object sender, EventArgs e)
        {

        }

            
    }
}
