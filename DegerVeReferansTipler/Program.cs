﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


//Değer tip
int sayi1 = 10;
int sayi2 = 20;
sayi1 = sayi2;
sayi2 = 65;

Console.WriteLine(sayi1);


//Referans tip
int[] sayilar1 = new int[] {10,20,30};
int[] sayilar2= new int[] {100,200,300};
sayilar1 = sayilar2;
sayilar2[0] = 999;

Console.WriteLine(sayilar1[0]);
