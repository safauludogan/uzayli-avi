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
    public partial class AracSec2 : Form
    {
        public static string g1, g2, g3, g4, gt1, gt2, gt3, gt4;
        public AracSec2()
        {
            InitializeComponent();
        }
       
        private void AracSec2_Load(object sender, EventArgs e)
        {
            
            radioButton1.Checked = true;
            radioButton5.Checked = true;
            groupBox2.Text = Menü.IkiOyuncu1 + " Gemini Seç";
            groupBox1.Text = Menü.IkiOyuncu2 + " Gemini Seç";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {            
            g1 = "a";
            g2 = "b";
            g3 = "b";
            g4 = "b";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {            
            g1 = "b";
            g2 = "a";
            g3 = "b";
            g4 = "b";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            g1 = "b";
            g2 = "b";
            g3 = "a";
            g4 = "b";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {            
            g1 = "b";
            g2 = "b";
            g3 = "b";
            g4 = "a";
        }        
        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
           
            gt1 = "a";
            gt2 = "b";
            gt3 = "b";
            gt4 = "b";
        }
        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            gt1 = "b";
            gt2 = "a";
            gt3 = "b";
            gt4 = "b";
        }
        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            gt1 = "b";
            gt2 = "b";
            gt3 = "a";
            gt4 = "b";
        }
        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            gt1 = "b";
            gt2 = "b";
            gt3 = "b";
            gt4 = "a";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Menü frm2 = new Menü();
            frm2.Show();
            this.Hide();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            İki_Oyuncu frm = new İki_Oyuncu();
            frm.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            radioButton5.Checked = true;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            radioButton6.Checked = true;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            radioButton7.Checked = true;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            radioButton8.Checked = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            radioButton2.Checked = true;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            radioButton3.Checked = true;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            radioButton4.Checked = true;
        }
    }
}
