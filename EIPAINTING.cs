using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemSoLanXuatHien
{
    class Program
    {
        public static void Main(string[] args)
        {
            int n = NextInt();
            int b = n;
            int[] table = new int[1000001];
            int k = 0;
            while (b-->0)
            {
                int a = NextInt();
                k = (k < ++table[a] ? table[a] : k);

            }
            
            
            Console.Write(n-k);
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
