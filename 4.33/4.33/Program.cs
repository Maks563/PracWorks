using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace _4._33
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double h = 1.5;
            double x = 0;
            double y;
            int negativeCount = 0;
            double max = double.MinValue;

            Console.WriteLine("x\t| y");

            while (x <= 15)
            {
                y = 7.1 * Math.Cos(x - 4) * Math.Sin(2 * x);


                Console.WriteLine("{0:F2}\t| {1:F2}", x, y);

                if (y < 0)
                {
                    negativeCount++;
                }

                if (y > max)
                {
                    max = y;
                }

                x += h;
            }

            Console.WriteLine("Кiлькiсть негативних значень: {0}", negativeCount);
            Console.WriteLine("Максимальне значення: {0:F2}", max);

            Console.WriteLine("Графiк: ");
            PrintGraph(0, 15, h);

            Console.ReadLine();
        }

        static void PrintGraph(double xMin, double xMax, double h) 
        {
            double x = xMin;
            double y;

            while (x <= xMax) 
            {
                y = 7.1 * Math.Cos(x - 4) * Math.Sin(2 * x);
                int sc = (int)Math.Round(y, MidpointRounding.AwayFromZero);
                string s = sc >= 0 ? "+" : "-";

                Console.WriteLine("{0,5:F2} | {1}", x, string.Format("{0," + (sc + 6) + "}", s).Replace(" ", "-"));
                x += h;
            }
        }
    }
}
