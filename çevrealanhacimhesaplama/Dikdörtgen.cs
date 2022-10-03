using System;

namespace çevrealanhacimhesaplama
{
    public class Dikdörtgen
    {
        public static void Hesaplama()
        {
            Console.WriteLine("Lütfen kısa kenarın uzunluğu giriniz:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lütfen uzun kenarın uzunluğu giriniz:");
            int b = Convert.ToInt32(Console.ReadLine());

            BoyutSeçimi.Seçim();
            int boyut = Convert.ToInt32(Console.ReadLine());

            switch (boyut)
            {
                case 1:
                    double çevre = 2 * (a + b);
                    Console.WriteLine("Çevre: " + çevre);
                    break;

                case 2:
                    double alan = a * b;
                    Console.WriteLine("Alan: " + alan);
                    break;

                case 3:
                    Console.WriteLine("Yükseklik giriniz:");
                    int c = Convert.ToInt32(Console.ReadLine());
                    double hacim = a * b * c;
                    Console.WriteLine("Hacim: " + hacim);
                    break;

                default:
                    HataMesajı.Hata();
                    break;
            }
        }
    }
}