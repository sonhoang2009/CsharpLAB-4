using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM
{
    class Medicine
    {
		int mediCode;
		string mediName;
		string manuName;
		double price;
		int qty;
		DateTime manu;
		DateTime exp;
		int bath;
	
	 public void Accept()
		{
			Console.Write("Enter medicine Code : ");
			mediCode = Convert.ToInt32(Console.ReadLine());
			Console.Write("Enter medicine Name : ");
			mediName = Console.ReadLine();
			Console.Write("Enter manu Name : ");
			manuName = Console.ReadLine();
			Console.Write("Enter price : ");
			price = Convert.ToDouble(Console.ReadLine());
			Console.Write("Enter manu date : ");
			manu = Convert.ToDateTime(Console.ReadLine());
			Console.Write("Enter exp date : ");
			exp = Convert.ToDateTime(Console.ReadLine());
			Console.Write("Enter bath medicine : ");
			bath = Convert.ToInt32(Console.ReadLine());
		}
		public  void Print()
		{
			Console.WriteLine("Medicine Code : " + mediCode);
			Console.WriteLine("Medicine Name : " + mediName);
			Console.WriteLine("Manufacturer Name : " + manuName);
			Console.WriteLine("Price : " + price);
			Console.WriteLine("Quantity : " + qty);
			Console.WriteLine("Manufatured Date : " + manuName);
			Console.WriteLine("Expiry Date : " + exp);
			Console.WriteLine("Batch Number : " + bath);
		}
	}

}
