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

namespace Rehber
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void Listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from KISILER", connection);
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private SqlConnection connection =
            new SqlConnection(@"Data Source=DESKTOP-JOSCHSR;Initial Catalog=25_Rehber;Integrated Security=True");
        private void Form1_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand insertCommand =
                new SqlCommand("insert into KISILER (AD, SOYAD, TELEFON, MAIL) values (@P1,@P2,@P3,@P4)", connection);
            insertCommand.Parameters.AddWithValue("@P1", txtAd.Text);
            insertCommand.Parameters.AddWithValue("@P2", txtSoyad.Text);
            insertCommand.Parameters.AddWithValue("@P3", mskTelefon.Text);
            insertCommand.Parameters.AddWithValue("@P4", txtMail.Text);
            insertCommand.ExecuteNonQuery();
            connection.Close();
            Listele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand deleteCommand = new SqlCommand("delete from KISILER where ID=@P1", connection);
            deleteCommand.Parameters.AddWithValue("@P1", txtId.Text);
            deleteCommand.ExecuteNonQuery();
            connection.Close();
            Listele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand updateCommand =
                new SqlCommand("update KISILER set AD=@P1, SOYAD=@P2, TELEFON=@P3, MAIL = @P4 where ID=@P5",
                    connection);
            updateCommand.Parameters.AddWithValue("@P1", txtAd.Text);
            updateCommand.Parameters.AddWithValue("@P2", txtSoyad.Text);
            updateCommand.Parameters.AddWithValue("@P3", mskTelefon.Text);
            updateCommand.Parameters.AddWithValue("@P4", txtMail.Text);
            updateCommand.Parameters.AddWithValue("@P5", txtId.Text);
            updateCommand.ExecuteNonQuery();
            connection.Close();
            Listele();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
        }
    }
}
