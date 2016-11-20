using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EIUTAX
{
    class Program
    {
        static void Main(string[] args)
        {
            long money = NextLong() - 9000000;
            long tax = 0;
            List<long> alo = new List<long>();
            alo.Add(5000000);
            alo.Add(5000000);
            alo.Add(8000000);
            alo.Add(14000000);
            alo.Add(20000000);
            alo.Add(28000000);
            alo.Add(money);
            List<int> percent = new List<int>();
            percent.Add(5);
            percent.Add(10);
            percent.Add(15);
            percent.Add(20);
            percent.Add(25);
            percent.Add(30);
            percent.Add(35);
            for (int i = 0; i < alo.Count(); i++)
            {
                if (alo[6] <= 0)
                {
                    tax = 0;
                }
                else
                {
                    if (alo[6] <= alo[i])
                    {
                        tax += (alo[6] * percent[i]) / 100;
                        break;
                    }
                    else
                    {
                        tax += (alo[i] * percent[i]) / 100;
                        alo[6] -= alo[i];
                    }
                }
            }
            Console.WriteLine(tax);
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
