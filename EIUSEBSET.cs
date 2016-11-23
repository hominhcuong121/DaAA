using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DISCOUNT
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = NextInt();
            int dem = 0;
            Double tong = Math.Pow(2,a);
            int[] ds = new int[a];
            List<string> dsnhap = new List<string>();
           

            for(int i=0;i<a;i++)
            {
                dsnhap.Add(Next());
            }    
       
            for (int i = a-1; i >-1; i--)
            {
                if (dem == tong-1) break;
                if (ds[i] == 0)
                {
                    ds[i] = 1;
                  
                    for(int k=0;k<a;k++)
                    {
                        if (ds[k] == 1)
                        {
                            buffer.Append(dsnhap[k] + " ");                            
                        }
                        
                    }
                    buffer.Append("\n");
                    dem++;                
                    i = a;
                }
                else ds[i] = 0;

            }

            Console.WriteLine(dem);
           
            Console.Write(buffer);

            Console.ReadKey();
        }
      
     
        #region bien
        static StringBuilder buffer = new StringBuilder();
        static int s_index = 0;
        static List<string> s_tokens;


        private static string Next()
        {
            while (s_tokens == null || s_index == s_tokens.Count)
            {
                s_tokens = Console.ReadLine().Split(new char[] { ' ', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries).ToList();
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
        private static ulong Nextulong()
        {
            return ulong.Parse(Next());
        }

        private static double Nextdouble()
        {
            return Double.Parse(Next());
        }

        #endregion



    }
}
