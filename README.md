# Project17_Inheritance 🚀

Bu proje, C# dilinde nesne yönelimli programlama (OOP) prensiplerini kullanarak temel sınıf mirası (inheritance) örneğini göstermektedir. Projede bir temel sınıf (`BaseKisi`) ve bu sınıftan türetilmiş iki alt sınıf (`Ogrenci` ve `Ogretmen`) bulunmaktadır.

## İçindekiler 📚

- [Proje Hakkında](#proje-hakkında)
- [Nesne Yönelimli Programlama (OOP) Nedir?](#nesne-yönelimli-programlama-oop-nedir)
- [Kullanılan Teknolojiler](#kullanılan-teknolojiler)
- [Kurulum](#kurulum)
- [Kullanım](#kullanım)
- [Kod Yapısı](#kod-yapısı)
- [Sınıfların Detaylı Açıklamaları](#sınıfların-detaylı-açıklamaları)

## Proje Hakkında 📝

Bu proje, temel sınıfın nasıl oluşturulacağı, miras alınacağı ve alt sınıfların nasıl genişletileceği konularını içermektedir. `BaseKisi` sınıfı, temel kişisel bilgileri (ad ve soyad) tutmakta; `Ogrenci` sınıfı öğrenci bilgilerini, `Ogretmen` sınıfı ise öğretmen bilgilerini tutmaktadır.

## Nesne Yönelimli Programlama (OOP) Nedir? 🌐

Nesne yönelimli programlama, yazılım tasarımında nesneleri kullanarak programların daha esnek ve yeniden kullanılabilir olmasını sağlar. OOP, aşağıdaki temel prensiplere dayanır:

1. **Kapsülleme**: Verilerin ve metotların bir arada tutulması.
2. **Miras (Inheritance)**: Alt sınıfların üst sınıflardan özellik ve metotları devralması.
3. **Polimorfizm**: Farklı nesnelerin aynı metodu farklı şekillerde uygulayabilmesi.
4. **Soyutlama**: Gereksiz detayları gizleyerek önemli özelliklere odaklanma.

## Kullanılan Teknolojiler ⚙️

- C#
- .NET Framework (veya .NET Core)

## Kurulum 🔧

1. **Gereksinimler**: .NET SDK'sının bilgisayarınızda kurulu olduğundan emin olun. [İndir](https://dotnet.microsoft.com/download).
   
2. **Projeyi Klonlayın**:
   ```bash
   git clone https://github.com/kullanici_adiniz/Project17_Inheritance.git
   cd Project17_Inheritance
   ```

3. **Projeyi Açın**: Visual Studio veya tercih ettiğiniz başka bir IDE ile projeyi açın.

## Kullanım 🖥️

Projeyi çalıştırmak için aşağıdaki adımları izleyin:

1. **Proje Çalıştırma**: IDE üzerinden projeyi çalıştırın veya terminalde aşağıdaki komutu kullanın:
   ```bash
   dotnet run
   ```

2. **Çıktıyı Gözlemleyin**: Program çalıştığında, öğrenci ve öğretmen bilgileri konsola yazdırılacaktır.

## Kod Yapısı 📁

### BaseKisi Sınıfı

- **Ad**: Kişinin adını tutar.
- **Soyad**: Kişinin soyadını tutar.
- **BilgiYazdir()**: Ad ve soyadı ekrana yazdıran sanal metot.

### Ogrenci Sınıfı

- **OgrenciNo**: Öğrencinin numarasını tutar.
- **OgrenciBilgileriYazdir()**: Öğrenci numarasını, adını ve soyadını ekrana yazdırır.

### Ogretmen Sınıfı

- **Maas**: Öğretmenin maaş bilgisini tutar.
- **OgretmenBilgileriYazdir()**: Maaş bilgisini, adını ve soyadını ekrana yazdırır.

## Sınıfların Detaylı Açıklamaları 📖

### BaseKisi

Bu sınıf, temel kişisel bilgileri (ad ve soyad) tutan bir üst sınıf olarak tanımlanmıştır. Aşağıdaki özellikleri içerir:

- **Ad**: Kullanıcının adını saklar.
- **Soyad**: Kullanıcının soyadını saklar.
- **BilgiYazdir()**: Ad ve soyadı ekrana yazdıran sanal metot. Bu metot, alt sınıflar tarafından geçersiz kılınabilir.

### Ogrenci

`BaseKisi` sınıfından türemiştir ve öğrenci bilgilerini içerir:

- **OgrenciNo**: Öğrencinin benzersiz numarasını saklar.
- **OgrenciBilgileriYazdir()**: Öğrenci numarasını, adını ve soyadını ekrana yazdırır.

### Ogretmen

`BaseKisi` sınıfından türemiştir ve öğretmen bilgilerini içerir:

- **Maas**: Öğretmenin maaş bilgisini saklar.
- **OgretmenBilgileriYazdir()**: Maaş bilgisini, adını ve soyadını ekrana yazdırır.
