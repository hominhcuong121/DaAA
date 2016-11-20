using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCCOMMAS
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Next();
            StringBuilder tmp = new StringBuilder();
            StringBuilder result = new StringBuilder();
            int commas = 0;
            if(number.Length <= 3)
            {
                Console.WriteLine(number);
            }
            else
            {
                for (int i = number.Length - 1; i >= 0; i--)
                {
                    tmp.Append(number[i]);
                    commas++;
                    if(commas == 3 & i != 0)
                    {
                        tmp.Append(',');
                        commas = 0;
                    }
                }
            }
            for (int i = tmp.Length - 1; i >= 0; i--)
            {
                result.Append(tmp[i]);
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
