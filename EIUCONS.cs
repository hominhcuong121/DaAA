using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EIUCONS
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = NextInt();
            long count = 0;
            while (n-- > 0)
            {
                long i = NextLong();
                long a = NextLong();
                long b = NextLong();
                long[] ar = new long[i];
                ar[0] = a % b;
                for (int c = 1; c < i; c++)
                {
                    ar[c] = (ar[c - 1] * a) % b;
                }
                Array.Sort(ar);
                count += ar[i - 1];
            }
            Console.Write(count);
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
