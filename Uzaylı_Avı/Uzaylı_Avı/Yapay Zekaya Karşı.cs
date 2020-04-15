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
    public partial class Bilgisayara_Karşı : Form
    {
        public Bilgisayara_Karşı()
        {
            InitializeComponent();
        }
        string g1, g2, g3, g4;
        int tekrar = 0, menu = 0, slpasif = 0, secenekler, geriSayim = 5, Gemipatlama = 0, p = 0, p2 = 0, atesKac, roketgidiyor = 0, gemix, rokety, gemiy, tersGemix, tersGemiy, tersRokety, SagSol, SagSol2, oyunBitti = 0;
        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (slpasif == 0)
            {
                if (geriSayim <= 0)
                {
                    if (oyunBitti == 0)
                    {
                        if (keyData == Keys.Right)
                        {
                            if (roketgidiyor == 1)
                            {
                                roketAtesle.Start();
                            }
                            else
                            {
                                roketgidiyor = 0;
                                gemix += 20;
                                roket.Left += 20;

                            }
                            if (gemi.Left >= 470)
                            {
                                if (roketgidiyor != 1)
                                {
                                    gemix = (gemi.Location.X) + 12;
                                    roket.Location = new Point(gemix, rokety);
                                }
                                button3.Location = new Point(485, 530);
                            }
                            else
                            {
                                button3.Left += 20;
                                button2.Left += 20;
                                gemi.Left += 20;
                                patlama.Left += 20;
                            }
                        }
                        if (keyData == Keys.Left)
                        {

                            if (roketgidiyor == 1)
                            {
                                roketAtesle.Start();
                            }
                            else
                            {
                                roketgidiyor = 0;
                                gemix -= 20;
                                roket.Left -= 20;

                            }
                            if (gemi.Left <= 15)
                            {
                                if (roketgidiyor != 1)
                                {
                                    gemix = (gemi.Location.X) + 12;
                                    roket.Location = new Point(gemix, rokety);
                                }
                                button3.Location = new Point(25, 530);
                            }
                            else
                            {
                                button3.Left -= 20;
                                button2.Left -= 20;
                                gemi.Left -= 20;
                                patlama.Left -= 20;
                            }
                        }
                    }
                    if (keyData == Keys.Space)
                    {
                        roketAtesle.Start();
                        roketgidiyor = 1;
                        if (button2.Bottom >= gemiTers.Top && button2.Left <= gemiTers.Right && button2.Right >= gemiTers.Left)
                        {
                            atesKac = 1;
                        }
                    }
                }
            }
                return base.ProcessDialogKey(keyData);            
        }
        public void CanAzal()
        {
            if (oyunBitti == 0)
            {
                progressBar1.Value -= 10;
            }
            if (progressBar1.Value <= 0)
            {
                label3.Visible = true;
                label3.Location = new Point(119, 303);
                label3.Text = "SEN KAZANDIN";
                oyunBitti = 1;
                gemiTers.Visible = false;
                p2 = 1;
                timerPatlama.Start();
                progressBar1.Visible = false;
                progressBar2.Visible = false;
                roketTers.Visible = false;
                gemiTers.Location = new Point(700, 20);
                roket.Visible = false;
                button4.Visible = true;
                button5.Visible = true;
                button6.Visible = true;
                seceneklerPasif = 1;
                progressBar3.Visible = true;
            }
        }
        public void CanAzal2()
        {

            if (oyunBitti == 0)
            {
                progressBar2.Value -= 10;
            }
            if (progressBar2.Value <= 0)
            {
                label3.Visible = true;
                label3.Location = new Point(119, 303);
                label3.Text = "YAPAY ZEKA KAZANDI";
                oyunBitti = 1;
                p = 1;
                gemi.Visible = false;
                timerPatlama.Start();
                progressBar1.Visible = false;
                progressBar2.Visible = false;
                roket.Visible = false;
                roketTers.Visible = false;
                gemi.Location = new Point(700, 20);
                button4.Visible = true;
                button5.Visible = true;
                button6.Visible = true;
                seceneklerPasif = 1;
                progressBar3.Visible = true;
            }
        }
        Random r = new Random();
        int rastgeleArac;
        private void Bilgisayara_Karşı_Load(object sender, EventArgs e)
        {
            rastgeleArac = r.Next(0, 4);
            if (rastgeleArac == 0)
            {  
                gemiTers.Image = Image.FromFile("GemiTers1.png");
            }
            else if (rastgeleArac == 1)
            {  
                gemiTers.Image = Image.FromFile("GemiTers2.png");
            }
            else if (rastgeleArac == 2)
            {
                gemiTers.Image = Image.FromFile("GemiTers3.png");
            }
            else if (rastgeleArac == 3)
            {
                gemiTers.Image = Image.FromFile("GemiTers4.png");
            }
            g1 = AracSec.g1.ToString();
            g2 = AracSec.g2.ToString();
            g3 = AracSec.g3.ToString();
            g4 = AracSec.g4.ToString();
            if (g1 == "a")
            {
                gemi.Image = Image.FromFile("gemi1.png");
            }
            else if (g2 == "a")
            {
                gemi.Image = Image.FromFile("gemi2.png");
            }
            else if (g3 == "a")
            {
                gemi.Image = Image.FromFile("gemi3.png");
            }
            else if (g4 == "a")
            {
                gemi.Image = Image.FromFile("gemi4.png");
            }
            button7.Visible = false;
            label3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            zamanlayici.Start();
            progressBar3.Value = 0;
            progressBar3.Visible = false;
            patlama.Visible = false;
            patlamaTers.Visible = false;
            progressBar1.Value = 100;
            progressBar2.Value = 100;
            tersRoketAtesEtsinmi.Start();
            button3.Visible = false;
            tersRoketAtesle.Start();
            kovalaKac.Start();
            roketTers.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            roket.Visible = false;
            gemix = 234;
            gemiy = 564;
            rokety = 560;
            tersGemix = 236;
            tersGemiy = 63;
            tersRokety = 138;
            gemiTers.Location = new Point(tersGemix, tersGemiy);
            roketTers.Location = new Point(tersGemix, tersRokety);
            gemi.Location = new Point(gemix, gemiy);
            roket.Location = new Point(gemix, rokety);
        }
        void kacKomutu()
        {
            int pcSol = gemiTers.Left;
            if (gemi.Left > pcSol)
            {
                gemiTers.Left++;
                button1.Left++;
                roketTers.Left++;
                patlamaTers.Left++;
            }
            else if (gemi.Left < pcSol)
            {
                gemiTers.Left--;
                button1.Left--;
                roketTers.Left--;
                patlamaTers.Left--;
            }
        }

        private void kovalaKac_Tick(object sender, EventArgs e)
        {
            if (slpasif == 0)
            {
                if (geriSayim <= 0)
                {
                    if (oyunBitti == 0)
                    {
                        int pcSol = gemiTers.Left;
                        if (gemiTers.Left >= 470)
                        {
                            button1.Location = new Point(480, 144);
                            solaKac.Start();
                            kovalaKac.Stop();

                        }
                        if (gemiTers.Left <= 10)
                        {
                            button1.Location = new Point(20, 144);
                            sagaKac.Start();
                            kovalaKac.Stop();
                        }
                        else
                        {
                            if (atesKac == 0)
                            {
                                kacKomutu();

                            }
                            else if (atesKac == 1)
                            {
                                if (gemiTers.Left <= button2.Left)
                                {
                                    button1.Left--;
                                    gemiTers.Left--;
                                    roketTers.Left--;
                                    patlamaTers.Left--;
                                }
                                else
                                {
                                    button1.Left++;
                                    gemiTers.Left++;
                                    roketTers.Left++;
                                    patlamaTers.Left++;
                                }
                            }
                        }
                    }
                }
            }
        }
        private void roketAtesle_Tick(object sender, EventArgs e)
        {
            if (slpasif == 0)
            {
                if (geriSayim <= 0)
                {
                    int fuztop = roket.Top;
                    int fuzsol = roket.Right;
                    int fuzsag = roket.Left;
                    roket.Visible = true;
                    rokety -= 25;
                    roket.Location = new Point(gemix + 15, rokety);
                    if (rokety <= -20)
                    {
                        atesKac = 0;
                        gemix = (gemi.Location.X) + 12;
                        roketAtesle.Stop();
                        roketgidiyor = 0;
                        rokety = 560;
                        roket.Visible = false;
                        roket.Location = new Point(gemix, rokety);
                    }
                    if (button1.Bottom >= fuztop && button1.Left <= fuzsol && button1.Right >= fuzsag)
                    {
                        roket.Visible = false;
                        CanAzal();
                        gemix = (gemi.Location.X) + 12;
                        rokety = 560;
                        roket.Location = new Point(gemix, rokety);
                        roketgidiyor = 0;
                        roketAtesle.Stop();
                    }
                }
            }
        }
        private void solaKac_Tick(object sender, EventArgs e)
        {

            if (oyunBitti == 0)
            {
                SagSol++;
                if (SagSol <= 50)
                {
                    SagSol = 0;
                    kovalaKac.Start();
                    solaKac.Stop();
                }
                else
                {
                    gemiTers.Left--;
                    button1.Left--;
                    patlamaTers.Left--;
                }
            }
        }
        private void sagaKac_Tick(object sender, EventArgs e)
        {
            if (oyunBitti == 0)
            {
                SagSol2++;
                if (SagSol2 >= 50)
                {
                    SagSol2 = 0;
                    kovalaKac.Start();
                    sagaKac.Stop();
                }
                else
                {
                    gemiTers.Left++;
                    button1.Left++;
                    patlamaTers.Left++;
                }
            }
        }
        int sayac;
        private void tersRoketAtesle_Tick(object sender, EventArgs e)
        {
            if (slpasif == 0)
            {
                if (geriSayim <= 0)
                {
                    int fuztop = roketTers.Top;
                    int fuzsol = roketTers.Right;
                    int fuzsag = roketTers.Left;
                    if (oyunBitti == 0)
                    {
                        roketTers.Visible = true;
                        tersRokety += 25;
                        roketTers.Location = new Point(tersGemix + 20, tersRokety);
                    }
                    if (tersRokety >= 680)
                    {
                        tersGemix = (gemiTers.Location.X) + 12;
                        tersRokety = 115;
                        roketTers.Visible = false;
                        roketTers.Location = new Point(tersGemix, tersRokety);

                    }
                    if (button3.Top <= fuztop && button3.Left <= fuzsol && button3.Right >= fuzsag)
                    {
                        if (button7.Top < roketTers.Bottom) 
                        {
                            
                            CanAzal2();
                          
                        }
                        roketTers.Visible = false;
                        tersGemix = (gemiTers.Location.X) + 12;
                        tersRokety = 115;
                        roketTers.Location = new Point(tersGemix, tersRokety);
                    }
                }
            }
        }
        private void tersRoketAtesEtsinmi_Tick(object sender, EventArgs e)
        {
            if (slpasif == 0)
            {
                if (geriSayim <= 0)
                {
                    if (button2.Bottom >= gemiTers.Top && button2.Left <= gemiTers.Right && button2.Right >= gemiTers.Left)
                    {
                        tersRoketAtesle.Start();
                    }
                    else
                    {
                        int fuztop = roketTers.Top;
                        int fuzsol = roketTers.Right;
                        int fuzsag = roketTers.Left;
                        if (tersRokety >= 660)
                        {
                            tersRoketAtesle.Stop();
                        }
                        if (button3.Top <= fuztop && button3.Left <= fuzsol && button3.Right >= fuzsag)
                        {
                            tersRoketAtesle.Stop();
                        }
                    }
                }
            }
        }
        public void Patlama(int g, int g2)
        {
            roket.Visible = false;
            roketTers.Visible = false;
            gemiTers.Enabled = false;
            gemi.Enabled = false;
            roket.Enabled = false;
            if (g == 1)
            {
                patlama.Visible = true;
                patlama.Enabled = true;
            }
            if (g2 == 1)
            {
                patlamaTers.Visible = true;
                patlamaTers.Enabled = true;
            }
            Gemipatlama += 1;
            if (Gemipatlama == 3)
            {
                if (g == 1)
                {
                    patlama.Visible = false;
                    patlama.Enabled = false;

                }
                if (g2 == 1)
                {
                    patlamaTers.Visible = false;
                    patlamaTers.Enabled = false;

                }

                timerPatlama.Stop();
                Gemipatlama = 0;

            }
        }
        private void timerPatlama_Tick(object sender, EventArgs e)
        {
            if (p == 1)
            {
                Patlama(1, 0);
            }
            else if (p2 == 1)
            {
                Patlama(0, 1);
            }
        }
        int ikinciGeriSayim = 2;
        private void zamanlayici_Tick(object sender, EventArgs e)
        {
            if (slpasif == 0)
            {
                geriSayim--;
                label2.Text = geriSayim.ToString();            
                if (geriSayim <= 0)
                {
                    label2.Location = new Point(132, 209);
                    label2.Text = "Başla";
                    ikinciGeriSayim--;
                    if (ikinciGeriSayim <= 0) 
                    {
                        label2.Visible = false;
                    }
                }
            }
        }
        private void Bilgisayara_Karşı_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        int seceneklerPasif = 0;
        private void label1_Click(object sender, EventArgs e)
        {
            if (seceneklerPasif == 0) 
            {
                secenekler += 1;
                if (secenekler == 1)
                {
                    slpasif = 1;
                    progressBar3.Visible = true;
                    button4.Visible = true;
                    button5.Visible = true;
                    button6.Visible = true;
                }
                else
                {
                    slpasif = 0;
                    secenekler = 0;
                    progressBar3.Visible = false;
                    button4.Visible = false;
                    button5.Visible = false;
                    button6.Visible = false;

                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tekrar = 1;
            progres.Start();
        }

        private void progres_Tick(object sender, EventArgs e)
        {
            if (tekrar == 1)
            {
                progressBar3.Value += 20;
                if (progressBar3.Value >= 100)
                {
                    progres.Stop();
                    Bilgisayara_Karşı frm = new Bilgisayara_Karşı();
                    frm.Show();
                    this.Hide();
                }

                menu = 0;
            }
            else if (menu == 1)
            {

                progressBar3.Value += 20;
                if (progressBar3.Value >= 100)
                {
                    progres.Stop();
                    Menü frm2 = new Menü();
                    frm2.Show();
                    this.Hide();
                }
                tekrar = 0;

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            menu = 1;
            progres.Start();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
