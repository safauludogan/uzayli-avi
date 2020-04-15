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
    public partial class Seviye_İki : Form
    {
        int roketgidiyor = 0, gemix, gemiy, rokety, oyunBitti = 0, CanlarGeliyor = 0;
        public Seviye_İki()
        {
            InitializeComponent();
        }
        public void Boslar(PictureBox Bos)
        {
            int fuztop = roket.Top;
            int fuzsol = roket.Right;
            int fuzsag = roket.Left;
            if (Bos.Bottom >= fuztop && Bos.Left <= fuzsol && Bos.Right >= fuzsag)
            {
                progressBar2.Value -= 10;
                if (progressBar2.Value <= 0)
                {
                    gemix = (gemi.Location.X) + 12;
                    rokety = 602;
                    roket.Location = new Point(gemix, rokety);
                    roketgidiyor = 0;
                    timerRoketAtesle.Stop();
                    roketgidiyor = 0;
                    roket.Visible = false;
                    Bos.Location = new Point(500, -1000);
                    Bos.Visible = false;
                }
                else
                {
                    gemix = (gemi.Location.X) + 12;
                    rokety = 602;
                    roket.Location = new Point(gemix, rokety);
                    roketgidiyor = 0;
                    timerRoketAtesle.Stop();
                    roketgidiyor = 0;
                    roket.Visible = false;
                }
                 
                   
                
            }
        }
        public void Canlar(PictureBox canavar)
        {
            int fuztop = roket.Top;
            int fuzsol = roket.Right;
            int fuzsag = roket.Left;

            if(canavar.Bottom >= fuztop && canavar.Left <= fuzsol && canavar.Right >= fuzsag)
            {
                    gemix = (gemi.Location.X) + 12;
                    rokety = 602;
                    roket.Location = new Point(gemix, rokety);
                    roketgidiyor = 0;
                    timerRoketAtesle.Stop();
                    roketgidiyor = 0;
                    roket.Visible = false;
                    canavar.Location = new Point(500, -1000);
                    canavar.Visible = false;
             }

        }
        public void kaybetme()
        {
            oyunBitti = oyunBitti + 1;
            can1.Visible = false;
            can2.Visible = false;
            can3.Visible = false;
            can4.Visible = false;
            can5.Visible = false;
            can6.Visible = false;
            if (can1.Visible == false && can2.Visible == false && can3.Visible == false && can4.Visible == false && can5.Visible == false && can6.Visible == false)
            {
                timerCanavarlarSaga.Stop();
                timerCanavarlarSola.Stop();
            }
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
        private void timerCanavarlarSola_Tick(object sender, EventArgs e)
        {
            if (CanlarGeliyor == 1)
            {
                timerDuvar.Start();
                label6.Text = can1.Location.ToString();
                label7.Text = CanBos1.Location.ToString();
                if (CanBos1.Bottom>=529 || can1.Bottom >= 529 || can2.Bottom >= 529 || can3.Bottom >= 529 || can4.Bottom >= 529 || can5.Bottom >= 529 || can6.Bottom >= 529)
                {

                    kaybetme();
                    timerCanavarlarSaga.Stop();
                    timerCanavarlarSola.Stop();

                }
                else
                {
                    progressBar2.Left -= 4;
                    foreach (var item in this.Controls)
                    {
                        if (item is PictureBox)
                        {
                           
                            if (((PictureBox)item).Name != "Sinir" && ((PictureBox)item).Name != "roket" && ((PictureBox)item).Name != "gemi")
                            {

                                ((PictureBox)item).Left -= 4;
                            }
                        }

                    }

                    if (CanBos1.Left<=15 || Duvar1.Left <= 15 || Duvar2.Left <= 65 || Duvar3.Left <= 65 || Duvar4.Left <= 65 || Duvar5.Left <= 65 || Duvar6.Left <= 65)
                    {
                        timerCanavarlarSola.Stop();
                        progressBar2.Top += 34;
                        foreach (var item in this.Controls)
                        {
                            if (item is PictureBox)
                            {
                                if (((PictureBox)item).Name != "Sinir" && ((PictureBox)item).Name != "roket" && ((PictureBox)item).Name != "gemi")
                                {

                                    ((PictureBox)item).Top += 34;
                                }
                            }

                        }
                        timerCanavarlarSaga.Start();

                    }

                }
            }
        }



        private void Seviye_İki_Load(object sender, EventArgs e)
        {
            progressBar2.Value = 100;
            CanBos1.Location = new Point(499, -250);
            Duvar7.Location = new Point(499, -250);
            progressBar2.Location = new Point(499, -255);
            CanlarGeliyor = 1;
            gemix = 299;
            gemiy = 602;
            rokety = 602;
            gemi.Location = new Point(gemix, gemiy);
            roket.Location = new Point(gemix, rokety);
            roket.Visible = false;
            
            timerDuvar.Start();
            timerCanavarlarSola.Start();
          
        }

        private void timerCanavarlarSaga_Tick(object sender, EventArgs e)
        {
            if (CanlarGeliyor == 1)
            {
                timerDuvar.Start();
                label6.Text = can1.Location.ToString();
                label7.Text = CanBos1.Location.ToString();
                if (CanBos1.Bottom>=516 || can1.Bottom >= 516 || can2.Bottom >= 516 || can3.Bottom >= 516 || can4.Bottom >= 516 || can5.Bottom >= 516 || can6.Bottom >= 516)
                {

                    kaybetme();
                    timerCanavarlarSaga.Stop();
                    timerCanavarlarSola.Stop();

                }
                else
                {
                    progressBar2.Left += 4;
                    foreach (var item in this.Controls)
                    {
                        if (item is PictureBox)
                        {
                            if (((PictureBox)item).Name != "Sinir" && ((PictureBox)item).Name != "roket" && ((PictureBox)item).Name != "gemi")
                            {

                                ((PictureBox)item).Left += 4;

                            }
                        }
                    }
                    if (CanBos1.Left>=530 || Duvar1.Left >= 655 || Duvar2.Left >= 655 || Duvar3.Left >= 655 || Duvar4.Left >= 655 || Duvar5.Left >= 655 || Duvar6.Left >= 655)
                    {
                        timerCanavarlarSaga.Stop();
                        timerCanavarlarSola.Start();
                    }
                }
            }

        }

        private void timerRoketAteşle_Tick(object sender, EventArgs e)
        {

            timerDuvar.Start();
            
            if (oyunBitti == 0)
            {
                Boslar(CanBos1);
                if (Duvar1.Top >= roket.Top || Duvar3.Top >= roket.Top || Duvar2.Top >= roket.Top || Duvar4.Top >= roket.Top || Duvar5.Top >= roket.Top || Duvar6.Top >= roket.Top || Duvar7.Top >= roket.Top)
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
                    Canlar(can1);
                    Canlar(can2);
                    Canlar(can3);
                    Canlar(can4);
                    Canlar(can5);
                    Canlar(can6);
                    
                    
                }
            }
            else if (oyunBitti == 1)
            {
                roket.Visible = false;
                roket.Location = new Point(500, -1000);
                gemi.Visible = false;
                gemi.Location = new Point(500, -1000);
            }

        }
        
        private void timerDuvar_Tick(object sender, EventArgs e)
        {
            
            if (can6.Visible == false)
            {
                Duvar6.Location = new Point(500, -1000);
            }
            if (can5.Visible == false)
            {
                Duvar5.Location = new Point(500, -1000);
            }
            if (can4.Visible == false)
            {
                Duvar4.Location = new Point(500, -1000);
            }
            if (can3.Visible == false)
            {
                Duvar3.Location = new Point(500, -1000);
            }
            if (can2.Visible == false)
            {
                Duvar2.Location = new Point(500, -1000);
            }
            if (can1.Visible == false)
            {
                Duvar1.Location = new Point(500, -1000);
            }
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

                gemi.Left += 5;
            }
        }
       
        private void button4_Click(object sender, EventArgs e)
        {
            can1.Location = new Point(0 ,0);
            can2.Location = new Point(0, 0);
            can3.Location = new Point(0, 0);
            can4.Location = new Point(0, 0);
            can5.Location = new Point(0, 0);
            can6.Location = new Point(0, 0);
            label6.Text = can1.Location.ToString();
            timerCanavarlarSola.Stop();
            timerCanavarlarSaga.Stop();
         
            CanlarGeliyor = 0;
            can1.Visible = false;
            can2.Visible = false;
            can3.Visible = false;
            can4.Visible = false;
            can5.Visible = false;
            can6.Visible = false;
           
        }

    }
}
    

