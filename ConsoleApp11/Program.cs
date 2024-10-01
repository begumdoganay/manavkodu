using System;

Console.Write("Hangi meyveyi satın almak istersiniz? (Elma, Armut, Çilek, Muz, diğer): ");
string meyve = Console.ReadLine().ToLower();

double fiyat = 0; // string verdiğimde hata verdi.bundan dolayı Main'deki parantez içine string[]args dediğimde hatalarından dolayı kapattım  

switch (meyve)
{
    case "elma":
        fiyat = 2;
        Console.WriteLine("Elmanın fiyatı 2 TL.");
        break;
    case "armut":
        fiyat = 3;
        Console.WriteLine("Armutun fiyatı 3 TL.");
        break;
    case "çilek":
        fiyat = 2;
        Console.WriteLine("Çileğin fiyatı 2 TL.");
        break;
    case "muz":
        fiyat = 3;
        Console.WriteLine("Muzun fiyatı 3 TL.");
        break;
    default:
        fiyat = 4;
        Console.WriteLine("Bu meyvenin fiyatı 4 TL.");
        break;
}

Console.Write("Kaç kilo almak istersiniz? ");

string kiloInput = Console.ReadLine();
double kilo;

if (double.TryParse(kiloInput, out kilo) && kilo > 0)
{
    double toplamFiyat = fiyat * kilo;
    Console.WriteLine($"{kilo} kilo {meyve} için toplam fiyat: {toplamFiyat} TL.");
}
else
{
    Console.WriteLine("Geçersiz kilo girdiniz, lütfen geçerli bir sayı girin.");
}

 Console.ReadKey(); // Program kapanmasın diye ekledim çünkü program fiyat göstermeden kapatıyordu 
