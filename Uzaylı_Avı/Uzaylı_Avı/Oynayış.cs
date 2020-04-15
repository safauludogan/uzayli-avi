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
    public partial class Oynayış : Form
    {
        public Oynayış()
        {
            InitializeComponent();
        }
        int sayac = 0, sayac2 = 0, sayac3 = 0, bitir = 0, menu = 0, tekrar = 0, secenekler = 0;
        private void sola_Tick(object sender, EventArgs e)
        {
            if (secenekler == 0)
            {
                button8.BackColor = Color.White;
                button8.ForeColor = Color.Crimson;
                button1.BackColor = Color.White;
                button1.ForeColor = Color.Crimson;
                label1.Text = "Sola gitmek için sol ok yön tusunu kullanınız.";
                gemi.Left -= 5;
                if (gemi.Left <= 15)
                {
                    button8.BackColor = Color.Crimson;
                    button8.ForeColor = Color.White;
                    button1.BackColor = Color.Crimson;
                    button1.ForeColor = Color.White;
                    label1.Visible = false;
                    sure.Start();
                    sola.Stop();
                }
            }
        }

        private void Oynayış_Load(object sender, EventArgs e)
        {
            progressBar1.Visible = false;
            button10.Visible = false;
            button9.Visible = false;
            button11.Visible = false;
            button10.Enabled = false;
            button9.Enabled = false;
            button11.Enabled = false;
            label1.Visible = false;
            roket.Visible = false;
            FormAcıldı.Start();
        }

        private void FormAcıldı_Tick(object sender, EventArgs e)
        {
            if (secenekler == 0)
            {
                label1.Visible = true;
                label1.Text = "Hoş Geldiniz!";
                sayac += 1;
                if (sayac == 3)
                {
                    sola.Start();
                    FormAcıldı.Stop();
                }
            }
        }

        private void saga_Tick(object sender, EventArgs e)
        {
            if (secenekler == 0)
            {
                label1.Visible = true;
                button7.BackColor = Color.White;
                button7.ForeColor = Color.Crimson;
                button2.BackColor = Color.White;
                button2.ForeColor = Color.Crimson;
                label1.Text = "Sağa gitmek için sağ ok yön tuşunu kullanınız.";
                gemi.Left += 5;
                if (gemi.Left >= 600)
                {
                    button7.BackColor = Color.Crimson;
                    button7.ForeColor = Color.White;
                    button2.BackColor = Color.Crimson;
                    button2.ForeColor = Color.White;


                    sure2.Start();
                    saga.Stop();
                }
            }
        }

        private void sure_Tick(object sender, EventArgs e)
        {
            if (secenekler == 0)
            {
                sayac2 += 1;
                if (sayac2 == 3)
                {

                    saga.Start();
                    sola.Stop();
                    sure.Stop();

                }
                if (sayac == 1)
                {
                    sola.Stop();
                    saga.Stop();
                    gemi.Location = new Point(320, 616);
                }
            }
        }

        private void sure2_Tick(object sender, EventArgs e)
        {
            if (secenekler == 0)
            {
                sayac3 += 1;
                if (sayac3 == 3)
                {

                    button3.BackColor = Color.White;
                    button3.ForeColor = Color.Crimson;
                    button6.BackColor = Color.White;
                    button6.ForeColor = Color.Crimson;
                    label1.Text = "Ateş etmek için space tuşuna basınız, ikinci oyuncu iseniz T ye basınız";
                    gemi.Location = new Point(320, 616);
                    sure2.Stop();
                    roketAtesle.Start();

                }
            }
        }

        private void roketAtesle_Tick(object sender, EventArgs e)
        {
            if (secenekler == 0)
            {
                roket.Visible = true;
                roket.Top -= 25;
                if (roket.Top <= 25)
                {
                    button3.BackColor = Color.Crimson;
                    button3.ForeColor = Color.White;
                    button6.BackColor = Color.Crimson;
                    button6.ForeColor = Color.White;
                    bitir += 1;
                    if (bitir == 60)
                    {
                        label4.Visible = false;
                        progressBar1.Visible = true;
                        button10.Visible = true;
                        button9.Visible = true;
                        button11.Visible = true;
                        button10.Enabled = true;
                        button9.Enabled = true;
                        button11.Enabled = true;
                        //
                        label1.Visible = false;
                        label2.Visible = false;
                        button1.Visible = false;
                        button2.Visible = false;
                        button3.Visible = false;

                        button6.Visible = false;
                        button7.Visible = false;
                        button8.Visible = false;
                        gemi.Visible = false;
                        roket.Visible = false;

                        button10.Enabled = true;
                        button9.Enabled = true;
                        button11.Enabled = true;
                    }
                }
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            tekrar = 1;
            progres.Start();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            menu = 1;
            progres.Start();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Oynayış_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void progres_Tick(object sender, EventArgs e)
        {
            if (tekrar == 1)
            {

                progressBar1.Value += 20;
                if (progressBar1.Value >= 100)
                {
                    progres.Stop();
                    Oynayış frm = new Oynayış();
                    frm.Show();
                    this.Hide();
                }

                menu = 0;
            }
            else if (menu == 1)
            {

                progressBar1.Value += 20;
                if (progressBar1.Value >= 100)
                {
                    progres.Stop();
                    Menü frm2 = new Menü();
                    frm2.Show();
                    this.Hide();
                }
                tekrar = 0;

            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            secenekler += 1;
            if (secenekler == 1)
            {                            
                button10.Enabled = true;
                button9.Enabled = true;
                button11.Enabled = true;
                button9.Visible = true;
                button10.Visible = true;
                button11.Visible = true;
                progressBar1.Visible = true;
            }
            else
            {                
                button10.Enabled = false;
                button9.Enabled = false;
                button11.Enabled = false;
                button9.Visible = false;
                button10.Visible = false;
                button11.Visible = false;
                progressBar1.Visible = false;
                secenekler = 0;
            }
        }

    }
}
