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
    public partial class Form1 : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-PA2B818;Initial Catalog=AtolyeDB;Integrated Security=True");
        SqlCommand komut;
        SqlDataAdapter da;
        DataTable tablo = new DataTable();
        public Form1()
        {
            InitializeComponent();
        }
        
           
                
               
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            groupBox1.Visible = !groupBox1.Visible;

            baglanti.Open();
            tablo.Clear();
            komut = new SqlCommand("SELECT * FROM Musteri", baglanti);
            da = new SqlDataAdapter(komut);
            tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            baglanti.Open();
            string kayit = "SELECT * FROM Musteri WHERE musteri_isim=@musteri_isim";
            //musteriler tablosundaki tüm alanları isim parametresi
             komut = new SqlCommand(kayit, baglanti);
            komut.Parameters.AddWithValue("@musteri_isim", textBox1.Text);
            //isim parametremize textbox'dan girilen değeri aktarıyoruz.
             da = new SqlDataAdapter(komut);
             tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 ff = new Form2();
        
            ff.FormBorderStyle = FormBorderStyle.None;
            ff.MdiParent = this;
            ff.Show();
            ff.Location = new Point(10, 10);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string secmeSorgusu = "SELECT * from Musteri where musteri_id=@musteri_id";
            SqlCommand secmeKomutu = new SqlCommand(secmeSorgusu, baglanti);
            secmeKomutu.Parameters.AddWithValue("@musteri_id", textBox3.Text);
            SqlDataAdapter da= new SqlDataAdapter(secmeKomutu);
            SqlDataReader dr = secmeKomutu.ExecuteReader();
            
            if (dr.Read()) 
            {
                string isim = dr["musteri_isim"].ToString() + " " + dr["musteri_soyisim"].ToString();
                dr.Close();
                DialogResult durum = MessageBox.Show(isim + " kaydını silmek istediğinizden emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo);
                if (DialogResult.Yes == durum) 
                {
                    string silmeSorgusu = "DELETE from Musteri where musteri_id=@musteri_id";
                    SqlCommand silKomutu = new SqlCommand(silmeSorgusu, baglanti);
                    silKomutu.Parameters.AddWithValue("@musteri_id", textBox3.Text);
                    silKomutu.ExecuteNonQuery();
                    MessageBox.Show("Kayıt Silindi...");
               
                }
            }
            else
                MessageBox.Show("Müşteri Bulunamadı.");
            baglanti.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = !groupBox1.Visible;
            dataGridView1.DataSource = null;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            
            baglanti.Open();
            string kayit = "SELECT * FROM Ayakkabi WHERE ayakkabi_id=@ayakkabi_id";
            //musteriler tablosundaki tüm alanları isim parametresi
            komut = new SqlCommand(kayit, baglanti);
            komut.Parameters.AddWithValue("@ayakkabi_id", textBox4.Text);
            //isim parametremize textbox'dan girilen değeri aktarıyoruz.
            da = new SqlDataAdapter(komut);
            tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            groupBox2.Visible = !groupBox2.Visible;
            baglanti.Open();
            tablo.Clear();
            komut = new SqlCommand("SELECT * FROM Ayakkabi", baglanti);
            da = new SqlDataAdapter(komut);
            tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = !groupBox2.Visible;
            dataGridView1.DataSource = null;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            
            SqlCommandBuilder komutbuilder = new SqlCommandBuilder(da);
            da.Update(tablo);
            baglanti.Open();
            tablo.Clear();
            komut = new SqlCommand("SELECT * FROM Ayakkabi", baglanti);
            da = new SqlDataAdapter(komut);
            tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo.DefaultView;
            baglanti.Close();
            

        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form3 fff = new Form3();
            fff.FormBorderStyle = FormBorderStyle.None;
            fff.MdiParent = this;
            fff.Show();
            fff.Location = new Point(10, 10);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupBox3.Visible = !groupBox3.Visible;
            dataGridView1.DataSource = null;
            baglanti.Open();
            tablo.Clear();
            komut = new SqlCommand("SELECT * FROM Siparis", baglanti);
            da = new SqlDataAdapter(komut);
            tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            groupBox3.Visible = !groupBox3.Visible;
            dataGridView1.DataSource = null;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Form4 ffff = new Form4();

            ffff.FormBorderStyle = FormBorderStyle.None;
            ffff.MdiParent = this;
            ffff.Show();
            ffff.Location = new Point(10, 10);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            baglanti.Open();
            string kayit = "SELECT * FROM Siparis WHERE siparis_id=@siparis_id";
            //musteriler tablosundaki tüm alanları isim parametresi
            komut = new SqlCommand(kayit, baglanti);
            komut.Parameters.AddWithValue("@siparis_id", textBox2.Text);
            da = new SqlDataAdapter(komut);
            tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string secmeSorgusu = "SELECT * from Siparis where siparis_id=@siparis_id";
            SqlCommand secmeKomutu = new SqlCommand(secmeSorgusu, baglanti);
            secmeKomutu.Parameters.AddWithValue("@siparis_id", textBox5.Text);
            SqlDataReader dr = secmeKomutu.ExecuteReader();
            if (dr.Read())
            {
                string isim = dr["siparis_id"].ToString();
                dr.Close();
                DialogResult durum = MessageBox.Show(isim + " kaydını silmek istediğinizden emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo);
                if (DialogResult.Yes == durum)
                {
                    string silmeSorgusu = "DELETE from Siparis where siparis_id=@siparis_id";
                    SqlCommand silKomutu = new SqlCommand(silmeSorgusu, baglanti);
                    silKomutu.Parameters.AddWithValue("@siparis_id", textBox5.Text);
                    silKomutu.ExecuteNonQuery();
                    MessageBox.Show("Kayıt Silindi...");

                }
            }
            else
                MessageBox.Show("Sipariş Bulunamadı.");
            baglanti.Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            baglanti.Open();
            string kayit = "SELECT * FROM Siparis WHERE musteri_id=@musteri_id";
            //musteriler tablosundaki tüm alanları isim parametresi
            komut = new SqlCommand(kayit, baglanti);
            komut.Parameters.AddWithValue("@musteri_id", textBox6.Text);
            da = new SqlDataAdapter(komut);
            tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }
    }
}
