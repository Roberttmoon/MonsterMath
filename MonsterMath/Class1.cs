using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterMath
{
    public static class devCodeCampExtendedMath
    {
        public static string intToRoman(int number)
        {
            // from http://dotnet-snippets.de/snippet/roemische-zahlen/1457 not mine :(
            StringBuilder result = new StringBuilder();
            int[] digitsDivideByValues = { 1, 4, 5, 9, 10, 40, 50, 90, 100, 400, 500, 900, 1000 };
            string[] romanDigits = { "I", "IV", "V", "IX", "X", "XL", "L", "XC", "C", "CD", "D", "CM", "M" };
            while (number > 0)
            {
                for (int i = digitsDivideByValues.Count() - 1; i >= 0; i--)
                    if (number / digitsDivideByValues[i] >= 1)
                    {
                        number -= digitsDivideByValues[i];
                        result.Append(romanDigits[i]);
                        break;
                    }
            }
            return result.ToString();
        }

        public static int makeHappyNumbersUpTo(int myNum)
        {
            int myHappy=1;
            return myHappy;
        }
        public static int findGreatistCommonFactor(int numb1, int numb2)
        {
            while (numb1 != numb2)
            {
                if (numb1 > numb2)
                {
                    numb1 = numb1 - numb2;
                }
                else if (numb2 > numb1)
                {
                    numb2 = numb2 - numb1;
                }
            }
            return numb1;
        }
        public static void theThirdOne()
        {

        }



    }
}
