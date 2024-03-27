using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
namespace Transkript_Ödev2
{
    public partial class KayıtSil : Form
    {
        public KayıtSil()
        {
            InitializeComponent();
        }

        NpgsqlConnection baglanti = new NpgsqlConnection("Server=localhost;Port=5432;Database=BIL203;User Id=postgres;Password=1234");


        public void verileri_goster(string txt)
        {
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand();
            komut.Connection = baglanti;
            komut.CommandType = CommandType.Text;
            komut.CommandText = txt;
            NpgsqlDataReader dr = komut.ExecuteReader();

            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
              KayıtSil_dataGridView.DataSource = dt;
            }
            komut.Dispose();
            baglanti.Close();
        }

        private void VerileriSil_button_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            NpgsqlCommand komut_ekle = new NpgsqlCommand();
            komut_ekle.Connection = baglanti;


            komut_ekle.CommandType = CommandType.Text;
            komut_ekle.Parameters.AddWithValue("@ders_kodu",DersKoduSil_textBox.Text);
            komut_ekle.CommandText = "delete from Transkript4 where ders_kodu=@ders_kodu";

            NpgsqlDataReader dr = komut_ekle.ExecuteReader();
            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
               KayıtSil_dataGridView.DataSource = dt;
            }
            baglanti.Close();
            verileri_goster("select* from Transkript4");
        }

        private void VerileriSilİptal_button_Click(object sender, EventArgs e)
        {
            Form1 anasayfa = new Form1();
            anasayfa.Show();
        }

        private void KayıtSil_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
