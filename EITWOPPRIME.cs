using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asssssssssssssd
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = NextInt();
            for (int j = 0; j < t; j++)
            {
                StringBuilder rs = new StringBuilder();
                int n = NextInt();
                int count = 0;
                for (int i = 2; i <= n; i++)
                {
                    if (KiemTraSoNguyenTo(i))
                    {
                        if (n - i < i) break;
                        if (KiemTraSoNguyenTo(n - i))
                        {
                            rs.Append(i + "+" + (n - i) + "\n");
                            count++;
                        }
                    }
                }
                Console.WriteLine(n + " has " + count + " representation(s)");
                Console.WriteLine(rs);
            }
        }
        
        
        public static bool KiemTraSoNguyenTo(int n)
        {
            if (n == 2) return true;
            for(int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }

            return true;
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


