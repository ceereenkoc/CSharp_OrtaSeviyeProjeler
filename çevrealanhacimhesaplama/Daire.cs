using System;

namespace çevrealanhacimhesaplama
{
    public class Daire
    {
        public static void Hesaplama()
        {
            Console.WriteLine("Lütfen yarıçap uzunluğu giriniz:");
            int r = Convert.ToInt32(Console.ReadLine());

            BoyutSeçimi.Seçim();
            int boyut = Convert.ToInt32(Console.ReadLine());

            switch (boyut)
            {
                case 1:
                    double çevre = 2 * Math.PI * r;
                    Console.WriteLine("Çevre: " + çevre);
                    break;

                case 2:
                    double alan = Math.PI * Math.Pow(r, 2);
                    Console.WriteLine("Alan: " + alan);
                    break;

                case 3:
                    double hacim = (4 * Math.PI * Math.Pow(r, 3)) / 3;
                    Console.WriteLine("Hacim: " + hacim);
                    break;

                default:
                    HataMesajı.Hata();
                    break;
            }
        }
    }
}