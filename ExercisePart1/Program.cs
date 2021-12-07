using System;

namespace ExercisePart1
{
    class Program
    {
        static void Main(string[] args)
        {
            //write a program that asks for user's first and last name
            //the programm greets the user by their name
            //the programm asks the user to enter their year of birth and calculates the user's age
            //*Convert.ToInt32(stringToConvert); 
            //if the user is 13 or older, then the programm displays "Welcome to Instagram"
            //otherwise the programm displays "You are too young to have an Insagram account"
            string name, lastname;
            int Date;
            Console.WriteLine("Enter your name?");
            name = Console.ReadLine();
            Console.WriteLine("Enter your last name?");
            lastname = Console.ReadLine();

            Console.WriteLine($"Hello, {name} {lastname}");

            Console.WriteLine("Enter your year of birth?");
            Date = Convert.ToInt32(Console.ReadLine());

            int currentYear = Convert.ToInt32(DateTime.Now.Year.ToString());

            int age = currentYear - Date;

            if (age >= 13)
            {
                Console.WriteLine("Welcome to Instagram");
            }
            else
            {
                Console.WriteLine("You are too young to have an Insagram account");
            }

            Console.WriteLine(DateTime.Now.ToString());
                
                




        }
    }
}
