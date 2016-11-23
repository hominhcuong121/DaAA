using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace funpic
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = NextInt();
            int b = n;
            int[] table = new int[1000001];
            int k = 0;
            while (b-->0)
            {
                int a = NextInt();
                k = (k < ++table[a] ? table[a] : k);

            }
            
            
            Console.Write(n-k);
            Console.ReadKey();
        
      }
        #region Input wrapper  //giup viec quan ly khoi 



        static int s_index = 0;
        static string[] s_tokens;



        private static string Next() //kieu ky tu
        {
            while (s_tokens == null || s_index == s_tokens.Length)
            {
                s_tokens = Console.ReadLine().Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                s_index = 0;
            }
            return s_tokens[s_index++];
        }

        private static int[] readIntArray()
        {
            return Console.ReadLine().Split(' ').Where(i => !string.IsNullOrEmpty(i)).Select(i => int.Parse(i)).ToArray();
        }


        private static int NextInt() //kieu so nguyen
        {
            return Int32.Parse(Next());  //bien ky tu vao ra so nguyen
        }



        private static long NextLong() //kieu so lon
        {
            return Int64.Parse(Next()); //giong tren 
        }



        #endregion //ket khuc
    }
}
