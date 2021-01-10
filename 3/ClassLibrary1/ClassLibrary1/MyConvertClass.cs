using System;

namespace ClassLibrary1
{
    public static class MyConvertClass
    {
        public static int MyStringToInt(this string str) //расширяющий метод
        {
            int d = 1, result = 0;
            int StartPosition = 0;
            bool IsNumberNegative = false;

            try
            {
                switch (str[0]) // проверка нулевой позиции строки на наличие знака
                {
                    case '-':
                        StartPosition = 1;
                        IsNumberNegative = true;
                        break;
                    case '+':
                        StartPosition = 1;
                        break;
                }
            }
            catch(IndexOutOfRangeException ex)
            {
                Console.WriteLine("Необходимо ввести данные! " + ex.Message);
            }

            for (int i = str.Length - 1; i >= StartPosition; i--)
            {
                if(str[i] >= 48 && str[i] <= 57)  //числа от 0 до 9 по ASCII
                {
                    result = (str[i] - 48) * d + result;
                    d *= 10;
                }
                else
                {
                    Console.WriteLine("Неверный формат введенной строки! ");
                    return 0;
                }
            }
            return (IsNumberNegative) ? -result : result; 
        }
    }
}
