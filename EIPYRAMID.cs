using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KimTuThapBatOn
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder Result = new StringBuilder();            
            int testcase = NextInt();
            for (int times = 0; times < testcase; times++)
            {
                int ID = NextInt();
                //int Count = 0;                
                List<int> Input = new List<int>();
                //nhap
                for (int i = 0; i < 12; i++)
                {
                    Input.Add(NextInt());
                }
                //while(Input.Count>0)
                //{
                //    int Head = -1;
                //    int Tail = -1;
                //    //cat ra tung mang 
                //    for (int i = 0; i < Input.Count; i++)
                //    {
                //        if (Input[i] == 0 && Head == -1)
                //        {
                //            Input.Remove(0);
                //            i--;
                //        }
                //        else if (Input[i] != 0 && Head == -1)
                //        {
                //            Head = i;
                //        }
                //        else if (Input[i] == 0 && Tail == -1)
                //        {
                //            Tail = i;
                //            break;
                //        }
                //    }
                //    //tru mang con cho min                    
                //    if (Input.Count > 0)
                //    {                        
                //        subtraction(Head, Tail, MinList(Head, Tail, Input), Input);
                //        Count++; 
                //    }
                //}
                //Result.Append(times + 1 + " " + Count + "\n");  
                Result.Append(times + 1 + " " + Pyramid(Input)+"\n");
            }
            Console.Write(Result);
            Console.ReadLine();

        }
        static int Pyramid(List<int> acc)
        {
            int Head = 0, Tail = 0;
            while (acc[0] == 0)
            {
                acc.Remove(0);
                if (acc.Count==0)
                {
                    return 0;
                }
            }
            Head = 0;
            for (int i = 0; i < acc.Count; i++)
            {
                if (acc[i] == 0)
                {
                    Tail = i;
                    break;
                }
            }
            subtraction(Head, Tail, MinList(Head, Tail, acc), acc);
            return 1 + Pyramid(acc);
        } 
        static int MinList(int Head, int Tail, List<int> ListInt)
        {
            int min = ListInt[Head];
            for (int i = Head+1; i < Tail; i++)
            {
                if (min>ListInt[i])
                {
                    min = ListInt[i];
                }
            }
            return min;
        }
        static void subtraction(int Head, int Tail, int min, List<int> ListInt)
        {
            for (int i = Head; i < Tail; i++)
            {
                ListInt[i] -= min;
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
