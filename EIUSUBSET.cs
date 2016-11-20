using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = NextInt();
            
            List<string> input = new List<string>();
            int size = 2 << (n - 1);
            
            
            for (int i = 0; i < n; i++)
            {
                input.Add(Next());
            }
            
            int dem = 1;
            int tam = dem;
            save.Append(size - 1 + "\n");
            while (size-->1)
            {
                StringBuilder a = new StringBuilder();
                tam = dem;                
                for (int i = n-1; i >= 0; i--)
                {
                    if (tam % 2 == 1)
                    {
                        a.Insert(0, " " + input[i]);
                        tam /= 2;
                    }
                    else if (tam == 0) break;
                    else tam /= 2;
                }
                a.Remove(0,1);
                save.Append(a + "\n");
                dem++;                
            }

            Console.Write(save);

            Console.ReadKey();
        }
        class test : IComparable<test>
        {
            public long kg { get; set; }
            public long gt { get; set; }
            public bool kt;
            public test(long KG, long GT)
            {
                gt = GT;
                kg = KG;
            }
            public int CompareTo(test other)
            {
                return this.gt.CompareTo(other.gt);
            }
        }

        public static List<long> don(List<long> a)
        {
            long tam = a[0];
            for (int i = 1; i < a.Count; i++)
            {
                if (tam == a[i])
                {
                    a.RemoveAt(i);
                    i--;

                }
                else tam = a[i];
            }
            return a;
        }

        public static long timkiem(List<long> a)
        {
            long level = 0;
            int tam = 0;
            again:;
            if (a.Count > 1)
            {
                for (int i = tam; i < a.Count; i++)
                {
                    if (a[i] > a[i + 1])
                    {
                        level++;

                        if (a[i - 1] < a[i + 1])
                            tam = i;
                        else tam = i - 1;
                        a[i] = Math.Max(a[i - 1], a[i + 1]);
                        a = don(a);
                        goto again;
                    }

                }
            }

            return level;
        }
        public static long findin(List<long> a)
        {
            Dictionary<long, long> max = new Dictionary<long, long>();
            Dictionary<long, long> min = new Dictionary<long, long>();

            long wood = 0;

            int tam = 1;
            int tam1 = 0;
            min.Add(0, 0);
            int tamne = 0;
            long same = -1;
            for (int i = 0; i < a.Count - 1; i++)
            {
                //maxtam = Math.Max(maxtam,a[i]);    
                if (a[i] == a[i + 1] && same != a[i])
                {
                    tamne = i;
                    same = a[i];
                }
                if (a[i] > a[i + 1])
                {

                    if (tam1 == 0)
                    {
                        if (a[i] == same && same - a[tamne - 1] == 2 && a[i] - a[i + 1] >= 2 || a[i] == same && same - a[tamne - 1] >= 2 && a[i] - a[i + 1] == 2)
                        {
                            max.Add(i, a[i] - 1);
                        }
                        else if (a[i] - a[i - 1] == 2 && a[i] - a[i + 1] >= 2 || a[i] - a[i - 1] >= 2 && a[i] - a[i + 1] == 2)
                        {
                            max.Add(i, a[i] - 1);
                        }
                        else
                        {
                            max.Add(i, a[i]);
                        }
                        tam1++;
                        tam = 0;
                    }

                }
                else if (a[i] < a[i + 1])
                {
                    if (tam == 0)
                    {
                        min.Add(i, a[i]);
                        tam1 = 0;
                        tam++;
                    }

                }

                if (a[a.Count - 2] < a[a.Count - 1] && i == a.Count - 2)
                {
                    max.Add(a.Count - 1, a[a.Count - 1]);
                }

            }
            int checkmin = 0;
            int checkmax = 0;
            int j = 0;
            for (int i = 0; i < a.Count; i++)
            {
                if (max.ContainsKey(i))
                {
                    for (j = i + 1; j < a.Count; j++)
                    {
                        if (min.ContainsKey(j))
                        {
                            wood += max[i] - min[j];
                            checkmin++;
                            break;
                        }
                    }
                    checkmax++;
                }
                if (max.ContainsKey(i) && checkmin == min.Count - 1 && checkmax == max.Count)
                {
                    wood += max[i];
                }
            }

            return wood;
        }

        class Student : IComparable<Student>
        {
            public string ten { get; set; }

            public string tendem { get; set; }
            public string ho { get; set; }


            public string fullname { get; set; }

            public Student(string Ho, string Tendem, string Ten)
            {
                ho = Ho;
                tendem = Tendem;
                ten = Ten;
                if (Tendem != "")
                {
                    fullname = Ho + Tendem + Ten;
                }
                else if (Ho != "")
                {
                    fullname = Ho + " " + Ten;
                }
                else
                {
                    fullname = Ten;
                }


            }


            public int CompareTo(Student other)
            {
                if (this.ten.CompareTo(other.ten) != 0)
                {
                    return this.ten.CompareTo(other.ten);
                }
                else if (this.ho.CompareTo(other.ho) != 0)
                {
                    return this.ho.CompareTo(other.ho);
                }
                else
                {
                    return this.tendem.CompareTo(other.tendem);
                }

            }
        }

        public static void mix(int n, int h)
        {
            int tang1 = h, tang2 = h;
            string space = " ", doc = "|", ngang = "_";
            string hor = null;
            for (int i = 0; i < n + 6; i++)
            {
                if (i == 0 || i == h + 2 || i == h + 4 || i == n + 5)
                {
                    hor += doc;

                }
                else hor += space;

            }

            for (int i = 0; i < n + 6; i++)
            {

                if (i >= 1 && i <= h)
                {
                    save.Append(ngang);
                }
                else save.Append(space);
            }
            save.Append("\n");

            while (tang1-- > 1)
            {

                save.Append(hor + "\n");
            }

            for (int i = 0; i < n + 6; i++)
            {
                if (i == 0 || i == h + 2 || i == h + 4 || i == n + 5)
                {
                    save.Append(doc);

                }
                else if (i >= 1 && i <= h)
                {
                    save.Append(ngang);

                }
                else save.Append(space);
            }
            save.Append("\n");

            while (tang2-- > 1)
            {

                save.Append(hor + "\n");
            }

            for (int i = 0; i < n + 6; i++)
            {
                if (i == 0 || i == h + 2 || i == h + 4 || i == n + 5)
                {
                    save.Append(doc);
                }
                else if (i >= 1 && i <= h || i >= h + 5 && i <= n + 4)
                {
                    save.Append(ngang);
                }
                else save.Append(space);
            }

        }
        static StringBuilder save = new StringBuilder();

        //------------------------------------------------------
        static int s_index = 0;
        static List<string> s_tokens;

        private static string Next()
        {
            while (s_tokens == null || s_index == s_tokens.Count)
            {
                s_tokens = Console.ReadLine().Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries).ToList();
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
                    s_tokens = nextLine.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries).ToList();
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
    }
}
