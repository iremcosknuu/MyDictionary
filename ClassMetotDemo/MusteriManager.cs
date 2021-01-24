using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        List<Musteri> Musteriler = new List<Musteri>();
        Musteri musteri = new Musteri();
        public void MusteriEkle()
        {
            Console.Write("TC kimlik Numarası: ");
            musteri.MusteriTC = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ad: ");
            musteri.Ad = Console.ReadLine();
            Console.Write("Soyad: ");
            musteri.Soyad = Console.ReadLine();
            Console.Write("Parola: ");
            musteri.Parola = Console.ReadLine();
            Console.Write("Bakiye: ");
            musteri.Bakiye = Convert.ToDouble(Console.ReadLine());

            Musteriler.Add(musteri);

            Console.WriteLine("-------Müsteri bilgileri eklenmiştir-------");

        }
        public void MusteriListele()
        {
            foreach (var item in Musteriler)
            {
                Console.WriteLine("Musteri TC: "+item.MusteriTC);
                Console.WriteLine("Musteri Ad: " + item.Ad);
                Console.WriteLine("Musteri Soyad: " + item.Soyad);
                Console.WriteLine("Musteri Parola: " + item.Parola);
                Console.WriteLine("Musteri Bakiye: " + item.Bakiye);
                Console.WriteLine("----------------------------------------------");
            }

        }
        public void MusteriSil()
        {
            Console.Write("Silmek istediğiniz kullanıcının TC sini giriniz: ");
            int istenilenTC = Convert.ToInt32(Console.ReadLine());

            foreach (var item in Musteriler)
            {
                if(istenilenTC == item.MusteriTC) 
                {
                    Console.WriteLine("------"+item.Ad + " " + item.Soyad + "silinmiştir-----------");
                    Musteriler.Remove(item);
                    break;
                }

            }
            

        }
        
    }
}
