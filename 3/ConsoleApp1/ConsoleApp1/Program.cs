using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string str="";
            while (str != "Exit")
            {
                try
                {
                    Console.Write("Введите строку(Для выхода Exit): ");
                    str = Console.ReadLine();
                    if(str =="Exit")
                    {
                        break;
                    }
                    Console.WriteLine(FirstCharacter.FirsrCharacterMethod(str));
                }
                catch(IndexOutOfRangeException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            } 
        }
    }
}
