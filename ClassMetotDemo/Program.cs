using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MusteriManager MusteriIslemleri = new MusteriManager();

            Console.WriteLine("--------------Hoşgeldiniz--------------");
            Console.WriteLine("Müşteri bilgileri oluşturmak için 1");
            Console.WriteLine("Müşteri bilgileri listelemek için 2");
            Console.WriteLine("Müşteri bilgileri silmek için 3");
            Console.WriteLine("tuşlayız");

            int islem = Convert.ToInt32(Console.ReadLine());
            switch (islem)
            {
                case 1:
                    MusteriIslemleri.MusteriEkle();
                    break;
                case 2:
                    MusteriIslemleri.MusteriListele();
                    break;
                case 3:
                    MusteriIslemleri.MusteriSil();
                    break;
            }

        }
    }
}
