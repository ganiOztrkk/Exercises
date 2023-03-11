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

namespace Proje6_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-JOSCHSR;Initial Catalog=Proje6;Integrated Security=True");

        private void Form1_Load(object sender, EventArgs e)
        {
            this.pROHAREKETTableAdapter.Fill(this.proje6DataSet.PROHAREKET);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into HAREKETLER (URUN, MUSTERI, PERSONEL, FIYAT) values (@P1,@P2,@P3,@P4)", baglanti);
            komut.Parameters.AddWithValue("@P1", txturun.Text);
            komut.Parameters.AddWithValue("@P2", txtmusteri.Text);
            komut.Parameters.AddWithValue("@P3", txtpersonel.Text);
            komut.Parameters.AddWithValue("@P4", txtfiyat.Text);

            komut.ExecuteNonQuery();
            baglanti.Close();
            this.pROHAREKETTableAdapter.Fill(this.proje6DataSet.PROHAREKET);

        }
    }
}
