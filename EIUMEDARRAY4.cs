using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblem4
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder Result = new StringBuilder();
            int Testcase = NextInt();
            for (int times = 0; times < Testcase; times++)
            {
                int N = NextInt();
                long A = NextInt();
                long P = NextLong();
                long K = NextInt();                
                List<long> array = new List<long>();
                for (int i = 0; i < N; i++)
                {
                    if (i == 0)
                    {
                        array.Add(((A%P) * A) % P);
                    }
                    else
                    {
                        array.Add((array[i - 1])*A % P);
                    }
                }
                Result.Append(Ksmallest(array,0,N-1,K)+"\n");
            }
            Console.Write(Result);
        }
        static long Ksmallest(List<long> array, int left, int right, long k)
        {
            if (k > 0 && k <= right - left + 1)
            {
                int i = Partition(array, left, right);
                if (i-left == k -1)
                {
                    return array[i];
                }
                if (i-left > k-1)
                {
                    return Ksmallest(array, left, i - 1, k);
                }
                else
                {
                    return Ksmallest(array, i + 1, right, k - i + left - 1);
                }
            }
            return 0;
        }
        static int Partition(List<long> array, int left, int right)
        {
            long pivot = array[right];
            int i = left;
            for (int j = left; j < right; j++)
            {
                if (array[j]<=pivot)
                {
                    long temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                    i++;
                }
            }
            array[right] = array[i];
            array[i] = pivot;
            return i;

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
