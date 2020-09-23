using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _2faladatlaphazi
{
    class Program
    {
        static Random rnd = new Random();

        static void Main(string[] args)
        {
            //1
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Kéninger László");
            }


            //2

            Console.WriteLine("\n Kérek egy számot");
            int bekertszam = int.Parse(Console.ReadLine());

            Console.WriteLine("\n Kérek egy szót");
            string bekertszoveg = Console.ReadLine();


            Console.WriteLine("megfejtés:");
            for (int i = 0; i < bekertszam; i++)
            {

                Console.Write(bekertszoveg + " ");
            }


            //3
            Console.WriteLine("\n");
            for (int b = 10; b >= 1; b--)
            {
                Console.WriteLine(b);
                Thread.Sleep(1000);

                //itt nem léptetem ki a programot hogy tudjon tovább haladnia  feladat
            }
            Console.WriteLine("Lejárt az idő");

            //4

            for (int l = 1; l < 10; l++)
            {
                Console.Clear();
                Console.SetCursorPosition(l, 100);
                Console.WriteLine("Kéninger László");
                Thread.Sleep(1000);
            }

            //5,6

            string nev = "*";

            for (int m = 0; m < 200; m++)
            {
                Console.ForegroundColor = (ConsoleColor)rnd.Next(1, 16);
                Console.SetCursorPosition(
                    rnd.Next(Console.WindowWidth - nev.Length),
                    rnd.Next(Console.WindowHeight));
                Console.WriteLine(nev);
                Thread.Sleep(50);
                Console.Clear();
            }

            //7

            int hatar = 901;
            int g = 1;
            while (g * g < hatar)
            {
                Console.WriteLine(g * g);
                g++;
            }


            //8 nincs megoldásom

            //9nincs megoldásom

            //10nincs megoldásom



            Console.ReadKey();
        }
    }
}
