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
    public partial class FaktörAğırlık : Form
    {
        #region Değişkenler

        double s1, s2, s3;

        double atoplam;

        #endregion
        
        #region Tanımlamalar

        double[] igi= new double[4];
        double[] ty = new double[4];
        double[] iü = new double[4];
        double[] ç  = new double[4]; 
        double[] my = new double[4]; 
        double[] ut = new double[4]; 
        double[] hh = new double[4]; 

        #endregion

        #region Metodlar

        #endregion



        public FaktörAğırlık()
        {
            InitializeComponent();
        }

        private void FaktörAğırlık_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            atoplam = double.Parse(textBox1.Text) + double.Parse(textBox5.Text) + double.Parse(textBox9.Text) + double.Parse(textBox13.Text) + double.Parse(textBox17.Text) + double.Parse(textBox21.Text) + double.Parse(textBox25.Text);

            label26.Text = atoplam.ToString();
            if (atoplam!=1.0)
            {
                MessageBox.Show("Ağrılıklar toplamı 1 yapmalıdır değerlerinizi kontrol edip tekrar giriniz","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

            else
            {
                label26.Text = ((double.Parse(textBox2.Text) * double.Parse(textBox1.Text))).ToString();
                label27.Text = ((double.Parse(textBox3.Text) * double.Parse(textBox1.Text))).ToString();
                label28.Text = ((double.Parse(textBox4.Text) * double.Parse(textBox1.Text))).ToString();

                label29.Text = ((double.Parse(textBox6.Text) * double.Parse(textBox5.Text))).ToString();
                label30.Text = (double.Parse(textBox7.Text) * double.Parse(textBox5.Text)).ToString();
                label31.Text = (double.Parse(textBox8.Text) * double.Parse(textBox5.Text)).ToString();

                label32.Text = (double.Parse(textBox10.Text) * double.Parse(textBox9.Text)).ToString();
                label33.Text = (double.Parse(textBox11.Text)* double.Parse(textBox9.Text)).ToString();
                label34.Text = (double.Parse(textBox12.Text) * double.Parse(textBox9.Text)).ToString();

                label35.Text = (double.Parse(textBox14.Text) * double.Parse(textBox13.Text)).ToString();
                label36.Text = (double.Parse(textBox15.Text) * double.Parse(textBox13.Text)).ToString();
                label37.Text = (double.Parse(textBox16.Text) * double.Parse(textBox13.Text)).ToString();

                label38.Text = (double.Parse(textBox18.Text) * double.Parse(textBox17.Text)).ToString();
                label39.Text = (double.Parse(textBox19.Text) * double.Parse(textBox17.Text)).ToString();
                label40.Text = (double.Parse(textBox20.Text) * double.Parse(textBox17.Text)).ToString();

                label41.Text = (double.Parse(textBox22.Text) * double.Parse(textBox21.Text)).ToString();
                label42.Text = (double.Parse(textBox23.Text) * double.Parse(textBox21.Text)).ToString();
                label43.Text = (double.Parse(textBox24.Text) * double.Parse(textBox21.Text)).ToString();

                label44.Text = (double.Parse(textBox26.Text) * double.Parse(textBox25.Text)).ToString();
                label45.Text = (double.Parse(textBox27.Text) * double.Parse(textBox25.Text)).ToString();
                label46.Text = (double.Parse(textBox28.Text) * double.Parse(textBox25.Text)).ToString();

                s1 = (double.Parse(label26.Text) + double.Parse(label29.Text) + double.Parse(label32.Text) + double.Parse(label35.Text) + double.Parse(label38.Text) + double.Parse(label41.Text) + double.Parse(label44.Text));
                s2 = (double.Parse(label27.Text) + double.Parse(label30.Text) + double.Parse(label33.Text) + double.Parse(label36.Text) + double.Parse(label39.Text) + double.Parse(label42.Text) + double.Parse(label45.Text));
                s3= (double.Parse(label28.Text) + double.Parse(label31.Text) + double.Parse(label34.Text) + double.Parse(label37.Text) + double.Parse(label40.Text) + double.Parse(label43.Text) + double.Parse(label46.Text));

                label47.Text = s1.ToString();
                label48.Text = s2.ToString();
                label49.Text = s3.ToString();


                if (s1>s2 && s1>s3)
                {
                    label52.Text = s1.ToString();
                    label51.Text = "A";
                }

                else if (s2>s1 && s2>s3)
                {
                    label52.Text = s2.ToString();
                    label51.Text = "B";
                }

                else
                {
                    label52.Text = s3.ToString();
                    label51.Text = "C";
                }
            }
        }
    }
}
