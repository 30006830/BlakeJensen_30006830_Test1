//Blake Jensen 30006830
//Question 3b
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question3b
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White; //text color

            //title of program
            Console.WriteLine("I wonder if you can solve the following Algebraic Equation: 2(x - 3) + x = 12"); //greeting message
            Console.ReadLine(); //press enter here, used for a break in the consoles text

            Console.WriteLine("What is x (enter a number): "); //asls the user to try to guess the answer of the equation

            int guess = int.Parse(Console.ReadLine()); //takes the users input via number and responds accordingly to the variables if it is the answer or not.
            int x = 6; //answer to the algebraic equation

            if (guess == x) //if statement checking if the users 'guess' is the same as 'x'
            {
                Console.WriteLine("Well done you guessed right"); //message regarding they got the question correct
            }
            else if (guess > x)
            {
                Console.WriteLine("Close, however you were just a bit off. Try again");
            }
            else if (guess < x)
            {
                Console.WriteLine("Nearly, you were really close");
            }
            else
                Console.WriteLine("You guessed wrong bud, try again."); //message regarding they got the question wrong.

            //how to solve the equation.
            /*2 (x - 6) + x = 12 || 2x - 6 + x = 12 || 2x - 6 + 6 + x = 12 + 6 
              2x + x = 18 || 3x = 18 || 3x / 3 = x || 18 / 3 = 6 || x = 6*/

            Console.ReadLine();

        }
    }
}
