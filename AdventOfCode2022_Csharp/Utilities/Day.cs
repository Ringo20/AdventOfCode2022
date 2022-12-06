using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdventOfCode2022_Csharp.Utilities
{
    public class Day
    {
        public void RunTests(dynamic day, bool print)
        {
            var dict = Convert.ChangeType(day.testInput, day.testInput.GetType());

            foreach (var test in dict)
            {
                day.input = test.Key;
                Helpers.AssertEqual(day.Part1(), test.Value[0], print);
                Helpers.AssertEqual(day.Part2(), test.Value[1], print);
            }
        }

    }
}
