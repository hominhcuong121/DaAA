using System;
using System.Collections.Generic;
using System.Linq;

namespace EIPYRAMID
{
    class Program
    {
        static void Main(string[] args)
        {
            var T = NextInt();
            for (var t = 0; t < T; t++)
            {
                var id = NextInt();
                var heights = new List<int>();
                for (var i = 0; i < 12; i++)
                {
                    heights.Add(NextInt());
                }

                var total = 0;
                var max = heights.Max();
                while (max > 0)
                {
                    var newHeights = new List<int>();
                    for (int i = 0; i < heights.Count; i++)
                    {
                        if (heights[i] < max)
                        {
                            newHeights.Add(heights[i]);
                        }
                        else if (i == 0 || heights[i - 1] < max)
                        {
                            total++;
                        }
                    }
                    heights = newHeights;
                    max = heights.Max();
                }

                Console.WriteLine(id + " " + total);
            }
        }

        #region INPUT WRAPPER
        static int s_index = 0;
        static string[] s_tokens;

        private static string Next()
        {
            while (s_tokens == null || s_index == s_tokens.Length)
            {
                s_tokens = Console.ReadLine().Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                s_index = 0;
            }
            return s_tokens[s_index++];
        }

        private static bool HasNext()
        {
            while (s_tokens == null || s_index == s_tokens.Length)
            {
                s_tokens = null;
                s_index = 0;
                var nextLine = Console.ReadLine();
                if (nextLine != null)
                {
                    s_tokens = nextLine.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                }
                else
                {
                    return false;
                }

            }
            return s_tokens != null && s_tokens.Length > 0;
        }

        private static int NextInt()
        {
            return Int32.Parse(Next());
        }

        private static long NextLong()
        {
            return Int64.Parse(Next());
        }

        #endregion
    }
}
