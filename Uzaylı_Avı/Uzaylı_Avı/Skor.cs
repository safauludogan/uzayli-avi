using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;//sil
using System.Data.OleDb;
namespace Uzaylı_Avı
{
    public partial class Skor : Form
    {
        public Skor()
        {
            InitializeComponent();
        }
        OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='GameKayıt.accdb'");
        OleDbCommand sorgu = new OleDbCommand();
        DataSet al = new DataSet();
        DataView goster = new DataView();
        OleDbDataAdapter verial;
        public void SqlEkle()
        {  
            al.Clear();
            verial = new OleDbDataAdapter("select * from  PuanTablosu order by Puani desc", baglan);
            verial.Fill(al, "PuanTablosu");
            goster.Table = al.Tables[0];
            dataGridView1.DataSource = goster;
        }
        private void Skor_Load(object sender, EventArgs e)
        {
            dataGridView1.Enabled = false;
            SqlEkle();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menü frm = new Menü();
            frm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Kaydı silmek istediğinizden emin misiniz?", "Silme İşlemi", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                baglan.Open();
                sorgu.Connection = baglan;
                sorgu.CommandText = "delete * from PuanTablosu where Adi='" + textBox1.Text + "'";
                sorgu.ExecuteNonQuery();
                baglan.Close();
                textBox1.Text = "";
                SqlEkle();
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tüm kayıtları silmek istediğinizden emin misiniz?", "Silme İşlemi", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                baglan.Open();
                sorgu.Connection = baglan;
                sorgu.CommandText = "delete * from PuanTablosu";
                sorgu.ExecuteNonQuery();
                baglan.Close();
                SqlEkle();
            }
            
        }

        private void Skor_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

    }
}
