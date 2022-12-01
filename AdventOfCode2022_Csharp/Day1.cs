using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace AdventOfCode2022_Csharp
{
    public static class Day1
    {
        public  static int Day1_p1(List<String> inputDay1)
        {

            var lstSum = getSumsList(inputDay1);
            return lstSum.Max();
            
        }

        public static int Day1_p2(List<String> inputDay1)
        {

            var lstSum = getSumsList(inputDay1);

            var pippo = lstSum.OrderByDescending(x => x).Take(3).Count();
            return lstSum.OrderByDescending(x => x).Take(3).Sum();


        }

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
