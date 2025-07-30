using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
//Learning Basics concepts 
namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!"); //Display on Console Application
            Console.ReadLine();                //Avoid Closing the Console Suddenly 

            //Learning Data types,declaring variables

            String module = "Software Architecture"; //store characters texts
            int age = 21; //store integers (numbers without decimals)
            double batch = 23.2; //store numbers with decimal points
            char x = 'A'; //store a single character
            bool result = false; //store boolean values

            //Displaying values

            Console.WriteLine("" + age);
            Console.WriteLine("Your age is " + age);
            Console.ReadLine();

            Console.WriteLine("" + module);
            Console.WriteLine("Module name  is " + module);
            Console.ReadLine();

            Console.WriteLine("" + batch);
            Console.WriteLine("My batch  is " + batch);
            Console.ReadLine();

            Console.WriteLine("" + x);
            Console.WriteLine("Char character is " + x);
            Console.ReadLine();

            Console.WriteLine("" + result);
            Console.WriteLine("Boolean Character is " + result);
            Console.ReadLine();

            //Getting String input from the  user
            String name; //Declaring String Variable
            Console.WriteLine("Enter your name :");
            name = Console.ReadLine(); // Taking user input for variable
            Console.WriteLine("Welcome" + name); //Displaying the variable
            Console.ReadLine(); //Avoid closing the console

            //Getting Integer from the User
            int Year;
            Console.WriteLine("Enter the Year:");
            Year = int.Parse(Console.ReadLine());
            Console.WriteLine("Today is a day of" + Year);
            Console.ReadLine();


        }
    }
}
