using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE_0021
{
    class Program
    {
        static void Main(string[] args)
        {
            long countLine = 0;
            long countAll = 0;
            List<long> a = new List<long>();
            while (HasNext())
            {
                int n = NextInt();
                if (n != 0)
                {
                    countLine += n;
                    countAll += n;
                }
                else
                {
                    a.Add(countLine);
                    countLine = 0;
                }
                
            }
            a.Add(countAll);
            foreach (var item in a)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }

        #region Input wrapper

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
