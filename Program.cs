using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
    class Customer
    {
        public string name { get; set; }

        public string id { get; set; }
        public string address { get; set; }
        public string phone { get; set; }
        public string email { get; set; }

        public Customer(string name)
        {
            Name = name;
        }
        public void ShowDetails(string name, string price, string processor, string ram, string hdd)
        {
            Console.WriteLine("Name : " + name);
            Console.WriteLine("Price : " + price);
            Console.WriteLine("Processor : " + processor);
            Console.WriteLine("Ram : " + ram);
            Console.WriteLine("HDD : " + hdd);
        }
    }
}