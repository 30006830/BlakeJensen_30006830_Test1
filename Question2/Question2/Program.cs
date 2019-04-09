//Blake Jensen Student ID: 30006830
//Question 2.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White; //makes text white for easier reading
            Console.WriteLine("Program designed to calculate the sum total of 5 prices."); //program title

            double total = 0; //variable double for later use

            //for loop used to ask the user to input 5 prices
            for(int i = 1; i <= 5; i++)
            {
                //console.writeline repeats itself 5 times whilst also being able to use variable {i} as a counter to list each item number eg. 1, 2, 3, 4, 5
                Console.WriteLine($"Please Enter the price of item {i}");
                total = total + double.Parse(Console.ReadLine()); //the variable 'total is itself + the doubles total from each repitition of the for loop.
            }
            Console.ReadLine();
            Console.WriteLine($"The sum of the prices you entered is: ${total}");
            Console.ReadLine();
            Console.WriteLine("End of Question 2, Press ENTER to continue.");
            Console.ReadLine();

        }
    }
}
