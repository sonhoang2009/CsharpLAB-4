using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM
{
    class Test
    {
        static void Main(string[] args)
        {
            Medicine objMe = new Medicine();
            Sale objSa = new Sale();
            objMe.Accept();
            objSa.Accpect();
            Console.WriteLine();
            objMe.Print();
            objSa.Display();
            Console.ReadKey();

        }
    }
}
