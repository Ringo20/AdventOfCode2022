using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using AdventOfCode2022_Csharp.Utilities;

namespace AdventOfCode2022_Csharp
{
    public static class Day4
    {
        public static int Day4_p1(List<String> inputDay4)
        {
            int sum = 0;
            int seq1_start, seq1_end, seq2_start, seq2_end;

            inputDay4.ForEach(x => {
                seq1_start = Convert.ToInt32(x.Split(",")[0].ToString().Split("-")[0]);
                seq1_end = Convert.ToInt32(x.Split(",")[0].ToString().Split("-")[1]);
                seq2_start = Convert.ToInt32(x.Split(",")[1].ToString().Split("-")[0]);
                seq2_end = Convert.ToInt32(x.Split(",")[1].ToString().Split("-")[1]);

                if (
                    (seq2_start <= seq1_start && seq1_start <= seq2_end && seq2_start <= seq1_end && seq1_end <= seq2_end) ||
                    (seq1_start <= seq2_start && seq2_start <= seq1_end && seq1_start <= seq2_end && seq2_end <= seq1_end)
                )
                {
                    sum++;
                }

            });

            return sum;

        }
        public static int Day4_p2(List<String> inputDay4)
        {
            int sum = 0;
            int seq1_start, seq1_end, seq2_start, seq2_end;

            inputDay4.ForEach(x => {
                seq1_start = Convert.ToInt32(x.Split(",")[0].ToString().Split("-")[0]);
                seq1_end = Convert.ToInt32(x.Split(",")[0].ToString().Split("-")[1]);
                seq2_start = Convert.ToInt32(x.Split(",")[1].ToString().Split("-")[0]);
                seq2_end = Convert.ToInt32(x.Split(",")[1].ToString().Split("-")[1]);

                if (
                    ((seq2_start <= seq1_start && seq1_start <= seq2_end) || (seq2_start <= seq1_end && seq1_end <= seq2_end)) ||
                    ((seq1_start <= seq2_start && seq2_start <= seq1_end) || (seq1_start <= seq2_end && seq2_end <= seq1_end))
                )
                {
                    sum++;
                }

            });

            return sum;

        }

        public static void RunTestsDay4()
        {
            Day4_Part1_Test();
            Day4_Part2_Test();

        }
        public static void Day4_Part1_Test()
        {

            var tests = new List<Tuple<List<string>, int>>
            {
                new Tuple<List<string>, int>(new List<string>() {
                    "2-4,6-8",
                    "2-3,4-5",
                    "5-7,7-9",
                    "2-8,3-7",
                    "6-6,4-6",
                    "2-6,4-8",
                }, 2),
            };

            tests.ForEach(test => Helpers.AssertEqual(Day4_p1(test.Item1), test.Item2, true));
        }
        public static void Day4_Part2_Test()
        {

            var tests = new List<Tuple<List<string>, int>>
            {
                new Tuple<List<string>, int>(new List<string>() {
                    "2-4,6-8",
                    "2-3,4-5",
                    "5-7,7-9",
                    "2-8,3-7",
                    "6-6,4-6",
                    "2-6,4-8",
                }, 4),
            };

            tests.ForEach(test => Helpers.AssertEqual(Day4_p2(test.Item1), test.Item2, true));
        }
    }
}
