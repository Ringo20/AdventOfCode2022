using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace AdventOfCode2022_Csharp.Utilities
{
    public class Helpers
    {
        public static void AssertEqual<T>(T a, T b, bool print = false)
        {
            if (!a.Equals(b) && print)
            {
                throw new Exception(String.Format("    Test fallito. {0} diverso da {1}", a, b));
            }
            else
            {
                if (print)
                {
                    Console.WriteLine(String.Format("     {0} uguale {1}. Test Ok", a, b));
                }
            }
        }

        public static List<string> GetInputList(int dayID)
        {
            var res = new List<string>();
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(GetUrlByDayId(dayID));
            request.Headers.Add("Cookie", "session=53616c7465645f5f7c4b5521fd5d78291676efdb7cd59f023a9f0e9289c045ba3741ff3eecd405a5d5f28808f07899d07cddbffb93e12fe46d4a100d76edca71");
            request.Method = "GET";

            if (!File.Exists(string.Format("Input/input_Day{0}.txt", dayID)))
            {
                try
                {
                    HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                    using (var reader = new System.IO.StreamReader(response.GetResponseStream()))
                    {
                        var line = "";
                        while ((line = reader.ReadLine()) != null)
                        {
                            res.Add(line);
                        }

                        File.WriteAllLines(string.Format("Input/input_Day{0}.txt", dayID), res);
                        File.WriteAllLines(string.Format("../../../Day{0}/input_Day{0}.txt", dayID), res);

                    }
                }
                catch (Exception ex)
                {

                    Console.WriteLine(string.Format("Exception: {0}", ex));
                }
            }
            else
            {
                res = File.ReadAllLines(string.Format("Input/input_Day{0}.txt", dayID)).ToList();
            }
            return res;
        }


        private static string GetUrlByDayId(int dayID)
        {
            var res = string.Format("https://adventofcode.com/2022/day/{0}/input", dayID); ;
            return res;
        }
    }
}
