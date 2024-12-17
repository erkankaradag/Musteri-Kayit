
using System;
namespace Degiskenler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcıdan bilgileri alma
            // Kullanıcıdan ilk önce 11 haneli kimlik numarası girmesi istenilir. Boş veya geçersiz karakter girmesi durumunda doğru bir yapıda kimlik numarası girmesi istenilir.
            // IsNullOrEmpty ile kullanıcının boş bırakmamasını sağladım - lenght ile 11 haneli numara girilmesini şart koştum. - Long.TryParse ile sadece rakam girilmesini sağladım. İF Bloğu bunları kontrol edecek ve doğru ise kabul edecektir.
            string? tcKimlikNo;
            while (true)
            {
                Console.Write("T.C. Kimlik Numarası: ");
                tcKimlikNo = Console.ReadLine();

                if (!string.IsNullOrEmpty(tcKimlikNo) && tcKimlikNo.Length == 11 && long.TryParse(tcKimlikNo, out _))
                {
                    break;
                }
                Console.WriteLine("Hatalı T.C. kimlik numarası. Lütfen 11 haneli bir sayı giriniz.");
            }
            // Kullanıcıdan adı girilmesi istenilir boş bırakılamaz ve sadece boşluk kullanamaz
            string? adi;
            while (true)
            {
                Console.Write("Adı: ");
                adi = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(adi)) // Ad boş olmamalı
                {
                    break;
                }
                Console.WriteLine("Ad boş olamaz. Lütfen geçerli bir ad giriniz.");
            }

            // Kullanıcıdan soyadı girilmesi istenilir
            string? soyadi;
            while (true)
            {
                Console.Write("Soyadı: ");
                soyadi = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(soyadi)) // Soyad boş olmamalı
                {
                    break;
                }
                Console.WriteLine("Soyad boş olamaz. Lütfen geçerli bir soyad giriniz.");
            }
            // Kullanıcıdan 11 haneli telefon numarası girmesi istenilir. burada string veri tipini kullandım çünkü telefon numaralarında + () gibi işaretlemeler kullanılabilir.
            // Tabi bunların da önüne geçmek, kullanıcının boş veya gereksiz karakter girmesi ve başında 0 olacak şekilde 11 haneli sayı girmesi için bir T.C. kimlik numarasındaki gibi bir döngü oluşturdum ve belirli şartlar sundum.
            string? telefonNo;
            while (true)
            {
                Console.Write("Telefon Numarası: ");
                telefonNo = Console.ReadLine();

                if (!string.IsNullOrEmpty(telefonNo) && telefonNo.Length == 11 && telefonNo[0] == '0' && long.TryParse(telefonNo, out _))
                {
                    break;
                }
                Console.WriteLine("Hatalı telefon numarası. Lütfen başında 0 olacak şekilde 11 haneli telefon numarası giriniz.");
            }
            // Yaş bilgisini alır eğer negatif bir yaş veya 0 girilir ise kullanıcıdan doğru bir yaş bilgisi girmesi istenilir.
            Console.Write("Yaş: ");
            int yas;
            while (!int.TryParse(Console.ReadLine(), out yas) || yas <= 0)
            {
                Console.WriteLine("Geçersiz yaş girdiniz. Lütfen geçerli bir yaş giriniz.");
            }
            // İlk ürün fiyatını al burada decimal veri tipini kullandım. desimal.Parse kullanıcının girdiği değeri sayıya dönüştürür ayrıca decimal para gibi hassas hesaplamalarda kullanılır.
            decimal urunFiyati1;
            while (true)
            {
                Console.Write("İlk ürünün fiyatını giriniz: ");
                if (decimal.TryParse(Console.ReadLine(), out urunFiyati1) && urunFiyati1 > 0)
                {
                    break;
                }
                Console.WriteLine("Hatalı giriş! Lütfen geçerli bir sayı formatında fiyat giriniz.");
            }

            // İkinci ürün fiyatını al burada decimal veri tipini kullandım. desimal.Parse kullanıcının girdiği değeri sayıya dönüştürür ayrıca decimal para gibi hassas hesaplamalarda kullanılır.
            decimal urunFiyati2;
            while (true)
            {
                Console.Write("İkinci ürünün fiyatını giriniz: ");
                if (decimal.TryParse(Console.ReadLine(), out urunFiyati2) && urunFiyati2 > 0)
                {
                    break;
                }
                Console.WriteLine("Hatalı giriş! Lütfen geçerli bir sayı formatında fiyat giriniz.");
            }
            decimal toplamFiyat = urunFiyati1 + urunFiyati2;
            decimal yuzde = 10;
            decimal yuzdeDegeri = (toplamFiyat * yuzde) / 100;
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------");
            Console.WriteLine($"{tcKimlikNo} T.C. kimlik numaralı {adi} {soyadi} isimli kullanıcı için kayıt oluşturulmuştur.");
            Console.WriteLine($"{telefonNo} numaralı telefona bildirim mesajı gönderilmiştir.");
            Console.WriteLine($"{toplamFiyat} TL toplam harcama karşılığı %10({yuzdeDegeri}) patika puanı kazandınız.");
        }
    }
}