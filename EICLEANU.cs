using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analysis_And_Design_Of_Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = NextLong();
            long acc = 0;
            for (int i = 0; i < n; i++)
            {
                acc += NextLong();
            }
            Console.WriteLine(acc * 2);
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
