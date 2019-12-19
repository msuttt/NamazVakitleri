namespace NamazVakitleriUygulama
{
    partial class Not
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateAciklama = new System.Windows.Forms.DateTimePicker();
            this.richtxtAciklama = new System.Windows.Forms.RichTextBox();
            this.btnNot = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tarih:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Açıklama:";
            // 
            // dateAciklama
            // 
            this.dateAciklama.Location = new System.Drawing.Point(185, 72);
            this.dateAciklama.Name = "dateAciklama";
            this.dateAciklama.Size = new System.Drawing.Size(200, 26);
            this.dateAciklama.TabIndex = 2;
            // 
            // richtxtAciklama
            // 
            this.richtxtAciklama.Location = new System.Drawing.Point(185, 144);
            this.richtxtAciklama.Name = "richtxtAciklama";
            this.richtxtAciklama.Size = new System.Drawing.Size(200, 111);
            this.richtxtAciklama.TabIndex = 3;
            this.richtxtAciklama.Text = "";
            // 
            // btnNot
            // 
            this.btnNot.Location = new System.Drawing.Point(236, 298);
            this.btnNot.Name = "btnNot";
            this.btnNot.Size = new System.Drawing.Size(77, 34);
            this.btnNot.TabIndex = 4;
            this.btnNot.Text = "Kaydet";
            this.btnNot.UseVisualStyleBackColor = true;
            this.btnNot.Click += new System.EventHandler(this.BtnNot_Click);
            // 
            // Not
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(539, 365);
            this.Controls.Add(this.btnNot);
            this.Controls.Add(this.richtxtAciklama);
            this.Controls.Add(this.dateAciklama);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Not";
            this.Text = "Not";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Not_FormClosed);
            this.Load += new System.EventHandler(this.Not_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateAciklama;
        private System.Windows.Forms.RichTextBox richtxtAciklama;
        private System.Windows.Forms.Button btnNot;
    }
}