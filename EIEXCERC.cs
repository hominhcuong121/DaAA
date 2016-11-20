using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EIEXCERC
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = NextInt();
            int even = 0;
            int odd = 0;
            while(n > 0)
            {
                if(n % 2 == 0)
                {
                    even++;
                    n = n / 2;
                }
                else
                {
                    odd++;
                    n = n / 2;
                }
            }
            Console.WriteLine(odd + " " + even);
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
