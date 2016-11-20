using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROTRIENLAM
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = NextInt();
            List<int> arr = new List<int>();
            List<int> arr2 = new List<int>();
            StringBuilder result = new StringBuilder();
            int count = 0;
            int flag = 0;
            while (n-- > 0)
            {
                arr.Add(NextInt());
            }
            arr.Sort();
            for (int i = 0; i < arr.Count - 1; i++)
            {
                flag = arr[i];
                if(flag != 0)
                {
                    arr2.Add(flag);
                    for (int j = 1; j < arr.Count; j++)
                    {
                        if(arr[j] != 0 && flag < arr[j])
                        {
                            arr2.Add(arr[j]);
                            flag = arr[j];
                            arr[j] = 0;
                        }
                    }
                }
            }
            for (int a = 0; a < arr2.Count - 1; a++)
            {
                if(arr2[a] < arr2[a + 1])
                {
                    count++;
                }
            }
            Console.Write(count);
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
