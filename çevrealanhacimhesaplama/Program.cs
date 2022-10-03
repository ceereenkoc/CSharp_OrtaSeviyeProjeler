using System;

namespace çevrealanhacimhesaplama
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen hesaplama yapmak istediğiniz şekili seçiniz: ");
            Console.WriteLine("*************************************************** ");
            Console.WriteLine("Daire veya Küre                        (1)");
            Console.WriteLine("Üçgen veya Üçgen Prizma                (2)");
            Console.WriteLine("Kare veya Küp                          (3)");
            Console.WriteLine("Dikdörtgen veya Dikdörtgenler Prizması (4)");
            int şekil = Convert.ToInt32(Console.ReadLine());

            switch (şekil)
            {

                case 1:
                    Daire.Hesaplama();
                    break;

                case 2:
                    Üçgen.Hesaplama();
                    break;

                case 3:
                    Kare.Hesaplama();
                    break;

                case 4:
                    Dikdörtgen.Hesaplama();
                    break;

                default:
                    HataMesajı.Hata();
                    break;
            }
            
        }
    }
}
