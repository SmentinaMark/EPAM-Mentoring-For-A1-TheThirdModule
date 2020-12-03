using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку чисел: ");
            string a = Console.ReadLine();

            int res = a.MyStringToInt();
            Console.WriteLine("Число: " + (res));
        }
    }
}
