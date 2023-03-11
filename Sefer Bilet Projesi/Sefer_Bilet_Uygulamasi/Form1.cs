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

namespace Sefer_Bilet_Uygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-JOSCHSR;Initial Catalog=DbYolcuBilet;Integrated Security=True");
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TblYolcuBilgi (YolcuAd, YolcuSoyad, YolcuTelefon, YolcuTC, YolcuCinsiyet, YolcuMail) values (@p1,@p2,@p3,@p4,@p5,@p6)",baglanti);
            komut.Parameters.AddWithValue("@p1", txtAd.Text);
            komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", mskTelefon.Text);
            komut.Parameters.AddWithValue("@p4", mskTC.Text);
            komut.Parameters.AddWithValue("@p5", cmbCinsiyet.Text);
            komut.Parameters.AddWithValue("@p6", mskMail.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Yolcu Bilgisi Sisteme Kaydedildi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Hand);
        }

        private void btnKaptan_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut =
                new SqlCommand("insert into TblKaptan (KaptanNO, KaptanAdSoyad, KaptanTelefon) values (@p1,@p2,@p3)",
                    baglanti);
            komut.Parameters.AddWithValue("@p1", txtKaptanNo.Text);
            komut.Parameters.AddWithValue("@p2", txtKaptanAdSoyad.Text);
            komut.Parameters.AddWithValue("@p3", mskKaptanTelefon.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kaptan Bilgisi Sisteme Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }

        private void btnSeferOlustur_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut =
                new SqlCommand(
                    "insert into TblSeferBilgi (SeferKalkis, SeferVaris, SeferTarih, SeferSaat, SeferKaptan, SeferFiyat) values (@p1,@p2,@p3,@p4,@p5,@p6)",
                    baglanti);
            komut.Parameters.AddWithValue("@p1", txtKalkis.Text);
            komut.Parameters.AddWithValue("@p2", txtVaris.Text);
            komut.Parameters.AddWithValue("@p3", mskTarih.Text);
            komut.Parameters.AddWithValue("@p4", mskSaat.Text);
            komut.Parameters.AddWithValue("@p5", mskKaptan.Text);
            komut.Parameters.AddWithValue("@p6", txtFiyat.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Sefer Bilgisi Sisteme Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from TblSeferBilgi",baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtSefer.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtKoltukNo.Text = "1";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtKoltukNo.Text = "2";

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtKoltukNo.Text = "3";

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtKoltukNo.Text = "4";

        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtKoltukNo.Text = "5";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtKoltukNo.Text = "6";

        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtKoltukNo.Text = "7";

        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtKoltukNo.Text = "8";

        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtKoltukNo.Text = "9";

        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtKoltukNo.Text = "10";

        }

        private void btnRezervasyonYap_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TblSeferDetay (SeferNo, YolcuTC, KoltukNO) values (@p1,@p2,@p3)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtSefer.Text);
            komut.Parameters.AddWithValue("@p2", mskYolcuTC.Text);
            komut.Parameters.AddWithValue("@p3", txtKoltukNo.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Rezervasyon Oluşturuldu.");
        }
    }
}
