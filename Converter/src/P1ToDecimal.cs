using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter.src
{
    internal class P1ToDecimal : Converter
    {
        protected override string ConvertIntegerPart(string number, byte basis)
        {
            UInt64 sum = 0, pr = 1;
            for (int i = number.Length - 1; i >= 0; i--, pr *= basis)
            {
                sum += (UInt64)DigitOfChar(number[i]) * pr;
            }
            return sum.ToString();
        }

        protected override string ConvertFractionPart(string number, byte basis)
        {
            double sum = 0, pr = 1.0 / basis;
            for(int i = 0; i < number.Length; i++, pr /= basis)
            {
                sum += (UInt64)DigitOfChar(number[i]) * pr;
            }
            return sum.ToString().Substring(2);
        }
    }
}
