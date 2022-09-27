using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter.src
{
    public static class Control
    {
        /// <summary>
        /// Осуществляет конвертирование числа, записанного в одной системе счисления, в другую систему счисления.
        /// </summary>
        /// <param name="str">Строка, содержащая число.</param>
        /// <param name="p1">Основание исходной системы счисления.</param>
        /// <param name="p2">Основание желаемой системы счисления.</param>
        /// <returns></returns>
        /// 
        public static string DoConversion(string str,byte p1,byte p2)
        {
            bool isNegative = false;
            //Проверка на знак
            if (str[0] == '-')
            {
                str = str.Substring(1);
                isNegative = true;
            }

            if (p1 != 10)
            {
                var toDecimal = new P1ToDecimal();
                str = toDecimal.Convert(str, p1);
            }

            if (p2 != 10)
            {
                var fromDecimal = new DecimalToP1();
                str = fromDecimal.Convert(str, p2);
            }

            if (isNegative)
                str = "-" + str;

            return str;
        }
    }
}
