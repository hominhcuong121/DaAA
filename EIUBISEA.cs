using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EIUBISEA
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = NextInt();
            int m = NextInt();
            List<int> ar = new List<int>();
            for (int i = 0; i < n; i++)
            {
                ar.Add(NextInt());
            }
            ar.Sort();
            StringBuilder re = new StringBuilder();
            while (m-- > 0)
            {
                int a = NextInt();
                int left = 0;
                int right = ar.Count - 1;
                re.Append(BinarySearch(ar, a, left, right) + " ");
            }
            Console.Write(re);
            Console.ReadKey();
        }
        private static int BinarySearch(List<int> ar, int v, int left, int right)
        {

            if (left > right)
            {
                return -1;
            }
            else
            {
                int mid = (left + right) / 2;
                if (v == ar[mid])
                {
                    while (mid != 0 && ar[mid] == ar[mid - 1])
                    {
                        mid = mid - 1;
                    }
                    return mid;
                }
                else if (v < ar[mid])
                {
                    return BinarySearch(ar, v, left, mid - 1);
                }
                else
                {
                    return BinarySearch(ar, v, mid + 1, right);
                }
            }
        }
        #region
        static int s_index = 0;
        static List<string> s_tokens;

        private static string Next()
        {
            while (s_tokens == null || s_index == s_tokens.Count)
            {
                s_tokens = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                s_index = 0;
            }
            return s_tokens[s_index++];
        }

        private static bool HasNext()
        {
            while (s_tokens == null || s_index == s_tokens.Count)
            {
                s_tokens = null;
                s_index = 0;
                var nextLine = Console.ReadLine();
                if (nextLine != null)
                {
                    s_tokens = nextLine.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                }
                else
                {
                    return false;
                }

            }
            return s_tokens.Count > 0;
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
