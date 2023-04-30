using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace la5
{
    internal class Program
    {
        enum City
        {
            Київ,
            Львiв,
            Одеса,
            Париж,
            Марсель,
            Лiон,
            Берлiн,
            Мюнхен,
            Гамбург
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Списрк мiст:");
            Console.WriteLine($"{(int)City.Київ}. {City.Київ}");
            Console.WriteLine($"{(int)City.Львiв}. {City.Львiв}");
            Console.WriteLine($"{(int)City.Одеса}. {City.Одеса}");
            Console.WriteLine($"{(int)City.Париж}. {City.Париж}");
            Console.WriteLine($"{(int)City.Марсель}. {City.Марсель}");
            Console.WriteLine($"{(int)City.Лiон}. {City.Лiон}");
            Console.WriteLine($"{(int)City.Берлiн}. {City.Берлiн}");
            Console.WriteLine($"{(int)City.Мюнхен}. {City.Мюнхен}");
            Console.WriteLine($"{(int)City.Гамбург}. {City.Гамбург}");

            Console.WriteLine("Введiть номери мiст, якi б ви хотiли вiдвiдати, через кому:");
            string input = Console.ReadLine();
            string[] selectedCityNumbers = input.Split(',');
            Console.WriteLine("Вибранi країни:");
            foreach (string cityNumber in selectedCityNumbers)
            {
                int city = int.Parse(cityNumber);
                switch (city)
                {
                    case (int)City.Київ:
                    case (int)City.Львiв:
                    case (int)City.Одеса:
                        Console.WriteLine($"{city}. Україна - {((City)city).ToString()}");
                        break;
                    case (int)City.Париж:
                    case (int)City.Марсель:
                    case (int)City.Лiон:
                        Console.WriteLine($"{city}. Францiя - {((City)city).ToString()}");
                        break;
                    case (int)City.Берлiн:
                    case (int)City.Мюнхен:
                    case (int)City.Гамбург:
                        Console.WriteLine($"{city}. Нiмеччина - {((City)city).ToString()}");
                        break;
                    default:
                        Console.WriteLine($"{city}. Неопiзнане мiсто");
                        break;
                }
            }

            Console.WriteLine("Автор програми: Семенченко Максим");

        }
    }
}
