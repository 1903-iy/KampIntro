// See https://aka.ms/new-console-template for more information



string adi = "İrfan";
int yas = 28;

Kurs kurs1= new Kurs();
kurs1.Egitmen = "İrfan Yücesoy";
kurs1.KursAdi = "JavaScript";
kurs1.IzlenmeOrani = 100;

Kurs kurs2 = new Kurs();
kurs2.Egitmen = "Cihangir Karakılçık";
kurs2.KursAdi = "C#";
kurs2.IzlenmeOrani = 100;

Kurs kurs3 = new Kurs();
kurs3.Egitmen = "Burak Genç";
kurs3.KursAdi = "Java";
kurs3.IzlenmeOrani = 100;

//Console.WriteLine(kurs1.KursAdi +": " +kurs1.Egitmen);

Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3 };

foreach (Kurs kurs in kurslar)
{
    Console.WriteLine(kurs.KursAdi +" "+ kurs.Egitmen);
}



class Kurs
{
    public string KursAdi { get; set; }
    public string Egitmen { get; set; }
   public int IzlenmeOrani { get; set; }
}