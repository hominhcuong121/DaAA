using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semi_palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<char, int> dic = new Dictionary<char, int>();            
            foreach (var item in input)
            {
                if (dic.ContainsKey(item))
                {
                    dic[item]++;
                }
                else dic.Add(item, 1);
            }
            int count = 0;
            foreach (var item in dic)
            {
                if (item.Value % 2 == 1)
                {
                    count++;
                }
            }
            Console.Write((count < 1 ? 1 : count) - 1);
                       
        }
        
    }
}
