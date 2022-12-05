using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCode2022_Csharp.Utilities
{
    interface IDay<T>
    {
         T Part1 ();
         T Part2();

        void RunTests(bool print);
        

    }
}
