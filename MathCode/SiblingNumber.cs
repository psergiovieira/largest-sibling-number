using System;
using System.Collections.Generic;
using System.Linq;


namespace MathCode
{
    public class SiblingNumber
    {
        private const string _NOT_A_POSITIVE_NUMBER_MSG = "is not a positive integer.";
        private const int _BIGGEST_NUMBER = 100000000;
        private const int _NUMBER_FOR_OUTPUT_ERROR = -1;
        private const int _DECIMAL_PLACES = 10;

        public int Largest(int number)
        {
            if (number <= 0)
                throw new ArgumentException($"{number} {_NOT_A_POSITIVE_NUMBER_MSG}");

            if (number > _BIGGEST_NUMBER)
                return _NUMBER_FOR_OUTPUT_ERROR;
            
            var numbers = GetDigitsFromNumber(number);
            var groupedDigits = GroupByNumberOnArray(numbers);
            var output = GetNumberFromOrderedDescDigits(groupedDigits);

            return output;
        }

        private string[] GroupByNumberOnArray(IEnumerable<int> numbers)
        {
            var digits = new string[_DECIMAL_PLACES];
            foreach (var number in numbers)
            {
                if (digits[number] == null)
                    digits[number] = number.ToString();
                else
                    digits[number] += number;
            }

            return digits;
        }

        private IEnumerable<int> GetDigitsFromNumber(int number)
        {
            return number.ToString().Select(c => int.Parse(new string(c, 1)));
        }

        private int GetNumberFromOrderedDescDigits(IReadOnlyList<string> digits)
        {
            var output = string.Empty;
            for (var i = _DECIMAL_PLACES - 1; i >= 0; i--)
            {
                if (digits[i] != null)
                    output += digits[i];
            }

            return int.Parse(output);
        }
    }
}
