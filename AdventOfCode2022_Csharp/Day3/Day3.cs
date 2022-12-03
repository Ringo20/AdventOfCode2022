using System;
using System.Collections.Generic;
using System.Text;
using AdventOfCode2022_Csharp.Utilities;
using System.Linq;

namespace AdventOfCode2022_Csharp
{
    public static class Day3
    {
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
        public static int Day3_p1(List<String> inputDay3)
        {
            int sum = 0;
            foreach (var item in inputDay3)
            {
                var backpack1 = item.Substring(0, item.Length / 2);
                var backpack2 = item.Substring(item.Length / 2, item.Length / 2);
                sum += backpack1.Intersect(backpack2)
                                    .Sum(x => char.ToLower(x) - 'a' + (x.ToString().ToLower() == x.ToString() ? 1 :27));

            }

            return sum;

        }
        public static int Day3_p2(List<String> inputDay3)
        {
            int sum = 0;
            for (int i = 0; i < inputDay3.Count; i= i+3)
            {
                var val = (inputDay3[i].Intersect(inputDay3[i + 1])).Intersect(inputDay3[i + 2]).First();
                sum += char.ToLower(val) - 'a' + (char.ToLower(val) == val ? 1 : 27);
            }
            return sum;

        }


        public static void RunTestsDay3()
        {
            Day3_Part1_Test();
            Day3_Part2_Test();

        }
        public static void Day3_Part1_Test()
        {

            var tests = new List<Tuple<List<string>, int>>
            {
                new Tuple<List<string>, int>(new List<string>() { "vJrwpWtwJgWrhcsFMMfFFhFp","jqHRNqRjqzjGDLGLrsFMfFZSrLrFZsSL","PmmdzqPrVvPwwTWBwg","wMqvLMZHhHMvwLHjbvcjnnSBnvTQFn","ttgJtRGJQctTZtZT","CrZsJsPPZsGzwwsLwLmpwMDw"}, 157),
            };

            tests.ForEach(test => Helpers.AssertEqual(Day3_p1(test.Item1), test.Item2,true));
        }
        public static void Day3_Part2_Test()
        {

            var tests = new List<Tuple<List<string>, int>>
            {
                new Tuple<List<string>, int>(new List<string>() { "vJrwpWtwJgWrhcsFMMfFFhFp","jqHRNqRjqzjGDLGLrsFMfFZSrLrFZsSL","PmmdzqPrVvPwwTWBwg","wMqvLMZHhHMvwLHjbvcjnnSBnvTQFn","ttgJtRGJQctTZtZT","CrZsJsPPZsGzwwsLwLmpwMDw"}, 70),
            };

            tests.ForEach(test => Helpers.AssertEqual(Day3_p2(test.Item1), test.Item2, true));
        }

    }
}
