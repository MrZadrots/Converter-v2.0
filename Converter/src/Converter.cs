using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter.src
{
    abstract class Converter
    {
        public string Convert(string number,byte basis,int fract_digits = -1)
        {
            string integer, fraction;
            SplitParts(number, out integer, out fraction); //выделение дробной и целой части

            string converted_number = ConvertIntegerPart(integer, basis); // Перевод целой части

            if (!String.IsNullOrEmpty(fraction))
            {
                converted_number += Program.DecimalPoint + ConvertFractionPart(fraction, basis);
            }

            return converted_number;
        }

        /// <summary>
        /// Выделение дробной и целой части из исходного числа.
        /// </summary>
        /// <param name="number"></param>
        /// <param name="integer"></param>
        /// <param name="fraction"></param>
        /// 

        protected void SplitParts(string number,out string integer, out string fraction)
        {
            string[] ret = number.Split(Program.DecimalPoint.ToCharArray(), 2, StringSplitOptions.None);
            integer = ret[0];
            fraction = (ret.Length > 1 ? ret[1] : String.Empty);
        }

        /// <summary>
        /// Конвертация целой части числа.
        /// </summary>
        /// <param name="number">Число в строковом формате.</param>
        /// <param name="basis">Основание системы.</param>
        /// <returns>Результат конвертации.</returns>
        abstract protected string ConvertIntegerPart(string number, byte basis);

        /// <summary>
        /// Конвертация дробной части числа.
        /// </summary>
        /// <param name="number">Число в строковом формате.</param>
        /// <param name="basis">Основание системы.</param>
        /// <returns>Результат конвертации/</returns>
        abstract protected string ConvertFractionPart(string number, byte basis);

        /// <summary>
        /// Возвращает десятичное значение цифры в какой-либо другой системе счисления.
        /// </summary>
        /// <param name="c">Символ цифры.</param>
        /// <returns>Значение цифры.</returns>
        /// 
        protected byte DigitOfChar(char c)
        {
            if (c >= '0' && c <= '9')
            {
                return (byte)(c - '0');
            }
            if(c>='A' && c <= 'F')
            {
                return (byte)(c - 'A' + 10);
            }

            return 0;
        }


        /// <summary>
        /// Возвращает цифру по её десятичному значению.
        /// </summary>
        /// <param name="digit"></param>
        /// <returns></returns>
        /// 
        protected char CharOfDigit(byte digit)
        {
            if (digit < 10)
            {
                return digit.ToString()[0];
            }
            else
            {
                return (char)(digit - 10 + 'A');
            }
        }
    }
}
