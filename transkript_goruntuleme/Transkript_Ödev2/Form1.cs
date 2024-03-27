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
    public partial class Form1 : Form
    {
        public Form1()
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
               Transkript_dataGridView.DataSource = dt;
            }
            komut.Dispose();
           baglanti.Close();
        }

        
        private void KayıtGöster_button_Click(object sender, EventArgs e)
        {
            verileri_goster("select * from Transkript4");
        }

        private void KayıtEkle_button_Click(object sender, EventArgs e)
        {
            KayıtEkle ekle = new KayıtEkle();
            ekle.Show();
        }

        private void KayıtGüncelle_button_Click(object sender, EventArgs e)
        {
            KayıtGüncelle ekle = new KayıtGüncelle();
            ekle.Show();
        }

        private void KayıtSil_button_Click(object sender, EventArgs e)
        {
            KayıtSil ekle = new KayıtSil();
            ekle.Show();
        }

        private void GNOHesapla_button_Click(object sender, EventArgs e)
        {
            GNOHesapla ekle = new GNOHesapla();
            ekle.Show();
        }
    }
}
