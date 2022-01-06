using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peter_2022._01._06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //11.feladat: Írj programot, mely beolvassa egy derékszögű háromszög két befogóját, és megadja
            //az átfogójának a hosszát!Az átfogót 2 tizedesjeggyel add meg!
            /*Console.Write("Adja meg az a oldalt");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Adja meg az b oldalt");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("A háromháromszök c oldala: "+Math.Sqrt((a*a)+(b*b))); */

            //12.feladat: Írj programot, mely beolvassa a téglatest három élének hosszát, és kiírja a
            //felszínének és térfogatának mérőszámát!
            Console.Write("Adja meg az a oldalt: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Adja meg az b oldalt: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Adja meg az magasságot: ");
            int m = int.Parse(Console.ReadLine());

            Console.WriteLine("A téglatest térfogata:"+(a*b*m));
            Console.WriteLine($"A téglatest felszíne: {4 * a * b + 2 * b * m}");

            //13.feladat: Írj programot, mely beolvassa egy kör átmérőjét, és kiírja a kör kerületét és
            //területét! A pi értékének meghatározásához használd a Math.PI értéket!
            Console.Write("Adja meg a kör átmérőjét: ");
            int d = int.Parse(Console.ReadLine());

            Console.WriteLine("A kör területe: "+(d/2)*(d/2)*Math.PI);
            Console.WriteLine("A kör kerülete: "+d*Math.PI);

            //15.feladat: Írj programot, mely beolvas egy pozitív egész számot, és kiírja az egész számokat a
            //képernyőre eddig a számig, egymástól szóközzel elválasztva!

                        Console.ReadKey();
        }
    }
}
