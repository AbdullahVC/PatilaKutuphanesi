using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatilaKutuphanesi
{
    public class Kitap
    {
        // Özellikler (Properties)
        private string _ad;
        private string _yazarAdi;
        private string _yazarSoyadi;
        private int _sayfaSayisi;
        private string _yayinevi;
        private DateTime _kayitTarihi;

        // Default constructor
        public Kitap()
        {
            _kayitTarihi = DateTime.Now; // Kayıt tarihi otomatik olarak atanıyor
        }

        // Parametre alan constructor
        public Kitap(string ad, string yazarAdi, string yazarSoyadi, int sayfaSayisi, string yayinevi)
        {
            _ad = ad;
            _yazarAdi = yazarAdi;
            _yazarSoyadi = yazarSoyadi;
            _sayfaSayisi = sayfaSayisi;
            _yayinevi = yayinevi;
            _kayitTarihi = DateTime.Now;
        }


        public string Ad
        {
            get { return _ad; }
            set { _ad = value; }
        }

        public string YazarAdi
        {
            get { return _yazarAdi; }
            set { _yazarAdi = value; }
        }

        public string YazarSoyadi
        {
            get { return _yazarSoyadi; }
            set { _yazarSoyadi = value; }
        }

        public int SayfaSayisi
        {
            get { return _sayfaSayisi; }
            set { _sayfaSayisi = value; }
        }

        public string Yayinevi
        {
            get { return _yayinevi; }
            set { _yayinevi = value; }
        }

        public DateTime KayitTarihi
        {
            get { return _kayitTarihi; }
        }

    }
}