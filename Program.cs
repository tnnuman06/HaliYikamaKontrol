using System;

namespace HaliYikamaKontrol
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool halı1;
            bool halı2;

            Console.Write("Halı 1'in temizlik durumu (true/false): ");
            halı1 = Convert.ToBoolean(Console.ReadLine());

            Console.Write("Halı 2'nin temizlik durumu (true/false): ");
            halı2 = Convert.ToBoolean(Console.ReadLine());

            Console.Clear();

            TemizlikRobotu robot = new TemizlikRobotu();
            robot.KontrolVeYıkama("Halı 1", ref halı1);
            robot.KontrolVeYıkama("Halı 2", ref halı2);

            Console.WriteLine("Yıkama işlemi tamamlandı.");
            Console.ReadLine();
        }
    }
    class TemizlikRobotu
    {
        public TemizlikRobotu()
        {
            //fonksiyonu gerçekleştirelim
        }
        public void KontrolVeYıkama(string halıAdı, ref bool halıTemizlikDurumu)
        {
            Console.WriteLine(halıAdı + " temizlik durumu kontrol ediliyor...");

            if (!halıTemizlikDurumu)
            {
                Console.WriteLine(halıAdı + " kirli, yıkanıyor...");

                halıTemizlikDurumu = true;
            }
            else
            {
                Console.WriteLine(halıAdı + " zaten temiz, yıkanmadı.");
            }
        }
    }
}


