using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCode2022_Csharp.Utilities
{
    public class Helpers
    {
        public static void AssertEqual<T>(T a, T b, bool print = false)
        {
            if (!a.Equals(b) && print)
            {
                throw new Exception(String.Format("Test fallito. {0} diverso da {1}", a, b));
            }
            else
            {
                if (print)
                {
                    Console.WriteLine(String.Format("{0} uguale {1}. Test Ok", a, b));
                }
            }
        }
    }
}
