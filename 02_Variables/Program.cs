using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Değişkenler
            ////double number;

            ////number = 4.85;
            ////Console.WriteLine(number);

            //Console.WriteLine("***** Fiyat Listesi *****");
            //Console.WriteLine();

            //double applePrice, orangePrice, strawberryPrice, patatoPrice, tomatoPrice;

            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //patatoPrice = 9.74;
            //tomatoPrice = 6.88;

            //Console.WriteLine("----- Elma Birim Fiyatı: " + applePrice + " TL");
            //Console.WriteLine("----- Portakal Birim Fiyatı: " + orangePrice + " TL");
            //Console.WriteLine("----- Çilek Birim Fiyatı: " + strawberryPrice + " TL");
            //Console.WriteLine("----- Patates Birim Fiyatı: " + patatoPrice + " TL");
            //Console.WriteLine("----- Domates Birim Fiyatı: " + tomatoPrice + " TL");

            //Console.WriteLine();

            //double appleGram, orangeGram, strawberryGram, patatoGram, tomatoGram;

            //appleGram = 1.245;
            //orangeGram = 2.65;
            //strawberryGram = 0.75;
            //patatoGram = 4.859;
            //tomatoGram = 3.745;

            //double appleTotalPrice = applePrice * appleGram;
            //double orangeTotalPrice = orangePrice * orangeGram;
            //double strawberryTotalPrice = strawberryPrice * strawberryGram;
            //double patatoTotalPrice = patatoPrice * patatoGram;
            //double tomatoTotalPrice = tomatoPrice * tomatoGram;


            //Console.WriteLine("Alınan ürün: Elma -" + " Birim Fiyatı: " + applePrice + " - Gramaj " + appleGram + " Toplam Tutar: " + appleTotalPrice + " Tl");
            //Console.WriteLine("Alınan ürün: Portakal -" + " Birim Fiyatı: " + orangePrice + " - Gramaj " + orangeGram + " Toplam Tutar: " + orangeTotalPrice + " Tl");
            //Console.WriteLine("Alınan ürün: Çilek -" + " Birim Fiyatı: " + strawberryPrice + " - Gramaj " + strawberryGram + " Toplam Tutar: " + strawberryTotalPrice + " Tl");
            //Console.WriteLine("Alınan ürün: Patates -" + " Birim Fiyatı: " + patatoPrice + " - Gramaj " + patatoGram + " Toplam Tutar: " + patatoTotalPrice + " Tl");
            //Console.WriteLine("Alınan ürün: Domates -" + " Birim Fiyatı: " + tomatoPrice + " - Gramaj " + tomatoGram + " Toplam Tutar: " + tomatoTotalPrice + " Tl");
            //Console.WriteLine();

            //double shopingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + patatoTotalPrice + tomatoTotalPrice;

            //Console.WriteLine();
            //Console.WriteLine();

            //Console.WriteLine("Alışveriş Toplam Tutarı: " + shopingTotalPrice + " TL");



            #endregion

            #region Char Değişkenler

            //ABCDEFGH
            //DEF...
            //TOPLANTI SAAT 20:00'DA
            // " '

            //Char symbol;
            //symbol = 'a';

            //Console.WriteLine(symbol);

            #endregion

            #region Klavyeden Veri Girişleri String Değişkenler

            //Console.WriteLine("***** CSharp Hava Yolları Yolcu Bilgisi *****");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;

            //Console.Write("Yolcu Adı: ");
            //passengerName = Console.ReadLine();

            //Console.Write("Yolcu Soyadı: ");
            //passengerSurname = Console.ReadLine();

            //Console.Write("İlçe Bilgisi: ");
            //passengerDistrict = Console.ReadLine();

            //Console.Write("Şehir Bilgisi: ");
            //passengerCity = Console.ReadLine();

            //Console.Write("Yolcu Yaş: ");
            //passengerAge = Console.ReadLine();

            //Console.Write("Yolcu TC No: ");
            //passengerIdentityNumber = Console.ReadLine();

            //Console.WriteLine();

            //Console.WriteLine("--------------------------------");
            //Console.WriteLine("Yolcu Adı Soyadı: " + passengerName + " " + passengerSurname + " " + "Yolcu Adres: " + passengerDistrict + " " + passengerCity + " " + "Yolcu Yaş: " + passengerAge + " " + "Yolcu TC: " + passengerIdentityNumber);









            #endregion

            #region Klavyeden Tam Sayı Girişleri ve Dönüşümler

            //ABC12D string ifade, sayıları karakter olarak algılıyor 

            //int shoesPrice, computerPrice, chairPrice, tvPrice;
            //shoesPrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoesCount, computerCount, chairCount, tvCount;

            //Console.Write("Lütfen Aldığınız Ayakkabı Sayısını Giriniz: ");
            //shoesCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen Aldığınız Bilgisayar Sayısını Giriniz: ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen Aldığınız Sandalye Sayısını Giriniz: ");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen Aldığınız Televizyon Sayısını Giriniz: ");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice = shoesCount * shoesPrice + computerCount * computerPrice + chairCount * chairPrice + tvCount * tvPrice;

            //Console.WriteLine();

            //Console.WriteLine("Toplam Ödemeniz Gereken Tutar: " + totalPrice + " TL");


            #endregion

            #region Klavyeden Ondalıklı Sayı İşlemleri

            //double exam1, exam2, exam3, result;

            //Console.Write("Lütfen 1. Sınav Notunu Giriniz: ");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2. Sınav Notunu Giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 3. Sınav Notunu Giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine();

            //Console.WriteLine("Not Ortalamanız: " + result);


            #endregion

            #region Klavyeden Karakter Girişleri

            //char gender;
            //Console.Write("Lütfen cinsiyet seçiniz:  ");
            //gender=char.Parse(Console.ReadLine());

            //Console.WriteLine();

            //Console.WriteLine("Seçtiğiniz cinsiyet:  " + gender);


            #endregion




            //Console.Read();


        }
    }
}
