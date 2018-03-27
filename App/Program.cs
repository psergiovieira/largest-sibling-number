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
            try
            {
                int userInput;
                do
                {
                    userInput = Calculate();
                } while (userInput != -1);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
            catch (FormatException ex)
            {

                Console.WriteLine("Invalid number");
                Console.ReadLine();
            }
            catch (OverflowException ex)
            {

                Console.WriteLine("Number is too larger");
                Console.ReadLine();
            }
            catch (Exception ex)
            {

                Console.WriteLine("Fatal Error");
                Console.ReadLine();
            }
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
                if (largestSiblingNumber == -1)
                {
                    Console.WriteLine("The result exceeds 100,000,000");
                    Console.ReadLine();
                    return largestSiblingNumber;
                }

                Console.WriteLine($"The sibling number is {largestSiblingNumber}");
                return largestSiblingNumber;
            }

            return inputNumber;
        }
    }
}
