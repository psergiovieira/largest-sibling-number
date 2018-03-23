﻿using System;
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
            var dic = new Sibling[9];
            var numberSplited = n.ToString().Select(c => int.Parse(new string(c,1))).ToList();
            foreach (var partNumber in numberSplited)
            {
                if (dic[partNumber] == null)
                    dic[partNumber] = new Sibling {Number = partNumber.ToString()};
                else
                    dic[partNumber].Number += partNumber;
            }

            var result = string.Empty;
            for (var i = 8; i >= 0; i--)
            {
                if (dic[i] != null)
                    result += dic[i].Number;
            }

            return int.Parse(result);
        }
    }

    public class Sibling
    {
        public string Number { get; set; }
    }
}