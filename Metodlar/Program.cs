// See https://aka.ms/new-console-template for more information


//Dont Repeat Yourself--DRY - Clean Code - Best Practice


using Metodlar;

Urun urun1 = new Urun();
urun1.Adi = "Elma";
urun1.Fiyati = 10;
urun1.Aciklama = "Amasya Elması";

Urun urun2 = new Urun();
urun2.Adi = "Karpuz";
urun2.Fiyati = 80;
urun2.Aciklama = "Salbas Karpuzu";


Urun[] urunler = new Urun[] {urun1,urun2 };

foreach (Urun urun in urunler)
{
    Console.WriteLine(urun.Adi);
    Console.WriteLine(urun.Fiyati);
    Console.WriteLine(urun.Aciklama);
}


Console.WriteLine("-------------------------");
Console.WriteLine("Metotlar");


//encapsulation
SepetManager sepetManager = new SepetManager();
sepetManager.Ekle(urun1);
sepetManager.Ekle(urun2);

sepetManager.Ekle2("Armut", "Yeşil Armut", 12);
sepetManager.Ekle2("Elma", "Yeşil Elma", 12);
sepetManager.Ekle2("Karpuz ", "Salbaş Karpuzu", 12);



