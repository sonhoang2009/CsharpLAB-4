using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contructor
{
    class ProductTest
    {
        static void Main(string[] args)
        {
            Product objProduct = new Product();
            objProduct.DisplayDetails();
            Console.WriteLine();

            Product objProduct1 = new Product(102);
            objProduct1.DisplayDetails();
            Console.WriteLine();

            Product objProduct2 = new Product(103, "Television", 5560.45F, 68);
            objProduct2.DisplayDetails();

            Console.ReadKey();



        }
    }
}
