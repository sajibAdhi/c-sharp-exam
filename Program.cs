using System;

class Person
{
    private string name;  // field
    public string Name    // property
    {
        get { return name; }
        set { name = value; }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Person info = new Person();
        info.Name = "Mehedi Hasan Rasel";
        Console.WriteLine(info.Name);
    }
}