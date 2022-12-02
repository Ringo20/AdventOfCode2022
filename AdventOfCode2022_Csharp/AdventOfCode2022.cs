using System;
using System.IO;
using System.Linq;

namespace AdventOfCode2022_Csharp
{
    class AdventOfCode2022
    {
        static void Main(string[] args)
        {
            var inputDay1 = File.ReadAllLines("Input/input_Day1.txt").ToList();
            var inputDay2 = File.ReadAllLines("Input/input_Day2.txt").ToList();


            var d1p1 = Day1.Day1_p1(inputDay1);
            var d1p2 = Day1.Day1_p2(inputDay1);
            var d2p1 = Day2.Day2_p1(inputDay2);
            var d2p2 = Day2.Day2_p2(inputDay2);

            Console.WriteLine(string.Format("Day1Part1: {0}", d1p1));
            Console.WriteLine(string.Format("Day1Part2: {0}", d1p2));
            Console.WriteLine(string.Format("Day2Part1: {0}", d2p1));
            Console.WriteLine(string.Format("Day2Part2: {0}", d2p2));

            Console.Read();
        }
    }
}
