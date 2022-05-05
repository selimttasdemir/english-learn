using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace english_learn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Baglanti bgl = new Baglanti();
        Random rnd = new Random();
        int sayi, kelime = 0, sure = 120;

        void getir()
        {
            sayi = rnd.Next(1, 2490); // 1 dahil 2490 dahil değil arasında rastgele ınt sayılar turetır.
            OleDbCommand komut = new OleDbCommand("Select * from sozluk where id = @id", bgl.baglanti());
            komut.Parameters.AddWithValue("@id", sayi);
            OleDbDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txtEnglish.Text = dr[1].ToString();
                lblCevap.Text = dr[2].ToString();
            }
            bgl.baglanti().Close();
            txtTurkce.Focus();
            txtTurkce.Text = "";
        }

        private void btnPas_Click(object sender, EventArgs e)
        {
            getir();
            sure = sure - 5;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sure--;
            lblSure.Text = sure.ToString();
            if (sure == 0)
            {
                txtTurkce.Enabled = false;
            }
        }

        private void txtTurkce_TextChanged(object sender, EventArgs e)
        {
            if (txtTurkce.Text == lblCevap.Text)
            {
                kelime++;
                lblDogruSayisi.Text = kelime.ToString();
                getir();
                sure = sure + 5;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            getir();
            timer1.Start();
        }
    }
}
