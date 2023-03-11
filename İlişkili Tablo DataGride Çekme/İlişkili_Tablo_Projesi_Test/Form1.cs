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

namespace İlişkili_Tablo_Projesi_Test
{
    public partial class Form1 : Form
    {
        //Data Source=DESKTOP-JOSCHSR;Initial Catalog=IliskiliTabloTest;Integrated Security=True
        private SqlConnection connection =
            new SqlConnection(
                @"Data Source=DESKTOP-JOSCHSR;Initial Catalog=IliskiliTabloTest;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        public void listele()
        {
            connection.Open();
            SqlCommand listele = new SqlCommand("execute pro1", connection);
            SqlDataAdapter da = new SqlDataAdapter(listele);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            connection.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listele();
        }
        private void BtnEkle_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand insert =
                new SqlCommand("insert into tblhareket (urun,musteri,personel,fiyat) values (@P1,@P2,@P3,@P4)");
            insert.Parameters.AddWithValue("@P1", TxtUrun.Text);
            insert.Parameters.AddWithValue("@P2", TxtMusteri.Text);
            insert.Parameters.AddWithValue("@P3", TxtPersonel.Text);
            insert.Parameters.AddWithValue("@P4", TxtFiyat.Text);
            insert.ExecuteNonQuery();
            connection.Close();
            listele();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            TxtID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            TxtUrun.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            TxtMusteri.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            TxtPersonel.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            TxtFiyat.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand update =
                new SqlCommand(
                    "update tblhareket set URUN=@P1, MUSTERI=@P2, PERSONEL=@P3, FIYAT=@P4 where HAREKETID = @p5",connection);
            update.Parameters.AddWithValue("@P1", TxtUrun.Text);
            update.Parameters.AddWithValue("@P2", TxtMusteri.Text);
            update.Parameters.AddWithValue("@P3", TxtPersonel.Text);
            update.Parameters.AddWithValue("@P4", TxtFiyat.Text);
            update.Parameters.AddWithValue("@P5", TxtID.Text);
            update.ExecuteNonQuery();
            connection.Close();
            listele();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand delete = new SqlCommand("delete from tblhareket where HAREKETID=@P1", connection);
            delete.Parameters.AddWithValue("@P1", TxtID.Text);
            delete.ExecuteNonQuery();
            connection.Close();
            listele();
        }
    }
}
