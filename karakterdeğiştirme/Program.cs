using System;

namespace karakterdeğiştirme
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen aralarında boşluk bırakarak kelimeler giriniz: ");
            string kelimeler = Console.ReadLine();
            string[] kelime = kelimeler.Split();

            foreach (var item in kelime)
            {
                char[] karakter = item.ToCharArray(); // Elemanlar ToCharArray ile karakterlerine ayrıldı.
                char hafıza = karakter[0]; // Her elamanın ilk karakterini hafıza değişkenine atadık. Bunu yapmamızdaki sebep daha sonrasında son elemanın yerine bu değeri atayabilmek.
                karakter[0] = karakter[karakter.Length - 1]; // Her elemanın son karakterini ilk karaktere atadık. Bunu yaparken karakter olarak tanımladığımız dizinin boyutundan bir çıkardık.
                karakter[karakter.Length - 1] = hafıza; // Her elemanın son karakterine daha öncesinde oluşturduğumuz hafıza değerini atadık.

                
                foreach (var item1 in karakter)
                {
                    string yeniKelime = item1.ToString(); // yeniKelime adında string bir değişken oluşturup char tipindeki karakter dizimizi ToString() ile string hale çevirdik.
                    Console.Write(yeniKelime);
                }
            }
        }
    }
}
