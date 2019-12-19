using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NamazVakitleriUygulama
{
    public partial class AyarlarForm : Form
    {
       
    public AyarlarForm()
        {
            InitializeComponent();
        }


        public void FormAc(Form f)
        {
            f.Show();
            this.Hide();
        }

        //static değişkenler ile bir formdan başka bir forma değer taşıyabiliyoruz
        public static Color renkAyarı;
        public static string secilenNesne; 

        public static string sesAyarı;
        public static string secilenSes;

        private void BtnRenk_Click(object sender, EventArgs e)
        {
            if (rdbtnLabel.Checked)//eğere rdbtnLabel seçili ise
            {
                secilenNesne = "Label";//secilenNesne adlı static değişkene "Label" yaz.Sonra mesela bu değişkeni anasayfaya yollayacağız.AyarlarForm.secilenNesne="Label" ise label rengini değiştir diyeceğiz
            }
            else if (rdbtnButon.Checked)//aynı şey buton için
            {
                secilenNesne = "Buton";
            }

            DialogResult tus;
            tus = colorDialog1.ShowDialog();//colordialog renk kataloğu çıkartıyor.Dialogresult nesnesi oluşturdum ve bu nesne renk kataloğunu göstersin dedim

               if (tus == DialogResult.OK)//eğer katalogda OK'a basıldıysa 
              {
                   renkAyarı = colorDialog1.Color;//burda secilen rengi renkAyarı adındaki static değişkene at.Daha sonra mesela anasayfaya gideceğiz ve şunu diyeceğiz. label1.BackColor=AyarlarForm.renkAyarı
              }
        }

        private void BtnSes_Click(object sender, EventArgs e)
        {
            //burda da seçilen sesleri alıyorum secilenSes değişkenine atıyorum
            if (rdbtnAyasofya.Checked)
            {             
                secilenSes = "Ayasofyada Ezan Sesi.wav";
            }
            if (rdbtnArap.Checked)
            {
                secilenSes = "Arap Hoca.wav";
            }
            if (rdbtnzil1.Checked)
            {
                secilenSes = "Dini zil sesi 1.wav";
            }
            if (rdbtnzil2.Checked)
            {
                secilenSes = "Dini zil sesi 4.wav";
            }

            MessageBox.Show("Ses seçiminiz alındı.Bir sonraki ezanda bu ses çalacak", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void AyarlarForm_Load(object sender, EventArgs e)
        {
            groupBox1.Parent = pictureBox1;
            groupBox1.BackColor = Color.Transparent;

            groupBox2.Parent = pictureBox1;
            groupBox2.BackColor = Color.Transparent;

            lblAyarlar.Parent = pictureBox1;
            lblAyarlar.BackColor = Color.Transparent;

            rdbtnAyasofya.Checked = true;//form ilk açıldığında bunlar seçili gelsin diyorum
            rdbtnLabel.Checked = true;
        }

      

        private void PicAnasayfa4_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            FormAc(f);
        }

        private void PicKible4_Click(object sender, EventArgs e)
        {
            KibleForm f = new KibleForm();
            FormAc(f);
        }

        private void PicOnemliGun4_Click(object sender, EventArgs e)
        {
            OnemliGunlerForm f = new OnemliGunlerForm();
            FormAc(f);
        }

        private void PicHatirlatici5_Click(object sender, EventArgs e)
        {
            HatirlaticiForm f = new HatirlaticiForm();
            FormAc(f);
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
