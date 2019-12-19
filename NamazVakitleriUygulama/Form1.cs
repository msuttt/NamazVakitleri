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
using HtmlAgilityPack;
using System.Net;
using System.Media;

namespace NamazVakitleriUygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
      
       

        SqlConnection baglan = new SqlConnection(@"Data Source= LAPTOP-MSV44HS0\MINE;Initial Catalog=NamazVakitleriDB;Integrated Security=True");//Sql server'a bağlantı adresi.Bunu kendi server adına göre değiştirmeniz lazım

        public void FormAc(Form f)//butona tıklatıldığında başka forma gitmek için fonksiyon
        {
            //ilk başta bir form nesnesi oluşturulur sonra aşağıdaki kodlar yazılır.Form nesnesi oluşturma -
            //açılacak forma göre değişir ama aşağıdaki kodlar sabittir.Bu yüzden bu kodları fonksiyona aldım.
            //Bize lazım olan form nesnesi parantez içinden geliyor.
            f.Show();
            this.Hide();
        }
        public void ComboBoxDoldur()//Veritabanından combobox'a şehirleri dolduruyor.
        {
            baglan.Open();
            SqlCommand cmbDoldur = new SqlCommand("Select * from  SehirVakit", baglan);//verileri listesin istediğimi belirten sorgu

            SqlDataReader dataReader = cmbDoldur.ExecuteReader();//sonra gitsin veritabanını okusun 

            List<string> veriler = new List<string>();//verileri atmak için list oluşturdum
            while (dataReader.Read())//veritabanını okurken 
            {
                veriler.Add(dataReader["Sehir"].ToString());//Şehirleri yukarda oluşturduğum veriler isimli list'e at
            }
            dataReader.Close();

            for (int a = 0; a < 2370; a = a + 30)//list'e attığın verileri combobox'a doldur
            {
                cmbSehirler.Items.Add(veriler[a]);
            }


        }

        List<string> hadisler = new List<string>();//veritabanındaki hadislere list'e atabilmek için oluşturdum
        public void HadisDoldur()
        {

            SqlCommand al = new SqlCommand("Select Hadis from Hadis", baglan);//veritabanındaki hadisleri görmek istiyorum dedim
            SqlDataReader dr = al.ExecuteReader();//veritabanını okusun diye datareader nesnesi oluşturdum

            while (dr.Read())//veritabanını okurken oradaki hadisleri "hadisler" adındaki list'e at diyorum
            {
                for (int i = 0; i <= 9; i++)
                {
                    hadisler.Add(dr["Hadis"].ToString());
                }
            }
            dr.Close();


            lblHadis.Text = hadisler[0];//hadisin ilk verisini yaz diyorum
            timerHadis.Enabled = true;//hadis kayan yazı olsun diye timer'ı burada aktif ettim
        }

        public void FarkHesapla(TimeSpan fark)//zaman farkı hesaplayan fonksiyon aşağıda timerKalanSaat'de kullanıcam
        {
            double a = fark.TotalMinutes;//bitane timespan nesnesi geliyor,onun sayesinde girilen zaman farkının toplam dakikasını alıyorum.Timespan zaman farkı hesaplamaya yarar.

            if (a % 60 == 0)//eğer dakika 60'a tam bölünüyorsa
            {
                double b = a / 60;//60'a bölümünü al bölüm int gelmediğini için omu aşağıda int'e dönüştür dedim
                int z = Convert.ToInt32(b);
                //mesela toplam dakika 180.Tam bölünüyor.180/60=3.Bu 3'ü al bu benim diğer namaza kaç saatimin kaldığını gösterir.Küsurattan öncesi saat sonrası dakika.Tam bölündüğü için küsurat 0.

                lblKalanSaatGoster.Text = z.ToString();//bunu saat kısmına yaz.
            }
            if (a % 60 != 0)//eğer sayı 60'a tam bölünmüyorsa
            {
                double y = Math.Floor(a / 60);//bunu sayıyı yuvarlamasın diye yaptım.örneğin sayı 8.33 ise onu 9 yapıyor fazla gösteriyor.Burda küsurattan öncesini yani saati aldırıyorum.

                double mod = a % 60;//60' a bölümününden kalanı al yani küsurattan sonrası,dakikayı al

                string kalan = y.ToString() + ":" + mod.ToString();//saati ve dakikayı yazdır.Yalnız burada saniyeyi falan da alıyor onu düzeltemedim


                lblKalanSaatGoster.Text = kalan;


            }
        }

        public string YarınKiImsak()//saat yatsıyı geçtiyse imsak'a kalan vakti hesaplamak için veritabanından yarının imsağını almak gerekiyor.Fonksiyonun amacı bu.
        {
            string Secilensehir = cmbSehirler.SelectedItem.ToString();//seçilen şehri al
            string Yarintarih = DateTime.Now.AddDays(+1).ToString("dd MMMM yyyy dddd ");//yarının tarihini al
            string gelenDeger = string.Empty;//herşeyi hesapladıktan sonra en son bi değer döndüreceğiz bu değişken onun için

            SqlCommand com = new SqlCommand("Select * from SehirVakit where Sehir=@p1 and Tarih=@p2", baglan);//veritabanına tarihi ve şehri şu olan veriyi görmek istiyorum dedim
            com.Parameters.AddWithValue("@p1", Secilensehir);//yukardan aldığım tarih ve şehir değerlerini yazdım.Tarih ve şehir hangisi belirtmek için
            com.Parameters.AddWithValue("@p2", Yarintarih);

            SqlDataReader dr = com.ExecuteReader();

            while (dr.Read())
            {
                gelenDeger = dr["Imsak"].ToString();//tarihi ve şehri şu olan imsak vaktini al.Yani seçilen şehre göre onun yarınki imsak vaktini alıyor
            }
            dr.Close();

            return gelenDeger;//aldığı değeri döndür.Burada aldığım değer saat olmasına rağmen string'e çevirdim.Çünkü labellardaki namaz vakitleriyle kıyaslıyorum onlar string.Kıyaslaması daha rahat olur.
        }

       
       
        private void Form1_Load(object sender, EventArgs e)//form açıldığında çalışacak komutlar
        {
            Label[] array = { lblNamazVakitleri, lblImsak, lblGunes, lblOgle, lblIkindi, lblAksam, lblYatsı ,lblHadis,lblBugun2,lblKalanSaatGoster};
            for(int a = 0; a < 10; a++)
            {//bütün labelları bir array'e attım.Sıra sıra onları dolaş ve arkaplanlarını transparan yap.
                array[a].Parent = arkaplan;
                array[a].BackColor = Color.Transparent;
            }
            AyarlarForm.secilenSes = "Ayasofyada Ezan Sesi.wav";//Ayarlar formunda ses seçtiriyorum.Ama program ilk açıldığında hiçbirşey seçili olmuyor.İlk seçili değer bu gelsin dedim.Burada static değişkenlerle ilgili bir mesele var onu Ayarlar formda açıklayacağım.


            if (AyarlarForm.secilenNesne == "Label")//eğer ayarlar formundan seçilen nesne label ise renklerini değiştir
            {
                //secilenNesne ve renkAyarı, Ayarlar formunda oluşturduğum static değişkenler. O formdaki değerleri bu forma aktarabilmek için kullanılıyor.
                lblImsakVakti.BackColor = AyarlarForm.renkAyarı;
                lblGunesVakti.BackColor = AyarlarForm.renkAyarı;
                lblOgleVakti.BackColor = AyarlarForm.renkAyarı;
                lblIkindiVakti.BackColor = AyarlarForm.renkAyarı;
                lblAksamVakti.BackColor = AyarlarForm.renkAyarı;
                lblYatsıVakti.BackColor = AyarlarForm.renkAyarı;
                lblBugun2.BackColor = AyarlarForm.renkAyarı;
                lblKalanSaatGoster.BackColor = AyarlarForm.renkAyarı;
            }
          
                 

            lblBugun.Text = DateTime.Now.ToString("dd MMMM dddd yyyy");//bugünün tarihini göster

            ComboBoxDoldur();//fonksiyonları çağırdım
            HadisDoldur();

            cmbSehirler.SelectedIndex = 0;//form ilk açıldığında ilk şehir seçili gelsin


            timerKalanVakit.Enabled = true;//timerlarım çalışması için burada enable ediyorum
            timerSes.Start();
            timerSaat.Enabled = true;



        }

        private void TimerSaat_Tick(object sender, EventArgs e)//şuanki saati yazdırmak için timer koydum
        {
            string saat;
            string dakika;
            string saniye;

            if (DateTime.Now.Hour >= 0 && DateTime.Now.Hour < 10)//eğer saat 10'dan küçükse önüne 0 koysun(06 gibi)
            {
                saat = ":" + "0" + DateTime.Now.Hour.ToString();
            }
            else//değilse normal yazsın
            {
                saat =  DateTime.Now.Hour.ToString();
            }

            if (DateTime.Now.Minute >= 0 && DateTime.Now.Minute < 10)
            {
                dakika = ":" + "0" + DateTime.Now.Minute.ToString();
            }
            else
            {
                dakika = ":" + DateTime.Now.Minute.ToString();
            }


            if (DateTime.Now.Second >= 0 && DateTime.Now.Second < 10)
            {
                saniye = ":" + "0" + DateTime.Now.Second.ToString();
            }
            else
            {
                saniye = ":" + DateTime.Now.Second.ToString();
            }

            lblBugun2.Text = saat + dakika + saniye;

        }

        private void TimerHadis_Tick(object sender, EventArgs e)
        {
            lblHadis.Text = lblHadis.Text.Substring(1) + lblHadis.Text.Substring(0, 1);//kayan yazı yapmak için timer
        }

        private void TimerKalanVakit_Tick(object sender, EventArgs e)//bir sonraki vakte kalan vakti bulmak için
        {

            if (DateTime.Now >= Convert.ToDateTime(lblImsakVakti.Text) && DateTime.Now < Convert.ToDateTime(lblGunesVakti.Text))//şimdiki zaman imsak'tan büyükse ve güneş vaktinden küçükse
            {
                TimeSpan fark = Convert.ToDateTime(lblGunesVakti.Text) - DateTime.Now;//güneş vaktinden şimdiki zamanı çıkar

                lblKalanSaat.Text = "Güneşin doğuşuna kalan vakit";

                FarkHesapla(fark);//yukarda yazdığım fonksiyonu çağır.fark değişkenini yolla ve o fonksiyon sayesinde güneşe kalan vakti hesapla.İstersen farkhesapla fonksiyonuna gidebilirsin anlamak için.

            }

            //aynı mantık aşağılarda da geçerli

            if (DateTime.Now >= Convert.ToDateTime(lblGunesVakti.Text) && DateTime.Now < Convert.ToDateTime(lblOgleVakti.Text))
            {
                TimeSpan fark = Convert.ToDateTime(lblOgleVakti.Text) - DateTime.Now;

                lblKalanSaat.Text = "Öğle namazına kalan vakit";

                FarkHesapla(fark);

            }


            if (DateTime.Now >= Convert.ToDateTime(lblOgleVakti.Text) && DateTime.Now < Convert.ToDateTime(lblIkindiVakti.Text))
            {
                TimeSpan fark = Convert.ToDateTime(lblIkindiVakti.Text) - DateTime.Now;

                lblKalanSaat.Text = "İkindi namazına kalan vakit";

                FarkHesapla(fark);

            }


            if (DateTime.Now >= Convert.ToDateTime(lblIkindiVakti.Text) && DateTime.Now < Convert.ToDateTime(lblAksamVakti.Text))
            {
                TimeSpan fark = Convert.ToDateTime(lblAksamVakti.Text) - DateTime.Now;

                lblKalanSaat.Text = "Akşam namazına kalan vakit";

                FarkHesapla(fark);

            }


            if (DateTime.Now >= Convert.ToDateTime(lblAksamVakti.Text) && DateTime.Now < Convert.ToDateTime(lblYatsıVakti.Text))
            {
                TimeSpan fark = Convert.ToDateTime(lblYatsıVakti.Text) - DateTime.Now;

                lblKalanSaat.Text = "Yatsı namazına kalan vakit";

                FarkHesapla(fark);

            }


            string YarınkiImsak = YarınKiImsak();//Eğer vakit yatsıyı geçtiyse imsak vaktine kalan zamanı hesaplamak için yarının imsak vaktini alman gerekiyor.lblImsakvakti'nde yazanı alamazsın çünkü o bugünün imsak'ı.
            //yarınkiImsak fonksiyonunu çağır o bana veritabanından,seçilen şehre göre yarının imsak vaktini getirip değişkene atsın

            string abc = "23:59";
            string sıfır = "00:00";
            if (DateTime.Now >= Convert.ToDateTime(lblYatsıVakti.Text) && DateTime.Now < Convert.ToDateTime(abc))//eğer vakit yatsı vaktinde büyük ve 23:59'dan küçükse
            {
                TimeSpan fark = Convert.ToDateTime(abc) - DateTime.Now;//23:59 dan şuanki vakti çıkar fark değişkenine at
                TimeSpan fark2 = Convert.ToDateTime(YarınkiImsak) - Convert.ToDateTime(sıfır);//yarınkiImsak'tan 0 çıkar.Burda 0 çıkar dedim çünkü yarınki imsak vaktini direk Timespan değişkenine atamıyorum.Timespan zaman farkını bulduğu için bi çıkarma işlemi yapmam gerekiyordu.
                TimeSpan farkToplam = fark + fark2;//gece 12'den çıkardığım fark ile yarınkiImsak - 0 işleminden çıkan sonucu topla.Örnek;saat şuan 20:00 diyelim.Gece 12 den çıkardım 4,bir sonraki imsak 06:00 diyelim.06:00 - 0 yaptım 6 geldi.4+6=10.bir sonraki imsak'a 10 saat var.

                lblKalanSaat.Text = "İmsak vaktine kalan vakit";

                FarkHesapla(farkToplam);//yukardan aldığım farkToplam değişkenini bu fonksiyonun içine atıyorum.O da bu fonksiyonu gidip içinde fark bulma işlemlerini yapıyor.

            }
            if (DateTime.Now >= Convert.ToDateTime(sıfır) && DateTime.Now < Convert.ToDateTime(lblImsakVakti.Text))//eğer vakit 00:00 dan büyükse yani gece 12 den sonraysa ve labelda yazan imsak vaktinden küçükse
            {
                TimeSpan fark = Convert.ToDateTime(lblImsakVakti.Text) - DateTime.Now;//labelda yazan vakitten şuanı çıkar.fark değişkenine at.

                lblKalanSaat.Text = "İmsak vaktine kalan vakit";

                FarkHesapla(fark);//bu fark değişkenini fonksiyona yolla.bunu kullanarak fonksiyona gitsin orada fark bulma işlemlerini yapsın
                //Burada fonksiyon kullanmamın amacı şu;Tekrar eden aynı işlemler varsa onları fonksiyona alırsınız burada da sadece o fonksiyonun ismini yazarsınız böylelikle fazla kod kalabalığı olmamış olur.

            }

        }

        private void TimerSes_Tick(object sender, EventArgs e)
        {
            string suanSaat;
            string suanDakika;
            string suan;

            //şuanki dakika ve saati al.
            int saat = Convert.ToInt32(DateTime.Now.Hour);
            int dakika= Convert.ToInt32(DateTime.Now.Minute);

            if (saat < 10)//eğer saat 10'dan küçükse önüne 0 koyarak yaz:
            {
                suanSaat = "0" + DateTime.Now.Hour.ToString() + ":";
            }
            else//değilse normal yaz
            {
                suanSaat= DateTime.Now.Hour.ToString() + ":";
            }

            if (dakika < 10)//aynı şeyi dakika için yaptım
            {
                suanDakika= "0" + DateTime.Now.Minute.ToString();
            }
            else
            {
                suanDakika= DateTime.Now.Minute.ToString();
            }

            suan = suanSaat + suanDakika;//suan değişkenine saati ve dakikayı at.Saati ve dakikayı stringe çevirdim.Çünkü labellarda yazanlarla kıyaslayacağım.Onlar string olduğu için kıyaslaması kolay olur.

            //eğer suan değişkeni labellarda yazan vakitlerden(güneş vakti hariç) herhangi birine eşitse diyorum.
            if(suan==lblImsakVakti.Text|| suan == lblOgleVakti.Text || suan == lblIkindiVakti.Text || suan == lblAksamVakti.Text || suan == lblYatsıVakti.Text)
            {
                //timer'ı durdur.Timer durmazsa şöyle yapar;diyelim timer aralığı 5 saniye.5 saniye bekler sonra ezan 5 saniye okunur sonra 5 saniye bekler sonra ezan başa alınır ve 5 saniye okunur.böyle gider
                //timer' ı durdurursak burda ezan aralıksız okunur sonuna kadar
                timerSes.Stop();
                SoundPlayer sound = new SoundPlayer(AyarlarForm.secilenSes);//ses nesnesi oluşturuyorum.Parantez içine bu ses dosyasının yolunu yazıyorum.Bu yol Ayarlar formundan secilenses isimli değişken ile buraya geliyor.
                sound.Play();
            }
          
        }

        private void CmbSehirler_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            string sehir = cmbSehirler.SelectedItem.ToString();//seçilen şehri al
            string tarih = DateTime.Now.ToString("dd MMMM yyyy dddd ");//bugünün tarihini al.10 Aralık 2019 Salı formatıyla.d=day M=Month y=Year d=day.iki tane d günü sayısal olarak 4 tane ise yazıyla veriyor aynı şey ay içinde geçerli

            for (int i = 0; i < 80; i++)//combobox'ı dolaşsın tek tek
            {
                if (cmbSehirler.SelectedIndex == i)//seçien index'i yani şehri bulsun
                {

                    SqlCommand com = new SqlCommand("Select * from SehirVakit Where Sehir=@p1 and Tarih=@p2", baglan);//veritabanından seçilen şehir adı ve tarihi şu olanı görnek istiyorum
                    com.Parameters.AddWithValue("@p1", sehir);//hangi şehir ve tarih olduğunu değişkenlerle burada belirttik
                    com.Parameters.AddWithValue("@p2", tarih);

                    SqlDataReader dr = com.ExecuteReader();//veritabınını oku

                    while (dr.Read())//okurken şunları yap
                    {
                        //veritabanındaki değerleri labellara bas.


                        
                        
                        lblImsakVakti.Text = dr["Imsak"].ToString();
                        lblGunesVakti.Text = dr["Gunes"].ToString();
                        lblOgleVakti.Text = dr["Ogle"].ToString();
                        lblIkindiVakti.Text = dr["Ikindi"].ToString();
                        lblAksamVakti.Text = dr["Aksam"].ToString();
                        lblYatsıVakti.Text = dr["Yatsı"].ToString();



                    }
                    dr.Close();
                }
            }
            
        }

       

        private void PicKible_Click(object sender, EventArgs e)
        {
            //butona tıklandığında kıble formunu aç
            KibleForm f = new KibleForm();
            FormAc(f);//formac fonksiyonunu çağırdım.Tekrar eden kodlar olduğu için onu yukarda fonksiyona almıştım.
            //ancak bana bunu için bir form nesnesi gerekiyor form nesnesini burada oluşturup fonksiyonun içine atıyorum.Form nesnesi oluşturmayı neden fonksiyon içinde yapmadım çünkü forma göre değişir.Kıble için Kıbleform yazarsın Ayarlar için Ayarlarform yazarsın aşağıda göreceksin zaten 
        }

        private void PicOnemliGun_Click(object sender, EventArgs e)
        {
            OnemliGunlerForm f = new OnemliGunlerForm();
            FormAc(f);
        }

        private void PicHatirlatici_Click(object sender, EventArgs e)
        {
            HatirlaticiForm f = new HatirlaticiForm();
            FormAc(f);
        }

        private void PicAyarlar_Click(object sender, EventArgs e)
        {
            AyarlarForm f = new AyarlarForm();
            FormAc(f);
        }

        private void PicKible_MouseEnter(object sender, EventArgs e)
        {
           
        }

        private void PicKible_MouseMove(object sender, MouseEventArgs e)
        {
            picKible.BackColor = Color.Red;
        }





        //siteden veri çekmesi için bir buton koymuştum  işim bittiği için o butonu kaldırdım.

        //url="https://namazvakitleri.diyanet.gov.tr/tr-TR/9146/adana-icin-namaz-vakti" veri çekeceğim url'i siteden kopyalayıp string değişkene atıyorum.Bu sadece Adanın verilerini almak için her şehrin kendi verisi için kendi linkini siteden kopyalayıp attım buraya sırayla
        //        WebClient webclient = new WebClient();
        //        webclient.Encoding = Encoding.UTF8;

        //            ServicePointManager.Expect100Continue = true;
        //            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
        // buraya kadar internetten baktığıma göre güvenli bağlantı ile ilgili kodlar yazıyor

        //            string adres = webclient.DownloadString(url); yukarda tanımladığım url'i adres adında bir değişkene attım.Güvenlik açısında webclient demen gerekiyor burada.
       
        //List<string> Nvakitler=new List<string>();
        //List<string> Sehirler=new List<string>();

        //        HtmlAgilityPack.HtmlDocument document = new HtmlAgilityPack.HtmlDocument();
        //document adında htmlagilitypack nesnesi oluşturdu.Siteden veri çekmek için htmlagilitypack kullanılır

        //        document.LoadHtml(adres); yukarda adres değişkeninin içinde linkim var onu bu document nesnesi at diyorum.Böylelikle bu nesne hangi siteye hangi linke gideceğini biliyor.

        //            for(int isim = 1; isim <= 81; isim++)
        //            {
        //               aşağıda parantez içine yazdığım şey sitede şehir isimlerinin yazılı olduğu html etiketinin adresi.Buna Xpath deniliyor.81 şehir olduğu için döngü sırayla bu html etiketlerine gitsin ve şehir isimlerini alsın dedim
        //                string sehirismi = document.DocumentNode.SelectSingleNode("//*[@id='state-select-col']/div/select/option[" + isim + "]").InnerText;
        //        Sehirler.Add(sehirismi); alınan iaimleri Sehirler adındaki list'e at
        //            }


        //    HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();//siteye ulaşmak bir HtmlAgilityPack nesnesi oluşturuyoruz
        //    doc.LoadHtml(adres);//oluşturduğumuz nesneye url atıyoruz.Bu url yukarda tanımladığımız sitenin adresi.Yani hangi siteye gideceğini söylüyoruz.

        //           for(int dön = 1; dön <=30; dön++)//30 gün var onun için 30 kere dön
        //            {

        //                for(int döngü = 1; döngü <= 7; döngü++)//toplam 6 veri var her gün için.Tarih,İmsak,Güneş,Öğle,İkindi,Akşam,Yatsı.Onları dön
        //                {

        //                    string vakitler = doc.DocumentNode.SelectSingleNode("//*[@id='tab-1']/div/table/tbody/tr[" + dön + "]/td[" + döngü + "]").InnerText; bu verilerin olduğu Xpath'i yazdım paranteze.Oraya gidip sırayla bunları alıyor.
        //                    Nvakitler.Add(vakitler); aldığı değerleri Nvakitler adındaki list'e atıyor.
        //                    vakitler = string.Empty; daha sonra vakitler değişkenini boşaltıyorum.Bir sonraki veri geldiğinde sıkıntı olmasın
        //                }

        //            }



        //            for(int veri = 0; veri <=Nvakitler.Count-1; veri=veri+7) Nvakitler list'inin içini dolaş.7-7 arttırdım açıklayacağım
        //            {

        //                SqlCommand kaydet = new SqlCommand("Insert into SehirVakit(Sehir,Tarih,Imsak,Gunes,Ogle,Ikindi,Aksam,Yatsı) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", baglan); şu değerlere aşağıdaki verileri eklemek istiyorum dedim

        //                kaydet.Parameters.AddWithValue("@p1", "Zonguldak"); burada şehrin ismini yazdım.Sıra sıra her şehir için yaptım bunu
        //                kaydet.Parameters.AddWithValue("@p2", Nvakitler[veri]); list'in içindeki ilk veriyi yani tarihi veritabanına at
        //                kaydet.Parameters.AddWithValue("@p3", Nvakitler[veri + 1]); list'in içindeki ikinci veriyi yani imsak vaktini at.Böyle gidiyor.
        //                kaydet.Parameters.AddWithValue("@p4", Nvakitler[veri + 2]);
        //                kaydet.Parameters.AddWithValue("@p5", Nvakitler[veri + 3]);
        //                kaydet.Parameters.AddWithValue("@p6", Nvakitler[veri + 4]);
        //                kaydet.Parameters.AddWithValue("@p7", Nvakitler[veri + 5]);
        //                kaydet.Parameters.AddWithValue("@p8", Nvakitler[veri + 6]);
        //                kaydet.ExecuteNonQuery();
        //        
        //                bir gün bütün vakitleri atıyorum sonra döngü diğer güne geçiyor.Yani ilk günü değerleri döngünün ilk 7 indeksinde sonraki günün değerleri sonraki 7 indekdte yer alıyor.Onun için döngüyü 7-7 arttırdım
        //            }

    }
}
