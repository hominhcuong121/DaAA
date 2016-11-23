using System;
using System.Collections.Generic;
using System.Linq;

namespace EITHIEF2
{

    class Program
    {
        static void Main(string[] args)
        {
            int N = NextInt();
            long P= NextLong();
            int[] w = new int[N];
            int[] v = new int[N];
            for (int i = 0; i < N; i++)
            {
                w[i] = NextInt();
                v[i] = NextInt();
            }
          Console.WriteLine(knapsack(N, P, w, v));
        }

        static long knapsack(int N, long P, int[]w, int[]v)
        {
            int i, j;
            long[,] f = new long[N+1, P+1];
            for (i = 1; i <= N; i++)
            {
                for (j = 0; j <= P; j++)
                {
                    if (w[i - 1] <= j)
                    {
                        f[i,j] = Math.Max(f[i - 1,j], v[i - 1] + f[i - 1,j - w[i - 1]]);
                    }
                    else
                    {
                        f[i,j] = f[i - 1,j];
                    }
                }
            }

            return f[N,P];

        }

        #region
        static int s_index = 0;
        static List<string> s_tokens;
        private static string Next()
        {
            while (s_tokens == null || s_index == s_tokens.Count)
            {
                s_tokens = Console.ReadLine()
                    .Split(new char[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
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
            return long.Parse(Next());
        }
        #endregion
    }

}