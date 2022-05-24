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
    
    public partial class Form3 : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-PA2B818;Initial Catalog=AtolyeDB;Integrated Security=True");
        SqlCommand komut;
        SqlDataAdapter da;
        DataTable tablo = new DataTable();
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'atolyeDBDataSet6.Kategori' table. You can move, or remove it, as needed.
            this.kategoriTableAdapter.Fill(this.atolyeDBDataSet6.Kategori);
            // TODO: This line of code loads data into the 'atolyeDBDataSet5.Renk' table. You can move, or remove it, as needed.
            this.renkTableAdapter.Fill(this.atolyeDBDataSet5.Renk);
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();
                // müşteriler tablomuzun ilgili alanlarına kayıt ekleme işlemini gerçekleştirecek sorgumuz.
                string kayit = "insert into Ayakkabi(renk_id,ayakkabi_adet,ayakkabi_fiyat,ayakkabi_numara,katagori_id) values (@renk_id,@ayakkabi_adet,@ayakkabi_fiyat,@ayakkabi_numara,@katagori_id)";
                komut = new SqlCommand(kayit, baglanti);
                //Sorgumuzu ve baglantimizi parametre olarak alan bir SqlCommand nesnesi oluşturuyoruz.
                komut.Parameters.AddWithValue("@renk_id", comboBox1.SelectedValue);
                komut.Parameters.AddWithValue("@ayakkabi_adet", textBox1.Text);
                komut.Parameters.AddWithValue("@ayakkabi_fiyat", textBox2.Text);
                komut.Parameters.AddWithValue("@ayakkabi_numara", textBox3.Text);
                komut.Parameters.AddWithValue("@katagori_id", comboBox2.SelectedValue);
               
                //Parametrelerimize Form üzerinde ki kontrollerden girilen verileri aktarıyoruz.
                komut.ExecuteNonQuery();

                baglanti.Close();
                MessageBox.Show("Ayakkabı Kayıt İşlemi Gerçekleşti.");
            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
