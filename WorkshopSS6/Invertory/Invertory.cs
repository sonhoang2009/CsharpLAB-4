﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invertory
{
    class Supplier
    {
        private int _supplierID;
        private string _city;
        private string _supplierName;
        private string _phoneNo;
        private string _email;

        internal void AcceptDetails()
        {
            Console.Write("Enter ID of supplier : ");
            _supplierID = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter name of supplier : ");
            _supplierName = Console.ReadLine();
            Console.Write("Enter name city of supplier : ");
            _city = Console.ReadLine();
            Console.Write("Enter phone No. of supplier : ");
            _phoneNo = Console.ReadLine();
            Console.Write("Enter Email of supplier : ");
            _email = Console.ReadLine();
        }

        internal void DisplayDetails(int supplierID)
        {
            Console.WriteLine("Supplier ID : " + supplierID);
        }

        internal void DisplayDetails(string supplierName)
        {
            Console.WriteLine("Supplier Name : " + supplierName);
        }

        internal void DisplayDetails(int supplierID,string supplierName)
        {
            Console.WriteLine("\nSupplier {0} with ID {1} lives in city {2} ",supplierName,supplierID,_city);
        }




    }
}
