using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter.src
{
    internal class DecimalToP1 : Converter
    {
        protected override string ConvertIntegerPart(string number, byte basis)
        {
            UInt64 integerPart = UInt64.Parse(number);
            string ipcn = String.Empty;
            do
            {
                ipcn = CharOfDigit((byte)(integerPart % basis)) + ipcn;
                integerPart /= basis;
            }
            while (integerPart > 0);
            return ipcn;
        }

        protected override string ConvertFractionPart(string number, byte basis)
        {
            double tmp;
            UInt64 tmp3;
            number = "0" + Program.DecimalPoint + number;
            double fractionPart = double.Parse(number);
            string result = String.Empty;
            int k = ((number.Length) * 10)/basis;
            double kk = ((number.Length) * 10.0)/basis;

            if(kk>0 && kk < 1)
            {
                k = 1;
            }

            while (k > 0)
            {
                tmp = fractionPart * basis;
                tmp3 = System.Convert.ToUInt64(tmp);
                if (tmp3 > tmp)
                {
                    tmp3--;
                }
                fractionPart = tmp - tmp3;
                result += CharOfDigit((byte)tmp3);
                k--;
            }
            while (result.Length > 0 && result[result.Length - 1] == '0')
                result = result.Substring(0, result.Length - 1);

            return result;

        }
    }
}
