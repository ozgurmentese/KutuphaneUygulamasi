using Kutuphane.Business.Abstract;
using Kutuphane.Business.DependencyResolvers.Ninject;
using Kutuphane.Entities.Entities.Concrete;
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
    public partial class Ogrenciler : System.Windows.Forms.Form
    {
        public Ogrenciler()
        {
            InitializeComponent();
        }
        IOgrenciServis _ogrenciServis = InstanceFactory.GetInstance<IOgrenciServis>();
        private void Ogrenciler_Load(object sender, EventArgs e)
        {
            OgrenciListele();
        }
        private void OgrenciListele()
        {
            dgwOgrenciler.DataSource = _ogrenciServis.GetAll();
        }

        private void TabloBirlestirme()
        {
            dgwOgrenciler.DataSource = _ogrenciServis.OgrenciAdSoyadKitapGetir();
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                _ogrenciServis.Add(new Ogrenci
                {
                    Adi = tbxAdi.Text,
                    Soyadi = tbxSoyadi.Text,
                    Cinsiyet = tbxCinsiyet.Text,
                    DogumTarihi = dateTimeDogumTarihi.Value,
                    Sinif = tbxSinif.Text
                });
                OgrenciListele();
                MessageBox.Show("Öğrenci Eklendi");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnOgrenciSil_Click(object sender, EventArgs e)
        {
            var satir = dgwOgrenciler.CurrentRow;
            if (satir != null)
            {
                try
                {
                    _ogrenciServis.Delete(
                        new Ogrenci
                        {
                            Numarasi = Convert.ToInt32(satir.Cells[0].Value)
                        });
                    OgrenciListele();
                    MessageBox.Show("Öğrenci Silindi!");
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void tbxOgrenciArama_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxOgrenciArama.Text))
                OgrenciListele();
            else
            {
                dgwOgrenciler.DataSource = _ogrenciServis.OgrenciGetir(tbxOgrenciArama.Text);
            }
        }

        private void dgwOgrenciler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row= dgwOgrenciler.CurrentRow;
            tbxAdi.Text = row.Cells[1].Value.ToString();
            tbxSoyadi.Text = row.Cells[2].Value.ToString();
            tbxCinsiyet.Text = row.Cells[3].Value.ToString();
            dateTimeDogumTarihi.Text = row.Cells[4].Value.ToString();
            tbxSinif.Text = row.Cells[5].Value.ToString();
        }

        private void btnOgrenciGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                _ogrenciServis.Update(new Ogrenci
                {
                    Numarasi=Convert.ToInt32(dgwOgrenciler.CurrentRow.Cells[0].Value),
                    Adi = tbxAdi.Text,
                    Soyadi = tbxSoyadi.Text,
                    Cinsiyet = tbxCinsiyet.Text,
                    DogumTarihi = dateTimeDogumTarihi.Value,
                    Sinif = tbxSinif.Text

                });
                OgrenciListele();
                MessageBox.Show("Öğrenci Güncellendi");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
