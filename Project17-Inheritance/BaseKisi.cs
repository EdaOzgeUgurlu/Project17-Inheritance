using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project17_Inheritance
{
    // Temel sınıf: Bir kişiyi temsil eder
    public class BaseKisi
    {
        // Ad ve soyad için özellikler
        public string Ad { get; set; }
        public string Soyad { get; set; }

        // Ad ve soyadı ekrana yazdıran sanal metot
        public virtual void BilgiYazdir()
        {
            Console.WriteLine($"Ad: {Ad}, Soyad: {Soyad}");
        }
    }

    // Öğrenci için türetilmiş sınıf
    public class Ogrenci : BaseKisi
    {
        // Öğrenci numarası için özellik
        public int OgrenciNo { get; set; }

        // Öğrenci bilgilerini ekrana yazdıran metot
        public void OgrenciBilgileriYazdir()
        {
            Console.WriteLine($"Öğrenci No: {OgrenciNo}, {Ad} {Soyad}");
        }
    }

    // Öğretmen için türetilmiş sınıf
    public class Ogretmen : BaseKisi
    {
        // Maaş bilgisi için özellik
        public decimal Maas { get; set; }

        // Öğretmen bilgilerini ekrana yazdıran metot
        public void OgretmenBilgileriYazdir()
        {
            Console.WriteLine($"Maaş: {Maas} TL, {Ad} {Soyad}");
        }
    }
}

