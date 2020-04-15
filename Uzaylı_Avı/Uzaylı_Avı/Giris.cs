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
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }
        int sayac = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac += 20;
            if (sayac >= 100)
            {
                timer1.Stop();
                Menü2 frm2 = new Menü2();
                this.Hide();
                frm2.Show();
            }
        }

        private void Giris2_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
