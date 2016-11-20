using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EILETTERS
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = Console.ReadLine();
            string text = Console.ReadLine();
            int c = 0;
            int count = 0;
            StringBuilder res = new StringBuilder();
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i].Equals(pattern[c]))
                {
                    count++;
                    res.Append(text[i]);
                    c++;
                }
                if (c == pattern.Length)
                {
                    c = 0;
                }
            }
            Console.Write(count / pattern.Length);
            Console.ReadKey();
        }
        #region
        static int s_index = 0;
        static List<string> s_tokens;

        private static string Next()
        {
            while (s_tokens == null || s_index == s_tokens.Count)
            {
                s_tokens = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                s_index = 0;
            }
            return s_tokens[s_index++];
        }

        private static bool HasNext()
        {
            while (s_tokens == null || s_index == s_tokens.Count)
            {
                s_tokens = null;
                s_index = 0;
                var nextLine = Console.ReadLine();
                if (nextLine != null)
                {
                    s_tokens = nextLine.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                }
                else
                {
                    return false;
                }

            }
            return s_tokens.Count > 0;
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
