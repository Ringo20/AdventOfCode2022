using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using AdventOfCode2022_Csharp.Utilities;
using System.IO;

namespace AdventOfCode2022_Csharp
{
    public class Day4 : Day, Utilities.IDay<int>
    {
        public List<String> input { get; set; }
        public Dictionary<List<string>, List<int>> testInput { get; set; }
        public bool print { get; set; }
        public Day4()
        {
            this.input = Utilities.Helpers.GetInputList(4);
            this.print = false;
        }
        public  int Part1()
        {
            int sum = 0;
            int seq1_start, seq1_end, seq2_start, seq2_end;

            input.ForEach(x => {
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
        public int Part2()
        {
            int sum = 0;
            int seq1_start, seq1_end, seq2_start, seq2_end;

            input.ForEach(x => {
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

        public void TestsSetup(bool print)
        {
            this.testInput = new Dictionary<List<string>, List<int>>()
            {
                {
                    new List<string>() {
                    "2-4,6-8",
                    "2-3,4-5",
                    "5-7,7-9",
                    "2-8,3-7",
                    "6-6,4-6",
                    "2-6,4-8",
                    } , new List<int>(){2,4}
                }
            };
            if (print) Console.WriteLine("Test Day4:");
            this.RunTests(this, print);
            this.input = Utilities.Helpers.GetInputList(4);

        }

    }
}
