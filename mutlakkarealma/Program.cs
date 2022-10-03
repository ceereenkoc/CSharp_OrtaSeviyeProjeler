using System;

namespace mutlakkarealma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen bir sayı giriniz: ");
            int sayı = Convert.ToInt32(Console.ReadLine());
            int[] sayıListesi = new int[sayı];

            Console.WriteLine($"Lütfen {sayı} tabe sayı giriniz.");
            for (int i = 0; i < sayı; i++)
            {
                Console.WriteLine("{0}. sayı: ", i+1);
                sayıListesi[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Oluşturduğunuz sayı dizisi:");
            foreach (var item in sayıListesi)
            {
                Console.Write(" " + item);
            }

            Console.WriteLine();

            int toplam = 0;
            int toplam1 = 0;
            for (int i = 0; i < sayıListesi.Length; i++)
            {
                if( sayıListesi[i] < 67)
                {
                    toplam = (67 - sayıListesi[i]) + toplam;
                }
                else
                {
                    int fark = 67 - sayıListesi[i];
                    int mutlak =  Math.Abs(fark);
                    toplam1 = (mutlak * mutlak) + toplam1;
                }
            }
            Console.WriteLine("İşlem uygulanmış sayı dizisi:");
            Console.WriteLine($"{toplam} {toplam1}");
        }
        
    }
}
