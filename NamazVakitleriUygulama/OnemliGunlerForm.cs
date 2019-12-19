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
    public partial class OnemliGunlerForm : Form
    {
        public OnemliGunlerForm()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection(@"Data Source= LAPTOP-MSV44HS0\MINE;Initial Catalog=NamazVakitleriDB;Integrated Security=True");

        public void FormAc(Form f)
        {
            f.Show();
            this.Hide();
        }
        
        public void VerileriGetir()
        {
            //tarih yazdıracağım labelları array1'e gün ismini yazdıracağım labelları aray2'e attım
            Label[] array = { label3,label4,label5,label6,label7,label8,label9,label10,label11,label12,label13,label14,label15,label16,label17,label18,label19,label20};
            Label[] array2 = { label21, label22, label23, label24, label25, label26, label27, label28, label29, label30, label31, label32, label33, label34, label35, label36, label37, label38 };

            
            List<string> GelenTarih = new List<string>();
            List<string> GelenGun = new List<string>();
            baglan.Open();

            SqlCommand getir = new SqlCommand("Select * from OnemliGunler",baglan);//önemli günler tablosundaki verileri görmek istiyorum dedim

            SqlDataReader dr = getir.ExecuteReader();

            while (dr.Read())//veritabanına okurken
            {
                                               
                     GelenTarih.Add(dr["Tarih"].ToString());//tarihleri GelenTarih isimli list'e at
                    GelenGun.Add(dr["GunIsmi"].ToString());//günleri Gelengün isimli listê at
               
            }           
                         
            dr.Close();
            baglan.Close();

            for(int a = 0; a < array.Length; a++)
            {
                //arraylerin içini dolaş ve listlerdeki verileri sırayla bu arraylere bas.
                array[a].Text = GelenTarih[a];
                array2[a].Text = GelenGun[a];
            }
        }

        private void OnemliGunlerForm_Load(object sender, EventArgs e)
        {
            lblBaslik.Parent = OnemliGunResim;
            lblBaslik.BackColor = Color.Transparent;

            Label[] dizi1 = { label3, label4, label5, label6, label7, label8, label9, label10, label11, label12, label13, label14, label15, label16, label17, label18, label19, label20 };
            Label[] dizi2 = { label21, label22, label23, label24, label25, label26, label27, label28, label29, label30, label31, label32, label33, label34, label35, label36, label37, label38 };

            //eğer ayarlarda Label seçildiyse dizilerdeki arrayleri dolaş sırayla renklerini değiştir.
            if (AyarlarForm.secilenNesne == "Label")
            {
                for(int a = 0; a < dizi1.Length; a++)
                {
                    dizi1[a].BackColor = AyarlarForm.renkAyarı;
                    dizi2[a].BackColor = AyarlarForm.renkAyarı;
                }
              

            }

            VerileriGetir();//yukaerda yazdığım fonksiyonu çağırdım.EKranda verileri göstersin diye.

        }

        private void PicAnasayfa3_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            FormAc(f);
        }

        private void PicKible3_Click(object sender, EventArgs e)
        {
            KibleForm f = new KibleForm();
            FormAc(f);
        }

        private void PicHatirlatici3_Click(object sender, EventArgs e)
        {
            HatirlaticiForm f = new HatirlaticiForm();
            FormAc(f);
        }

        private void PicAyarlar3_Click(object sender, EventArgs e)
        {
            AyarlarForm f = new AyarlarForm();
            FormAc(f);
        }
    }
}
