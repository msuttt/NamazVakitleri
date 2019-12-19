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
    public partial class KibleForm : Form
    {
        public KibleForm()
        {
            InitializeComponent();
        }

        public void FormAc(Form f)
        {
            
            f.Show();
            this.Hide();
        }

        private void KibleForm_Load(object sender, EventArgs e)
        {
            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;

        }

        private void PicAnasayfa_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            FormAc(f);
        }

        private void PicAyarlar_Click(object sender, EventArgs e)
        {
            AyarlarForm f = new AyarlarForm();
            FormAc(f);
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
    }
}
