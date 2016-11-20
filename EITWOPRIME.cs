using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tonghaisonguyento
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder Result = new StringBuilder();//xuat kq
            int Testcase = NextInt();
            List<int> input = new List<int>();//input
            int max = 0;
            //tim so lon nhat trong input
            for (int i = 0; i < Testcase; i++)
            {
                int temp = NextInt();
                if (max < temp)
                    max = temp;
                input.Add(temp);
            }
            //Sang so ngto truoc
            bool[] PrimeNumbers = new bool[max];
            for (int j = 0; j < max; j++)
                if (IsPrime(j + 1))
                    PrimeNumbers[j] = true;
            for (int i = 0; i < Testcase; i++)
            {
                StringBuilder strTong = new StringBuilder();
                int Count = 0;
                for (int j = 2; j <= input[i]/2; j++)
                {
                    if (PrimeNumbers[j-1])
                    {
                        int subtraction = input[i] - j;
                        if (PrimeNumbers[subtraction-1])
                        {
                            strTong.Append(j + "+" + subtraction + "\n");
                            Count++;
                        }
                    }
                }
                Result.Append(input[i] + " has " + Count + " representation(s)\n" + strTong + "\n");
            }            
            Console.Write(Result);
        }
        public static bool IsPrime(int p)
        {
            if (p == 1)
            {
                return false;
            }
            else
            {
                for (int i = 2; i <= Math.Sqrt(p); i++)
                {
                    if (p % i == 0)
                    {
                        return false;
                    }
                }
                return true;
            }
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
