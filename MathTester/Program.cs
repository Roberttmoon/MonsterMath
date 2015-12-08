using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MonsterMath;

namespace MathTester
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Roman Numarl to Number!");
            string myRoman = devCodeCampExtendedMath.intToRoman(4522);
            Console.WriteLine(devCodeCampExtendedMath.romanToInt(ref myRoman));
            Console.WriteLine();
            Console.WriteLine("List of happy Numbers!");
            Console.WriteLine(string.Join(",", devCodeCampExtendedMath.getHappyNumbersUpToo(1000)));
            Console.WriteLine();
            Console.WriteLine("Gratest Common Factor");
            Console.WriteLine(devCodeCampExtendedMath.findGreatistCommonFactor(43224, 553432));
            Console.WriteLine();
            Console.WriteLine("Vampire Numbers");
            Console.WriteLine(devCodeCampExtendedMath.numberOfVamps(10));
            Console.ReadLine();
        }
    }
}
