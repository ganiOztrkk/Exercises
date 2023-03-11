using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Banka_Projesi
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-JOSCHSR;Initial Catalog=DbBanka;Integrated Security=True");

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut =
                new SqlCommand(
                    "insert into TblKisiler (MusteriAd, MusteriSoyad, MusteriTC, MusteriTelefon, MusteriHesapNo, MusteriSifre) values (@P1,@P2,@P3,@P4,@P5,@P6)",
                    baglanti);
            komut.Parameters.AddWithValue("@P1", txtAd.Text);
            komut.Parameters.AddWithValue("@P2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@P3", mskTC.Text);
            komut.Parameters.AddWithValue("@P4", mskTel.Text);
            komut.Parameters.AddWithValue("@P5", mskHesap.Text);
            komut.Parameters.AddWithValue("@P6", txtSifre.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();

            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("insert into TblHesap (HesapNo) values (@E1)", baglanti);
            komut2.Parameters.AddWithValue("@E1", mskHesap.Text);
            komut2.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Kayıt Gerçekleştirilmiştir","Kayıt Başarılı",MessageBoxButtons.OK,MessageBoxIcon.Hand);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            mskHesap.Text = random.Next(100000, 1000000).ToString();
        }
    }
}
