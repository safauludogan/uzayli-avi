using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Uzaylı_Avı
{
    public partial class OyunuBaslatSeviye2 : Form
    {
        public OyunuBaslatSeviye2()
        {
            InitializeComponent();
        }
        int gemix, gemiy, rokety, roketgidiyor = 0, oyunBitti = 0, puan = 0, menu = 0, secenekler = 0, Gemipatlama = 0;
        OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='GameKayıt.accdb'");
        OleDbCommand sorgu = new OleDbCommand();

        string sql;
        public void SqleOyuncu()
        {
            try
            {
                
                baglan.Open();
                sorgu.Connection = baglan;
                sql = "insert into PuanTablosu(Adi,Puani) values ('" + OyuncuAdi.Text + "'," + Convert.ToInt32(Puan2.Text) + ")";
                sorgu.CommandText = sql;
                sorgu.ExecuteNonQuery();

            }
            finally
            {
                baglan.Close();
            }
        }
        public void OnlukPuan()
        {

            puan = puan + 20;
            
            Puan2.Text = puan.ToString();
        }
        public void YirmilikPuan()
        {
            puan = puan + 40;
            Puan2.Text = puan.ToString();
        }
        public void OtuzlukPuan()
        {
            
            puan = puan + 60;
            Puan2.Text = puan.ToString();
        }
        public void Canlar(PictureBox canavar , ProgressBar CanavarCan, int sayi)
        {
            int fuztop = roket.Top;
            int fuzsol = roket.Right;
            int fuzsag = roket.Left;

            if (canavar.Bottom >= fuztop && canavar.Left <= fuzsol && canavar.Right >= fuzsag)
            {
                
                CanavarCan.Value -= 20;
                if (CanavarCan.Value <= 0)
                {
                    if (sayi == 10)
                    {
                        OnlukPuan();
                    }
                    else if (sayi == 20)
                    {

                        YirmilikPuan();
                    }
                    else if (sayi == 30) 
                    {
                        OtuzlukPuan();
                    }
                    gemix = (gemi.Location.X) + 12;
                    rokety = 602;
                    roket.Location = new Point(gemix, rokety);
                    roketgidiyor = 0;
                    timerRoketAtesle.Stop();
                    roketgidiyor = 0;
                    roket.Visible = false;
                    canavar.Location = new Point(343, -1000);
                    canavar.Visible = false;
                    CanavarCan.Visible = false;
                    CanavarCan.Location = new Point(347, -500);
                    
                }
                else
                {
                    gemix = (gemi.Location.X) + 12;
                    rokety = 602;
                    roket.Location = new Point(gemix, rokety);
                    roketgidiyor = 0;
                    timerRoketAtesle.Stop();
                    roket.Visible = false;
                }

            }

        }
        public void kaybetme()
        {
            kontrol.Stop();
            kk.Text = "Kaybettiniz";
            kk.Visible = true;
            progressBar1.Visible = true;
            Secenekler.Visible = false;
            secenekler = 0;
            oyunBitti = oyunBitti + 1;
            
           
            can1.Visible = false;
            can2.Visible = false;
            can3.Visible = false;
            can4.Visible = false;
            can5.Visible = false;
            can6.Visible = false;
            can7.Visible = false;
            can8.Visible = false;
            can9.Visible = false;
            Can1Can.Visible = false;
            Can2Can.Visible = false;
            Can3Can.Visible = false;
            Can4Can.Visible = false;
            Can5Can.Visible = false;
            Can6Can.Visible = false;
            Can7Can.Visible = false;
            Can8Can.Visible = false;
            Can9Can.Visible = false;

            if (can1.Visible == false && can2.Visible == false && can3.Visible == false && can4.Visible == false && can5.Visible == false && can6.Visible == false && can7.Visible == false && can8.Visible == false && can9.Visible == false)// && can10.Visible == false && can11.Visible == false && can12.Visible == false && can13.Visible == false && can14.Visible == false && can15.Visible == false && can16.Visible == false && can17.Visible == false && can18.Visible == false)
            {
                oyunBitti = oyunBitti + 1;
                Puan1.Visible = true;
                timerCanavarSaga.Stop();
                timerCanavarSola.Stop();
                timerGemiSaga.Stop();
                timerGemiSola.Stop();
                timerRoketAtesle.Stop();
              
                roket.Visible = false;
            }
           
            C.Visible = true;
            M.Visible = true;
          
            C.Enabled = true;
            M.Enabled = true;
        }
        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (keyData == Keys.Left)
            {
                timerGemiSola.Start();
                timerGemiSaga.Stop();
            }
            else if (keyData == Keys.Right)
            {
                timerGemiSaga.Start();
                timerGemiSola.Stop();
            }
            else if (keyData == Keys.Down)
            {
                timerGemiSaga.Stop();
                timerGemiSola.Stop();
            }
            else if (keyData == Keys.Space)
            {
                roketgidiyor = 1;
                timerRoketAtesle.Start();
            }
            return base.ProcessDialogKey(keyData);
        }
        private void OyunuBaslatSeviye2_Load(object sender, EventArgs e)
        {
            duvarS1.Visible = false;
            duvarS2.Visible = false;
            duvarS3.Visible = false;
            duvar1.Visible = false;
            duvar2.Visible = false;
            duvar3.Visible = false;
            duvar1.Location = new Point(169, -44);
            duvar2.Location = new Point(343, -44);
            duvar3.Location = new Point(514, -44);
            kontrol.Start();
            kk.Visible = false;
            progressBar1.Visible = false;
            
            C.Visible = false;
            M.Visible = false;
          
            C.Enabled = false;
            M.Enabled = false;
            Puan2.Text = OyunuBaslat.puan.ToString();
            puan = Convert.ToInt32(OyunuBaslat.puan.ToString());
            OyuncuAdi.Text = Menü2.OyuncuAdi.ToString().Trim().ToUpper();
            Can1Can.Value = 100;
            Can2Can.Value = 100;
            Can3Can.Value = 100;
            Can4Can.Value = 100;
            Can5Can.Value = 100;
            Can6Can.Value = 100;
            Can7Can.Value = 100;
            Can8Can.Value = 100;
            Can9Can.Value = 100;

            Can1Can.Location = new Point(167, 29);
            Can2Can.Location = new Point(343, 29);
            Can3Can.Location = new Point(514, 29);
            Can4Can.Location = new Point(170, -155);
            Can5Can.Location = new Point(346, -155);
            Can6Can.Location = new Point(518, -155);
            Can7Can.Location = new Point(170, -332);
            Can8Can.Location = new Point(342, -332);
            Can9Can.Location = new Point(517, -332);
           
            can1.Location = new Point(168, 44);
            can2.Location = new Point(344, 44);
            can3.Location = new Point(515, 44);
            can4.Location = new Point(174, -139);
            can5.Location = new Point(344, -139);
            can6.Location = new Point(515, -139);
            can7.Location = new Point(173, -325);
            can8.Location = new Point(344, -325);
            can9.Location = new Point(515, -325);
            button1.Visible = false;
            button1.Location = new Point(515, -325);
            timerCanavarSola.Start();
            timerCanavarSaga.Stop();
            gemix = 299;
            gemiy = 602;
            rokety = 602;
            gemi.Location = new Point(gemix, gemiy);
            roket.Location = new Point(gemix, rokety);
            roket.Visible = false;
        }

        private void timerGemiSola_Tick(object sender, EventArgs e)
        {
            if (roketgidiyor == 1)
            {
                timerRoketAtesle.Start();

            }
            else
            {

                roketgidiyor = 0;
                gemix -= 5;
                roket.Left -= 5;

            }
            if (gemi.Left <= 15)
            {

                timerGemiSola.Stop();
                timerGemiSaga.Stop();
            }
            else
            {
                patlama.Left -= 5;
                gemi.Left -= 5;
            }
        }

        private void timerGemiSaga_Tick(object sender, EventArgs e)
        {
            if (roketgidiyor == 1)
            {
                timerRoketAtesle.Start();

            }
            else
            {

                roketgidiyor = 0;
                gemix += 5;
                roket.Left += 5;

            }
            if (gemi.Left >= 600)
            {
                timerGemiSola.Stop();
                timerGemiSaga.Stop();
            }
            else
            {
                patlama.Left += 5;
                gemi.Left += 5;
            }
        }

        private void timerRoketAtesle_Tick(object sender, EventArgs e)
        {
            if (oyunBitti == 0)
            {
                int fuztop = roket.Top;
                int fuzsol = roket.Right;
                int fuzsag = roket.Left;
                if (button1.Top >= roket.Top)
                {


                    roket.Visible = true;
                    rokety -= 25;
                    roket.Location = new Point(gemix, rokety);


                    if (rokety <= -35)
                    {
                        gemix = (gemi.Location.X) + 12;
                        roket.Location = new Point(gemix, rokety);
                        timerRoketAtesle.Stop();
                        roketgidiyor = 0;
                        rokety = 602;
                        roket.Visible = false;
                    }
                }
                else
                {

                    roket.Visible = true;
                    rokety -= 25;
                    roket.Location = new Point(gemix, rokety);
                    Canlar(can1, Can1Can, 10);
                    Canlar(can2, Can2Can, 10);
                    Canlar(can3, Can3Can, 10);
                    Canlar(can4, Can4Can, 20);
                    Canlar(can5, Can5Can, 20);
                    Canlar(can6, Can6Can, 20);
                    Canlar(can7, Can7Can, 30);
                    Canlar(can8, Can8Can, 30);
                    Canlar(can9, Can9Can, 30);
                    
                }
            }
            else if (oyunBitti == 1)
            {
                roket.Visible = false;
                roket.Location = new Point(500, -1000);
            }
        }

        private void timerCanavarSola_Tick(object sender, EventArgs e)
        {
            if (can1.Bottom >= 529 || can2.Bottom >= 529 || can3.Bottom >= 529 || can4.Bottom >= 529 || can5.Bottom >= 529 || can6.Bottom >= 529 || can7.Bottom >= 529 || can8.Bottom >= 529 || can9.Bottom >= 529)// || can10.Bottom >= 529 || can11.Bottom >= 529 || can12.Bottom >= 529 || can13.Bottom >= 529 || can14.Bottom >= 529 || can15.Bottom >= 529 || can16.Bottom >= 529 || can17.Bottom >= 529 || can18.Bottom >= 529)
            {
                timerPatlama.Start();
                kaybetme();
                timerCanavarSaga.Stop();
                timerCanavarSola.Stop();
              
            }
            else
            {

                button1.Left -= 4;
                Can1Can.Left -= 4;
                Can2Can.Left -= 4;
                Can3Can.Left -= 4;
                Can4Can.Left -= 4;
                Can5Can.Left -= 4;
                Can6Can.Left -= 4;
                Can7Can.Left -= 4;
                Can8Can.Left -= 4;
                Can9Can.Left -= 4;
                foreach (var item in this.Controls)
                {
                    if (item is PictureBox)
                    {
                        
                        if (((PictureBox)item).Name != "sınır" && ((PictureBox)item).Name != "roket" && ((PictureBox)item).Name != "gemi"&& ((PictureBox)item).Name != "patlama")
                        {

                            ((PictureBox)item).Left -= 4;
                        }
                    }

                }

                if (duvarS1.Left <= 167 || duvarS2.Left <= 167 || duvarS3.Left <= 167)
                {
                    timerCanavarSola.Stop();
                    button1.Top += 34;
                    Can1Can.Top += 34;
                    Can2Can.Top += 34;
                    Can3Can.Top += 34;
                    Can4Can.Top += 34;
                    Can5Can.Top += 34;
                    Can6Can.Top += 34;
                    Can7Can.Top += 34;
                    Can8Can.Top += 34;
                    Can9Can.Top += 34;
                    foreach (var item in this.Controls)
                    {
                        if (item is PictureBox)
                        {
                          
                            if (((PictureBox)item).Name != "sınır" && ((PictureBox)item).Name != "roket" && ((PictureBox)item).Name != "gemi"&& ((PictureBox)item).Name != "patlama")
                            {

                                ((PictureBox)item).Top += 34;
                            }
                        }

                    }
                    timerCanavarSaga.Start();
                }

            }
        }

        private void timerCanavarSaga_Tick(object sender, EventArgs e)
        {
            if (can1.Bottom >= 529 || can2.Bottom >= 529 || can3.Bottom >= 529 || can4.Bottom >= 529 || can5.Bottom >= 529 || can6.Bottom >= 529|| can7.Bottom >= 529 || can8.Bottom >= 529 || can9.Bottom >= 529)// || can10.Bottom >= 529 || can11.Bottom >= 529 || can12.Bottom >= 529 || can13.Bottom >= 529 || can14.Bottom >= 529 || can15.Bottom >= 529 || can16.Bottom >= 529 || can17.Bottom >= 529 || can18.Bottom >= 529)
            {
                timerPatlama.Start();
                kaybetme();
            }
            else
            {

                if (duvar1.Left >= 515 || duvar2.Left >= 515 || duvar3.Left >= 515)
                {
                    timerCanavarSaga.Stop();
                    timerCanavarSola.Start();
                }
                else
                {

                    button1.Left += 4;
                    Can1Can.Left += 4;
                    Can2Can.Left += 4;
                    Can3Can.Left += 4;
                    Can4Can.Left += 4;
                    Can5Can.Left += 4;
                    Can6Can.Left += 4;
                    Can7Can.Left += 4;
                    Can8Can.Left += 4;
                    Can9Can.Left += 4;
                    foreach (var item in this.Controls)
                    {
                        if (item is PictureBox)
                        {

                            if ((((PictureBox)item).Name != "sınır" && ((PictureBox)item).Name != "roket" && ((PictureBox)item).Name != "gemi")&& ((PictureBox)item).Name != "patlama")
                            {

                                ((PictureBox)item).Left += 4;

                            }
                        }
                    }
                }


            }
        }

        private void OyunuBaslatSeviye2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Td_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Devam ederseniz oyun 1.seviyeden devam eder.", "Tekrar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Puan2.Text = OyunuBaslat.puan.ToString();
                puan = Convert.ToInt32(OyunuBaslat.puan.ToString());
             
                timerProgres.Start();
               
            }
            
        }

        private void timerProgres_Tick(object sender, EventArgs e)
        {
            
            if (menu == 1)
            {
                M.Enabled = false;
              
                progressBar1.Value += 20;
                if (progressBar1.Value >= 100)
                {
                    timerProgres.Stop();
                    Menü2 frm2 = new Menü2();
                    frm2.Show();
                    this.Hide();
                }
               
            }
        }

        private void M_Click(object sender, EventArgs e)
        {
            SqleOyuncu();
            menu = 1;
            timerProgres.Start();
        }

        private void C_Click(object sender, EventArgs e)
        {
            SqleOyuncu();
            Application.Exit();
        }

        private void Secenekler_Click(object sender, EventArgs e)
        {
            secenekler += 1;
            if (secenekler == 1)
            {
                C.Enabled = true;
              
                M.Enabled = true;
                progressBar1.Enabled = true;
                C.Visible = true;
               
                M.Visible = true;
                progressBar1.Visible = true;
            }
            else
            {

                C.Enabled = false;
                
                M.Enabled = false;
                progressBar1.Enabled = false;
                C.Visible = false;
          
                M.Visible = false;
                progressBar1.Visible = false;
                secenekler = 0;

            }
        }

        private void kontrol_Tick(object sender, EventArgs e)
        {
            if (can3.Visible == false && can6.Visible == false && can9.Visible == false)
            {
                duvar3.Location = new Point(500, -1000);
            }
            if (can2.Visible == false && can5.Visible == false && can8.Visible == false)
            {
                duvar2.Location = new Point(500, -1000);
            }
            if (can1.Visible == false && can4.Visible == false && can7.Visible == false)
            {
                duvar1.Location = new Point(500, -1000);
            }
            if (can3.Visible == false && can6.Visible == false && can9.Visible == false)
            {
                duvarS3.Location = new Point(500, -1000);
            }
            if (can2.Visible == false && can5.Visible == false && can8.Visible == false)
            {
                duvarS2.Location = new Point(500, -1000);
            }
            if (can1.Visible == false && can4.Visible == false && can7.Visible == false)
            {
                duvarS1.Location = new Point(500, -1000);
            }
            if (can1.Visible == false && can2.Visible == false && can3.Visible == false && can4.Visible == false && can5.Visible == false && can6.Visible == false && can7.Visible == false && can8.Visible == false && can9.Visible == false)
            {
                
                SqleOyuncu();
                progressBar1.Visible = true;
                Secenekler.Enabled = false;
                M.Visible = true;
                M.Enabled = true;
                C.Enabled = true;
              
                gemi.Visible = false;
                roket.Visible = false;
                C.Visible = true;
          
                roket.Visible = false;
                timerCanavarSaga.Stop();
                timerCanavarSola.Stop(); 
                timerGemiSaga.Stop();
                timerGemiSola.Stop();
                timerRoketAtesle.Stop();
                kontrol.Stop();
                kk.Text = "Kazandınız";
                progressBar1.Visible = true;
                
            }

            
        }

        private void timerPatlama_Tick(object sender, EventArgs e)
        {
            gemi.Visible = false;
            roket.Visible = false;
            patlama.Visible = true;
            patlama.Enabled = true;
            Gemipatlama += 1;
            if (Gemipatlama == 3)
            {
                patlama.Visible = false;
                patlama.Enabled = false;

                timerPatlama.Stop();
                Gemipatlama = 0;

            }
        }

       
    }
}