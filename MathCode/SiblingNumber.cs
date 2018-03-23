using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MathCode
{
    public class SiblingNumber
    {
        public int Largest(int n)
        {
            if (n <= 0)
                throw new ArgumentException($"{n} is not a positive integer.");

            if (n > 100000000)
                return -1;

            var dic = new Sibling[9];
            var numberSplited = n.ToString().Select(c => int.Parse(new string(c,1))).ToList();
            foreach (var partNumber in numberSplited)
            {
                if (dic[partNumber] == null)
                    dic[partNumber] = new Sibling {Number = partNumber.ToString()};
                else
                    dic[partNumber].Number += partNumber;
            }

            var output = string.Empty;
            for (var i = 8; i >= 0; i--)
            {
                if (dic[i] != null)
                    output += dic[i].Number;
            }

            return int.Parse(output);
        }
    }

    public class Sibling
    {
        public string Number { get; set; }
    }
}
