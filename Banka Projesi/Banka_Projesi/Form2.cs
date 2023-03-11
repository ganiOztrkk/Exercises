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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-JOSCHSR;Initial Catalog=DbBanka;Integrated Security=True");

        public string hesapNo;
        private void Form2_Load(object sender, EventArgs e)
        {
            lblHesapNo.Text = hesapNo;

            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from TblKisiler where MusteriHesapNo=@P1", baglanti);
            komut.Parameters.AddWithValue("@P1", hesapNo);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblAdSoyad.Text = dr[1] + " " + dr[2];
                lblTelefon.Text = dr[3].ToString();
                lblTC.Text = dr[4].ToString();
            }
            baglanti.Close();

        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update TblHesap set Bakiye=Bakiye+@P1 where HesapNo=@P2", baglanti);
            komut.Parameters.AddWithValue("@P1", decimal.Parse(txtTutar.Text));
            komut.Parameters.AddWithValue("@P2", mskHesap.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();

            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("update tblhesap set bakiye=bakiye-@K1 where hesapno=@K2", baglanti);
            komut2.Parameters.AddWithValue("@K1", decimal.Parse(txtTutar.Text));
            komut2.Parameters.AddWithValue("@K2", mskHesap.Text);
            komut2.ExecuteNonQuery();
            baglanti.Close();
            
            MessageBox.Show("İşlem Gerçekleşti.");
        }
    }
}
