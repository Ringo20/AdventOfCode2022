using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using AdventOfCode2022_Csharp.Utilities;

namespace AdventOfCode2022_Csharp
{
    class AdventOfCode2022
    {
        static void Main(string[] args)
        {

            List<string> daysToRun = new List<string>(){ "1" ,"2","3","4","5"};

            foreach (var day in daysToRun)
            {
                var daystring = "AdventOfCode2022_Csharp.Day"+ day;
                var dayType = Type.GetType(daystring);
                var dayClass = Activator.CreateInstance(dayType);
                dynamic dynamicDayClass = dayClass;

                dynamicDayClass.RunTests(true);
                Console.WriteLine(string.Format("Day{0} Part1: {1}", day, dynamicDayClass.Part1()));
                Console.WriteLine(string.Format("Day{0} Part2: {1}", day, dynamicDayClass.Part2()));
                
            }
            Console.Read();
        }
    }
}
