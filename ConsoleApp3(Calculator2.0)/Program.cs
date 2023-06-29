using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3_Calculator2._0_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Yapmak istediğiniz işlemi seçiniz.");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("(T)oplama");
            Console.WriteLine("(Ç)ıkarma");
            Console.WriteLine("(ÇA)rpma");
            Console.WriteLine("(B)ölme");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("");
            string işlem = Console.ReadLine();
            string toplama = "T";
            string çıkarma = "Ç";
            string çarpma = "ÇA";
            string bölme = "B";
            string karesinialma = "KA";
            string küpünüalma = "KÜ";

            if (işlem == toplama)
                {
                Console.WriteLine("1. sayıyı giriniz");
                double toplamabirincisayı = double.Parse(Console.ReadLine());
                Console.WriteLine("2. sayıyı giriniz");
                double toplamaikincisayı = double.Parse(Console.ReadLine());
                double toplamasonuç = toplamabirincisayı + toplamaikincisayı;
                Console.WriteLine("Sonuç:" + toplamasonuç);
                Console.ReadKey();
                Environment.Exit(0);
                }

            else if (işlem == çıkarma)
                {
                Console.WriteLine("1.sayıyı giriniz");
                double çıkarmabirincisayı = double.Parse(Console.ReadLine());
                Console.WriteLine("2.sayıyı giriniz");
                double çıkarmaikincisayı = double.Parse(Console.ReadLine());
                double çıkarmasonuç = çıkarmabirincisayı - çıkarmaikincisayı;
                Console.WriteLine("Sonuç:" + çıkarmasonuç);
                Console.ReadKey();
                Environment.Exit(0);
                }

            if (işlem == çarpma)
                {
                Console.WriteLine("1.sayıyı giriniz");
                double çarpmabirincisayı = double.Parse(Console.ReadLine());
                Console.WriteLine("2.sayıyı giriniz");
                double çarpmaikincisayı = double.Parse(Console.ReadLine());
                double çarpmasonuç = çarpmabirincisayı * çarpmaikincisayı;
                Console.WriteLine("Sonuç:" + çarpmasonuç);
                Console.ReadKey();
                Environment.Exit(0);
                }

            else if (işlem == bölme)
                {
                Console.WriteLine("1.sayıyı giriniz");
                double bölmebirincisayı = double.Parse(Console.ReadLine());
                Console.WriteLine("2.sayıyı giriniz");
                double bölmeikincisayı = double.Parse(Console.ReadLine());
                double bölmesonuç = bölmebirincisayı / bölmeikincisayı;
                Console.WriteLine("Sonuç:" + bölmesonuç);
                Console.ReadKey();
                Environment.Exit(0);
                }
            

        }
    }
}
