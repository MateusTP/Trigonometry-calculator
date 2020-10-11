using System;
using System.Collections.Generic;
namespace ConsoleApp35
{
    class Program
    {

        static void Main(string[] args)
        {
            decimal sum = 0;
            Console.Write(" Enter sin: ");
            var value = Console.ReadLine();
            
            for (int i = 1; i < 18; i++) {
                var chosedSin = (Convert.ToDecimal(value));
                var dec = (Math.PI / 180);
                var rad = Convert.ToDecimal(dec) * chosedSin;
                decimal y = (-1 + 2 * i);
                var upPart = Math.Pow(Convert.ToDouble(rad), Convert.ToDouble(y));
                var downPart = 1;
                for(var fact = 1; fact <= y; fact++)
                {
                    downPart = downPart * fact;
                }
                var result = Convert.ToDecimal(Convert.ToDecimal(upPart) / Convert.ToDecimal(downPart)) * Convert.ToDecimal(-1 * Math.Pow(-1, i));
                sum = sum + result;
                Console.WriteLine(' ' + sum.ToString());
            }
            
            var finalValue = Decimal.Round(sum, 3);
            Console.WriteLine("\n the sin is: " + finalValue);
            Console.Read();
        }

    }
}
