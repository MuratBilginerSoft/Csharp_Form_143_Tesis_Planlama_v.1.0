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
    public partial class Toplammaliyet : Form
    {
        #region Değişkenler

        int ys1, ys2, ys3; // Yıllık Satışlar

        int sm1, sm2, sm3; // Satış Masrafları

        int hm1, hm2, hm3; // Hammadde

        int t1, t2, t3; // Taşıma

        int es1, es2, es3; //Enerji Su

        int ü1, ü2, ü3; // Ücretler
        
        int dk1, dk2, dk3; // Diğer Kalemler

        int sbm1, sbm2, sbm3; // Sabit Maliyetler

        int nüm1, nüm2, nüm3; // Net Üretim Maliyetleri

        int tm1, tm2, tm3; // Toplam Maliyetler

        int k1, k2, k3; // Kar

        #endregion 

        #region Tanımlamalar

        #endregion

        #region Metodlar

        #endregion

       

        public Toplammaliyet()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            ys1 = int.Parse(textBox1.Text);
            ys2 = int.Parse(textBox2.Text);
            ys3 = int.Parse(textBox3.Text);

            sm1 = int.Parse(textBox4.Text);
            sm2 = int.Parse(textBox5.Text);
            sm3 = int.Parse(textBox6.Text);

            hm1 = int.Parse(textBox7.Text);
            hm2 = int.Parse(textBox8.Text);
            hm3 = int.Parse(textBox9.Text);

            t1 = int.Parse(textBox10.Text);
            t2 = int.Parse(textBox11.Text);
            t3 = int.Parse(textBox12.Text);

            es1 = int.Parse(textBox13.Text);
            es2 = int.Parse(textBox14.Text);
            es3 = int.Parse(textBox15.Text);

            ü1 = int.Parse(textBox16.Text);
            ü2 = int.Parse(textBox17.Text);
            ü3 = int.Parse(textBox18.Text);

            dk1 = int.Parse(textBox19.Text);
            dk2 = int.Parse(textBox20.Text);
            dk3 = int.Parse(textBox21.Text);

            sbm1 = int.Parse(textBox22.Text);
            sbm2 = int.Parse(textBox23.Text);
            sbm3 = int.Parse(textBox24.Text);

            label22.Text = sm1.ToString();
            label23.Text = sm2.ToString();
            label25.Text = sm3.ToString();

            nüm1 = hm1 + t1 + es1 + ü1 + dk1 + sbm1;
            nüm2 = hm2 + t2 + es2 + ü2 + dk2 + sbm2;
            nüm3 = hm3 + t3 + es3 + ü3 + dk3 + sbm3;

            label26.Text = nüm1.ToString();
            label27.Text = nüm1.ToString();
            label28.Text = nüm1.ToString();

            tm1 = sm1 + nüm1;
            tm2 = sm2 + nüm2;
            tm3 = sm3 + nüm3;

            label29.Text = tm1.ToString();
            label30.Text = tm2.ToString();
            label31.Text = tm3.ToString();

            k1 = ys1 - tm1;
            k2 = ys2 - tm2;
            k3 = ys3 - tm3;

            label32.Text = k1.ToString();
            label33.Text = k2.ToString();
            label34.Text = k3.ToString();

            if (k1 > k2 && k1 > k3)
            {
                label36.Text = k1.ToString();
                label37.Text = "A";

            }

            else if (k2 > k1 && k2 > k3)
            {
                label36.Text = k2.ToString();
                label37.Text = "B";
            }

            else if (k3 > k1 && k3 > k2)
            {
                label36.Text = k3.ToString();
                label37.Text = "C";
            }

            MessageBox.Show("İşleminiz Tamamlandı Sonuç Tablosundan En İdeal Yer Seçimini Görebilirsiniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);

            tabControl1.SelectedIndex = 1;
        }

        private void Toplammaliyet_Load(object sender, EventArgs e)
        {

        }

       

       
    }
}
