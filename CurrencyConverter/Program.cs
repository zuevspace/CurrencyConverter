using System;
using System.Diagnostics;

namespace CurrencyConverter
{
    class Program
    {
        public static double currencyAmount;
        static void Main(string[] args)
        {
            Console.WriteLine("Currency Convector 1.0");

            bool work = true;
            
            while (work)
            {
                Console.WriteLine("Что вы хотите поменять?\n1.UDS 2.RUB");
            
                int yourСurrency = Int32.Parse(Console.ReadLine());
                double oneDollar = 77.32;

                ChangeCurrency(yourСurrency, oneDollar);
                Console.WriteLine("Конверсия валюты завершена!");
                Console.WriteLine("Напиши \"ВЫХОД\" чтобы выйти");
                string exit = Console.ReadLine().ToLower();

                if (exit == "выход")
                {
                    work = false;
                }
                
            }
        }

        static void ChangeCurrency(double currency, double dollar)
        {
            switch (currency)
            {
                case 1:
                    Console.WriteLine("Напишите вашу сумму UDS которую нужно поменять:");
                    currencyAmount = double.Parse(Console.ReadLine());
                    Console.WriteLine($"{Math.Round(currencyAmount * dollar)} RUB");
                    break;
                case 2:
                    Console.WriteLine("Напишите вашу сумму RUB которую нужно поменять:");
                    currencyAmount = double.Parse(Console.ReadLine());
                    Console.WriteLine($"{Math.Round(currencyAmount / dollar)} UDS");
                    break;
                default:
                    Console.WriteLine("Мы не поняли ваш запрос.");
                    break;
            }
        }
    }
}
