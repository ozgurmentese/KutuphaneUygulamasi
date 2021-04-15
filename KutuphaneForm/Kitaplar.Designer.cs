
namespace KutuphaneForm
{
    partial class Kitaplar
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
            this.dgwKitaplar = new System.Windows.Forms.DataGridView();
            this.cbxYazarlar = new System.Windows.Forms.ComboBox();
            this.cbxTurler = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwKitaplar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwKitaplar
            // 
            this.dgwKitaplar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwKitaplar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwKitaplar.Location = new System.Drawing.Point(3, 12);
            this.dgwKitaplar.Name = "dgwKitaplar";
            this.dgwKitaplar.Size = new System.Drawing.Size(503, 180);
            this.dgwKitaplar.TabIndex = 0;
            // 
            // cbxYazarlar
            // 
            this.cbxYazarlar.FormattingEnabled = true;
            this.cbxYazarlar.Location = new System.Drawing.Point(44, 231);
            this.cbxYazarlar.Name = "cbxYazarlar";
            this.cbxYazarlar.Size = new System.Drawing.Size(121, 21);
            this.cbxYazarlar.TabIndex = 1;
            this.cbxYazarlar.SelectedIndexChanged += new System.EventHandler(this.cbxYazarlar_SelectedIndexChanged);
            // 
            // cbxTurler
            // 
            this.cbxTurler.FormattingEnabled = true;
            this.cbxTurler.Location = new System.Drawing.Point(190, 231);
            this.cbxTurler.Name = "cbxTurler";
            this.cbxTurler.Size = new System.Drawing.Size(134, 21);
            this.cbxTurler.TabIndex = 1;
            this.cbxTurler.SelectedIndexChanged += new System.EventHandler(this.cbxTurler_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Yazarlar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(187, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Türler";
            // 
            // Kitaplar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 298);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxTurler);
            this.Controls.Add(this.cbxYazarlar);
            this.Controls.Add(this.dgwKitaplar);
            this.Name = "Kitaplar";
            this.Text = "Kitaplar";
            this.Load += new System.EventHandler(this.Kitaplar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwKitaplar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwKitaplar;
        private System.Windows.Forms.ComboBox cbxYazarlar;
        private System.Windows.Forms.ComboBox cbxTurler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}