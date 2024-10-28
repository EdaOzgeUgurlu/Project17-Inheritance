// Ana program
using Project17_Inheritance;

public class Program
{
    static void Main(string[] args)
    {
        // Ogrenci (Öğrenci) nesnesi oluşturma
        Ogrenci ogrenci = new Ogrenci
        {
            Ad = "Yıldız",             // Öğrencinin adını ayarlama
            Soyad = "Tilbe",           // Öğrencinin soyadını ayarlama
            OgrenciNo = 12345         // Öğrenci numarasını ayarlama
        };

        // Ogretmen (Öğretmen) nesnesi oluşturma
        Ogretmen ogretmen = new Ogretmen
        {
            Ad = "Sezen",           // Öğretmenin adını ayarlama
            Soyad = "Aksu",         // Öğretmenin soyadını ayarlama
            Maas = 17002            // Öğretmenin maaşını ayarlama
        };

        // Öğrenci bilgilerini yazdırma
        ogrenci.OgrenciBilgileriYazdir();

        // Öğretmen bilgilerini yazdırma
        ogretmen.OgretmenBilgileriYazdir();
    }
}
