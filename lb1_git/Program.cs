using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb1_git
{
    class Program
    {
        static void Main(string[] args)
        {
            Address address = new Address("","",0);
            address.input();
            address.print();
            Console.ReadKey();
        }
    }
}
