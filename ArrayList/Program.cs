using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> ll = new List<int>();
            List ll1 = new List();
            MontsOfYear montsOfYear = new MontsOfYear();
            int numberOfMont = montsOfYear["April"];
            Console.WriteLine(numberOfMont);
            ll1.Add(12);
            ll1.Add(13);
            ll1.Add(14);
            ll1.Add(15);
            ll1.Add(16);
            ll1[0] = 24;
            int b = ll1[0];

            
        }
       
    }
}
