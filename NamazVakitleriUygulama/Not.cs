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
    public partial class Not : Form
    {
        public Not()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection(@"Data Source= LAPTOP-MSV44HS0\MINE;Initial Catalog=NamazVakitleriDB;Integrated Security=True");

        public void FormAc(Form f)
        {
            f.Show();
            this.Hide();
        }

        private void Not_Load(object sender, EventArgs e)
        {

        }

        private void BtnNot_Click(object sender, EventArgs e)
        {
            //Kaydet butonuna tıkladığında eğer açıklama kısmı veya tarih boş ise boş geçemezsin mesajı ver.
            if (dateAciklama.Text == string.Empty || richtxtAciklama.Text == string.Empty)
            {
                MessageBox.Show("Boş geçemezsiniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else//boş değilse
            {
                baglan.Open();
                SqlCommand kaydet = new SqlCommand("Insert into Hatirlatici(Tarih,Aciklama) Values(@p1,@p2)", baglan);//veritabanında şu değerlere ekleme yapmak istiyorum
                kaydet.Parameters.AddWithValue("@p1", dateAciklama.Text);//girilen değerleri yazdım
                kaydet.Parameters.AddWithValue("@p2", richtxtAciklama.Text);


                kaydet.ExecuteNonQuery();
                baglan.Close();

                MessageBox.Show("Not Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);//kaydedildi mesajı ver

                HatirlaticiForm f = new HatirlaticiForm();//hatırlatıcı formunu aç
                FormAc(f);
            }

        }

        private void Not_FormClosed(object sender, FormClosedEventArgs e)
        {
            //bu formu kapattığında hatırlatıcı formunu açmıyordu.Not_FormClosed özelliği ile bu form kapatıldığında hatırlatıcı formunu aç dedim
            HatirlaticiForm f = new HatirlaticiForm();
            FormAc(f);

        }
    }
}
