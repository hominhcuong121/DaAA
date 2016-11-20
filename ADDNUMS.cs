using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADDNUMS
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = NextInt();
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < n; i++)
            {
                int a = NextInt();
                int b = NextInt();
                result.Append((a + b) + "\n");
            }
            Console.WriteLine(result);
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
