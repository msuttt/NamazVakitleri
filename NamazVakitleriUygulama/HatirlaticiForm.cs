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

namespace NamazVakitleriUygulama
{
    public partial class HatirlaticiForm : Form
    {
        public HatirlaticiForm()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection(@"Data Source= LAPTOP-MSV44HS0\MINE;Initial Catalog=NamazVakitleriDB;Integrated Security=True");

        public void FormAc(Form f)
        {
            f.Show();
            this.Hide();
        }
        public void Listele()
        {  //veri listelemek için bir datatable nesnesi oluşturdum
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("Select Tarih,Aciklama from Hatirlatici", baglan);//adapter nesnesi ile şu veriye adapte ol şunu istiyorum dedim
            adapter.Fill(dt);//adapter ile aldığım verileri datatable'a doldur dedim
            gridViewNotlar.DataSource = dt;//datatable'daki veriyi de formdaki gridview'a at diyorum
        }
        public void Sil()
        {
            string Id = string.Empty;

            baglan.Open();

            string tarih = gridViewNotlar.CurrentRow.Cells[0].Value.ToString();//tıklanan verinin tarih kısmını al
            string aciklama = gridViewNotlar.CurrentRow.Cells[1].Value.ToString();//tıklanan verini açıklama kısmını al

            SqlCommand oku = new SqlCommand("Select * from Hatirlatici", baglan);
            SqlDataReader dr = oku.ExecuteReader();
            //veritabanında hatırlatıcı tablosuna git tabloyu okumaya başla
            while (dr.Read())
            {   //tabloyu okurken eğer okuduğun kaydın tarihi ile yukardan aldığım tarih ve okuduğun değerin açıklaması ile yukardan aldığım açıklama aynı ise o kaydın id'sini bana ver.Id aldım çünkü hangi veriyi sildireceğime Id'ye göre karar vericem
                if (dr["Tarih"].ToString() == tarih && dr["Aciklama"].ToString() == aciklama)
                {
                    Id = dr["Id"].ToString();

                }
            }
            dr.Close();

            SqlCommand sil = new SqlCommand("Delete  from Hatirlatici where Id=@p1", baglan);
            sil.Parameters.AddWithValue("@p1", Convert.ToInt32(Id));
            //veritabanına git hatırlatıcı tablosunda aldığım Id^ye sahip olan veriyi sil.
            sil.ExecuteNonQuery();

            baglan.Close();

            MessageBox.Show("Not silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);//ekrana veri silindi mesajı ver.
        }

        private void HatirlaticiForm_Load(object sender, EventArgs e)
        {
            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;//label arkaplanını transoaran yaptım

            if (AyarlarForm.secilenNesne == "Buton")//Ayarlar formundan gelen secilenNesne değişkeni eğer Buton ise
            {
                //Bu butonların renk ayarlarını değiştir
                btnEkle.BackColor = AyarlarForm.renkAyarı;
                btnSil.BackColor = AyarlarForm.renkAyarı;
              
            }

            Listele();//listele fonksiyonun çağır verileri ekranda göstersin diye

        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            //ekle butonuna tıkladığında Not formunu aç.Ekleme ordan yapılacak.
            Not f = new Not();
            f.Show();

            this.Hide();

        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            //Sil butonuna tıklandığında sil fonksiyonuna git ordaki işlemleri yap.
            Sil();
            Listele();//sonra listele fonksiyonunu çağırdım.veriyi tekrar listelesin.Çünkü bişey silindi değişiklik oldu.

        }

        private void PicAnasayfa_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            FormAc(f);
        }

        private void PicKible2_Click(object sender, EventArgs e)
        {
            KibleForm f = new KibleForm();
            FormAc(f);
        }

        private void PicOnemliGun2_Click(object sender, EventArgs e)
        {
            OnemliGunlerForm f = new OnemliGunlerForm();
            FormAc(f);
        }

        private void PicAyarlar2_Click(object sender, EventArgs e)
        {
            AyarlarForm f = new AyarlarForm();
            FormAc(f);
        }
    }
}
