using System;
using System.Collections.Generic;
using System.Text;
using AdventOfCode2022_Csharp.Utilities;
using System.Linq;
using System.IO;

namespace AdventOfCode2022_Csharp
{
    public class Day3 : Day, Utilities.IDay<int>
    {
        public List<String> input { get; set; }
        public bool print { get; set; }
        public Dictionary<List<string>, List<int>> testInput;
        public Day3()
        {
            this.input = Utilities.Helpers.GetInputList(3);
            this.print = true;
        }
        public static Dictionary<string, int> ItemsValues
        {
            get
            {
                return new Dictionary<string, int>
                {
                    { "a",1 },{ "A",27 },
                    { "b",2 },{ "B",28 },
                    { "c",3 },{ "C",29 },
                    { "d",4 },{ "D",30 },
                    { "e",5 },{ "E",31 },
                    { "f",6 },{ "F",32 },
                    { "g",7}, { "G",33 },
                    { "h",8}, { "H",34 },
                    { "i",9}, { "I",35 },
                    { "j",10},{ "J",36 },
                    { "k",11},{ "K",37 },
                    { "l",12},{ "L",38 },
                    { "m",13},{ "M",39 },
                    { "n",14},{ "N",40 },
                    { "o",15},{ "O",41 },
                    { "p",16},{ "P",42 },
                    { "q",17},{ "Q",43 },
                    { "r",18},{ "R",44 },
                    { "s",19},{ "S",45 },
                    { "t",20},{ "T",46 },
                    { "u",21},{ "U",47 },
                    { "v",22},{ "V",48 },
                    { "w",23},{ "W",49 },
                    { "x",24},{ "X",50 },
                    { "y",25},{ "Y",51 },
                    { "z",26},{ "Z",52 }

                };
            }
            set { }
        }
        public static int Day3_p1_old(List<String> inputDay3)
        {
            int sum = 0;
            foreach (var item in inputDay3)
            {
                var backpack1 = item.Substring(0,item.Length/2) ;
                var backpack2 = item.Substring(item.Length/2, item.Length / 2);
                sum += backpack1.Intersect(backpack2)
                                    .Sum(x => 
                                        ItemsValues.GetValueOrDefault(x.ToString())
                                        );

            }

            return sum;

        }
        public int Part1()
        {
            int sum = 0;
            foreach (var item in input)
            {
                var backpack1 = item.Substring(0, item.Length / 2);
                var backpack2 = item.Substring(item.Length / 2, item.Length / 2);
                sum += backpack1.Intersect(backpack2)
                                    .Sum(x => char.ToLower(x) - 'a' + (x.ToString().ToLower() == x.ToString() ? 1 :27));

            }

            return sum;

        }
        public int Part2()
        {
            int sum = 0;
            for (int i = 0; i < input.Count; i= i+3)
            {
                var val = (input[i].Intersect(input[i + 1])).Intersect(input[i + 2]).First();
                sum += char.ToLower(val) - 'a' + (char.ToLower(val) == val ? 1 : 27);
            }
            return sum;

        }


        public void TestsSetup(bool print)
        {
            this.testInput = new Dictionary<List<string>, List<int>>()
            {
                {
                    new List<string>() { "vJrwpWtwJgWrhcsFMMfFFhFp", "jqHRNqRjqzjGDLGLrsFMfFZSrLrFZsSL", "PmmdzqPrVvPwwTWBwg", "wMqvLMZHhHMvwLHjbvcjnnSBnvTQFn", "ttgJtRGJQctTZtZT", "CrZsJsPPZsGzwwsLwLmpwMDw" } 
                    ,new List<int>(){ 157,70}
                }
            };

            if (print) Console.WriteLine("Test Day3:");
            this.RunTests(this, print);
            this.input = Utilities.Helpers.GetInputList(3);

        }
  

    }
}
