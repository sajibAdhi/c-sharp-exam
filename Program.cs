namespace Exam{
    class Customer{
        public string fullName = null!;
        public string id = null;
        public string address = null!;
        public string phone = null!;
        public string email = null!;

        //create a constructor that takes two arguments
        public Customer(string fullName, string address){
            Console.WriteLine("full name: " + fullName);
            Console.WriteLine("address: " + address);
        }
        //create a constructor that takes all the properties as parameters and displays them in the console
        public Customer(string fullName, string id, string address, string phone, string email){
            Console.WriteLine("Full Name: " + fullName);
            Console.WriteLine("id: " + id);
            Console.WriteLine("address: " + address);
            Console.WriteLine("phone: " + phone);
            Console.WriteLine("email: " + email);
        }

    }

    class Program
    {
        public static void Main(string[] args)
        {
            Customer intro = new Customer("Sajib Adhikary", "Kallyanpur Dhaka");
            Console.WriteLine("\n");
            Customer info = new Customer("Sajib Adhikary", "CSE1901016103", "kallyanpur dhaka", "01400593322", "tosajibadhi@gmail.com");
        }
    }
    
}