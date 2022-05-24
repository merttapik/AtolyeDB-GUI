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
    public partial class Form4 : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=;Initial Catalog=AtolyeDB;Integrated Security=True");
        SqlCommand komut;
        SqlDataAdapter da;
        DataTable tablo = new DataTable();
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'atolyeDBDataSet10.Musteri' table. You can move, or remove it, as needed.
            this.musteriTableAdapter2.Fill(this.atolyeDBDataSet10.Musteri);
            // TODO: This line of code loads data into the 'atolyeDBDataSet9.Musteri' table. You can move, or remove it, as needed.
            this.musteriTableAdapter1.Fill(this.atolyeDBDataSet9.Musteri);
            // TODO: This line of code loads data into the 'atolyeDBDataSet8.Ayakkabi' table. You can move, or remove it, as needed.
            this.ayakkabiTableAdapter.Fill(this.atolyeDBDataSet8.Ayakkabi);
            // TODO: This line of code loads data into the 'atolyeDBDataSet7.Musteri' table. You can move, or remove it, as needed.
            this.musteriTableAdapter.Fill(this.atolyeDBDataSet7.Musteri);

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
                int value1 = Convert.ToInt32(textBox1.Text);
                int value3= Convert.ToInt32(textBox1.Text);
                string kayit = "insert into Siparis(musteri_id,ayakkabi_id,siparis_adet) values (@musteri_id,@ayakkabi_id,@siparis_adet)";
                string kayit2 = "update  Ayakkabi set ayakkabi_adet=@yeniayakkabi_adet WHERE ayakkabi_id=@ayakkabi_id ";
                string kayit3 = "select ayakkabi_adet from Ayakkabi where ayakkabi_id=@ayakkabi_id ";
                string kayit4 = "select ayakkabi_fiyat from Ayakkabi where ayakkabi_id=@ayakkabi_id  ";
                string kayit5 = "update  Musteri set musteri_bakiye=@yenimusteri_bakiye WHERE musteri_id=@musteri_id ";
                string kayit6 = "select musteri_bakiye from Musteri where musteri_id=@musteri_id  ";




                komut = new SqlCommand(kayit, baglanti);
                //Sorgumuzu ve baglantimizi parametre olarak alan bir SqlCommand nesnesi oluşturuyoruz.
               
                if (comboBox1.SelectedIndex == comboBox3.SelectedIndex)
                {
                    komut.Parameters.AddWithValue("@musteri_id", comboBox1.SelectedValue); 
                    komut.Parameters.AddWithValue("@ayakkabi_id", comboBox2.SelectedValue);
                    komut.Parameters.AddWithValue("@siparis_adet",textBox1.Text);
                    komut.ExecuteNonQuery();

                    komut = new SqlCommand(kayit3, baglanti);
                    komut.Parameters.AddWithValue("@ayakkabi_id", comboBox2.SelectedValue);
                    int value2 = Convert.ToInt32(komut.ExecuteScalar());
                    int yenideger = value2 - value1;
                    
                    komut = new SqlCommand(kayit2, baglanti);
                    komut.Parameters.AddWithValue("@ayakkabi_id", comboBox2.SelectedValue);
                    komut.Parameters.AddWithValue("@yeniayakkabi_adet", yenideger);
                    komut.ExecuteNonQuery();

                    komut = new SqlCommand(kayit4, baglanti);
                    komut.Parameters.AddWithValue("@ayakkabi_id", comboBox2.SelectedValue);
                    int value4 = Convert.ToInt32(komut.ExecuteScalar());
                    int siparisTutari = value3 * value4;

                    komut = new SqlCommand(kayit6, baglanti);
                    komut.Parameters.AddWithValue("@musteri_id", comboBox1.SelectedValue);
                    int value5 = Convert.ToInt32(komut.ExecuteScalar());
                    int yeniBakiye = value5 - siparisTutari;

                    komut = new SqlCommand(kayit5, baglanti);
                    komut.Parameters.AddWithValue("@musteri_id", comboBox1.SelectedValue);
                    komut.Parameters.AddWithValue("@yenimusteri_bakiye", yeniBakiye);
                    komut.ExecuteNonQuery();

                    MessageBox.Show("Siparis Kayıt İşlemi onaylandı.");
                }
                else
                {
                   MessageBox.Show("Siparis Kayıt İşlemi olmadı.");
                }
                

                //Parametrelerimize Form üzerinde ki kontrollerden girilen verileri aktarıyoruz.


                baglanti.Close();
                
            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
