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
            int year_born;

            Console.WriteLine("Say hello!");
            response = Console.ReadLine();
            Console.WriteLine("You said: " + response);

            Console.WriteLine("What is your name?");
            name = Console.ReadLine();

            Console.WriteLine("How old are you?");
            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What year is it?");
            year = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("So you're" + name);
            Console.WriteLine("You are" + age);
            Console.WriteLine("That means you were born in" + year_born);
            Console.ReadLine();
        }
    }
}
