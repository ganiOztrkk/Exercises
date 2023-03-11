using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banka_Projesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-JOSCHSR;Initial Catalog=DbBanka;Integrated Security=True");
        private void linkKayit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form3 fr3 = new Form3();
            fr3.Show();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from TblKisiler where MusteriHesapNo = @P1 and MusteriSifre = @P2", baglanti);
            komut.Parameters.AddWithValue("@P1", mskHesap.Text);
            komut.Parameters.AddWithValue("@P2", txtSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                Form2 fr2 = new Form2();
                fr2.hesapNo = mskHesap.Text;
                fr2.Show();
            }
            else
            {
                MessageBox.Show("Hatalı Giriş Yaptınız.");
            }
            baglanti.Close();
        }
    }
}
