// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using SingleResponsibility.SRSample;

Araba araba = new Araba("Mavi");
BildirimServisi.ArabanınDurumunuVer(araba);

DepoServisi depoServisi = new DepoServisi();
depoServisi.ArabayaBenzinAl(araba);//fulle
BildirimServisi.ArabanınDurumunuVer(araba);

MotorServisi motorServisi = new MotorServisi(depoServisi);
motorServisi.MotorCalistir(araba);
BildirimServisi.ArabanınDurumunuVer(araba);

motorServisi.MotorDurdur(araba);
BildirimServisi.ArabanınDurumunuVer(araba);

//motorServisi.MotorDurdur(araba);

Console.ReadLine();