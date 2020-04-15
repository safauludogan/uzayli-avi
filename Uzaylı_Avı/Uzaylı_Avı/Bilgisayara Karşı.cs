using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace Uzaylı_Avı
{
    public partial class kk : Form
    {

        public static int puan = 0;
        string g1, g2, g3, g4;
        int dayan = 60, canKactiSayac = 0, KalanHak = 3, sevArt = 0, dur, canSayac = 0, canHizlan = 0, duvar = 0, p = 0, rokety;
        int roketgidiyor = 0, secenekler = 0, menu = 0, tekrar = 0, oyunBitti = 0, Gemipatlama = 0, slpasif = 0, gemix, gemiy;
        Random r = new Random();
        public kk()
        {

            InitializeComponent();
        }
        OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='GameKayıt.accdb'");
        OleDbCommand sorgu = new OleDbCommand();
        string sql;
        public void Puan()
        {
            label2.Text = "";
            p = p + 10;
            label2.Text = p.ToString();
        }
        public void Canlar(PictureBox canavar)
        {
            if (slpasif == 0)
            {
                int fuztop = roket.Top;
                int fuzsol = roket.Right;
                int fuzsag = roket.Left;

                if (canavar.Bottom >= fuztop && canavar.Left <= fuzsol && canavar.Right >= fuzsag)
                {

                    Puan();
                    gemix = (gemi.Location.X) + 12;
                    rokety = 600;
                    roket.Location = new Point(gemix, rokety);
                    roketgidiyor = 0;
                    roket.Visible = false;
                    canavar.Location = new Point(9999, -32000);
                    canSayac += 1;
                    canavar.Visible = false;
                    timerRoketAtesle.Stop();

                }
                if (roket.Top <= -50)
                {

                    gemix = (gemi.Location.X) + 12;
                    roket.Location = new Point(gemix, rokety);
                    roketgidiyor = 0;
                    rokety = 600;
                    roket.Visible = false;
                    timerRoketAtesle.Stop();
                }
            }  

        }
        public void SqleOyuncu()
        {
            try
            {
                label5.Text = Menü.OyuncuAdi.ToString().Trim();
                baglan.Open();
                sorgu.Connection = baglan;
                sql = "insert into PuanTablosu(Adi,Puani) values ('" + label5.Text + "'," + int.Parse(label2.Text) + ")";
                sorgu.CommandText = sql;
                sorgu.ExecuteNonQuery();

            }
            finally
            {
                baglan.Close();
            }
        }
        public void CanavarKonumla()
        {
            if (slpasif == 0)
            {
                sinir.Location = new Point(9, 510);
                can1.Visible = true;
                can2.Visible = true;
                can3.Visible = true;
                can4.Visible = true;
                can5.Visible = true;
                can6.Visible = true;
                can7.Visible = true;
                can8.Visible = true;
                can9.Visible = true;
                can10.Visible = true;
                can11.Visible = true;
                can12.Visible = true;
                can13.Visible = true;
                can14.Visible = true;
                can15.Visible = true;
                can16.Visible = true;
                can17.Visible = true;
                can18.Visible = true;
                can1.Location = new Point(r.Next(614), (-1) * (100));
                can2.Location = new Point(r.Next(614), (-1) * (250));
                can3.Location = new Point(r.Next(614), (-1) * (400));
                can4.Location = new Point(r.Next(614), (-1) * (550));
                can5.Location = new Point(r.Next(614), (-1) * (700));
                can6.Location = new Point(r.Next(614), (-1) * (850));
                can7.Location = new Point(r.Next(614), (-1) * (1000));
                can8.Location = new Point(r.Next(614), (-1) * (1150));
                can9.Location = new Point(r.Next(614), (-1) * (1300));
                can10.Location = new Point(r.Next(614), (-1) * (1450));
                can11.Location = new Point(r.Next(614), (-1) * (1600));
                can12.Location = new Point(r.Next(614), (-1) * (1750));
                can13.Location = new Point(r.Next(614), (-1) * (1950));
                can14.Location = new Point(r.Next(614), (-1) * (2100));
                can15.Location = new Point(r.Next(614), (-1) * (2250));
                can16.Location = new Point(r.Next(614), (-1) * (2400));
                can17.Location = new Point(r.Next(614), (-1) * (2550));
                can18.Location = new Point(r.Next(614), (-1) * (2700));
            }
        }
        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (dur == 0)
            {
                if (slpasif == 0)
                {
                    if (keyData == Keys.Left)
                    {

                        if (roketgidiyor == 1)
                        {
                            timerRoketAtesle.Start();

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
                        }
                        else
                        {
                            patlama.Left -= 20;
                            gemi.Left -= 20;
                            button1.Left -= 20;
                        }

                    }
                    if (keyData == Keys.Right)
                    {

                        if (roketgidiyor == 1)
                        {
                            timerRoketAtesle.Start();

                        }
                        else
                        {
                            roketgidiyor = 0;
                            gemix += 20;
                            roket.Left += 20;
                        }
                        if (gemi.Left >= 600)
                        {
                            if (roketgidiyor != 1) 
                            {
                                gemix = (gemi.Location.X) + 12;
                                roket.Location = new Point(gemix, rokety);
                            }    
                        }
                        else
                        {
                            patlama.Left += 20;
                            gemi.Left += 20;
                            button1.Left += 20;
                        }
                    }
                    if (keyData == Keys.Space)
                    {
                        roketgidiyor = 1;
                        timerRoketAtesle.Start();
                    }
                }
            }
            return base.ProcessDialogKey(keyData);
        }
        private void OyunuBaslat_Load(object sender, EventArgs e)
        {
            geriSayım.Start();
            canKactı.Start();
            seviyeArt.Start();
            button5.Visible = false;
            button1.Visible = false;
            button1.Enabled = false;
            sinirCan.Value = 100;
            CanavarKonumla();
            label5.Text = Menü.OyuncuAdi.ToString().Trim().ToUpper();
            g1 = AracSec.g1.ToString();
            g2 = AracSec.g2.ToString();
            g3 = AracSec.g3.ToString();
            g4 = AracSec.g4.ToString();
            if (g1 == "a")
            {
                gemi.Location = new Point(291, 599);
                button1.Location = new Point(313, 599);
                this.button1.Size = new System.Drawing.Size(41, 89);
                gemi.Image = Image.FromFile("gemi1.png");
            }
            else if (g2 == "a")
            {
                gemi.Location = new Point(291, 599);
                button1.Location = new Point(306, 599);
                this.button1.Size = new System.Drawing.Size(55, 89);
                gemi.Image = Image.FromFile("gemi2.png");
            }
            else if (g3 == "a")
            {
                gemi.Location = new Point(291, 599);
                button1.Location = new Point(316, 599);
                this.button1.Size = new System.Drawing.Size(36, 89);
                gemi.Image = Image.FromFile("gemi3.png");
            }
            else if (g4 == "a")
            {
                gemi.Location = new Point(291, 599);
                this.gemi.Size = new System.Drawing.Size(86, 92);
                gemi.Image = Image.FromFile("gemi4.png");
            }
            oyunBitti = 0;
            label3.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            tm.Visible = false;
            gemix = 286;
            gemiy = 600;
            rokety = 600;
            gemi.Location = new Point(gemix, gemiy);
            roket.Location = new Point(gemix, rokety);
            roket.Visible = false;
            timerCanavarKay.Start();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            SqleOyuncu();
            tm.Value = 0;
            timerCanavarKay.Stop();
            timerPatlama.Stop();
            sinirCanArt.Stop();
            puan = 0;
            sinirCan.Value = 100;
            tekrar = 1;
            timerProgres.Start();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            SqleOyuncu();
            menu = 1;
            timerProgres.Start();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            SqleOyuncu();
            Application.Exit();
        }
        private void label4_Click(object sender, EventArgs e)
        {               
            tm.Value = 0;
            secenekler += 1;
            if (secenekler == 1)
            {
                geriSayım.Stop();
                seviyeArt.Stop();
                slpasif = 1;
                button3.Visible = true;
                button2.Visible = true;
                button4.Visible = true;
                tm.Visible = true;
            }
            else
            {
                geriSayım.Start();
                seviyeArt.Start();
                slpasif = 0;
                secenekler = 0;
                button3.Visible = false;
                button2.Visible = false;
                button4.Visible = false;
                tm.Visible = false;
            }           
        }
        private void timerProgres_Tick(object sender, EventArgs e)
        {
            if (tekrar == 1)
            {
                button3.Enabled = false;
                button2.Enabled = false;
                tm.Value += 20;
                if (tm.Value >= 100)
                {
                    timerProgres.Stop();
                    kk frm = new kk();
                    frm.Show();
                    this.Hide();
                }

                menu = 0;
            }
            else if (menu == 1)
            {
                button3.Enabled = false;
                button2.Enabled = false;
                tm.Value += 20;
                if (tm.Value >= 100)
                {
                    timerProgres.Stop();
                    Menü frm2 = new Menü();
                    frm2.Show();
                    this.Hide();
                }
                tekrar = 0;
            }
        }

        private void OyunuBaslat_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void timerPatlama_Tick(object sender, EventArgs e)
        {
            label1.Visible = false;
            seviyeArt.Stop();
            label4.Visible = false;
            tm.Visible = true;
            button3.Visible = true;
            button2.Visible = true;
            button4.Visible = true;
            slpasif = 1;
            timerRoketAtesle.Stop();
            timerProgres.Stop();
            timerCanavarKay.Stop();
            sinirCanArt.Stop();
            label3.Text = "Canavarlar kaçmayı başardı oyun bitti.";
            label3.Visible = true;
            gemi.Visible = false;
            roket.Visible = false;
            gemi.Enabled = false;
            roket.Enabled = false;
            patlama.Visible = true;
            patlama.Enabled = true;            
            Gemipatlama += 1;
            if (Gemipatlama == 3)
            {
                slpasif = 1;
                patlama.Visible = false;
                patlama.Enabled = false;
                timerCanavarKay.Stop();
                timerPatlama.Stop();
                Gemipatlama = 0;
            }
        }
        public void canSinirCarp(PictureBox Can)
        {
            if (duvar == 0)
            {
                int fuztop = sinir.Top;
                int fuzsol = sinir.Right;
                int fuzsag = sinir.Left;
                if (Can.Top <= button5.Top)
                {
                    if (Can.Top >= -21)
                    {
                        if (Can.Bottom >= fuztop && Can.Left <= fuzsol && Can.Right >= fuzsag)
                        {
                            Can.Visible = false;
                            Can.Location = new Point(9999, -32000);
                            sinirCan.Value -= 20;
                            if (sinirCan.Value <= 0)
                            {
                                sinir.Location = new Point(6, 32767);
                                duvar += 1;
                            }
                        }
                    }
                }
            }
            else if (duvar != 0)
            {
                sinir.Location = new Point(500, -1000);
                sinir.Visible = false;
                sinir.Enabled = false;

                sinirCanArt.Start();
            }

        }
        public void Seviye(PictureBox Can)
        {
            if (Can.Top >= 711 || can18.Top>=709)
            {
                Can.Visible = false;
                Can.Location = new Point(9999, -32000);
            }
            if (Can.Visible == false)
            {
                Can.Visible = false;
                if (can1.Visible == false && can2.Visible == false && can3.Visible == false && can4.Visible == false && can5.Visible == false && can6.Visible == false && can7.Visible == false && can8.Visible == false && can9.Visible == false && can10.Visible == false && can11.Visible == false && can12.Visible == false && can13.Visible == false && can14.Visible == false && can15.Visible == false && can16.Visible == false && can17.Visible == false && can18.Visible == false)
                {
                    canHizlan += 1;
                    CanavarKonumla();
                }
            }
        }
        public void gemiCarp(PictureBox Can)
        {
            int fuztop = button1.Top;
            int fuzsol = button1.Right;
            int fuzsag = button1.Left;
            if (Can.Bottom >= fuztop && Can.Left <= fuzsol && Can.Right >= fuzsag)
            {
                Can.Visible = false;
                dur = 1;
                timerPatlama.Start();
                timerCanavarKay.Stop();
            }
        }
        public void canKacti(PictureBox Can)
        {
                int fuztop = button6.Top;
                int fuzsol = button6.Right;
                int fuzsag = button6.Left;
                if (Can.Bottom >= fuztop && Can.Left <= fuzsol && Can.Right >= fuzsag)
                {
                    KalanHak -= 1;
                    label8.Text = KalanHak.ToString();
                    canKactı.Stop();
                    canKactıAYAR.Start();
                    if (KalanHak <= 0)
                    {                        
                        timerPatlama.Start();
                        canKactı.Stop();
                        canKactıAYAR.Stop();
                    }
                }
        }
        void kaydirma()
        {
            foreach (var item in this.Controls)
            {
                if (item is PictureBox)
                {
                    if (((PictureBox)item).Name != "roket" && ((PictureBox)item).Name != "gemi" && ((PictureBox)item).Name != "patlama" && ((PictureBox)item).Name != "sinir")
                    {

                        ((PictureBox)item).Top += 3;
                    }
                }

            }
        }
        private void timerCanavarKay_Tick(object sender, EventArgs e)
        {            
            if (dayan != 0)
            {
                if (KalanHak != 0)
                {
                    if (slpasif == 0)
                    {
                        //
                        gemiCarp(can1);
                        gemiCarp(can2);
                        gemiCarp(can3);
                        gemiCarp(can4);
                        gemiCarp(can5);
                        gemiCarp(can6);
                        gemiCarp(can7);
                        gemiCarp(can8);
                        gemiCarp(can9);
                        gemiCarp(can10);
                        gemiCarp(can11);
                        gemiCarp(can12);
                        gemiCarp(can13);
                        gemiCarp(can14);
                        gemiCarp(can15);
                        gemiCarp(can16);
                        gemiCarp(can17);
                        gemiCarp(can18);
                        //
                        Seviye(can1);
                        Seviye(can2);
                        Seviye(can3);
                        Seviye(can4);
                        Seviye(can5);
                        Seviye(can6);
                        Seviye(can7);
                        Seviye(can8);
                        Seviye(can9);
                        Seviye(can10);
                        Seviye(can11);
                        Seviye(can12);
                        Seviye(can13);
                        Seviye(can14);
                        Seviye(can15);
                        Seviye(can16);
                        Seviye(can17);
                        Seviye(can18);
                        if (duvar == 0)
                        {
                            //
                            canSinirCarp(can1);
                            canSinirCarp(can2);
                            canSinirCarp(can3);
                            canSinirCarp(can4);
                            canSinirCarp(can5);
                            canSinirCarp(can6);
                            canSinirCarp(can7);
                            canSinirCarp(can8);
                            canSinirCarp(can9);
                            canSinirCarp(can10);
                            canSinirCarp(can11);
                            canSinirCarp(can12);
                            canSinirCarp(can13);
                            canSinirCarp(can14);
                            canSinirCarp(can15);
                            canSinirCarp(can16);
                            canSinirCarp(can17);
                            canSinirCarp(can18);
                            kaydirma();
                        }
                        else
                        {
                            kaydirma();
                        }
                    }
                }
            }
            else
            {
                kazandın.Start();
                timerCanavarKay.Stop();
            }
        }
        private void sinirCanArt_Tick(object sender, EventArgs e)
        {
            sinirCan.Value += 1;
            if (sinirCan.Value >= 100)
            {
                duvar = 0;
                tm.Value = 100;
                sinir.Location = new Point(9, 510);
                sinir.Visible = true;
                sinir.Enabled = true;
                sinirCanArt.Stop();
               
            }
        }

        private void timerRoketAtesle_Tick(object sender, EventArgs e)
        {
            if (oyunBitti == 0)
            {
                roket.Visible = true;
                rokety -= 50;
                roket.Location = new Point(gemix + 20, rokety);
                Canlar(can1);
                Canlar(can2);
                Canlar(can3);
                Canlar(can4);
                Canlar(can5);
                Canlar(can6);
                Canlar(can7);
                Canlar(can8);
                Canlar(can9);
                Canlar(can10);
                Canlar(can11);
                Canlar(can12);
                Canlar(can13);
                Canlar(can14);
                Canlar(can15);
                Canlar(can16);
                Canlar(can17);
                Canlar(can18);

            }
            else if (oyunBitti == 1)
            {
                roket.Visible = false;
                roket.Location = new Point(500, -1000);
            }
        }

        private void seviyeArt_Tick(object sender, EventArgs e)
        {
            sevArt += 1;
            if (sevArt >= 30)
            {
                timerCanavarKay.Interval = 2;
            }
            else if (sevArt >= 30)
            {
                timerCanavarKay.Interval = 3;
            }
            else if (sevArt >= 25) 
            {
              timerCanavarKay.Interval = 5;  
            }
            else  if (sevArt>=20)
            {
                timerCanavarKay.Interval = 10;
            }
            else if (sevArt >= 15)
            {
                timerCanavarKay.Interval = 15;
            }
            else if (sevArt >= 10)
            {
                timerCanavarKay.Interval = 20;
            }
            else if (sevArt >= 5)
            {
                timerCanavarKay.Interval = 25;
            }            
        }

        private void canKactı_Tick(object sender, EventArgs e)
        {
            canKacti(can1);
            canKacti(can2);
            canKacti(can3);
            canKacti(can4);
            canKacti(can5);
            canKacti(can6);
            canKacti(can7);
            canKacti(can8);
            canKacti(can9);
            canKacti(can10);
            canKacti(can12);
            canKacti(can13);
            canKacti(can14);
            canKacti(can15);
            canKacti(can16);
            canKacti(can17);
            canKacti(can18);  
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            canKactiSayac += 1;           
            if (canKactiSayac >= 2)
            {
                canKactı.Start();
                canKactiSayac = 0;
                canKactıAYAR.Stop();
            }
            
        }

        private void kazandın_Tick(object sender, EventArgs e)
        {
            roket.Visible = false;
            dayan = 0;
            label3.Text = "Tebrikler Kazandınız";
            label3.Visible = true;
            label4.Visible = false;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            tm.Visible = true;
            slpasif = 1;
            sinirCanArt.Stop();
            geriSayım.Stop();            
            foreach (var item in this.Controls)
            {
                if (item is PictureBox)
                {
                    if (((PictureBox)item).Name != "roket" && ((PictureBox)item).Name != "gemi" && ((PictureBox)item).Name != "patlama" && ((PictureBox)item).Name != "sinir")
                    {
                        ((PictureBox)item).Top -= 3;
                    }
                }
            }
        }
        private void geriSayım_Tick(object sender, EventArgs e)
        {
            dayan -= 1;
            label1.Text = dayan.ToString() + " Saniye dayan";
        }
    }
}