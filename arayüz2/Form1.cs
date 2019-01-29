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

namespace arayüz2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataReader dr;      

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnAdminGiris_Click(object sender, EventArgs e)
        {
            baglanti = new SqlConnection("Data Source = .; Initial Catalog = SempozyumDB; Integrated Security = True");
            komut = new SqlCommand();
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "SELECT * FROM admin where adminkullanıcıadı='" + txtAdminKullAdı.Text + "' AND adminsifre='" + txtAdminSifre.Text + "'";
            dr = komut.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Tebrikler! Başarılı bir şekilde giriş yaptınız.");
                AdminForm admin = new AdminForm();
                admin.Show();
            }
            else
            {
                MessageBox.Show("Kullanıcı adını ve şifrenizi kontrol ediniz.");
            }
            baglanti.Close();
            
        }

        private void txtAdminKullAdı_Click(object sender, EventArgs e)
        {
            txtAdminKullAdı.Clear();
        }

        private void txtAdminSifre_Click(object sender, EventArgs e)
        {
            txtAdminSifre.Clear();
        }

        private void btnMisafirGiris_Click(object sender, EventArgs e)
        {
            MisafirForm misafir = new MisafirForm();
            misafir.Show();
        }

        private void btnKullanıcıKayıt_Click(object sender, EventArgs e)
        {
            baglanti = new SqlConnection("Data Source = .; Initial Catalog = SempozyumDB; Integrated Security = True");
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();
                // Bağlantımızı kontrol ediyoruz, eğer kapalıysa açıyoruz.
                string kayit = "insert into kullanıcı(kullanıcıadı,kullanıcısifre,adsoyad,email,uzmanlıkalanı) values (@kullanıcıadı,@kullanıcısifre,@adsoyad,@email,@uzmanlıkalanı)";
                // müşteriler tablomuzun ilgili alanlarına kayıt ekleme işlemini gerçekleştirecek sorgumuz.
                SqlCommand komut = new SqlCommand(kayit, baglanti);
                //Sorgumuzu ve baglantimizi parametre olarak alan bir SqlCommand nesnesi oluşturuyoruz.
                komut.Parameters.AddWithValue("@kullanıcıadı", txtKullanıcıAdı.Text);
                komut.Parameters.AddWithValue("@kullanıcısifre", txtSifre.Text);
                komut.Parameters.AddWithValue("@adsoyad", txtAdSoyad.Text);
                komut.Parameters.AddWithValue("@email", txtEmail.Text);
                komut.Parameters.AddWithValue("@uzmanlıkalanı", cmbxUzmanlıkAlanı.SelectedItem.ToString());
                //Parametrelerimize Form üzerinde ki kontrollerden girilen verileri aktarıyoruz.
                komut.ExecuteNonQuery();
                //Veritabanında değişiklik yapacak komut işlemi bu satırda gerçekleşiyor.
                baglanti.Close();
                MessageBox.Show("Kullanıcı Kayıt İşlemi Gerçekleşti!");
            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu!" + hata.Message);
            }
        }

        private void btnKullanıcıGiris_Click(object sender, EventArgs e)
        {
            baglanti = new SqlConnection("Data Source = .; Initial Catalog = SempozyumDB; Integrated Security = True");
            komut = new SqlCommand();
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "SELECT * FROM kullanıcı where kullanıcıadı='" + txtKullanıcıAdıGiris.Text + "' AND kullanıcısifre='" + txtSifreGiris.Text + "'";
            dr = komut.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Tebrikler! " + txtKullanıcıAdıGiris.Text + " Başarılı bir şekilde giriş yaptınız.");
                KullanıcıForm kullanıcı = new KullanıcıForm();
                kullanıcı.Show();
            }
            else
            {
                MessageBox.Show("Kullanıcı adını ve şifrenizi kontrol ediniz.");
            }
            baglanti.Close();  
        }

        private void txtKullanıcıAdıGiris_TextChanged(object sender, EventArgs e)
        {
            txtKullanıcıAdıGiris.Clear();
        }

        private void txtSifreGiris_TextChanged(object sender, EventArgs e)
        {
            txtSifreGiris.Clear();
        }
    }
}
