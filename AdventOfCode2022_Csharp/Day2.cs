﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace AdventOfCode2022_Csharp
{
    public static class Day2
    {
        public static Dictionary<string,int> RockPaperScissor { get {
                return new Dictionary<string, int>
                {
                    { "A",1 }, //rock
                    { "B",2 }, //paper
                    { "C",3 }, //scissor
                    { "X",1 }, //rock
                    { "Y",2 }, //paper
                    { "Z",3 }, //scissor
                    { "Rock", 1},
                    { "Paper",2},
                    { "Scissor",3}

                };
            } set { } }
        public static int Day2_p1(List<String> inputDay2)
        {
            return inputDay2.Sum(x => fightResult(x.Split(" ")[0], x.Split(" ")[1],true));

        }
        public static int Day2_p2(List<String> inputDay2)
        {
            return inputDay2.Sum(x => fightResult(x.Split(" ")[0], x.Split(" ")[1], false));

        }


        public static int fightResult(string f1, string f2, bool part1)
        {
            int val = RockPaperScissor.GetValueOrDefault(f2);
            switch (f1)
            {
                case "A":
                    switch (f2)
                    {

                        case "X":
                            if(part1) Console.WriteLine(string.Format("Rock vs Rock. Draw"));
                            else      Console.WriteLine(string.Format("Gotta lose to Rock, will pick Scissor. Scissor + Lose = {0} + {1} ", RockPaperScissor.GetValueOrDefault("Scissor"), 0));
                            return part1 ? val + 3 : RockPaperScissor.GetValueOrDefault("Scissor");
                        case "Y":
                            if (part1) Console.WriteLine(string.Format("Rock vs Paper. I win"));
                            else Console.WriteLine(string.Format("Need to draw to Rock, will pick Rock. Rock + Draw = {0} + {1} ", RockPaperScissor.GetValueOrDefault("Rock"), 3));
                            return part1 ? val + 6 : RockPaperScissor.GetValueOrDefault("Rock") + 3;
                        case "Z":
                            if (part1) Console.WriteLine(string.Format("Rock vs Scissor. I lose"));
                            else Console.WriteLine(string.Format("Gotta win to Rock, will pick Paper. Paper + win = {0} + {1} ", RockPaperScissor.GetValueOrDefault("Paper"), 6));
                            return part1 ? val : RockPaperScissor.GetValueOrDefault("Paper") + 6;
                    }
                    break;
                case "B":
                    switch (f2)
                    {
                        case "X":
                            if (part1) Console.WriteLine(string.Format("Paper vs Rock. i Lose"));
                            else Console.WriteLine(string.Format("Gotta lose to Paper so will pick Rock. I Lose. Rock + Lose = {0} + {1} ", RockPaperScissor.GetValueOrDefault("Rock"), 0));
                            return part1 ? val : RockPaperScissor.GetValueOrDefault("Rock");
                        case "Y":
                            if (part1) Console.WriteLine(string.Format("Paper vs Paper. Draw"));
                            else Console.WriteLine(string.Format("Gotta draw to Paper, will pick Paper. Paper + Draw = {0} + {1} ", RockPaperScissor.GetValueOrDefault("Paper"), 3));
                            return part1 ? val + 3 : RockPaperScissor.GetValueOrDefault("Paper") + 3;
                        case "Z":
                            if (part1) Console.WriteLine(string.Format("Paper vs Scissor. i Win"));
                            else Console.WriteLine(string.Format("Gotta win to Paper, will pick Scissor. Paper + Win = {0} + {1} ", RockPaperScissor.GetValueOrDefault("Scissor"), 6));
                            return part1? val + 6: RockPaperScissor.GetValueOrDefault("Scissor") + 6;
                    }
                    break;
                case "C":
                    switch (f2)
                    {
                        case "X":
                            if (part1) Console.WriteLine(string.Format("Scissor vs Rock. i win"));
                            else Console.WriteLine(string.Format("Gotta lose to Scissor, will pick Paper. Paper + Lose = {0} + {1} ", RockPaperScissor.GetValueOrDefault("Paper"), 0));
                            return part1? val + 6 : RockPaperScissor.GetValueOrDefault("Paper");
                        case "Y":
                            if (part1) Console.WriteLine(string.Format("Scissor vs Paper. i Lose"));
                            else Console.WriteLine(string.Format("Gotta draw to Scissor, will pick scissor. Scissor + Draw = {0} + {1} ", RockPaperScissor.GetValueOrDefault("Scissor"), 3));
                            return part1 ? val : RockPaperScissor.GetValueOrDefault("Scissor") + 3;
                        case "Z":
                            if (part1) Console.WriteLine(string.Format("Scissor vs Scissor. draw"));
                            else Console.WriteLine(string.Format("Gotta win to Scissor, will pick Rock. Scissor + win = {0} + {1} ", RockPaperScissor.GetValueOrDefault("Rock"), 6));
                            return part1 ? val + 3 : RockPaperScissor.GetValueOrDefault("Rock") + 6;
                    }
                    break;
            }
            return 0;
        }

    }
}
