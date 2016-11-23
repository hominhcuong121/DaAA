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
            long a = NextLong();
            long b = NextLong();
            long c = NextLong();
            long final=1;

            for (int i = 0; i< b; i++ )
            {
                final= (final* a) % c;    
            }
            Console.WriteLine(final);
            Console.ReadLine();
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
