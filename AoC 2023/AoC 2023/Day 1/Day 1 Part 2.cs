using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AoC_2023.Day_1
{
    internal class Day_1_Part_2
    {
        public static void Main()
        {
            string input_Path = $"C:\\Users\\User\\Documents\\Personal Projects\\Advent-of-Code-2023\\AoC 2023\\AoC 2023\\Day 1\\input.txt";
            var input = File.ReadLines(input_Path);

            List<string> s_Numbers = new List<string> { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            int total_Sum = 0;

            //Get line by line from input file
            foreach (string line in input)
            {
                List<char> numbers = new List<char> { };
                string curr = "";

                //iterate through line
                foreach (char c in line)
                {
                    if (Char.IsDigit(c))
                    {
                        numbers.Add(c);
                    }

                    curr += c;
                }

                //Get first and last numbers from the list
                string calibration_Val = "";
                calibration_Val += numbers[0];
                calibration_Val += numbers[numbers.Count - 1];

                total_Sum += int.Parse(calibration_Val);
            }

            Console.WriteLine(total_Sum);
        }
    }
}
