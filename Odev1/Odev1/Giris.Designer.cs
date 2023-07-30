namespace Odev1
{
    partial class Giris
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
            this.LblKontrol = new System.Windows.Forms.Label();
            this.BtnCikis = new System.Windows.Forms.Button();
            this.BtnGiris = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtSifre = new System.Windows.Forms.TextBox();
            this.CbKullanici = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LblKontrol
            // 
            this.LblKontrol.AutoSize = true;
            this.LblKontrol.Location = new System.Drawing.Point(687, 475);
            this.LblKontrol.Name = "LblKontrol";
            this.LblKontrol.Size = new System.Drawing.Size(44, 16);
            this.LblKontrol.TabIndex = 19;
            this.LblKontrol.Text = "label4";
            this.LblKontrol.Visible = false;
            // 
            // BtnCikis
            // 
            this.BtnCikis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnCikis.Location = new System.Drawing.Point(779, 417);
            this.BtnCikis.Name = "BtnCikis";
            this.BtnCikis.Size = new System.Drawing.Size(88, 36);
            this.BtnCikis.TabIndex = 17;
            this.BtnCikis.Text = "Çıkış";
            this.BtnCikis.UseVisualStyleBackColor = true;
            this.BtnCikis.Click += new System.EventHandler(this.BtnCikis_Click);
            // 
            // BtnGiris
            // 
            this.BtnGiris.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnGiris.Location = new System.Drawing.Point(673, 417);
            this.BtnGiris.Name = "BtnGiris";
            this.BtnGiris.Size = new System.Drawing.Size(88, 36);
            this.BtnGiris.TabIndex = 16;
            this.BtnGiris.Text = "Giriş";
            this.BtnGiris.UseVisualStyleBackColor = true;
            this.BtnGiris.Click += new System.EventHandler(this.BtnGiris_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(309, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(358, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "TURHAN RESTORAN SİSTEMLERİ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(576, 371);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "Şifre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(576, 328);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Kullanıcı:";
            // 
            // TxtSifre
            // 
            this.TxtSifre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtSifre.Location = new System.Drawing.Point(673, 371);
            this.TxtSifre.Name = "TxtSifre";
            this.TxtSifre.Size = new System.Drawing.Size(194, 21);
            this.TxtSifre.TabIndex = 12;
            this.TxtSifre.UseSystemPasswordChar = true;
            // 
            // CbKullanici
            // 
            this.CbKullanici.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbKullanici.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CbKullanici.FormattingEnabled = true;
            this.CbKullanici.Location = new System.Drawing.Point(673, 328);
            this.CbKullanici.Name = "CbKullanici";
            this.CbKullanici.Size = new System.Drawing.Size(194, 30);
            this.CbKullanici.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Odev1.Properties.Resources.logomuz;
            this.pictureBox1.Location = new System.Drawing.Point(199, 107);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(638, 210);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // Giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1067, 570);
            this.Controls.Add(this.LblKontrol);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnCikis);
            this.Controls.Add(this.BtnGiris);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtSifre);
            this.Controls.Add(this.CbKullanici);
            this.Name = "Giris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel Giris Ekrani";
            this.Load += new System.EventHandler(this.Giris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblKontrol;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnCikis;
        private System.Windows.Forms.Button BtnGiris;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtSifre;
        private System.Windows.Forms.ComboBox CbKullanici;
    }
}