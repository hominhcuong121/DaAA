using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EIUSEARC
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = NextInt();
            int m = NextInt();
            List<Student> fullname = new List<Student>();
            for (int i = 0; i < n; i++)
            {
                string fname = "";
                string mname = "";
                string lname = "";
                string full = Console.ReadLine();
                string[] tmpname = full.Split(' ');
                if (tmpname.Length == 1)
                {
                    fname = tmpname[0];
                }
                else if (tmpname.Length == 2)
                {
                    fname = tmpname[1];
                    lname = tmpname[0];
                }
                else
                {
                    lname = tmpname[0];
                    fname = tmpname[tmpname.Length - 1];
                    for (int j = 1; j < tmpname.Length - 1; j++)
                    {
                        if (j == tmpname.Length - 2)
                        {
                            mname += tmpname[j];
                        }
                        else
                        {
                            mname += tmpname[j] + " ";
                        }
                    }
                }
                fullname.Add(new Student(lname, mname, fname));
            }
            StringBuilder re = new StringBuilder();
            fullname.Sort();
            Dictionary<string, int> dic = new Dictionary<string, int>();
            int id = 1;
            foreach (Student item in fullname)
            {
                String test = "";
                if (!item.getLastName().Equals(""))
                {
                    test += item.getLastName() + " ";
                }
                if (!item.getMidName().Equals(""))
                {
                    test += item.getMidName() + " ";
                }
                if (!item.getFirstName().Equals(""))
                {
                    test += item.getFirstName();
                }
                dic.Add(test, id);
                id++;
            }
            for (int i = 0; i < m; i++)
            {
                string input = Console.ReadLine();
                if (dic.ContainsKey(input))
                {
                    re.Append(dic[input] + "\n");
                }
                else
                {
                    re.Append(-1 + "\n");
                }
            }
            Console.Write(re);
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
    public class Student : IComparable<Student>
    {
        private string fname;
        private string lname;
        private string mname;

        public Student(string lname, string mname, string fname)
        {
            this.lname = lname;
            this.mname = mname;
            this.fname = fname;
        }
        public int CompareTo(Student other)
        {
            if (this.fname.CompareTo(other.fname) > 0)
            {
                return 1;
            }
            else if (this.fname.CompareTo(other.fname) < 0)
            {
                return -1;
            }
            else
            {
                if (this.lname.CompareTo(other.lname) > 0)
                {
                    return 1;
                }
                else if (this.lname.CompareTo(other.lname) < 0)
                {
                    return -1;
                }
                else
                {
                    if (this.mname.CompareTo(other.mname) > 0)
                    {
                        return 1;
                    }
                    else if (this.mname.CompareTo(other.mname) < 0)
                    {
                        return -1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        public string getFirstName()
        {
            return fname;
        }

        public string getLastName()
        {
            return lname;
        }

        public string getMidName()
        {
            return mname;
        }
    }

}
