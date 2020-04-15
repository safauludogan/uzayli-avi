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
    public partial class İki_Oyuncu : Form
    {
        public İki_Oyuncu()
        {
            InitializeComponent();
        }
        string g1, g2, g3, g4, gt1, gt2, gt3, gt4;
        int slpasif = 0, p = 0, p2 = 0, Gemipatlama = 0, oyunBitti = 0, tersGemix, tersGemiy, tersRokety, gemix, gemiy, rokety, roketgidiyor = 0, tersRoketGidiyor = 0, secenekler = 0, tekrar = 0, menu = 0;
        
        public void CanAzal()
        {
            progressBar1.Value -= 10;
            if (progressBar1.Value <= 0)
            {
                gemiTers.Visible = false; 
                p2 = 1;
                timerPatlama.Start();
                label4.Visible = true;
                label4.Text = "Kazanan Oyuncu : " + Menü.IkiOyuncu2.ToString();
                oyunBitti = oyunBitti + 1;
                progressBar1.Visible = false;
                progressBar2.Visible = false;
                button1.Visible = true;
                button2.Visible = true;
                button3.Visible = true;
                progressBar3.Visible = true;
                roketTers.Visible = false;
                gemiTers.Location = new Point(700,20);
                
            }
        }
        public void CanAzal2()
        {
            progressBar2.Value -= 10;
            if (progressBar2.Value <= 0)
            {
                p = 1;
                gemi.Visible = false;
                timerPatlama.Start();
                progressBar1.Visible = false;
                progressBar2.Visible = false;
                label4.Visible = true;
                label4.Text = "Kazanan Oyuncu : " + Menü.IkiOyuncu1.ToString();
                oyunBitti = oyunBitti + 1;
                button1.Visible = true;
                button2.Visible = true;
                button3.Visible = true;
                progressBar3.Visible = true;
                roket.Visible = false;
                roketTers.Visible = false;
                gemi.Location = new Point(700, 20);
                
            }
        }
        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (slpasif == 0)
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
                                               
                        button5.Location = new Point(474, 521);
                    }
                    else
                    {
                        button5.Left += 20;
                        patlama.Left += 20;
                        gemi.Left += 20;
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
                        button5.Location = new Point(14, 521);
                    }
                    else
                    {
                        button5.Left -= 20;
                        patlama.Left -= 20;
                        gemi.Left -= 20;
                    }

                }
                //2.Oyuncu Kontrolü
                if (keyData == Keys.D)
                {
                    if (tersRoketGidiyor == 1)
                    {
                        tersRoketAtesle.Start();
                    }
                    else
                    {
                        tersRoketGidiyor = 0;
                        tersGemix += 20;
                        roketTers.Left += 20;
                    }
                    if (gemiTers.Left >= 470)
                    {
                        if (tersRoketGidiyor != 1)
                        {
                            tersGemix = (gemiTers.Location.X) + 12;
                            roketTers.Location = new Point(tersGemix, tersRokety);                            
                        }                       
                        button4.Location = new Point(480, 117);
                    }
                    else
                    {
                        button4.Left += 20;
                        patlamaTers.Left += 20;
                        gemiTers.Left += 20;
                    }
                }
                if (keyData == Keys.A)
                {
                    if (tersRoketGidiyor == 1)
                    {
                        tersRoketAtesle.Start();
                    }
                    else
                    {
                        tersRoketGidiyor = 0;
                        tersGemix -= 20;
                        roketTers.Left -= 20;

                    }
                    if (gemiTers.Left <= 15)
                    {
                        if (tersRoketGidiyor != 1) 
                        {
                            tersGemix = (gemiTers.Location.X) + 12;
                            roketTers.Location = new Point(tersGemix, tersRokety); 
                        }                       
                        button4.Location = new Point(-7, 117);
                    }
                    else
                    {
                        button4.Left -= 20;
                        patlamaTers.Left -= 20;
                        gemiTers.Left -= 20;
                    }                    
                }
                if (keyData == Keys.Space)
                {
                    roketAtesle.Start();
                    roketgidiyor = 1;
                }
                else if (keyData == Keys.T)
                {
                    tersRoketAtesle.Start();
                    tersRoketGidiyor = 1;
                }
            }
            return base.ProcessDialogKey(keyData);
        }
        private void İki_Oyuncu_Load(object sender, EventArgs e)
        {            
            label4.Visible = false;
            patlama.Visible = false;
            patlamaTers.Visible = false;
            g1 = AracSec2.g1.ToString();
            g2 = AracSec2.g2.ToString();
            g3 = AracSec2.g3.ToString();
            g4 = AracSec2.g4.ToString();
            gt1 = AracSec2.gt1.ToString();
            gt2 = AracSec2.gt2.ToString();
            gt3 = AracSec2.gt3.ToString();
            gt4 = AracSec2.gt4.ToString();
            if (g1 == "a")
            {

                gemi.Image = Image.FromFile("gemi1.png");
            }
            if (g2 == "a")
            {
                this.gemi.Size = new System.Drawing.Size(78, 89);
                gemi.Image = Image.FromFile("gemi2.png");
            }
            if (g3 == "a")
            {
                gemi.Image = Image.FromFile("gemi3.png");
            }
            if (g4 == "a")
            {
                gemi.Image = Image.FromFile("gemi4.png");
            }
            //
            if (gt1 == "a")
            {

                gemiTers.Image = Image.FromFile("GemiTers1.png");
            }
            if (gt2 == "a")
            {
                this.gemi.Size = new System.Drawing.Size(78, 89);
                gemiTers.Image = Image.FromFile("GemiTers2.png");
            }
            if (gt3 == "a")
            {
                gemiTers.Image = Image.FromFile("GemiTers3.png");
            }
            if (gt4 == "a")
            {
                gemiTers.Image = Image.FromFile("GemiTers4.png");
            }
            label4.Visible = false;
            oyunBitti = 0;
            label2.Text = "Oyuncu : " + Menü.IkiOyuncu1.ToString();
            label3.Text = "Oyuncu : " + Menü.IkiOyuncu2.ToString();
            progressBar3.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            gemiTers.Location = new Point(236, 63);
            roket.Location = new Point(259, 560);
            roketTers.Location = new Point(262, 138);
            progressBar1.Value = 100;
            progressBar2.Value = 100;
            roket.Visible = false;
            roketTers.Visible = false;
            gemix = 234;
            gemiy = 564;
            rokety = 560;
            tersGemix = 236;
            tersGemiy = 63;
            tersRokety = 138;
            gemiTers.Location = new Point(tersGemix,tersGemiy);
            roketTers.Location = new Point(tersGemix,tersRokety);
            gemi.Location = new Point(gemix, gemiy);
            roket.Location = new Point(gemix, rokety);          
            
        }
        private void roketAtesle_Tick(object sender, EventArgs e)
        {
            if (oyunBitti == 0)
            {
                int fuztop = roket.Top;
                int fuzsol = roket.Right;
                int fuzsag = roket.Left;               
                roket.Visible = true;
                rokety -= 25;
                roket.Location = new Point(gemix + 15, rokety);
                if (rokety <= -20)
                {
                    gemix = (gemi.Location.X) + 12;
                    roketAtesle.Stop();
                    roketgidiyor = 0;
                    rokety = 560;
                    roket.Visible = false;
                    roket.Location = new Point(gemix, rokety);
                }
                if (button4.Bottom >= fuztop && button4.Left <= fuzsol && button4.Right >= fuzsag)
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
            else
            {
                roket.Visible = false;
                roketTers.Visible = false;

            }
        }
        private void tersRoketAtesle_Tick(object sender, EventArgs e)
        {
            if (oyunBitti == 0)
            {
                int fuztop = roketTers.Top;
                int fuzsol = roketTers.Right;
                int fuzsag = roketTers.Left;
                roketTers.Visible = true;
                tersRokety += 25;
                roketTers.Location = new Point(tersGemix + 20, tersRokety);
                if (tersRokety >= 707)
                {
                    tersGemix = (gemiTers.Location.X) + 12;
                    tersRoketAtesle.Stop();
                    tersRoketGidiyor = 0;
                    tersRokety = 115;
                    roketTers.Visible = false;
                    roketTers.Location = new Point(tersGemix, tersRokety);
                }
                if (button5.Top <= fuztop && button5.Left <= fuzsol && button5.Right >= fuzsag)
                {
                    roketTers.Visible = false;
                    CanAzal2();
                    tersGemix = (gemiTers.Location.X) + 12;
                    tersRokety = 115;
                    roketTers.Location = new Point(tersGemix, tersRokety);
                    tersRoketGidiyor = 0;
                    tersRoketAtesle.Stop();
                }
            }
            else
            {
                roket.Visible = false;
                roketTers.Visible = false;
            }
           
        }

        private void label1_Click(object sender, EventArgs e)
        {
            secenekler += 1;
            if (secenekler == 1)
            {
                slpasif = 1;
                button1.Visible = true;
                button2.Visible = true;
                button3.Visible = true;
                progressBar3.Visible = true;
            }
            else
            {
                slpasif = 0;
                secenekler = 0;
                button1.Visible = false;
                button2.Visible = false;
                button3.Visible = false;
                progressBar3.Visible = false;

            }
        }

        private void progres_Tick(object sender, EventArgs e)
        {
            if (tekrar == 1)
            {
                
                progressBar3.Value += 20;
                if (progressBar3.Value >= 100)
                {
                    progres.Stop();
                    İki_Oyuncu frm = new İki_Oyuncu();
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

        private void button1_Click(object sender, EventArgs e)
        {
            tekrar = 1;
            progres.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            menu = 1;
            progres.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void İki_Oyuncu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        public void Patlama(int g,int g2)
        {
            slpasif = 1;
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
               Patlama(1,0);
            }
            else if (p2 == 1)
            {
               Patlama(0, 1);
            }
            
        }
    }
}
