using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 23;
            age++;
           // age=age+1;
            //age+= 1;
            Console.WriteLine(age);

            age--;
            Console.WriteLine(age);
            Console.ReadLine();

            string name = "python";
            name += "Programming Language";
            Console.WriteLine(name);

            char ch = 'a';
            ch += 'b';
            Console.WriteLine(ch);  
            Console.ReadLine();

            int i = 0;
            Console.WriteLine(i++);
            Console.ReadLine();

            Console.WriteLine(++i);
            Console.ReadLine();

        }

    }
}
