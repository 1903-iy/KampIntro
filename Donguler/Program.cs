// See https://aka.ms/new-console-template for more information



string kurs1 = "Yzılım Geliştici Yetiştirme Kursu";
string kurs2 = "Programlamaya başlangıç için teml kurs";
string kurs3 = "Java";
string kurs4 = "C#";
string kurs5 = "Python";

Console.WriteLine(kurs1);
Console.WriteLine(kurs2);   
Console.WriteLine(kurs3);
Console.WriteLine(kurs4);
Console.WriteLine(kurs5);

string[] kurslar = new string[] { "Yzılım Geliştici Yetiştirme Kursu" ,
  "Programlamaya başlangıç için teml kurs" ,"Java","C#","Python","C++" };
for (int i = 0; i < kurslar.Length; i++)
{
    Console.WriteLine(kurslar[i]);
}

Console.WriteLine("Satır sonu");

foreach (string kurs in kurslar)
{
    Console.WriteLine(kurs);
}