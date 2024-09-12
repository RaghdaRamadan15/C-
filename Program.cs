using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace darft
{
    internal class Program
    {

        public static IEnumerable<int> f()
        {
            Console.WriteLine("dd");
            yield return 1;
            Console.WriteLine("11");
            yield return 2;
            Console.WriteLine("cc");
            yield return 3;
        }
        static void Main(string[] args)
        {
            IEnumerable<int> l= f();
            
            foreach (int i in l)
            {
                Console.WriteLine(i);
            }
        }
    }
}
