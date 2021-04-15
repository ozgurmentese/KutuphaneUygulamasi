using Kutuphane.Business.Abstract;
using Kutuphane.Business.DependencyResolvers.Ninject;
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
    public partial class Kitaplar : System.Windows.Forms.Form
    {
        public Kitaplar()
        {
            InitializeComponent();
        }
        IKitapServis _kitapServis = InstanceFactory.GetInstance<IKitapServis>();
        IYazarServis _yazarServis = InstanceFactory.GetInstance<IYazarServis>();
        ITurServis _turServis = InstanceFactory.GetInstance<ITurServis>();
        private void Kitaplar_Load(object sender, EventArgs e)
        {
            //dgwKitapLarDoldur();
            TabloGetir();
            cbxDoldur();
        }
        private void cbxDoldur()
        {
            cbxYazarlar.DataSource = _yazarServis.GetAll();
            cbxYazarlar.DisplayMember = "YazarAd";
            cbxYazarlar.ValueMember = "YazarNumarasi";

            cbxTurler.DataSource = _turServis.GetAll();
            cbxTurler.DisplayMember = "TurAdi";
            cbxTurler.ValueMember = "Id";
        }

        private void TabloGetir()
        {
            dgwKitaplar.DataSource = _kitapServis.KitapYazarTurGetir();
        }

        private void btnKitapEkle_Click(object sender, EventArgs e)
        {
           
        }

        private void cbxYazarlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dgwKitaplar.DataSource = _yazarServis.YazaraGoreGetir2(Convert.ToInt32(cbxYazarlar.SelectedValue));
            }
            catch{}
        }

        private void cbxTurler_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dgwKitaplar.DataSource = _turServis.TureGoreGetir2(Convert.ToInt32(cbxTurler.SelectedValue));
            }
            catch { }
        }
    }
}
