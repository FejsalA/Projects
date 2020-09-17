using System;

namespace Assigment1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string name;
            string age;

            Console.Write("Enter your name: ");

            name = Console.ReadLine();

            Console.Write("Enter your age: ");

            age = Console.ReadLine();



         
           Console.WriteLine("Your name is " + name);
           Console.WriteLine("Your age is " + age);

           Console.ReadKey();
        }
    }
}
