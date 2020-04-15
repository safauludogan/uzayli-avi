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
    public partial class menuyeYonlendir : Form
    {
        public menuyeYonlendir()
        {
            InitializeComponent();
        }
        int sayac = 0;
        private void menuyeYonlendir_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }


        private void timer1_Tick_1(object sender, EventArgs e)
        {
            sayac += 20;
            if (sayac >= 100)
            {
                timer1.Stop();
                Menü frm2 = new Menü();
                this.Hide();
                frm2.Show();
            }
        }
    }
}

