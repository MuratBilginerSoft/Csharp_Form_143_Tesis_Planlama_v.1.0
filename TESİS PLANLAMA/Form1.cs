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
    public partial class Form1 : Form
    {

        #region Değişkenler

        #endregion

        #region Tanımlamalar

        
        FaktörAğırlık fafrm = new FaktörAğırlık();
        Toplammaliyet tmfrm = new Toplammaliyet();
        Oyun ofrm = new Oyun();
        Dikdoğrusal ddfrm = new Dikdoğrusal();

        #endregion 

        #region Metodlar

        public void formaç(Form x)
        {
            this.Hide();
            x.ShowDialog();
            this.Show();
        }

        #endregion

        #region MouseHover

        private void label1_MouseHover(object sender, EventArgs e)
        {
            label1.BackColor = Color.DeepSkyBlue;
        }

        private void label2_MouseHover(object sender, EventArgs e)
        {
            label2.BackColor = Color.DeepSkyBlue;
        }

        private void label3_MouseHover(object sender, EventArgs e)
        {
            label3.BackColor = Color.DeepSkyBlue;
        }

        private void label4_MouseHover(object sender, EventArgs e)
        {
            label4.BackColor = Color.DeepSkyBlue;
        }


        #endregion

        #region MouseLeave

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.BackColor = Color.CadetBlue;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.BackColor = Color.CadetBlue;
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.BackColor = Color.CadetBlue;
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            label4.BackColor = Color.CadetBlue;
        }

        #endregion

        #region LabelClick

        private void label1_Click(object sender, EventArgs e)
        {
            formaç(tmfrm);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            formaç(fafrm);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            formaç(ddfrm);
        }

        private void label4_Click(object sender, EventArgs e)
        {
            formaç(ofrm);
        }

        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
