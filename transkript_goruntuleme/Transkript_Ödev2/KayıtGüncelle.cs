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
    public partial class KayıtGüncelle : Form
    {
        public KayıtGüncelle()
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
                KayıtGüncelle_dataGridView.DataSource = dt;
            }
            komut.Dispose();
            baglanti.Close();
        }
        private void VeriGüncelle_button_Click(object sender, EventArgs e)
        {

            baglanti.Open();

            NpgsqlCommand komut_ekle = new NpgsqlCommand();
            komut_ekle.Connection = baglanti;


            komut_ekle.CommandType = CommandType.Text;
            komut_ekle.CommandText = "update Transkript4 set harf_notu=@harf_notu,ders_adı=@ders_adı,kredi=@kredi,akts=@akts,Öğretim_Üyesi=@Öğretim_Üyesi,dönem=@dönem where ders_kodu = @ders_kodu";
            komut_ekle.Parameters.AddWithValue("@ders_kodu",DersKoduGüncelle_textBox.Text);
            komut_ekle.Parameters.AddWithValue("@ders_adı", DersAdıGüncelle_textBox.Text);
            komut_ekle.Parameters.AddWithValue("@kredi", Convert.ToInt32(KrediGüncelle_textBox.Text));
            komut_ekle.Parameters.AddWithValue("@akts", Convert.ToInt32( AKTSGüncelle_textBox.Text));
            komut_ekle.Parameters.AddWithValue("@Öğretim_Üyesi", ÖğretimÜyesiGüncelle_textBox.Text);
            komut_ekle.Parameters.AddWithValue("@dönem",DönemGüncelle_textBox.Text);
            komut_ekle.Parameters.AddWithValue("@harf_notu", HarfNotuGüncelle_textBox.Text);

          

            NpgsqlDataReader dr = komut_ekle.ExecuteReader();
            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                KayıtGüncelle_dataGridView.DataSource = dt;
            }
            baglanti.Close();
            verileri_goster("select* from Transkript4");
        }

        private void VerileriGüncelleİptal_button_Click(object sender, EventArgs e)
        {
            Form1 anasayfa = new Form1();
            anasayfa.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
