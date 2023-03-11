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

namespace Petrol_Ofisi_Proje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-JOSCHSR;Initial Catalog=DbBenzinIstasyonu;Integrated Security=True");

        void Listele()
        {
            //kursunsuz95

            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from TblBenzin where PetrolTur='Kursunsuz95'", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblKursunsuz95.Text = dr[3].ToString();
                barKursunsuz95.Value = int.Parse(dr[4].ToString());
                lblKursunsuz95Depo.Text = dr[4].ToString();
            }
            baglanti.Close();

            //kursunsuz97 

            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("select * from TblBenzin where PetrolTur='Kursunsuz97'", baglanti);
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                lblKursunsuz97.Text = dr1[3].ToString();
                barKursunsuz97.Value = int.Parse(dr1[4].ToString());
                lblKursunsuz97Depo.Text = dr1[4].ToString();

            }
            baglanti.Close();

            //eurodizel10
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select * from TblBenzin where PetrolTur='EuroDizel10'", baglanti);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                lblEuroDizel10.Text = dr2[3].ToString();
                barEuroDizel.Value = int.Parse(dr2[4].ToString());
                lblEuroDizelDepo.Text = dr2[4].ToString();

            }
            baglanti.Close();

            //yeniprodizel
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("select * from TblBenzin where PetrolTur='YeniProDizel'", baglanti);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                lblYeniProDizel.Text = dr3[3].ToString();
                barProDizel.Value = int.Parse(dr3[4].ToString());
                lblYeniProDepo.Text = dr3[4].ToString();

            }
            baglanti.Close();

            //gaz
            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("select * from TblBenzin where PetrolTur='Gaz'", baglanti);
            SqlDataReader dr4 = komut4.ExecuteReader();
            while (dr4.Read())
            {
                lblGaz.Text = dr4[3].ToString();
                barGaz.Value = int.Parse(dr4[4].ToString());
                lblGazDepo.Text = dr4[4].ToString();

            }
            baglanti.Close();

            baglanti.Open();
            SqlCommand komut5 = new SqlCommand("select * from tblkasa", baglanti);
            SqlDataReader dr5 = komut5.ExecuteReader();
            while (dr5.Read())
            {
                lblKasa.Text = dr5[0].ToString();
            }
            baglanti.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            double kursunsuz95, litre, tutar;
            kursunsuz95 = Convert.ToDouble(lblKursunsuz95.Text);
            litre = Convert.ToDouble(numericUpDown1.Value);
            tutar = kursunsuz95 * litre;
            txtKursunsuz95Tutar.Text = tutar.ToString();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            double kursunsuz97, litre, tutar;
            kursunsuz97 = Convert.ToDouble(lblKursunsuz97.Text);
            litre = Convert.ToDouble(numericUpDown2.Value);
            tutar = kursunsuz97 * litre;
            txtKursunsuz97Tutar.Text = tutar.ToString();
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            double euroDizel10, litre, tutar;
            euroDizel10 = Convert.ToDouble(lblEuroDizel10.Text);
            litre = Convert.ToDouble(numericUpDown3.Value);
            tutar = euroDizel10 * litre;
            txtEuroDizelTutar.Text = tutar.ToString();
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            double yeniPro, litre, tutar;
            yeniPro = Convert.ToDouble(lblYeniProDizel.Text);
            litre = Convert.ToDouble(numericUpDown4.Value);
            tutar = yeniPro * litre;
            txtYeniProTutar.Text = tutar.ToString();
        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {
            double gaz, litre, tutar;
            gaz = Convert.ToDouble(lblGaz.Text);
            litre = Convert.ToDouble(numericUpDown5.Value);
            tutar = gaz * litre;
            txtGazTutar.Text = tutar.ToString();
        }

        private void btnDepoDoldur_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value != 0)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into TblHareket (Plaka, BenzinTuru, Litre, Fiyat) values (@p1,@p2,@p3,@p4)",baglanti);
                komut.Parameters.AddWithValue("@p1", txtPlaka.Text);
                komut.Parameters.AddWithValue("@p2", "Kursunsuz95");
                komut.Parameters.AddWithValue("@p3", numericUpDown1.Value);
                komut.Parameters.AddWithValue("@p4", decimal.Parse(txtKursunsuz95Tutar.Text));
                komut.ExecuteNonQuery();
                baglanti.Close();
                

                baglanti.Open();
                SqlCommand komut2 = new SqlCommand("update TblKasa set Miktar=Miktar + @m1", baglanti);
                komut2.Parameters.AddWithValue("@m1", decimal.Parse(txtKursunsuz95Tutar.Text));
                komut2.ExecuteNonQuery();
                baglanti.Close();

                baglanti.Open();
                SqlCommand komut3 = new SqlCommand("update TblBenzin set Stok=Stok-@s1 where PetrolTur= 'Kursunsuz95'",
                    baglanti);
                komut3.Parameters.AddWithValue("@s1", numericUpDown1.Value);
                komut3.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Satış Yapıldı.");
                Listele();
                
            }
        }
    }
}
