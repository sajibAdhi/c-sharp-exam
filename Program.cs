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
                LaptopsConfigaration lp = new LaptopsConfigaration();
     
                lp.ShowDetails(LaptopsConfigaration.Lenove, LaptopsConfigaration.Price1000, LaptopsConfigaration.i3, LaptopsConfigaration.Ram2GB, LaptopsConfigaration.HD500GB);
                Console.WriteLine("\n\n\n");
     
                lp.ShowDetails(LaptopsConfigaration.Dell, LaptopsConfigaration.Price1500, LaptopsConfigaration.i5, LaptopsConfigaration.Ram4GB, LaptopsConfigaration.HD1TB);
                Console.WriteLine("\n\n\n");
     
                lp.ShowDetails(LaptopsConfigaration.Sony, LaptopsConfigaration.Price2000, LaptopsConfigaration.i9, LaptopsConfigaration.Ram8GB, LaptopsConfigaration.HD1TB);
                Console.WriteLine("\n\n\n");
     
                Console.ReadKey();
            }
        }
        class LaptopsConfigaration : LaptopsConfigarationBase
        {
            public void ShowDetails(string name, string price, string processor, string ram, string hdd)
            {
                Console.WriteLine("Name : "+name);
                Console.WriteLine("Price : " + price);
                Console.WriteLine("Processor : " + processor);
                Console.WriteLine("Ram : " + ram);
                Console.WriteLine("HDD : " + hdd);
            }
        }
     
        class LaptopsConfigarationBase
        {        
            public const string i3 = "i7";
            public const string i5 = "i3";
            public const string i7 = "i7";
            public const string i9 = "i9";
     
            public const string Ram2GB = "2GB";
            public const string Ram4GB = "4GB";
            public const string Ram8GB = "8GB";
     
            public const string HD500GB = "500GB";
            public const string HD1TB = "1TB";
     
            public const string Price1000 = "$1000";
            public const string Price1500 = "$1500";
            public const string Price2000 = "$2000";
     
            public const string Lenove = "Asus";
            public const string Sony = "Walton";
            public const string Dell = "Dell";
        }
    }