
namespace KutuphaneForm
{
    partial class Ogrenciler
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
            this.dgwOgrenciler = new System.Windows.Forms.DataGridView();
            this.tbxAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxSoyadi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxCinsiyet = new System.Windows.Forms.TextBox();
            this.tbxSinif = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimeDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnOgrenciGuncelle = new System.Windows.Forms.Button();
            this.btnOgrenciSil = new System.Windows.Forms.Button();
            this.tbxOgrenciArama = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwOgrenciler)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwOgrenciler
            // 
            this.dgwOgrenciler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwOgrenciler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwOgrenciler.Location = new System.Drawing.Point(12, 12);
            this.dgwOgrenciler.Name = "dgwOgrenciler";
            this.dgwOgrenciler.Size = new System.Drawing.Size(663, 193);
            this.dgwOgrenciler.TabIndex = 0;
            this.dgwOgrenciler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwOgrenciler_CellClick);
            // 
            // tbxAdi
            // 
            this.tbxAdi.Location = new System.Drawing.Point(70, 226);
            this.tbxAdi.Name = "tbxAdi";
            this.tbxAdi.Size = new System.Drawing.Size(100, 20);
            this.tbxAdi.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Adı";
            // 
            // tbxSoyadi
            // 
            this.tbxSoyadi.Location = new System.Drawing.Point(70, 285);
            this.tbxSoyadi.Name = "tbxSoyadi";
            this.tbxSoyadi.Size = new System.Drawing.Size(100, 20);
            this.tbxSoyadi.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 292);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Soy Adı";
            // 
            // tbxCinsiyet
            // 
            this.tbxCinsiyet.Location = new System.Drawing.Point(70, 338);
            this.tbxCinsiyet.Name = "tbxCinsiyet";
            this.tbxCinsiyet.Size = new System.Drawing.Size(100, 20);
            this.tbxCinsiyet.TabIndex = 1;
            // 
            // tbxSinif
            // 
            this.tbxSinif.Location = new System.Drawing.Point(70, 398);
            this.tbxSinif.Name = "tbxSinif";
            this.tbxSinif.Size = new System.Drawing.Size(100, 20);
            this.tbxSinif.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 345);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cinsiyet";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 401);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Sinif";
            // 
            // dateTimeDogumTarihi
            // 
            this.dateTimeDogumTarihi.Location = new System.Drawing.Point(231, 250);
            this.dateTimeDogumTarihi.Name = "dateTimeDogumTarihi";
            this.dateTimeDogumTarihi.Size = new System.Drawing.Size(200, 20);
            this.dateTimeDogumTarihi.TabIndex = 3;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(231, 323);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(126, 56);
            this.btnEkle.TabIndex = 4;
            this.btnEkle.Text = "Öğrenci Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnOgrenciGuncelle
            // 
            this.btnOgrenciGuncelle.Location = new System.Drawing.Point(387, 323);
            this.btnOgrenciGuncelle.Name = "btnOgrenciGuncelle";
            this.btnOgrenciGuncelle.Size = new System.Drawing.Size(111, 56);
            this.btnOgrenciGuncelle.TabIndex = 5;
            this.btnOgrenciGuncelle.Text = "Öğrenci Güncelle";
            this.btnOgrenciGuncelle.UseVisualStyleBackColor = true;
            this.btnOgrenciGuncelle.Click += new System.EventHandler(this.btnOgrenciGuncelle_Click);
            // 
            // btnOgrenciSil
            // 
            this.btnOgrenciSil.Location = new System.Drawing.Point(529, 323);
            this.btnOgrenciSil.Name = "btnOgrenciSil";
            this.btnOgrenciSil.Size = new System.Drawing.Size(111, 56);
            this.btnOgrenciSil.TabIndex = 5;
            this.btnOgrenciSil.Text = "Öğrenci Sil";
            this.btnOgrenciSil.UseVisualStyleBackColor = true;
            this.btnOgrenciSil.Click += new System.EventHandler(this.btnOgrenciSil_Click);
            // 
            // tbxOgrenciArama
            // 
            this.tbxOgrenciArama.Location = new System.Drawing.Point(574, 229);
            this.tbxOgrenciArama.Name = "tbxOgrenciArama";
            this.tbxOgrenciArama.Size = new System.Drawing.Size(100, 20);
            this.tbxOgrenciArama.TabIndex = 6;
            this.tbxOgrenciArama.TextChanged += new System.EventHandler(this.tbxOgrenciArama_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(491, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Öğrenci Arama";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(228, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Doğum Tarihi";
            // 
            // Ogrenciler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 444);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbxOgrenciArama);
            this.Controls.Add(this.btnOgrenciSil);
            this.Controls.Add(this.btnOgrenciGuncelle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.dateTimeDogumTarihi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxSinif);
            this.Controls.Add(this.tbxSoyadi);
            this.Controls.Add(this.tbxCinsiyet);
            this.Controls.Add(this.tbxAdi);
            this.Controls.Add(this.dgwOgrenciler);
            this.Name = "Ogrenciler";
            this.Text = "Ogrenciler";
            this.Load += new System.EventHandler(this.Ogrenciler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwOgrenciler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwOgrenciler;
        private System.Windows.Forms.TextBox tbxAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxSoyadi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxCinsiyet;
        private System.Windows.Forms.TextBox tbxSinif;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimeDogumTarihi;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnOgrenciGuncelle;
        private System.Windows.Forms.Button btnOgrenciSil;
        private System.Windows.Forms.TextBox tbxOgrenciArama;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}