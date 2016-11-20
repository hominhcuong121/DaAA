using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecretFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = NextInt();
            int n = NextInt();
            int b = NextInt();
            Console.Write((a % b == 0) ? 0 : SecretFunction(a, n, b));

        }
        static long SecretFunction(long a, int n, int b)
        {
            if (n == 1)
            {
                return a % b;
            }
            return (SecretFunction(a, n - 1, b) * a) % b;
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
