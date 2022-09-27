using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter.src
{
    internal class Editor
    {
        /// <summary>
        /// Контролирует процедуру редактирования числа как строки.
        /// </summary>
        /// <param name="number">Число в строковом формате.</param>
        /// <param name="p1">Основание системы счисления вводимого числа.</param>
        /// <returns></returns>
        public string DoEditing(string number, byte p1)
        {
            number = this.CorrectInput(number);
            char c = this.FindIncorrectSymbol(number, p1);
            if (c != char.MinValue)
                number = this.CorrectEnteredString(c, number);

            if (this.CheckSpecCount(number) > 1) // если точек больше одной, убрать последний введенный символ (точку)
                number = number.Substring(0, number.Length - 1);

            return number;
        }

        /// <summary>
        /// Убирает недопустимый символ из строки.
        /// </summary>
        /// <param name="c">Символ.</param>
        /// <param name="number">Строка, содержащая число.</param>
        /// <returns>Откорректированная строка.</returns>
        protected string CorrectEnteredString(char c, string number)
        {
            return number.Replace(c.ToString(), "");
        }

        /// <summary>
        /// Проверка символа на возможность использования в данной n-чной системе.
        /// </summary>
        /// <param name="c">Символ.</param>
        /// <param name="p1">Основание системы.</param>
        /// <returns>true, если символ доступен для использования; false, если нет.</returns>
        protected bool CheckSymbol(char c, byte p1)
        {
            int n = p1;
            bool check_sym = false;
            if (c >= '0' && c <= '9')
            {
                if (c < '0' + n)
                    check_sym = true;
                else
                    check_sym = false;
            }
            else
            {
                if (c >= 65 && c < 55 + n) // ???
                    check_sym = true;
                else
                    if (c >= 97 && c < 87 + n) // ???
                    check_sym = true;
            }
            if ((c == Program.DecimalPoint[0]) || (c == '-'))
                check_sym = true;
            return check_sym;
        }

        /// <summary>
        /// Нахождение недопустимого символа в строке.
        /// </summary>
        /// <param name="str">Исходная строка.</param>
        /// <param name="p1">Основание используемой системы счисления.</param>
        /// <returns>Найденный символ. Char.MinValue, если недопустимых символов не обнаружено.</returns>
        protected char FindIncorrectSymbol(string str, byte p1)
        {
            char ret = char.MinValue;
            for (int i = 0; i < str.Length; i++)
            {
                if (!CheckSymbol(str[i], p1))
                {
                    ret = str[i];
                    break;
                }
            }
            return ret;
        }

        /// <summary>
        /// Исправление часто встречающихся неточностей ввода: десятичная точка в начале числа, регистр букв и прочее.
        /// </summary>
        /// <param name="number">Число в строковом формате.</param>
        /// <returns></returns>
        protected string CorrectInput(string number) // проверка корректности 
        {
            char tmp;
            if (number == Program.DecimalPoint) // если поставили точку, то добавить ноль перед ней
                number = "0" + Program.DecimalPoint;
            if (number == "0" || number == "-") // если при удалении цифр остается ноль или минус очистить строку
                number = "0";

            string str = number;
            for (int i = 0; i < number.Length; i++)
            {
                // преобразование букв в верхний регистр
                if (str[i] >= 'a' && str[i] <= 'f')
                {
                    tmp = str[i];
                    tmp -= (char)32;
                    str = str.Replace(str[i], tmp);
                }
            }
            return str;
        }

        /// <summary>
        /// Проверка на количество точек или запятых.
        /// </summary>
        /// <param name="number">Строка для проверки.</param>
        /// <returns>Количество специальных символов в строке.</returns>
        protected int CheckSpecCount(string number)
        {
            int k = 0;
            for (int i = 0; i < number.Length; i++)
                if (number[i] == '.' || number[i] == ',')
                    k++;
            return k;
        }


    }

}
