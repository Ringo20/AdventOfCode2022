using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using AdventOfCode2022_Csharp.Utilities;
using System.IO;

namespace AdventOfCode2022_Csharp
{
    public class Day5 : Utilities.IDay<string>
    {

        public List<List<String>> stacks;
        public bool isTest = false;
        List<String> input { get; set; }
        bool print { get; set; }
        public Day5()
        {
            this.input = File.ReadAllLines("Input/input_Day5.txt").ToList();
            this.print = false;
        }
        public string Part1()
        {
            string res = "";
            List<int> move;
            stacks = buildStack();

            input.ForEach(x =>
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

        public string Part2()
        {
            string res = "";
            List<int> move;
            stacks = buildStack();

            input.ForEach(x =>
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


        public List<List<String>> buildStack()
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

        public List<String> getTestMoves()
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

        public List<int> getMove(String stringMove)
        {
            List<int> move = new List<int>();
            //move 5 from 4 to 9
            move.Add(Convert.ToInt32(stringMove.Split(" ")[1]));
            move.Add(Convert.ToInt32(stringMove.Split(" ")[3])-1);
            move.Add(Convert.ToInt32(stringMove.Split(" ")[5])-1);
            return move;
        }

        public void TestsSetup(bool print)
        {
            this.input = getTestMoves();
            this.print = print;

            isTest = true;
            if (print) Console.WriteLine("Test Day5:");
            Day5_Part2_Test();
            isTest = false;
            this.input = File.ReadAllLines("Input/input_Day5.txt").ToList();

        }
        public void Day5_Part2_Test()
        {

            new List<string> { "MCD" }.ForEach(testResult => Helpers.AssertEqual(Part2(), testResult, print));
            
        }

   
    }
}
