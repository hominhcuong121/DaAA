using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EIBORROW
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = NextInt();
            int resultT = 0;
            int resultH = 0;
            while (n-- > 0)
            {
                string sentence = Next();
                int countT = 0;
                int countH = 0;
                int tmp = 0;
                sentence.ToArray();
                foreach (var item in sentence)
                {
                    if (item == 'T')
                    {
                        countT++;
                    }
                    else
                    {
                        countH++;
                    }
                }
                tmp = countT - countH;
                if (tmp > 0)
                {
                    resultT++;
                }
                if (tmp < 0)
                {
                    resultH++;
                }
            }
            Console.WriteLine(resultH + " " + resultT);
            Console.ReadKey();
        }
        #region Input wrapper

        static int s_index = 0;
        static string[] s_tokens;

        private static string Next()
        {
            while (s_tokens == null || s_index == s_tokens.Length)
            {
                s_tokens = Console.ReadLine().Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                s_index = 0;
            }
            return s_tokens[s_index++];
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
