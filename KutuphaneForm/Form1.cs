using Kutuphane.Business.Abstract;
using Kutuphane.Business.Concrete;
using Kutuphane.Business.DependencyResolvers.Ninject;
using Kutuphane.DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneForm
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }
        //IIslemServis _islemServis = InstanceFactory.GetInstance<IIslemServis>();
        IOgrenciServis _ogrenciServis = InstanceFactory.GetInstance<IOgrenciServis>();
        private void Form1_Load(object sender, EventArgs e)
        {
            dgwDoldur();

        }
        private void dgwDoldur()
        {
            dgwIslemler.DataSource = _ogrenciServis.OgrenciAdSoyadKitapGetir();
        }

        private void tbnKitapAlis_Click(object sender, EventArgs e)
        {
            Kitaplar kitaplar = new Kitaplar();
            kitaplar.ShowDialog();
        }

        private void btnOgrenciEkle_Click(object sender, EventArgs e)
        {
            Ogrenciler ogrenciler = new Ogrenciler();
            ogrenciler.ShowDialog();
        }

        private void tbxOgrenciArama_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxOgrenciArama.Text))
                dgwDoldur();
            else
            {
                dgwIslemler.DataSource = _ogrenciServis.OgrenciGetir(tbxOgrenciArama.Text);
            }
        }
    }
}
