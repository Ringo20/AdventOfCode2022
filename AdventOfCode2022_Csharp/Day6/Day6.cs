using AdventOfCode2022_Csharp.Utilities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace AdventOfCode2022_Csharp
{
    class Day6 : IDay<int>
    {
        List<String> input { get; set; }
        bool print { get; set; }
        public Day6()
        {
            this.input = Utilities.Helpers.GetInputList(6);
            this.print = false;
        }
        public int Part1()
        {
            var str = "";

            input.ForEach(x => str += x);

            for (int i = 0; i < str.Length - 3; i++)
            {
                if (new List<char>() { str[i], str[i + 1], str[i + 2], str[i + 3] }.Distinct().Count() == 4)
                {
                    return i+4;
                } 
            }
            return 0;
        }

        public int Part2()
        {
            var str = "";

            input.ForEach(x => str += x);

            for (int i = 0; i < str.Length - 14; i++)
            {
                var lst = new List<char>();
                Enumerable.Range(i, 14).ToList().ForEach(l =>{lst.Add(str[l]);});
                if (lst.Distinct().Count() == 14)
                {
                    return i + 14;
                }
                
            }
            return 0;
        }

        public void RunTests(bool print)
        {
            this.print = print;
            this.input = new List<string>() { "mjqjpqmgbljsphdztnvjfqwrcgsmlb" };
            if (print) Console.WriteLine("Test Day6:");
            Day6_Part1_Test();
            Day6_Part2_Test();
            this.input = Utilities.Helpers.GetInputList(6);
        }

        private void Day6_Part1_Test()
        {

            new List<int> {7}.ForEach(testResult => Helpers.AssertEqual(Part1(), testResult, print));
        }

        private void Day6_Part2_Test()
        {

            new List<int> { 19 }.ForEach(testResult => Helpers.AssertEqual(Part2(), testResult, print));
        }
    }
}
