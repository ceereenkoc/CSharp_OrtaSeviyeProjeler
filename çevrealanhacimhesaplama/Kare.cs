using System;

namespace çevrealanhacimhesaplama
{
    public class Kare
    {
        public static void Hesaplama()
        {
            Console.WriteLine("Lütfen kenar uzunluğu giriniz:");
            int a = Convert.ToInt32(Console.ReadLine());

            BoyutSeçimi.Seçim();
            int boyut = Convert.ToInt32(Console.ReadLine());

            switch (boyut)
            {
                case 1:
                    double çevre = 4 * a;
                    Console.WriteLine("Çevre: " + çevre);
                    break;

                case 2:
                    double alan = Math.Pow(a, 2);
                    Console.WriteLine("Alan: " + alan);
                    break;

                case 3:
                    double hacim = Math.Pow(a, 3);
                    Console.WriteLine("Hacim: " + hacim);
                    break;

                default:
                    HataMesajı.Hata();
                    break;

            }
        }
    }
}