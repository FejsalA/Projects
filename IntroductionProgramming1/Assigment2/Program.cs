using System;

namespace Assigment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your age: ");
            string input = Console.ReadLine();


            int age = int.Parse(input);


            age += 1;

          string output = age.ToString();

           Console.WriteLine("Next year you will be " + age  + " years old");


            Console.ReadKey(); 
        }
    }
}
