using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakProject
{
    class Program
    {
        static void Main(string[] args)
        {
            string testStringA = "testings";
            string testStringB = "please work please";

            Console.WriteLine(RemoveDupes(testStringA));
            Console.WriteLine(RemoveDupes(testStringB));

            string reverseString = "Reverse this string";
            Console.WriteLine(ReverseString(reverseString));

            int[] ArrA = new int[] { 1, 4, 20, 3, 10, 5 };
            int sumA = 33;
            int[]ArrB = new int[] { 1, 4, 0, 0, 3, 10, 5 };
            int sumB = 7;
            int[] ArrC = new int[] { 1, 4 };
            int sumC = 0;
            Console.WriteLine(FindSum(ArrA, sumA));
            Console.WriteLine(FindSum(ArrB, sumB));
            Console.WriteLine(FindSum(ArrC, sumC));
            Console.ReadLine();
        }

        public static string RemoveDupes(string MyString)
        {
            HashSet<char> checkedList = new HashSet<char>();
            string returnString = "";
            foreach(char c in MyString)
            {
                if (!checkedList.Contains(c))
                {
                    returnString += c;
                    checkedList.Add(c);
                }
            }
            return returnString;
        }

        public static string ReverseString(string paramString)
        {
            char[] returnCharArray = new char[paramString.Length];
            int arrCounter = 0;
            for(int i = paramString.Length-1; i >= 0; i--)
            {
                returnCharArray[arrCounter] = paramString[i];
                arrCounter++;
            }

            return new string(returnCharArray); 
        }

        public static string FindSum (int[] intArr, int desiredSum)
        {
            int SkipCounter = -1;
            int TakeCounter = 0;
            for( int i = 0; i < intArr.Length; i++)
            {
                SkipCounter++;
                TakeCounter = 0;
                for(int j = i ; j < intArr.Length; j++)
                {
                    TakeCounter++;
                    int[] CheckArray = intArr.Skip(SkipCounter).Take(TakeCounter).ToArray();

                    if (CheckArray.Sum() == desiredSum)
                    {
                        return "Sum found at indexes " + i + " and " + j;
                    }
                }
            }
            return "No Sum Found";
        }
    }
}
