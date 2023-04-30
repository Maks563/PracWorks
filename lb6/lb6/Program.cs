using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Numerics;

namespace lb6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введiть степiнь, до якої пiдносити числа:");
            int power = int.Parse(Console.ReadLine());

            
            string filePath = "input.txt";
            

            if (!File.Exists(filePath))
            {
                Console.WriteLine($"Файл {filePath} не знайдено!");
                return;
            }

            string fileContents = File.ReadAllText(filePath);
            string[] numbers = fileContents.Split((char[])null, StringSplitOptions.RemoveEmptyEntries);

            foreach (string number in numbers)
            {
                BigInteger bigInteger = BigInteger.Parse(number);
                BigInteger result = BigInteger.Pow(bigInteger, power);
                Console.WriteLine($"{bigInteger}^{power} = {result}");
            }
        }
    
    }
}
