using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> working = new MyDictionary<int, string>();
            working.Add(1, "İrem");
            working.Add(2, "İlayda");
            working.Add(3, "Esat");

            Console.WriteLine("Key tipi 'integer' değer tipi 'string' örneği \n");

            for (int i = 0; i < working.KeyValue.Length; i++)
            {
                Console.WriteLine("Anahtar: " + working.KeyValue[i] + "  " + "Değer: " + working.ItemValue[i]);
            }

            Console.WriteLine("***********************************************\n");

            Console.WriteLine("Key tipi 'string' değer tipi 'string' örneği \n");

            MyDictionary<string, string> working2 = new MyDictionary<string, string>();
            working2.Add("Merhaba", "İrem");
            working2.Add("Selam", "İlayda");
            working2.Add("Naber", "Esat");


            for (int i = 0; i < working2.KeyValue.Length; i++)
            {
                Console.WriteLine("Anahtar: " + working2.KeyValue[i] + "  " + "Değer: " + working2.ItemValue[i]);
            }

            Console.WriteLine("***********************************************\n");
        }
    }
}
