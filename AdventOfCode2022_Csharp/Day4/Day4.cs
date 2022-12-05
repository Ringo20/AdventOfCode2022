using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using AdventOfCode2022_Csharp.Utilities;
using System.IO;

namespace AdventOfCode2022_Csharp
{
    public class Day4 : Utilities.IDay<int>
    {
        List<String> input { get; set; }
        bool print { get; set; }
        public Day4()
        {
            this.input = File.ReadAllLines("Input/input_Day4.txt").ToList();
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

        public void RunTests(bool print)
        {
            this.input = new List<string>() {
                    "2-4,6-8",
                    "2-3,4-5",
                    "5-7,7-9",
                    "2-8,3-7",
                    "6-6,4-6",
                    "2-6,4-8",
                };
            this.print = print;
            if (print) Console.WriteLine("Test Day4:");
            Day4_Part1_Test();
            Day4_Part2_Test();
            this.print = !print;
            this.input = File.ReadAllLines("Input/input_Day4.txt").ToList();

        }
        public void Day4_Part1_Test()
        {

            new List<int> { 2 }.ForEach(testResult => Helpers.AssertEqual(Part1(), testResult, print));
        }
        public void Day4_Part2_Test()
        {
            new List<int> { 4 }.ForEach(testResult => Helpers.AssertEqual(Part2(), testResult, print));
        }
    }
}
