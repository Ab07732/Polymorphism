using System;

namespace Tutlane
{
    // Base Class
    public class BClass
    {
        public virtual void GetInfo()
        {
            Console.WriteLine("Hello World");
        }
    }
    // Derived Class
    public class DClass : BClass
    {
        public override void GetInfo()
        {
            Console.WriteLine("Welcome to Mars");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            DClass d = new DClass();
            d.GetInfo();
            BClass b = new BClass();
            b.GetInfo();
            Console.WriteLine("\nPress Enter Key to Exit..");
            Console.ReadLine();
        }
    }
}