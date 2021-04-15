
namespace KutuphaneForm
{
    partial class Form
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
            this.dgwIslemler = new System.Windows.Forms.DataGridView();
            this.tbxOgrenciArama = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOgrenciEkle = new System.Windows.Forms.Button();
            this.tbnKitapAlis = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwIslemler)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwIslemler
            // 
            this.dgwIslemler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwIslemler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwIslemler.Location = new System.Drawing.Point(12, 12);
            this.dgwIslemler.Name = "dgwIslemler";
            this.dgwIslemler.Size = new System.Drawing.Size(439, 205);
            this.dgwIslemler.TabIndex = 0;
            // 
            // tbxOgrenciArama
            // 
            this.tbxOgrenciArama.Location = new System.Drawing.Point(39, 277);
            this.tbxOgrenciArama.Name = "tbxOgrenciArama";
            this.tbxOgrenciArama.Size = new System.Drawing.Size(118, 20);
            this.tbxOgrenciArama.TabIndex = 2;
            this.tbxOgrenciArama.TextChanged += new System.EventHandler(this.tbxOgrenciArama_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Öğrenci Arama";
            // 
            // btnOgrenciEkle
            // 
            this.btnOgrenciEkle.Location = new System.Drawing.Point(39, 353);
            this.btnOgrenciEkle.Name = "btnOgrenciEkle";
            this.btnOgrenciEkle.Size = new System.Drawing.Size(95, 36);
            this.btnOgrenciEkle.TabIndex = 4;
            this.btnOgrenciEkle.Text = "Öğrenci Ekle";
            this.btnOgrenciEkle.UseVisualStyleBackColor = true;
            this.btnOgrenciEkle.Click += new System.EventHandler(this.btnOgrenciEkle_Click);
            // 
            // tbnKitapAlis
            // 
            this.tbnKitapAlis.Location = new System.Drawing.Point(187, 353);
            this.tbnKitapAlis.Name = "tbnKitapAlis";
            this.tbnKitapAlis.Size = new System.Drawing.Size(95, 36);
            this.tbnKitapAlis.TabIndex = 5;
            this.tbnKitapAlis.Text = "Kitaplar";
            this.tbnKitapAlis.UseVisualStyleBackColor = true;
            this.tbnKitapAlis.Click += new System.EventHandler(this.tbnKitapAlis_Click);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 400);
            this.Controls.Add(this.tbnKitapAlis);
            this.Controls.Add(this.btnOgrenciEkle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxOgrenciArama);
            this.Controls.Add(this.dgwIslemler);
            this.Name = "Form";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwIslemler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwIslemler;
        private System.Windows.Forms.TextBox tbxOgrenciArama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOgrenciEkle;
        private System.Windows.Forms.Button tbnKitapAlis;
    }
}

