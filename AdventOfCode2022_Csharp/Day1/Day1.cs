using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using AdventOfCode2022_Csharp.Utilities;

namespace AdventOfCode2022_Csharp
{
    class Day1 : Day, IDay<int>
    {
        public List<String> input { get; set; }
        

        public Day1()
        {
            this.input = Helpers.GetInputList(1);
        }


        public int Part1()
        {

            return getSumsList(input).Max();
        }

        public int Part2()
        {
            return getSumsList(input).OrderByDescending(x => x).Take(3).Sum();
            
        }

        public void TestsSetup(bool print) { }

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
