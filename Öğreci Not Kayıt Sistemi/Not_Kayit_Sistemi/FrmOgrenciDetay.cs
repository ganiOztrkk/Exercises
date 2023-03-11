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

namespace Not_Kayit_Sistemi
{
    public partial class FrmOgrenciDetay : Form
    {
        public FrmOgrenciDetay()
        {
            InitializeComponent();
        }

        public string numara;
        private SqlConnection baglanti =
            new SqlConnection(@"Data Source=DESKTOP-JOSCHSR;Initial Catalog=DbNotKayit;Integrated Security=True");
        private void FrmOgrenciDetay_Load(object sender, EventArgs e)
        {
            lblnumara.Text = numara;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from TBLDERS where OGRNUMARA = @P1", baglanti);
            komut.Parameters.AddWithValue("@P1", numara);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lbladsoyad.Text = dr[2].ToString() + " " +dr[3].ToString();
                lblsinav1.Text = dr[4].ToString();
                lblsinav2.Text = dr[5].ToString();
                lblsinav3.Text = dr[6].ToString();
                lblortalama.Text = dr[7].ToString();
                lbldurum.Text = dr[8].ToString();
            }
            baglanti.Close();
        }
    }
}
