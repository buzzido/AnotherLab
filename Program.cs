using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGid
{
    class Program
    {

        static void Main(string[] args)
        {
            MyStructClass MyStruct = new MyStructClass();
            while (true)
            {
                Console.WriteLine("1. Вывести структуру.");
                Console.WriteLine("2. Сортировать структуру по курсу.");
                Console.WriteLine("3. Выход");
                ConsoleKeyInfo PressedButton = Console.ReadKey(true);
                if (PressedButton.KeyChar == '1')
                {
                    MyStruct.PrintStruct();
                }
                if (PressedButton.KeyChar == '2')
                {
                    MyStruct.SortStruct();
                    MyStruct.PrintStruct();
                }
                if (PressedButton.KeyChar == '3')
                {
                    break;
                }
            }
        }
    }
}
