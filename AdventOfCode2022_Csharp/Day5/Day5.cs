using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace AdventOfCode2022_Csharp
{
    public static class Day5
    {

        public static List<List<String>> stacks;
        public static bool isTest = false;

        public static string Day5_p1(List<String> inputDay5)
        {
            string res = "";
            List<int> move;
            stacks = buildStack();

            inputDay5.ForEach(x =>
            {
                move = getMove(x);
                stacks[move[2]].AddRange(stacks[move[1]].TakeLast(move[0]).Reverse());
                stacks[move[1]].RemoveRange(stacks[move[1]].Count - move[0], move[0]);
            });

            stacks.ForEach(x =>
            {
                res += x.TakeLast(1).FirstOrDefault();
            });

            return res;

        }

        public static string Day5_p2(List<String> inputDay5)
        {
            string res = "";
            List<int> move;
            stacks = buildStack();

            inputDay5.ForEach(x =>
            {
                move = getMove(x);
                stacks[move[2]].AddRange(stacks[move[1]].TakeLast(move[0]));
                stacks[move[1]].RemoveRange(stacks[move[1]].Count - move[0], move[0]);
            });

            stacks.ForEach(x =>
            {
                res += x.TakeLast(1).FirstOrDefault();
            });

            return res;

        }


        public static List<List<String>> buildStack()
        {
            List<List<String>> stacks;
            if (!isTest)
            {
                stacks = new List<List<String>>()
             {
                 new List<String>(){ "B","P","N","Q","H","D","R","T" },
                 new List<String>(){ "W","G","B","J","T","V" },
                 new List<String>(){ "N","R","H","D","S","V","M","Q" },
                 new List<String>(){ "P","Z","N","M","C" },
                 new List<String>(){ "D","Z","B" },
                 new List<String>(){ "V","C","W","Z" },
                 new List<String>(){ "G","Z","N","C","V","Q","L","S" },
                 new List<String>(){ "L","G","J","M","D","N","V" },
                 new List<String>(){ "T","P","M","F","Z","C","G" }
             };

            }
             
            else
            {
                stacks = new List<List<String>>()
            {
                new List<String>(){ "Z","N" },
                new List<String>(){ "M","C","D" },
                new List<String>(){ "P" },
            };

            }
            return stacks;
        }

        public static List<String> getTestMoves()
        {
            List<String> moves = new List<String>()
            {
                "move 1 from 2 to 1",
                "move 3 from 1 to 3",
                "move 2 from 2 to 1",
                "move 1 from 1 to 2"

            };
            return moves;
        }

        public static List<int> getMove(String stringMove)
        {
            List<int> move = new List<int>();
            //move 5 from 4 to 9
            move.Add(Convert.ToInt32(stringMove.Split(" ")[1]));
            move.Add(Convert.ToInt32(stringMove.Split(" ")[3])-1);
            move.Add(Convert.ToInt32(stringMove.Split(" ")[5])-1);
            return move;
        }

        public static void RunTestsDay5()
        {
            Day5_Part2_Test();

        }
        public static void Day5_Part2_Test()
        {

            var tests = new List<Tuple<List<string>, string>>
            {
                new Tuple<List<string>, string>(getTestMoves(), "MCD"),
            };
            isTest = true;
            tests.ForEach(test => Utilities.Helpers.AssertEqual(Day5_p2(test.Item1), test.Item2, true));
            isTest = false;
        }
    }
}
