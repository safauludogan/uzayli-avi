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
    public partial class bilgisayaraKarsi : Form
    {
        public bilgisayaraKarsi()
        {
            InitializeComponent();
        }
        Random r = new Random();
        int sayac = 0;
        private void bilgisayaraKarsi_Load(object sender, EventArgs e)
        {
            dusmanSagaSola.Start();
        }
        public void Kay()
        {
            sayac += 1;
                if (sayac >= 195)
                {
                    sayac = 0;
                }
                else if (sayac >= 160)
                {
                    dusmanGemi.Left -= 5;//sola
                }
                else if (sayac >= 90)
                {
                    dusmanGemi.Left += 5;//saga
                }
                else if (sayac >= 70)
                {
                    dusmanGemi.Left -= 5;//sola
                }
                else if (sayac >= 40)
                {

                    dusmanGemi.Left += 5;//saga
                }
                else if (sayac >= 1)
                {
                    dusmanGemi.Left -= 5;//sola
                }
            
           
        }
        private void dusmanSagaSola_Tick(object sender, EventArgs e)
        {
            label2.Text = sayac.ToString();
            Kay();
        }

    }
}
