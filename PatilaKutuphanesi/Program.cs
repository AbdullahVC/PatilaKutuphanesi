using System.Diagnostics.Metrics;
using System.Numerics;
using System;

namespace PatilaKutuphanesi
{    
public static class Program
    {
        public static void Main(string[] args)
        {
            // Default constructor kullanımı
            Kitap kitap1 = new Kitap();
            kitap1.Ad = "Adı Aylin";
            kitap1.YazarAdi = "Ayşe";
            kitap1.YazarSoyadi = "Kulin";
            kitap1.SayfaSayisi = 398;
            kitap1.Yayinevi = "Remzi Kitabevi";

            // Parametreli constructor kullanımı
            Kitap kitap2 = new Kitap("Adı Aylin", "Ayşe", "Kulin", 398, "Remzi Kitabevi");

            Console.WriteLine("Kitap 1 Adı: " + kitap1.Ad);
            Console.WriteLine("Kitap 1 Kayıt Tarihi: " + kitap1.KayitTarihi);

            Console.WriteLine("Kitap 2 Adı: " + kitap2.Ad);
            Console.WriteLine("Kitap 2 Kayıt Tarihi: " + kitap2.KayitTarihi);

//Namespace: PatikaKutuphanesi adında bir isim alanı tanımlayarak kodunuzu düzenli hale getiriyoruz.
//Class(Sınıf): Kitap sınıfı, kitap bilgilerini tutmak için kullanılır.
//Property(Özellik): Ad, YazarAdi, YazarSoyadi, SayfaSayisi, Yayinevi, ve KayitTarihi gibi özellikler, kitabın niteliklerini saklar.
//Constructor(Kurucu Metot): Kitap() parametresiz constructor, ve Kitap(string ad, string yazarAdi, string yazarSoyadi, int sayfaSayisi, string yayinevi) parametreli constructor, nesne oluşturulurken başlatma işlemlerini yapar.
        }
    }
}