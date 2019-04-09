//Blake Jensen. 30006830
//Question One.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White; //Makes text white for easier reading.
            Console.WriteLine("This program is made to calculate the result of base^exponent"); //introductory message for the user so they understand what the program is meant to do.

            //Program asks the user to enter a Base (double) for the calculation.
            Console.WriteLine("Please Enter a Base: ");

            double base1 = double.Parse(Console.ReadLine());

            //Program then asks the user to enter an exponent so that the base (double) will be multiplied by that integer (to the power of)
            Console.WriteLine("Please Enter an Exponent: ");
            int exponent = int.Parse(Console.ReadLine());

            double total = base1 * exponent;
            double result = total * exponent / base1 + base1 + exponent;

            Console.WriteLine($"{base1}^{exponent} = {result}");

            //end of program
            Console.WriteLine("This is the end of Question One. Please Open Question 2.");
            Console.ReadLine();
        }
    }
}
