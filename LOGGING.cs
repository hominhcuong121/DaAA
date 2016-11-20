using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGGING
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = NextInt();
            long[] ar = new long[n + 1];
            for (int i = 1; i <= n; i++)
            {
                ar[i] = NextLong();
            }
            long[] res = new long[n + 1];
            res[0] = 0;
            res[1] = ar[1];
            for (int i = 2; i <= n; i++)
            {
                if(ar[i] < 0)
                {
                    res[i] = res[i - 1];
                }
                else
                {
                    res[i] = Math.Max((ar[i] + res[i - 2]), res[i - 1]);
                }
            }
            Console.Write(res[res.Length - 1]);
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
