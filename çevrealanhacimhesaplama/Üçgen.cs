using System;

namespace çevrealanhacimhesaplama
{
    public class Üçgen
    {
        public static void Hesaplama()
        {
            Console.WriteLine("Lütfen birinci kenar uzunluğunu giriniz:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lütfen ikinci kenar uzunluğunu giriniz:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lütfen üçüncü kenar uzunluğunu giriniz:");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lütfen üçüncü kenara ait yüksekliği giriniz:");
            int h = Convert.ToInt32(Console.ReadLine());

            BoyutSeçimi.Seçim();
            int boyut = Convert.ToInt32(Console.ReadLine());

            switch (boyut)
            {
                case 1:
                    double çevre = a + b + c;
                    Console.WriteLine("Çevre: " + çevre);
                    break;

                case 2:
                    double alan = (c * h) / 2;
                    Console.WriteLine("Alan: " + alan);
                    break;

                case 3:
                    Console.WriteLine("Yükseklik giriniz:");
                    int h1 = Convert.ToInt32(Console.ReadLine());
                    double hacim = (c * h * h1) / 2;
                    Console.WriteLine("Hacim: " + hacim);
                    break;

                default:
                    HataMesajı.Hata();
                    break;

            }
        }
    }
}