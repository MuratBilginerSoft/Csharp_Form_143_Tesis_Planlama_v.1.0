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
    public partial class Dikdoğrusal : Form
    {
        #region Değişkenler

        int a = 0, b=0;

        int ag1, ag2, ag3, ag4, ag5;

        int agy1, agy2, agy3, agy4, agy5;

        int t,z;

        int y;

        #endregion


        #region Tanımlamalar

        string[] tezgah = { "P1", "P2", "P3", "P4", "P5" };

        string[] tezgahx = new string[5];

        string[] tezgahy = new string[5];

        int[,] Koordinat=new int[5,4];

        int[] koordinatx = new int[5];

        int[] koordinaty = new int[5];

        int[] koordinatxx = new int[5];

        int[] koordinatyy = new int[5];

        int[] toplamağırlık=new int[5];

        int[] toplamağırlıky = new int[5];

        #endregion

        #region Metodlar

        #endregion


        public Dikdoğrusal()
        {
            InitializeComponent();
        }

        private void Dikdoğrusal_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("En iyi koordinatlar bulundu. Diğer Sayfalarda Sonuçlara göz atabilirsiniz.","Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Information);

            #region Koordinatlar Alındı

            Koordinat[0, 0] = 0;
            Koordinat[1, 0] = 1;
            Koordinat[2, 0] = 2;
            Koordinat[3, 0] = 3;
            Koordinat[4, 0] = 4;

            Koordinat[0, 1] = int.Parse(textBox1.Text);
            Koordinat[0, 2] = int.Parse(textBox2.Text);
            Koordinat[0, 3] = int.Parse(textBox3.Text);

            Koordinat[1, 1] = int.Parse(textBox4.Text);
            Koordinat[1, 2] = int.Parse(textBox5.Text);
            Koordinat[1, 3] = int.Parse(textBox6.Text);

            Koordinat[2, 1] = int.Parse(textBox7.Text);
            Koordinat[2, 2] = int.Parse(textBox8.Text);
            Koordinat[2, 3] = int.Parse(textBox9.Text);

            Koordinat[3, 1] = int.Parse(textBox10.Text);
            Koordinat[3, 2] = int.Parse(textBox11.Text);
            Koordinat[3, 3] = int.Parse(textBox12.Text);

            Koordinat[4, 1] = int.Parse(textBox13.Text);
            Koordinat[4, 2] = int.Parse(textBox14.Text);
            Koordinat[4, 3] = int.Parse(textBox15.Text);

            #endregion

            #region En İyi X Belirle

            for (int i = 0; i < 5; i++)
            {
                koordinatx[i] = Koordinat[i, 1];
                
            }

            Array.Sort(koordinatx);

            foreach (int değer in koordinatx)
            {
                for (int i = 0; i < 5; i++)
                {
                    if (değer==Koordinat[i,1])
                    {
                        koordinatxx[a] = i;
                        a++;
                        break;
                    }
                   
                }
            }

            #region Tezgah Sıralaması

            label14.Text = tezgah[koordinatxx[0]];
            label15.Text = tezgah[koordinatxx[1]];
            label16.Text = tezgah[koordinatxx[2]];
            label17.Text = tezgah[koordinatxx[3]];
            label18.Text = tezgah[koordinatxx[4]];

            #endregion

            #region X Sıralması

            label20.Text = koordinatx[0].ToString();
            label23.Text = koordinatx[1].ToString();
            label26.Text = koordinatx[2].ToString();
            label29.Text = koordinatx[3].ToString();
            label32.Text = koordinatx[4].ToString();

            #endregion

            #region Ağırlık Sıralaması

            label21.Text = Koordinat[koordinatxx[0], 3].ToString();
            label24.Text = Koordinat[koordinatxx[1], 3].ToString();
            label27.Text = Koordinat[koordinatxx[2], 3].ToString();
            label30.Text = Koordinat[koordinatxx[3], 3].ToString();
            label33.Text = Koordinat[koordinatxx[4], 3].ToString();

            ag1 = int.Parse(label21.Text);
            ag2 = int.Parse(label24.Text);
            ag3 = int.Parse(label27.Text);
            ag4 = int.Parse(label30.Text);
            ag5 = int.Parse(label33.Text);


            ag2 = ag1 + ag2;
            ag3 = ag3 + ag2;
            ag4 = ag4 + ag3;
            ag5 = ag5 + ag4;

            toplamağırlık[0]=ag1;
            toplamağırlık[1]=ag2;
            toplamağırlık[2]=ag3;
            toplamağırlık[3]=ag4;
            toplamağırlık[4]=ag5;
            
            #endregion

            #region Toplam Ağırlık Yazma

            label22.Text = ag1.ToString();
            label25.Text = ag2.ToString();
            label28.Text = ag3.ToString();
            label31.Text = ag4.ToString();
            label34.Text = ag5.ToString();

            #endregion

            t = ag5 / 2;

            for (int i = 0; i < 5; i++)
            {
                if (toplamağırlık[i]>t)
                {
                     y = i;
                    break;
                }
            }

            int yenix=koordinatx[y];

            label59.Text = yenix.ToString();

            #endregion

            #region En İyi Y Belirle

            
            for (int i = 0; i < 5; i++)
            {
                koordinaty[i] = Koordinat[i, 2];


            }
            Array.Sort(koordinaty);



            foreach (int değer2 in koordinaty)
            {
                for (int i = 0; i < 5; i++)
                {
                    if (değer2 == Koordinat[i, 2])
                    {
                        koordinatyy[b] = i;
                        b++;
                        break;
                    }

                }
            }

            label53.Text = tezgah[koordinatyy[0]];
            label54.Text = tezgah[koordinatyy[1]];
            label55.Text = tezgah[koordinatyy[2]];
            label56.Text = tezgah[koordinatyy[3]];
            label57.Text = tezgah[koordinatyy[4]];

            label51.Text = koordinaty[0].ToString();
            label48.Text = koordinaty[1].ToString();
            label45.Text = koordinaty[2].ToString();
            label42.Text = koordinaty[3].ToString();
            label39.Text = koordinaty[4].ToString();

            label50.Text = Koordinat[koordinatyy[0], 3].ToString();
            label47.Text = Koordinat[koordinatyy[1], 3].ToString();
            label44.Text = Koordinat[koordinatyy[2], 3].ToString();
            label41.Text = Koordinat[koordinatyy[3], 3].ToString();
            label38.Text = Koordinat[koordinatyy[4], 3].ToString();

            agy1 = int.Parse(label50.Text);
            agy2 = int.Parse(label47.Text);
            agy3 = int.Parse(label44.Text);
            agy4 = int.Parse(label41.Text);
            agy5 = int.Parse(label38.Text);


            agy2 = agy1 + agy2;
            agy3 = agy3 + agy2;
            agy4 = agy4 + agy3;
            agy5 = agy5 + agy4;

            toplamağırlıky[0] = agy1;
            toplamağırlıky[1] = agy2;
            toplamağırlıky[2] = agy3;
            toplamağırlıky[3] = agy4;
            toplamağırlıky[4] = agy5;


            label49.Text = agy1.ToString();
            label46.Text = agy2.ToString();
            label43.Text = agy3.ToString();
            label40.Text = agy4.ToString();
            label37.Text = agy5.ToString();

            z = agy5 / 2;

            for (int i = 0; i < 5; i++)
            {
                if (toplamağırlıky[i] > z)
                {
                    y = i;
                    break;
                }
            }

            int yeniy = koordinaty[y];

            label60.Text = yeniy.ToString();
            #endregion

            #region Toplam Maliyet Hesapla

            label64.Text = "( " + yenix + ", " + yeniy + ")";

            int maliyetx =(Koordinat[0, 3] * (Math.Abs((yenix - Koordinat[0, 1])))) + (Koordinat[1, 3] * (Math.Abs((yenix - Koordinat[1, 1])))) + (Koordinat[2, 3] * (Math.Abs((yenix - Koordinat[2, 1])))) + (Koordinat[3, 3] * (Math.Abs((yenix - Koordinat[3, 1]))))+(Koordinat[4, 3] * (Math.Abs((yenix - Koordinat[4, 1]))));
            
            int maliyety = (Koordinat[0, 3] * Math.Abs((yeniy - Koordinat[0, 2]))) + (Koordinat[1, 3] * Math.Abs((yeniy - Koordinat[1, 2]))) + (Koordinat[2, 3] * Math.Abs((yeniy - Koordinat[2, 2]))) + (Koordinat[3, 3] * Math.Abs((yeniy - Koordinat[3, 2]))) + (Koordinat[4, 3] * Math.Abs((yeniy - Koordinat[4, 2])));

            label65.Text = "F1(" + yenix + ") = " + "(" + Koordinat[0, 3] + " * " + Math.Abs((yenix - Koordinat[0, 1])) + ")" + " + " + "(" + Koordinat[1, 3] + " * " + Math.Abs((yenix - Koordinat[1, 1])) + ")" + " + " + "(" + Koordinat[2, 3] + " * " + Math.Abs((yenix - Koordinat[2, 1])) + ")" + " + " + "(" + Koordinat[3, 3] + " * " + Math.Abs((yenix - Koordinat[3, 1])) + ")" + " + " + "(" + Koordinat[4, 3] + " * " + Math.Abs((yenix - Koordinat[4, 1])) + ")" + "= " + maliyetx;

            label66.Text = "F1(" + yeniy + ") = " + "(" + Koordinat[0, 3] + " * " + Math.Abs((yeniy - Koordinat[0, 2])) + ")" + " + " + "(" + Koordinat[1, 3] + " * " + Math.Abs((yeniy - Koordinat[1, 2])) + ")" + " + " + "(" + Koordinat[2, 3] + " * " + Math.Abs((yeniy - Koordinat[2, 2])) + ")" + " + " + "(" + Koordinat[3, 3] + " * " + Math.Abs((yeniy - Koordinat[3, 2])) + ")" + " + " + "(" + Koordinat[4, 3] + " * " + Math.Abs((yeniy - Koordinat[4, 2])) + ")" + "= " + maliyety;


            label67.Text = "Enkf(" + yenix + "," + yeniy + ")=" +( maliyetx + maliyety)+"  Pb'dir";

            #endregion
        }

       
    
    }
}
