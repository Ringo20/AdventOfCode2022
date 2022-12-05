using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using AdventOfCode2022_Csharp.Utilities;

namespace AdventOfCode2022_Csharp
{
    class Day1 : IDay<int>
    {
        List<String> input { get; set; }

        public Day1()
        {
            this.input = File.ReadAllLines("Input/input_Day1.txt").ToList();
        }


        public int Part1()
        {

            var lstSum = getSumsList(input);
            return lstSum.Max();
        }

        public int Part2()
        {
            var lstSum = getSumsList(input);

            var pippo = lstSum.OrderByDescending(x => x).Take(3).Count();
            return lstSum.OrderByDescending(x => x).Take(3).Sum();
        }

        public void RunTests(bool print) { }

        public static List<int> getSumsList(List<String> inputDay1)
        {
            var lstSum = new List<int>();
            int sum = 0;
            for (int i = 0; i < inputDay1.Count; i++)
            {
                if (!string.IsNullOrEmpty(inputDay1[i]))
                {
                    sum += Convert.ToInt32(inputDay1[i]);
                }
                else
                {
                    lstSum.Add(sum);
                    sum = 0;
                }
            }

            return lstSum;
        }
    }
}
