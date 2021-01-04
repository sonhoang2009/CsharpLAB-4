using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkshopSS6
{
    class SupplierTest
    {
        static void Main(string[] args)
        {
            Supplier objSupplier = new Supplier();
            objSupplier.AcceptDetails();
            objSupplier.DisplayDetails();
            Console.ReadKey();
        }
    }
}
