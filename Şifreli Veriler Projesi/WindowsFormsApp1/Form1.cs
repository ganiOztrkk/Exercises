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


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-JOSCHSR;Initial Catalog=Test;Integrated Security=True");

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            string ad = TxtAd.Text;
            byte[] adDizi = ASCIIEncoding.ASCII.GetBytes(ad);
            string adSifre = Convert.ToBase64String(adDizi);
            label6.Text = adSifre;

            string soyad = TxtSoyad.Text;
            byte[] soyadDizi = ASCIIEncoding.ASCII.GetBytes(soyad);
            string soyadSifre = Convert.ToBase64String(soyadDizi);

            string mail = TxtMail.Text;
            byte[] mailDizi = ASCIIEncoding.ASCII.GetBytes(mail);
            string mailSifre = Convert.ToBase64String(mailDizi);

            string sifre = TxtSifre.Text;
            byte[] sifreDizi = ASCIIEncoding.ASCII.GetBytes(sifre);
            string sifreSifre = Convert.ToBase64String(sifreDizi);

            string hesapNo = TxtHesapNo.Text;
            byte[] hesapNoDizi = ASCIIEncoding.ASCII.GetBytes(hesapNo);
            string hesapNoSifre = Convert.ToBase64String(hesapNoDizi);

            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBLVERILER (AD,SOYAD,MAIL,SIFRE,HESAPNO) values (@P1,@P2,@P3,@P4,@P5)",baglanti);
            komut.Parameters.AddWithValue("@P1", adSifre);
            komut.Parameters.AddWithValue("@P2", soyadSifre);
            komut.Parameters.AddWithValue("@P3", mailSifre);
            komut.Parameters.AddWithValue("@P4", sifreSifre);
            komut.Parameters.AddWithValue("@P5", hesapNoSifre);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Veriler Eklendi.");

            listele();
        }

        public void listele()
        {
            baglanti.Open();
            SqlCommand listele = new SqlCommand("select * from TBLVERILER", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(listele);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listele();
        }
    }
}
