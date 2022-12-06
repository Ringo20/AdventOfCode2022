using AdventOfCode2022_Csharp.Utilities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace AdventOfCode2022_Csharp
{
    class Day6 : Day, IDay<int> 
    {
        public List<String> input { get; set; }

        public Dictionary<List<string>, List<int>> testInput { get; set; } 
        public bool print { get; set; }
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

        public void TestsSetup(bool print)
        {
            this.testInput = new Dictionary<List<string>, List<int>>()
            {
                {new List<string>(){ "mjqjpqmgbljsphdztnvjfqwrcgsmlb" }, new List<int>(){7, 19} },
                {new List<string>(){ "bvwbjplbgvbhsrlpgdmjqwftvncz"},new List<int> {5,23} },
                {new List<string>(){ "nppdvjthqldpwncqszvftbrmjlhg"},new List<int> {6,23} },
                {new List<string>(){ "nznrnfrfntjfmvfwmzdfjlvtqnbhcprsg"},new List<int> {10,29} },
                {new List<string>(){ "zcfzfwzzqfrljwzlrfnpqdbhtmscgvjw"},new List<int> {11,26} },
            };

            if (print) Console.WriteLine("Test Day6:");
            this.RunTests(this, print);
            this.input = Utilities.Helpers.GetInputList(6);
        }

    }
}
