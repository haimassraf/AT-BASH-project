using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT_BASH_project
{
    internal class Program
    {
        static void Main(string[] args)

        {
           
        }

        static int SumOfWord(string[] str)
        {
            string[] strings =new string[] { "bomb", "nukhba", "fighter", "rocket", "secret" };
            int count = 0;
            foreach (string s in str)
            {
                if (strings.Contains(s))
                {
                    count++;
                }
            }
            return count;

           
        }
        
    }
}
