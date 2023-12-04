using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.IO;

namespace advent_of_code_2023.Day1
{
    public class Part1
    {
        public static void Solve()
        {
            int Result = 0;
            string[] Lines = File.ReadAllLines("C:\\Apps\\advent_of_code\\day_1\\input.txt");

            string pattern = @"[a-zA-Z]+";

            foreach (var Line in Lines)
            {
                string OnlyNumbers = Regex.Replace(Line, pattern, "");
                char[] ArrOfNumbers = OnlyNumbers.ToArray();
                string NumbersCombined = ArrOfNumbers[0].ToString() + ArrOfNumbers[ArrOfNumbers.Length - 1].ToString();

                int InputResult = int.Parse(NumbersCombined);

                Result += InputResult;
            }

            Console.WriteLine(Result);
        }
    }
}
