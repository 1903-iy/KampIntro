// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


string KategoriEtiketi = "Kategoriler";

Console.WriteLine(KategoriEtiketi);


int OgrenciSayisi = 900000000;
double Faiz = 1.45;
bool GirisYapmisMi = true;
double dolarDun = 25.5;
double dolarBugun = 25.3;

if (dolarDun>dolarBugun)
{
    Console.WriteLine("Azalış butonu");
}
else if (dolarDun<dolarBugun)
{
    Console.WriteLine("Artış butonu");
}
else
{
    Console.WriteLine("Değişmedi butonu");
}

if (GirisYapmisMi == true)
{
    Console.WriteLine("Kaydol Butonuna Tıkla");
       
}

else
{
    Console.WriteLine("Giriş Yap Butonuna Tıkla");
}



