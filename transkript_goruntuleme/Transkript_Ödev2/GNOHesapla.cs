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
    public partial class GNOHesapla : Form
    {
        public GNOHesapla()
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
                GNOHesapla_dataGridView.DataSource = dt;
            }
            komut.Dispose();
            baglanti.Close();
        }
        private void GNOHesaplaListele_button_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            NpgsqlCommand komut_ekle = new NpgsqlCommand();
            komut_ekle.Connection = baglanti;


            komut_ekle.CommandType = CommandType.Text;
            komut_ekle.CommandText = "select* from Transkript4 where harf_notu !='Girilmedi'";

            NpgsqlDataReader dr = komut_ekle.ExecuteReader();
            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
              GNOHesapla_dataGridView.DataSource = dt;
            }
            komut_ekle.Dispose();
            baglanti.Close();

            verileri_goster("select* from Transkript4 where harf_notu !='Girilmedi'");
        }

        private void GNOHesapla_button_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            using (var cmd = new NpgsqlCommand("SELECT kredi, harf_notu FROM transkript4 where harf_notu!='Girilmedi'",baglanti))
            using (var reader = cmd.ExecuteReader())
            {
                double toplamkredi = 0;
                double toplamharfnotu = 0;
                while (reader.Read())
                {
                    int kredi = (int)reader["kredi"];
                    string letterGrade = (string)reader["harf_notu"];
                    double harf_deger = 0;
                    switch (letterGrade)
                    {
                        case "AA": harf_deger = 4.0; break;
                        case "BA": harf_deger = 3.5; break;
                        case "BB": harf_deger = 3.0; break;
                        case "CB": harf_deger = 2.5; break;
                        case "CC": harf_deger = 2.0; break;
                        case "DC": harf_deger = 1.5; break;
                        case "DD": harf_deger = 1.0; break;
                        case "FF": harf_deger = 0.0; break;
                    }
                   toplamkredi += kredi;
                    toplamharfnotu += kredi * harf_deger;
                }
                double GNO = toplamharfnotu/ toplamkredi;
               MessageBox.Show($"GNO (GPA): {GNO:F2}");
            }
           



        }

    }

    }

        
            
           
           
            
                






           
            

            
        
    

