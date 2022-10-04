using System;

namespace sessizharf
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen aralarında boşluk bırakarak kelime giriniz:");
            string[]  kelimeler = Console.ReadLine().Split();

            foreach (var item in kelimeler)
            {
                bool değer = false;
                for (int i = 1; i < item.Length; i++)
                {
                    if (sessiz(item[i]) == sessiz(item[i - 1]))
                        değer = true;
                    
                }
                Console.Write(değer + " ");
            }

            bool sessiz(char c)
            {
               return !"aeıioöuü".ToCharArray().Contains(c);             
            }
        }
    }
}

