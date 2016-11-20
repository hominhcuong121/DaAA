using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EIUPREIU
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = NextInt();
            string[,] re = new string[n + 1, n + 7];
            StringBuilder res = new StringBuilder();
            int m = n / 2;
            for (int i = 0; i < n + 1; i++)
            {
                for (int j = 0; j < n + 7; j++)
                {
                    if (!(i == n && j == n + 6))
                    {
                        re[i, j] = " ";
                    }
                    else
                    {
                        re[i, j] = " " + "\n";
                    }
                    if (i != 0)
                    {
                        if (j == 0 || j == (m + 2) || j == (m + 4) || j == (n + 5))
                        {
                            re[i, j] = "|";
                        }
                    }
                    if (i == 0 || i == m || i == n)
                    {
                        for (int c = 1; c <= m; c++)
                        {
                            re[i, c] = "_";
                        }
                    }
                    if (i == n)
                    {
                        if (j != m + 1 || j != m + 2 || j != m + 3 || j != m + 4)
                        {
                            for (int d = n + 4; d >= m + 5; d--)
                            {
                                re[i, d] = "_";
                            }
                        }
                    }
                }
            }
            for (int a = 0; a < n + 1; a++)
            {
                for (int b = 0; b < n + 6; b++)
                {
                    res.Append(re[a, b]);
                }
                res.Append("\n");
            }
            Console.Write(res);
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

