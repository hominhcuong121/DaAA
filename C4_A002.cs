using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C4_A002
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = NextInt();
            int[] ar = new int[n];
            for (int i = 0; i < n; i++)
            {
                ar[i] = NextInt();
            }
            StringBuilder res = new StringBuilder();
            MergeSort(ar, 0, n - 1);
            for (int i = 0; i < n; i++)
            {
                res.Append(ar[i] + " ");
            }
            Console.Write(res);
            Console.ReadKey();
        }

        private static void MergeSort(int[] ar, int left, int right)
        {
            if(left < right)
            {
                int middle = (left + right) / 2;
                MergeSort(ar, left, middle);
                MergeSort(ar, middle + 1, right);
                Merge(ar, left, middle, right);
            }
        }

        private static void Merge(int[] ar, int left, int middle, int right)
        {
            int[] leftArray = new int[middle - left + 1];
            int[] rightArray = new int[right - middle];
            Array.Copy(ar, left, leftArray, 0, middle - left + 1);
            Array.Copy(ar, middle + 1, rightArray, 0, right - middle);
            int i = 0;
            int j = 0;
            for (int k = left; k < right + 1; k++)
            {
                if (i == leftArray.Length)
                {
                    ar[k] = rightArray[j++];
                }
                else if (j == rightArray.Length)
                {
                    ar[k] = leftArray[i++];
                }
                else if (leftArray[i] <= rightArray[j])
                {
                    ar[k] = leftArray[i++];
                }
                else
                {
                    ar[k] = rightArray[j++];
                }
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
