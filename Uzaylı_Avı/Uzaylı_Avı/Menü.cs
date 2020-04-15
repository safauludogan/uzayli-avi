using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Uzaylı_Avı
{
    public partial class Menü : Form
    {
        public static string OyuncuAdi, IkiOyuncu1, IkiOyuncu2;

        public Menü()
        {
            InitializeComponent();
        }
        public static string secim;
        int uzaylilar = 0, İkiOyuncu = 0;
        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Menü2_Load(object sender, EventArgs e)
        {
            
            label12.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Skor frm5 = new Skor();
            frm5.Show();
            this.Hide();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Oynayış frm6 = new Oynayış();
            frm6.Show();
            this.Hide();
        }

        private void Menü2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        int sayac1 = 0, sayac2 = 0, sayac3 = 0;       
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            sayac1 = 1;
            if (char.IsNumber(e.KeyChar))//metin giriliyor rakam girilemiyor
            {
                e.Handled = true;
            }
            if (char.IsSeparator(e.KeyChar))//metin giriliyor rakam girilemiyor
            {
                e.Handled = true;
            }
            if (e.KeyChar == 22)
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            sayac2 = 1;
            if (char.IsNumber(e.KeyChar))//metin giriliyor rakam girilemiyor
            {
                e.Handled = true;
            }
            if (char.IsSeparator(e.KeyChar))//metin giriliyor rakam girilemiyor
            {
                e.Handled = true;
            }
            if (e.KeyChar == 22)
            {
                e.Handled = true;
            }
        }
        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            sayac3 = 1;
            if (char.IsNumber(e.KeyChar))//metin giriliyor rakam girilemiyor
            {
                e.Handled = true;
            }
            if (char.IsSeparator(e.KeyChar))//metin giriliyor rakam girilemiyor
            {
                e.Handled = true;
            }
            if (e.KeyChar == 22)
            {
                e.Handled = true;
            }
        }
        private void button2_Click_1(object sender, EventArgs e)
        {           
            textBox1.Text = "";
            textBox2.Text = "";            
            OyuncuAdi = textBox3.Text.ToUpper();
            AracSec frm3 = new AracSec();
            uzaylilar = 1;
            if (uzaylilar == 1)
            {
                label12.Visible = false;
                label13.Visible = false;
                textBox1.Visible = false;
                textBox2.Visible = false;
                label14.Visible = true;
                textBox3.Visible = true;
                label14.Visible = true;
                textBox3.Visible = true;
                if (textBox3.Text == "")
                {
                    label4.Text = "Lütfen Oyuncu İsminizi Giriniz";                                    
                }
                else if  (sayac3 == 1) 
                {
                    secim = "bilgisayar";
                    this.Hide();
                    frm3.Show(); 
                }
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";           
            IkiOyuncu1 = textBox1.Text.ToUpper();
            IkiOyuncu2 = textBox2.Text.ToUpper();
            İkiOyuncu = 1;
            AracSec2 frm4 = new AracSec2();
            if (İkiOyuncu == 1)
            {
                label14.Visible = false;
                textBox3.Visible = false;
                label12.Visible = true;
                label13.Visible = true;
                textBox1.Visible = true;
                textBox2.Visible = true;
                if (textBox1.Text == "" || textBox2.Text == "") 
                {
                    label4.Text = "Lütfen Oyuncu İsimlerini Giriniz";                                                    
                }
                else  if (sayac1 == 1 && sayac2 == 1) 
                {
                    
                    this.Hide();
                    frm4.Show();
                }

            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("");
        }
        private void button4_Click(object sender, EventArgs e)
        {
            AracSec frm = new AracSec();
            this.Hide();
            frm.Show();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";          
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
            if (MessageBox.Show("Yapay Zeka ile Oynamak İstiyormusunuz.", "Yapay Zeka", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                secim = "yapay";
                AracSec frm = new AracSec();
                this.Hide();
                frm.Show();
            }
           
        }
    }
}



