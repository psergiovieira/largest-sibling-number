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
        private const int _DECIMAL_PLACES = 9;

        public int Largest(int n)
        {
            if (n <= 0)
                throw new ArgumentException($"{n} {_NOT_A_POSITIVE_NUMBER_MSG}");

            if (n > _BIGGEST_NUMBER)
                return _NUMBER_FOR_OUTPUT_ERROR;

            var dictionary = new Entry[_DECIMAL_PLACES];
            var numberSplited = n.ToString().Select(c => int.Parse(new string(c, 1))).ToList();
            foreach (var partNumber in numberSplited)
            {
                if (dictionary[partNumber] == null)
                    dictionary[partNumber] = new Entry { Value = partNumber.ToString() };
                else
                    dictionary[partNumber].Value += partNumber;
            }
            var output = FormatOutput(dictionary);

            return output;
        }

        private int FormatOutput(Entry[] dictionary)
        {
            var output = string.Empty;
            for (var i = _DECIMAL_PLACES - 1; i >= 0; i--)
            {
                if (dictionary[i] != null)
                    output += dictionary[i].Value;
            }

            return int.Parse(output);
        }
    }
}
