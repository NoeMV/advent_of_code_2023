using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace advent_of_code_2023.Day1
{
    public class Part2
    {
        public static void Solve()
        {
            int Result = 0;
            string[] Lines = File.ReadAllLines("C:\\Apps\\advent_of_code\\day_1\\input.txt");

            Dictionary<string, string> matcher = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                {"one", "1"},
                {"two", "2"},
                {"three", "3"},
                {"four", "4"},
                {"five", "5"},
                {"six", "6"},
                {"seven", "7"},
                {"eight", "8"},
                {"nine", "9"},
            };

            string pattern = string.Join("|", matcher.Keys);

            foreach (var Line in Lines)
            {

                Regex rg = new Regex(pattern);

                var res = rg.Matches(Line);

                string TextToNumbersFirstFilter = rg.Replace(Line, match => matcher[match.Value] + match.Value.Substring(match.Length - 1));
                string TextToNumbers = rg.Replace(TextToNumbersFirstFilter, match => matcher[match.Value] + match.Value.Substring(match.Length - 1));

                string OnlyNumbers = Regex.Replace(TextToNumbers, @"[a-zA-Z]+", "");
                char[] ArrOfNumbers = OnlyNumbers.ToArray();
                string NumbersCombined = ArrOfNumbers[0].ToString() + ArrOfNumbers[ArrOfNumbers.Length - 1].ToString();

                int InputResult = int.Parse(NumbersCombined);

                Result += InputResult;
            }

            Console.WriteLine(Result);
        }
    }
}
