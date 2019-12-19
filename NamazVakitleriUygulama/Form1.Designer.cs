namespace NamazVakitleriUygulama
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.arkaplan = new System.Windows.Forms.PictureBox();
            this.lblNamazVakitleri = new System.Windows.Forms.Label();
            this.cmbSehirler = new System.Windows.Forms.ComboBox();
            this.lblImsak = new System.Windows.Forms.Label();
            this.lblImsakVakti = new System.Windows.Forms.Label();
            this.lblGunesVakti = new System.Windows.Forms.Label();
            this.lblGunes = new System.Windows.Forms.Label();
            this.lblOgleVakti = new System.Windows.Forms.Label();
            this.lblOgle = new System.Windows.Forms.Label();
            this.lblIkindiVakti = new System.Windows.Forms.Label();
            this.lblIkindi = new System.Windows.Forms.Label();
            this.lblAksamVakti = new System.Windows.Forms.Label();
            this.lblAksam = new System.Windows.Forms.Label();
            this.lblYatsıVakti = new System.Windows.Forms.Label();
            this.lblYatsı = new System.Windows.Forms.Label();
            this.lblBugun2 = new System.Windows.Forms.Label();
            this.lblBugun = new System.Windows.Forms.Label();
            this.lblKalanSaatGoster = new System.Windows.Forms.Label();
            this.lblKalanSaat = new System.Windows.Forms.Label();
            this.lblHadis = new System.Windows.Forms.Label();
            this.timerSaat = new System.Windows.Forms.Timer(this.components);
            this.timerHadis = new System.Windows.Forms.Timer(this.components);
            this.timerKalanVakit = new System.Windows.Forms.Timer(this.components);
            this.timerSes = new System.Windows.Forms.Timer(this.components);
            this.picHatirlatici = new System.Windows.Forms.PictureBox();
            this.picAyarlar = new System.Windows.Forms.PictureBox();
            this.picOnemliGun = new System.Windows.Forms.PictureBox();
            this.picKible = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.arkaplan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHatirlatici)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAyarlar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOnemliGun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picKible)).BeginInit();
            this.SuspendLayout();
            // 
            // arkaplan
            // 
            this.arkaplan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.arkaplan.Image = ((System.Drawing.Image)(resources.GetObject("arkaplan.Image")));
            this.arkaplan.Location = new System.Drawing.Point(0, 0);
            this.arkaplan.Name = "arkaplan";
            this.arkaplan.Size = new System.Drawing.Size(911, 752);
            this.arkaplan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.arkaplan.TabIndex = 0;
            this.arkaplan.TabStop = false;
            // 
            // lblNamazVakitleri
            // 
            this.lblNamazVakitleri.Font = new System.Drawing.Font("Monotype Corsiva", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNamazVakitleri.ForeColor = System.Drawing.Color.White;
            this.lblNamazVakitleri.Location = new System.Drawing.Point(274, 9);
            this.lblNamazVakitleri.Name = "lblNamazVakitleri";
            this.lblNamazVakitleri.Size = new System.Drawing.Size(318, 61);
            this.lblNamazVakitleri.TabIndex = 1;
            this.lblNamazVakitleri.Text = "Namaz Vakitleri";
            this.lblNamazVakitleri.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbSehirler
            // 
            this.cmbSehirler.FormattingEnabled = true;
            this.cmbSehirler.Location = new System.Drawing.Point(175, 112);
            this.cmbSehirler.Name = "cmbSehirler";
            this.cmbSehirler.Size = new System.Drawing.Size(515, 28);
            this.cmbSehirler.TabIndex = 2;
            this.cmbSehirler.SelectedIndexChanged += new System.EventHandler(this.CmbSehirler_SelectedIndexChanged);
            // 
            // lblImsak
            // 
            this.lblImsak.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblImsak.Font = new System.Drawing.Font("Monotype Corsiva", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblImsak.ForeColor = System.Drawing.Color.White;
            this.lblImsak.Location = new System.Drawing.Point(69, 174);
            this.lblImsak.Name = "lblImsak";
            this.lblImsak.Size = new System.Drawing.Size(136, 40);
            this.lblImsak.TabIndex = 3;
            this.lblImsak.Text = "İmsak";
            this.lblImsak.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblImsakVakti
            // 
            this.lblImsakVakti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblImsakVakti.Location = new System.Drawing.Point(69, 214);
            this.lblImsakVakti.Name = "lblImsakVakti";
            this.lblImsakVakti.Size = new System.Drawing.Size(136, 100);
            this.lblImsakVakti.TabIndex = 4;
            this.lblImsakVakti.Text = "label2";
            this.lblImsakVakti.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGunesVakti
            // 
            this.lblGunesVakti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGunesVakti.Location = new System.Drawing.Point(278, 214);
            this.lblGunesVakti.Name = "lblGunesVakti";
            this.lblGunesVakti.Size = new System.Drawing.Size(136, 100);
            this.lblGunesVakti.TabIndex = 6;
            this.lblGunesVakti.Text = "label3";
            this.lblGunesVakti.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGunes
            // 
            this.lblGunes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGunes.Font = new System.Drawing.Font("Monotype Corsiva", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGunes.ForeColor = System.Drawing.Color.White;
            this.lblGunes.Location = new System.Drawing.Point(278, 174);
            this.lblGunes.Name = "lblGunes";
            this.lblGunes.Size = new System.Drawing.Size(136, 40);
            this.lblGunes.TabIndex = 5;
            this.lblGunes.Text = "Güneş";
            this.lblGunes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOgleVakti
            // 
            this.lblOgleVakti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOgleVakti.Location = new System.Drawing.Point(69, 379);
            this.lblOgleVakti.Name = "lblOgleVakti";
            this.lblOgleVakti.Size = new System.Drawing.Size(136, 100);
            this.lblOgleVakti.TabIndex = 8;
            this.lblOgleVakti.Text = "label5";
            this.lblOgleVakti.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOgle
            // 
            this.lblOgle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOgle.Font = new System.Drawing.Font("Monotype Corsiva", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOgle.ForeColor = System.Drawing.Color.White;
            this.lblOgle.Location = new System.Drawing.Point(69, 339);
            this.lblOgle.Name = "lblOgle";
            this.lblOgle.Size = new System.Drawing.Size(136, 40);
            this.lblOgle.TabIndex = 7;
            this.lblOgle.Text = "Öğle";
            this.lblOgle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIkindiVakti
            // 
            this.lblIkindiVakti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIkindiVakti.Location = new System.Drawing.Point(278, 379);
            this.lblIkindiVakti.Name = "lblIkindiVakti";
            this.lblIkindiVakti.Size = new System.Drawing.Size(136, 100);
            this.lblIkindiVakti.TabIndex = 10;
            this.lblIkindiVakti.Text = "label7";
            this.lblIkindiVakti.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIkindi
            // 
            this.lblIkindi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblIkindi.Font = new System.Drawing.Font("Monotype Corsiva", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIkindi.ForeColor = System.Drawing.Color.White;
            this.lblIkindi.Location = new System.Drawing.Point(278, 339);
            this.lblIkindi.Name = "lblIkindi";
            this.lblIkindi.Size = new System.Drawing.Size(136, 40);
            this.lblIkindi.TabIndex = 9;
            this.lblIkindi.Text = "İkindi";
            this.lblIkindi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAksamVakti
            // 
            this.lblAksamVakti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAksamVakti.Location = new System.Drawing.Point(69, 554);
            this.lblAksamVakti.Name = "lblAksamVakti";
            this.lblAksamVakti.Size = new System.Drawing.Size(136, 100);
            this.lblAksamVakti.TabIndex = 12;
            this.lblAksamVakti.Text = "label9";
            this.lblAksamVakti.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAksam
            // 
            this.lblAksam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAksam.Font = new System.Drawing.Font("Monotype Corsiva", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAksam.ForeColor = System.Drawing.Color.White;
            this.lblAksam.Location = new System.Drawing.Point(69, 514);
            this.lblAksam.Name = "lblAksam";
            this.lblAksam.Size = new System.Drawing.Size(136, 40);
            this.lblAksam.TabIndex = 11;
            this.lblAksam.Text = "Akşam";
            this.lblAksam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblYatsıVakti
            // 
            this.lblYatsıVakti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYatsıVakti.Location = new System.Drawing.Point(278, 554);
            this.lblYatsıVakti.Name = "lblYatsıVakti";
            this.lblYatsıVakti.Size = new System.Drawing.Size(136, 100);
            this.lblYatsıVakti.TabIndex = 14;
            this.lblYatsıVakti.Text = "label11";
            this.lblYatsıVakti.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblYatsı
            // 
            this.lblYatsı.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblYatsı.Font = new System.Drawing.Font("Monotype Corsiva", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYatsı.ForeColor = System.Drawing.Color.White;
            this.lblYatsı.Location = new System.Drawing.Point(278, 514);
            this.lblYatsı.Name = "lblYatsı";
            this.lblYatsı.Size = new System.Drawing.Size(136, 40);
            this.lblYatsı.TabIndex = 13;
            this.lblYatsı.Text = "Yatsı";
            this.lblYatsı.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBugun2
            // 
            this.lblBugun2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBugun2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBugun2.ForeColor = System.Drawing.Color.White;
            this.lblBugun2.Location = new System.Drawing.Point(510, 242);
            this.lblBugun2.Name = "lblBugun2";
            this.lblBugun2.Size = new System.Drawing.Size(238, 128);
            this.lblBugun2.TabIndex = 16;
            this.lblBugun2.Text = "label13";
            this.lblBugun2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBugun
            // 
            this.lblBugun.BackColor = System.Drawing.Color.White;
            this.lblBugun.Location = new System.Drawing.Point(510, 174);
            this.lblBugun.Name = "lblBugun";
            this.lblBugun.Size = new System.Drawing.Size(238, 68);
            this.lblBugun.TabIndex = 15;
            this.lblBugun.Text = "label14";
            this.lblBugun.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblKalanSaatGoster
            // 
            this.lblKalanSaatGoster.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblKalanSaatGoster.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKalanSaatGoster.ForeColor = System.Drawing.Color.White;
            this.lblKalanSaatGoster.Location = new System.Drawing.Point(510, 520);
            this.lblKalanSaatGoster.Name = "lblKalanSaatGoster";
            this.lblKalanSaatGoster.Size = new System.Drawing.Size(238, 128);
            this.lblKalanSaatGoster.TabIndex = 18;
            this.lblKalanSaatGoster.Text = "label15";
            this.lblKalanSaatGoster.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblKalanSaat
            // 
            this.lblKalanSaat.BackColor = System.Drawing.Color.White;
            this.lblKalanSaat.Location = new System.Drawing.Point(510, 452);
            this.lblKalanSaat.Name = "lblKalanSaat";
            this.lblKalanSaat.Size = new System.Drawing.Size(238, 68);
            this.lblKalanSaat.TabIndex = 17;
            this.lblKalanSaat.Text = "label16";
            this.lblKalanSaat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHadis
            // 
            this.lblHadis.ForeColor = System.Drawing.Color.White;
            this.lblHadis.Location = new System.Drawing.Point(190, 670);
            this.lblHadis.Name = "lblHadis";
            this.lblHadis.Size = new System.Drawing.Size(467, 29);
            this.lblHadis.TabIndex = 19;
            this.lblHadis.Text = "label17";
            this.lblHadis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerSaat
            // 
            this.timerSaat.Tick += new System.EventHandler(this.TimerSaat_Tick);
            // 
            // timerHadis
            // 
            this.timerHadis.Tick += new System.EventHandler(this.TimerHadis_Tick);
            // 
            // timerKalanVakit
            // 
            this.timerKalanVakit.Tick += new System.EventHandler(this.TimerKalanVakit_Tick);
            // 
            // timerSes
            // 
            this.timerSes.Enabled = true;
            this.timerSes.Interval = 2000;
            this.timerSes.Tick += new System.EventHandler(this.TimerSes_Tick);
            // 
            // picHatirlatici
            // 
            this.picHatirlatici.Image = ((System.Drawing.Image)(resources.GetObject("picHatirlatici.Image")));
            this.picHatirlatici.Location = new System.Drawing.Point(799, 438);
            this.picHatirlatici.Name = "picHatirlatici";
            this.picHatirlatici.Size = new System.Drawing.Size(106, 71);
            this.picHatirlatici.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHatirlatici.TabIndex = 24;
            this.picHatirlatici.TabStop = false;
            this.picHatirlatici.Click += new System.EventHandler(this.PicHatirlatici_Click);
            // 
            // picAyarlar
            // 
            this.picAyarlar.Image = ((System.Drawing.Image)(resources.GetObject("picAyarlar.Image")));
            this.picAyarlar.Location = new System.Drawing.Point(799, 530);
            this.picAyarlar.Name = "picAyarlar";
            this.picAyarlar.Size = new System.Drawing.Size(106, 71);
            this.picAyarlar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAyarlar.TabIndex = 25;
            this.picAyarlar.TabStop = false;
            this.picAyarlar.Click += new System.EventHandler(this.PicAyarlar_Click);
            // 
            // picOnemliGun
            // 
            this.picOnemliGun.Image = ((System.Drawing.Image)(resources.GetObject("picOnemliGun.Image")));
            this.picOnemliGun.Location = new System.Drawing.Point(799, 350);
            this.picOnemliGun.Name = "picOnemliGun";
            this.picOnemliGun.Size = new System.Drawing.Size(106, 71);
            this.picOnemliGun.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picOnemliGun.TabIndex = 26;
            this.picOnemliGun.TabStop = false;
            this.picOnemliGun.Click += new System.EventHandler(this.PicOnemliGun_Click);
            // 
            // picKible
            // 
            this.picKible.Image = ((System.Drawing.Image)(resources.GetObject("picKible.Image")));
            this.picKible.Location = new System.Drawing.Point(799, 264);
            this.picKible.Name = "picKible";
            this.picKible.Size = new System.Drawing.Size(106, 71);
            this.picKible.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picKible.TabIndex = 27;
            this.picKible.TabStop = false;
            this.picKible.Click += new System.EventHandler(this.PicKible_Click);
            this.picKible.MouseEnter += new System.EventHandler(this.PicKible_MouseEnter);
            this.picKible.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PicKible_MouseMove);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 752);
            this.Controls.Add(this.picKible);
            this.Controls.Add(this.picOnemliGun);
            this.Controls.Add(this.picAyarlar);
            this.Controls.Add(this.picHatirlatici);
            this.Controls.Add(this.lblHadis);
            this.Controls.Add(this.lblKalanSaatGoster);
            this.Controls.Add(this.lblKalanSaat);
            this.Controls.Add(this.lblBugun2);
            this.Controls.Add(this.lblBugun);
            this.Controls.Add(this.lblYatsıVakti);
            this.Controls.Add(this.lblYatsı);
            this.Controls.Add(this.lblAksamVakti);
            this.Controls.Add(this.lblAksam);
            this.Controls.Add(this.lblIkindiVakti);
            this.Controls.Add(this.lblIkindi);
            this.Controls.Add(this.lblOgleVakti);
            this.Controls.Add(this.lblOgle);
            this.Controls.Add(this.lblGunesVakti);
            this.Controls.Add(this.lblGunes);
            this.Controls.Add(this.lblImsakVakti);
            this.Controls.Add(this.lblImsak);
            this.Controls.Add(this.cmbSehirler);
            this.Controls.Add(this.lblNamazVakitleri);
            this.Controls.Add(this.arkaplan);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.arkaplan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHatirlatici)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAyarlar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOnemliGun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picKible)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox arkaplan;
        private System.Windows.Forms.Label lblNamazVakitleri;
        private System.Windows.Forms.ComboBox cmbSehirler;
        private System.Windows.Forms.Label lblImsak;
        private System.Windows.Forms.Label lblImsakVakti;
        private System.Windows.Forms.Label lblGunesVakti;
        private System.Windows.Forms.Label lblGunes;
        private System.Windows.Forms.Label lblOgleVakti;
        private System.Windows.Forms.Label lblOgle;
        private System.Windows.Forms.Label lblIkindiVakti;
        private System.Windows.Forms.Label lblIkindi;
        private System.Windows.Forms.Label lblAksamVakti;
        private System.Windows.Forms.Label lblAksam;
        private System.Windows.Forms.Label lblYatsıVakti;
        private System.Windows.Forms.Label lblYatsı;
        private System.Windows.Forms.Label lblBugun2;
        private System.Windows.Forms.Label lblBugun;
        private System.Windows.Forms.Label lblKalanSaatGoster;
        private System.Windows.Forms.Label lblKalanSaat;
        private System.Windows.Forms.Label lblHadis;
        private System.Windows.Forms.Timer timerSaat;
        private System.Windows.Forms.Timer timerHadis;
        private System.Windows.Forms.Timer timerKalanVakit;
        private System.Windows.Forms.Timer timerSes;
        private System.Windows.Forms.PictureBox picHatirlatici;
        private System.Windows.Forms.PictureBox picAyarlar;
        private System.Windows.Forms.PictureBox picOnemliGun;
        private System.Windows.Forms.PictureBox picKible;
    }
}

