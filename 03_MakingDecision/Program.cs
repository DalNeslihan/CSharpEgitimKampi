﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If Else

            //Console.Write("Lütfen Şifreyi Giriniz:  ");
            //string password;
            //password = Console.ReadLine();
            //if(password == "abcd") 
            //{
            //    Console.WriteLine("Şifre Doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Şifreniz yanlış");
            //}

            //string capital, country;
            //Console.Write("Başkenti giriniz: ");
            //capital = Console.ReadLine();

            //Console.Write("Ülkeyi giriniz:  ");
            //country = Console.ReadLine();

            //if (capital == "Ankara" & country == "Türkiye") 
            //{
            //    Console.Write("Veriler doğrulandı.");
            //}
            //else
            //{
            //    Console.Write("Hatalı bilgi");
            //}

            //int number;
            //Console.Write("Sayıyı Giriniz: ");
            //number = int.Parse(Console.ReadLine());
            //if (number == 5)
            //{
            //    Console.WriteLine("Sayı doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı yanlış");
            //}

            //int exam1, exam2, exam3, average;
            //string result = "Hata";

            //Console.Write("Sınav1: ");
            //exam1 = int.Parse(Console.ReadLine());

            //Console.Write("Sınav2: ");
            //exam2 = int.Parse(Console.ReadLine());

            //Console.Write("Sınav3: ");
            //exam3 = int.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine("Sınavların Ortalaması: " + average);

            //if (average > 0 & average <= 50)
            //{
            //    result = "Sonuç vasat";
            //}
            //if(average >50 & average <= 70)
            //{
            //    result = "Sonuç orta";
            //}
            //if(average >70 & average <= 84)
            //{
            //    result = "Sonuç iyi";
            //}
            //if (average > 84 & average <= 100)
            //{
            //    result = "Sonuç çok iyi";
            //}


            //Console.WriteLine(result);

            //string city;
            //Console.WriteLine("Lütfen şehir girişi yapınız: ");
            //city =Console.ReadLine();

            //if (city == "adana" | city== "ankara" |city=="bursa" | city == "trabzon")
            //{
            //    Console.WriteLine("Şehir mevcut");
            //}
            //else
            //{
            //    Console.WriteLine("Şehir mevcut değil");
            //}

            //Console.WriteLine("Lütfen kullanıcı adını giriniz: ");
            //string username=Console.ReadLine();


            //if (username != "admin")
            //{
            //    Console.WriteLine("Bu kullanıcı adı doğru değil.");
            //}
            //else
            //{
            //    Console.WriteLine("Hoş geldiniz");
            //}

            #endregion

            #region Mod İşlemleri

            //int number;
            //number = 26;
            //int result = number % 5;
            //Console.WriteLine(result);

            //Console.WriteLine("Lütfen 1. sayıyı giriniz: ");
            //int number1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Lütfen 2. sayiyi giriniz: ");
            //int number2 = int.Parse(Console.ReadLine());

            //int result = number1 % number2;

            //Console.WriteLine("1. sayının 2. sayıya bölümünden kalan: " + result);

            //Console.WriteLine("Lütfen sayıyı giriniz: ");
            //int number = int.Parse(Console.ReadLine());
            //if (number % 2 == 0)
            //{
            //    Console.WriteLine("Sayi çifttir");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı tektir");
            //}




            #endregion

            #region Char Değişkenler ile Karar Yapıları

            //char team;
            //Console.WriteLine("Lütfen takım sembolünü giriniz: ");
            //team=char.Parse(Console.ReadLine());
            //if(team == 'g' | team == 'G')
            //{
            //    Console.WriteLine("Galatasaray");
            //}
            //if(team== 'f' | team== 'F')
            //{
            //    Console.WriteLine("Fenerbahçe");
            //}
            //if (team == 'b' | team == 'B')
            //{
            //    Console.WriteLine("Beşiktaş");
            //}


            #endregion

            #region Örnek Proje Uygulaması

            //Console.WriteLine("***** C# Eğitim Kampı Restoran *****");
            //Console.WriteLine();
            //Console.WriteLine("----------------------------------------");
            //Console.WriteLine("1- Ana Yemekler");
            //Console.WriteLine("2- Çorbalar");
            //Console.WriteLine("3- Pizzalar");
            //Console.WriteLine("4- İçecekler");
            //Console.WriteLine("5- Tatlılar");
            //Console.WriteLine("----------------------------------------");

            //string menuItem;
            //Console.WriteLine("Detayını görmek istediğiniz menü seçin");
            //menuItem = Console.ReadLine();

            //if (menuItem == "1") 
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------Ana Yemekler--------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Köri Soslu Tavuk");
            //    Console.WriteLine("2- Kızartma Tabağı");
            //    Console.WriteLine("3- Fasülye Pilav");
            //    Console.WriteLine("4- Fırında Somon");
            //    Console.WriteLine("5- Patlıcan Musakka");
            //    Console.WriteLine("------------Ana Yemekler--------------");
            //    Console.WriteLine();

            //}
            //if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------Çorbalar--------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Mercimek Çorbası");
            //    Console.WriteLine("2- Ezogelin");
            //    Console.WriteLine("------------Çorbalar--------------");
            //    Console.WriteLine();

            //}
            //if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------Pizzalar--------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Akdeniz");
            //    Console.WriteLine("2- Margarita");
            //    Console.WriteLine("3- Tavuklu");
            //    Console.WriteLine("4- Patlıcanlı");
            //    Console.WriteLine("5- 5 peynirli");
            //    Console.WriteLine("------------Pizzalar--------------");
            //    Console.WriteLine();

            //}
            //if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------İçecekler--------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Kola");
            //    Console.WriteLine("2- Ayran");
            //    Console.WriteLine("3- Su");
            //    Console.WriteLine("------------İçecekler--------------");
            //    Console.WriteLine();

            //}
            //if (menuItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------Tatlılar--------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Triliçe");
            //    Console.WriteLine("2- Kazandibi");
            //    Console.WriteLine("3- Sütlaç");
            //    Console.WriteLine("------------Tatlılar--------------");
            //    Console.WriteLine();

            //}



            #endregion

            #region Swich Case

            //Console.WriteLine("Kaçıncı ayı görmek istediniz: ");
            //int monthNumber=int.Parse(Console.ReadLine());

            //switch (monthNumber)
            //{
            //    case 1:Console.WriteLine("Ocak"); break;
            //    case 2:Console.WriteLine("Şubat"); break;
            //    case 3:Console.WriteLine("Mart"); break;
            //    case 4:Console.WriteLine("Nisan"); break;
            //    case 5:Console.WriteLine("Mayıs"); break;
            //    case 6:Console.WriteLine("Haziran"); break;
            //    case 7:Console.WriteLine("Temmuz"); break;
            //    case 8:Console.WriteLine("Ağustos"); break;
            //    case 9:Console.WriteLine("Eylül"); break;
            //    case 10:Console.WriteLine("Ekim"); break;
            //    case 11:Console.WriteLine("Kasım"); break;
            //    case 12:Console.WriteLine("Aralık"); break;
            //        default: Console.WriteLine("Hatalı veri girişi"); break;
            //}


            #endregion

            #region Swich case Hesap Makinesi

            
            
            //int number1, number2, result;
            //char symbol;

            //Console.WriteLine("1. sayıyı giriniz: ");
            //number1=int.Parse(Console.ReadLine());

            //Console.WriteLine("2. sayıyı giriniz: ");
            //number2=int.Parse(Console.ReadLine());

            //Console.WriteLine("Lütfen yapmak istediğiniz işlemi giriniz: ");
            //symbol=char.Parse(Console.ReadLine());


            //switch (symbol)
            //{
            //    case '+':
            //        result=number1 + number2;
            //        Console.WriteLine("Toplam: "+result); break;
            //    case '-':
            //        result=number1 - number2;
            //        Console.WriteLine("Çıkartma: " + result); break;
            //    case '*':
            //        result=number1 * number2;
            //        Console.WriteLine("Çarpım: " + result); break;
            //    case '/':
            //        result=number1 / number2;
            //        Console.WriteLine("Bölüm: " + result);break;
            //}

            #endregion

            //Console.Read();

        }
    }
}
