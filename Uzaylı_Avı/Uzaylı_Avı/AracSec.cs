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
    public partial class AracSec : Form
    {
        public static string g1, g2, g3, g4;     
        public AracSec()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            g4 = "b";
            g2 = "b";
            g3 = "b";
            g1 = "a";
            button1.Visible = true;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            g4 = "b";
            g2 = "b";
            g3 = "a";
            g1 = "b";
            button1.Visible = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            g4 = "b";
            g2 = "a";
            g3 = "b";
            g1 = "b";
            button1.Visible = true;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            g4 = "a";
            g2 = "b";
            g3 = "b";
            g1 = "b";
            button1.Visible = true;
        }
        string neSecti;
        private void button1_Click(object sender, EventArgs e)
        {
            neSecti = Menü.secim;
            if (neSecti == "bilgisayar")
            {
                kk frm = new kk();
                this.Hide();
                frm.Show();
            }
            else if (neSecti == "yapay") 
            {
                Bilgisayara_Karşı frm = new Bilgisayara_Karşı();
                this.Hide();
                frm.Show();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Menü frm2 = new Menü();
            this.Hide();
            frm2.Show();
        }

        private void AracSec_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            radioButton3.Checked = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            radioButton2.Checked = true;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            radioButton4.Checked = true;
        }



    }
}
