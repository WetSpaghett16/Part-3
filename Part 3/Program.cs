using System;

namespace Part_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string response;
            string name;
            int age;
            int year;

            Console.WriteLine("Say hello!");
            response = Console.ReadLine();
            Console.WriteLine("You said: " + response);

            Console.WriteLine("What is your name?");
            name = Console.ReadLine();

            Console.WriteLine("How old are you?");
            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What year is it?");
            year = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" ");


            Console.WriteLine("So your name is " + name);
            Console.WriteLine("and you claim to be " + age);
            Console.WriteLine($"Which would mean you were born in " + (year - age));
            Console.ReadLine();
        }
    }
}
