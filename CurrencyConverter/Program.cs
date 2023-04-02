using System;

namespace CurrencyConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Currency Convector 1.0");
            Console.WriteLine("Что вы хотите поменять?\n1.UDS 2.RUB");

            int from = Int32.Parse(Console.ReadLine());

            switch (from)
            {
                case 1:
                    Console.WriteLine("Вы попали в кейс 1");
                    break;
                case 2:
                    Console.WriteLine("Вы попали в кейс 2");
                    break;
                default:
                    Console.WriteLine("Вы попали в кейс 3");
                    break;
            }
            
            Console.WriteLine(from);
        }
    }
}
