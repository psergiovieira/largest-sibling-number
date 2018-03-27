using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathCode;

namespace App
{
    public class Program
    {
        static void Main(string[] args)
        {
            int userInput;
            do
            {
               userInput  = Calculate();
            } while (userInput != -1);
        }

        private static int Calculate()
        {
            Console.WriteLine("Please enter a number to discover your largest sibling number or -1 to exit");
            var result = Console.ReadLine();
            var inputNumber = Convert.ToInt32(result);
            
            if (inputNumber != -1)
            {
                var siblingNumber = new SiblingNumber();
                var largestSiblingNumber = siblingNumber.Largest(inputNumber);
                Console.WriteLine($"The sibling number is {largestSiblingNumber}");
                return largestSiblingNumber;
            }

            return inputNumber;
        }
    }
}
