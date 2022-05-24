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

namespace Atolye
{
    public partial class Form2 : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=;Initial Catalog=AtolyeDB;Integrated Security=True");
        SqlCommand komut;
        SqlDataAdapter da;
        DataTable tablo = new DataTable();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'atolyeDBDataSet1.il' table. You can move, or remove it, as needed.
            this.ilTableAdapter.Fill(this.atolyeDBDataSet1.il);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();
                // müşteriler tablomuzun ilgili alanlarına kayıt ekleme işlemini gerçekleştirecek sorgumuz.
                string kayit = "insert into Musteri(musteri_isim,musteri_soyisim,adres_bilgi,musteri_tel,musteri_bakiye,il_id) values (@musteri_isim,@musteri_soyisim,@adres_bilgi,@musteri_tel,@musteri_bakiye,@il_id)";
                komut = new SqlCommand(kayit, baglanti);
                //Sorgumuzu ve baglantimizi parametre olarak alan bir SqlCommand nesnesi oluşturuyoruz.
                komut.Parameters.AddWithValue("@musteri_isim", mstad.Text);
                komut.Parameters.AddWithValue("@musteri_soyisim", mstrsad.Text);
                komut.Parameters.AddWithValue("@adres_bilgi", mstradr.Text);
                komut.Parameters.AddWithValue("@musteri_tel", mstrtel.Text);
                komut.Parameters.AddWithValue("@musteri_bakiye", mstrbky.Text);
                komut.Parameters.AddWithValue("@il_id", comboBox1.SelectedValue);
                //Parametrelerimize Form üzerinde ki kontrollerden girilen verileri aktarıyoruz.
                komut.ExecuteNonQuery();
            
                baglanti.Close();
                MessageBox.Show("Müşteri Kayıt İşlemi Gerçekleşti.");
            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
