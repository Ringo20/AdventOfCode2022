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
                    { "a",1 },
                    { "b",2 }, 
                    { "c",3 },
                    { "d",4 }, 
                    { "e",5 }, 
                    { "f",6 }, 
                    { "g",7},
                    { "h",8},
                    { "i",9},
                    { "j",10},
                    { "k",11},
                    { "l",12},
                    { "m",13},
                    { "n",14},
                    { "o",15},
                    { "p",16},
                    { "q",17},
                    { "r",18},
                    { "s",19},
                    { "t",20},
                    { "u",21},
                    { "v",22},
                    { "w",23},
                    { "x",24},
                    { "y",25},
                    { "z",26}

                };
            }
            set { }
        }
        public static int Day3_p1(List<String> inputDay3)
        {
            int sum = 0;
            foreach (var item in inputDay3)
            {
                var backpack1 = item.Substring(0,item.Length/2) ;
                var backpack2 = item.Substring(item.Length/2, item.Length / 2);
                sum += backpack1.Intersect(backpack2)
                                    .Sum(x => 
                                        ItemsValues.GetValueOrDefault(x.ToString().ToLower()) + (x.ToString().ToLower() == x.ToString() ? 0 : 26)
                                        );

            }

            return sum;

        }
        public static int Day3_p2(List<String> inputDay3)
        {
            int sum = 0;
            for (int i = 0; i < inputDay3.Count; i= i+3)
            {
                var val = (inputDay3[i].Intersect(inputDay3[i + 1])).Intersect(inputDay3[i + 2]).First().ToString();
                sum += ItemsValues.GetValueOrDefault(val.ToLower()) + (val.ToLower() == val ? 0 : 26);
            }

            return sum;

        }


        public static void RunTestsDay3()
        {
            //Day3_Part1_Test();
            Day3_Part2_Test();

        }
        public static void Day3_Part1_Test()
        {

            var tests = new List<Tuple<List<string>, int>>
            {
                new Tuple<List<string>, int>(new List<string>() { "vJrwpWtwJgWrhcsFMMfFFhFp","jqHRNqRjqzjGDLGLrsFMfFZSrLrFZsSL","PmmdzqPrVvPwwTWBwg","wMqvLMZHhHMvwLHjbvcjnnSBnvTQFn","ttgJtRGJQctTZtZT","CrZsJsPPZsGzwwsLwLmpwMDw"}, 157),
            };

            tests.ForEach(test => Helpers.AssertEqual(Day3_p1(test.Item1), test.Item2,false));
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
