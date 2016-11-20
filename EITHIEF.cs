using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trom
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int NumItems = NextInt();//number of items
            int Capacity = NextInt();//capacity
            
            List<int> Weights = new List<int>(); //Weight of Values
            List<int> Values = new List<int>(); // values
            List<int> TotalValues = new List<int>();
            List<string> Subsets = new List<string>();
            long max = 0;
            int dem = 0;
            ////input
            for (int i = 0; i < NumItems; i++)
            {
                int w = NextInt();
                int v = NextInt();
                if (w <= Capacity)
                {
                    Weights.Add(w);
                    Values.Add(v);
                }
                else
                    dem++;
                
            }
            ////////////////
            NumItems -= dem;
            int Quatility = (int)Math.Pow(2, NumItems * 1.0);
            for (int i = 1; i < Quatility; i++)
            {
                long Weight = 0;
                long Value = 0;                
                for (int j = 0; j < NumItems; j++)
                {
                    if ((i & (1 << (NumItems - j - 1))) != 0)
                    {
                        Weight += Weights[j];
                        Value += Values[j];
                        if (Weight > Capacity)
                        {
                            break;
                        }
                    }
                }
                if (Weight <= Capacity)
                {
                    if (max<Value)
                    {
                        max = Value;
                    }
                }

            }
           
            Console.Write(max);
            
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
