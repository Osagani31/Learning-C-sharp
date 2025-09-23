using System;

namespace IfStatementExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== IF STATEMENT DEMO ===");

            // 1. Simple if
            Console.WriteLine("\nEnter your age:");
            int age = int.Parse(Console.ReadLine());

            if (age >= 18)
            {
                Console.WriteLine("You are an adult.");
            }

            // 2. if...else
            Console.WriteLine("\nEnter a number:");
            int number = int.Parse(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("The number is even.");
            }
            else
            {
                Console.WriteLine("The number is odd.");
            }

            // 3. if...else if...else
            Console.WriteLine("\nEnter your marks (0 - 100):");
            int marks = int.Parse(Console.ReadLine());

            if (marks >= 75)
            {
                Console.WriteLine("Grade: A");
            }
            else if (marks >= 65)
            {
                Console.WriteLine("Grade: B");
            }
            else if (marks >= 50)
            {
                Console.WriteLine("Grade: C");
            }
            else
            {
                Console.WriteLine("Grade: F");
            }

            // 4. Nested if
            Console.WriteLine("\nEnter a username:");
            string username = Console.ReadLine();

            Console.WriteLine("Enter a password:");
            string password = Console.ReadLine();

            if (username == "admin")
            {
                if (password == "1234")
                {
                    Console.WriteLine("Login successful!");
                }
                else
                {
                    Console.WriteLine("Wrong password!");
                }
            }
            else
            {
                Console.WriteLine("Invalid username!");
            }

            // 5. Logical operators
            Console.WriteLine("\nEnter temperature in Celsius:");
            int temp = int.Parse(Console.ReadLine());

            if (temp > 30 && temp < 40)
            {
                Console.WriteLine("It’s hot but manageable.");
            }
            else if (temp >= 40)
            {
                Console.WriteLine("Warning: Extreme heat!");
            }
            else if (temp >= 20 || temp <= 25)
            {
                Console.WriteLine("The weather is pleasant.");
            }

            Console.WriteLine("\n=== Program End ===");
            Console.ReadLine();
        }
    }
}
