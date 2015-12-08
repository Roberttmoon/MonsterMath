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
        public static string romanToInt(ref string romanNumb)
        {
            Dictionary<char, int> romanNumberDict = new Dictionary<char, int> { { 'I', 1 }, { 'V', 5 }, { 'X', 10 }, { 'L', 50 }, { 'C', 100 }, { 'D', 500 }, { 'M', 1000 } };
            int returnValue = 0, pastNumber = 0, currentNumber;

            foreach (char letter in romanNumb)
            {
                if (!romanNumberDict.ContainsKey(letter))
                    return "0";
                currentNumber = romanNumb[letter];
                returnValue += currentNumber;
                if (currentNumber != 0 && pastNumber < currentNumber)
                {
                    if (pastNumber == 1 && (currentNumber == 5 || currentNumber == 10)
                        || pastNumber == 10 && (currentNumber == 50 || currentNumber == 100)
                        || pastNumber == 100 && (currentNumber == 500 || currentNumber == 1000))
                        returnValue -= 2 * pastNumber;
                    else
                        return "0";
                    pastNumber = currentNumber;
                }
            }
                return returnValue.ToString();      
            
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
