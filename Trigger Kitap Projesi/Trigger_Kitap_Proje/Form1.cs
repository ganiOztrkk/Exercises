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

namespace Trigger_Kitap_Proje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private SqlConnection baglanti =
            new SqlConnection(@"Data Source=DESKTOP-JOSCHSR;Initial Catalog=DbTriggerTest;Integrated Security=True");

        public void listele()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from TblKitaplar", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }

        public void sayac()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from TblSayac", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblAdet.Text = dr[0].ToString();
            }
            baglanti.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            listele();
            sayac();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtYazar.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txtSayfa.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txtYayinEvi.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txtTur.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut2 =
                new SqlCommand(
                    "insert into TblKitaplar (KitapAd, KitapYazar, KitapSayfa, KitapYayinEvi, KitapTur) values (@P1,@P2,@P3,@P4,@P5)",baglanti);
            komut2.Parameters.AddWithValue("@P1", txtAd.Text);
            komut2.Parameters.AddWithValue("@P2", txtYazar.Text);
            komut2.Parameters.AddWithValue("@P3", txtSayfa.Text);
            komut2.Parameters.AddWithValue("@P4", txtYayinEvi.Text);
            komut2.Parameters.AddWithValue("@P5", txtTur.Text);
            komut2.ExecuteNonQuery();
            baglanti.Close();
            listele();
            sayac();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from TblKitaplar where ID=@P1", baglanti);
            komut.Parameters.AddWithValue("@P1", txtID.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kitap Kayıttan Silindi");
            listele();
            sayac();
        }
    }
}
