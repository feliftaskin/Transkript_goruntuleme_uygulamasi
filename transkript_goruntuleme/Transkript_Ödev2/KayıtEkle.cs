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
    public partial class KayıtEkle : Form
    {
        public KayıtEkle()
        {
            InitializeComponent();
        }

        NpgsqlConnection baglanti = new NpgsqlConnection("Server=localhost;Port=5432;Database=BIL203; User Id=postgres;Password=1234");

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
               KayıtEkle_dataGridView.DataSource = dt;
            }
            komut.Dispose();
            baglanti.Close();
        }
        private void VeriEkle_button_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut_ekle = new NpgsqlCommand();
            komut_ekle.Connection = baglanti;
            komut_ekle.Parameters.AddWithValue("@ders_kodu",DersKoduEkle_textBox.Text);
            komut_ekle.Parameters.AddWithValue("@ders_adı", DersAdıEkle_textBox.Text);
            komut_ekle.Parameters.AddWithValue("@kredi",Convert.ToInt32( KrediEkle_textBox.Text));
            komut_ekle.Parameters.AddWithValue("@akts", Convert.ToInt32( AKTSEkle_textBox.Text));
            komut_ekle.Parameters.AddWithValue("@Öğretim_Üyesi", ÖğretimÜyesiEkle_textBox.Text);
            komut_ekle.Parameters.AddWithValue("@dönem", DönemEkle_textBox.Text);
            komut_ekle.Parameters.AddWithValue("@harf_notu", HarfNotuEkle_textBox.Text);

            if (DersAdıEkle_textBox.Text == null && DersKoduEkle_textBox.Text == null && KrediEkle_textBox.Text == null && AKTSEkle_textBox.Text == null && ÖğretimÜyesiEkle_textBox.Text == null && DönemEkle_textBox.Text == null && HarfNotuEkle_textBox.Text == null)
            {
                MessageBox.Show("Girilen Bilgiler Eksiktir!");
            }

            komut_ekle.CommandType = CommandType.Text;
            komut_ekle.CommandText = "insert into Transkript4(ders_kodu,ders_adı,kredi,akts,Öğretim_Üyesi,dönem,harf_notu) values(@ders_kodu,@ders_adı,@kredi,@akts,@Öğretim_Üyesi,@dönem,@harf_notu)";

          
           NpgsqlDataReader dr = komut_ekle.ExecuteReader();
            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
               KayıtEkle_dataGridView.DataSource = dt;
            }
            komut_ekle.Dispose();
            baglanti.Close();

            verileri_goster("select * from Transkript4");

        }

        private void KayıtEkleİptal_button_Click(object sender, EventArgs e)
        {
            Form1 anasayfa = new Form1();
            anasayfa.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

    }
}
