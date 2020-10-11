
using System;
using System.Collections.Generic;

namespace Calculate
{
    class Program
    {

        static void Main(string[] args)
        {
            var chose = UserMenu();
            switch (chose)
            {
                case "1":
                    {
                        Console.Write(" Enter sin(): ");
                        var ValueFromSin = (Console.ReadLine());
                        var calculateSin = DefineSin(ValueFromSin);
                        var finalValue = Decimal.Round(calculateSin, 3);
                        Console.WriteLine("\n the sin() is: " + finalValue);
                        Console.Read();
                        break;
                    }
                case "2":
                    {
                        Console.Write(" Enter cos(): ");
                        var ValueFromCos = (Console.ReadLine());
                        var calculateCos = DefineSin(ValueFromCos);
                        var finalValue = Decimal.Round(calculateCos, 3);
                        Console.WriteLine("\n the cos() is: " + finalValue);
                        Console.Read();
                        break;
                    }
                case "3":
                    {
                        Console.Write(" Enter tg(): ");
                        var ValueTG = (Console.ReadLine());
                        var calculateSin = DefineSin(ValueTG);
                        var finalValueSin = Decimal.Round(calculateSin, 3);
                        var calculateCos = DefineSin(ValueTG);
                        var finalValueCos = Decimal.Round(calculateCos, 3);
                        Console.WriteLine("\n the tg() value is: " + finalValueSin / finalValueCos);
                        Console.Read();
                        break;
                    }
                case "0":
                    {
                        break;
                    }
            }



        }
        static string UserMenu()
        {
            Console.Write(" Hello, what function do you want to use?\n 1-Calculate the sin()\n 2-Calculate the cos()\n 3-Calculate the tg()\n 0-Leave\n ");
            string userChose = Console.ReadLine();
            return userChose;
        }
        static decimal DefineSin(string valueOfSin)
        {
            decimal sum = 0;
            for (int i = 1; i < 18; i++)
            {
                var chosedSin = (Convert.ToDecimal(valueOfSin));
                var dec = (Math.PI / 180);
                var rad = Convert.ToDecimal(dec) * chosedSin;
                decimal y = (-1 + 2 * i);
                var upPart = Math.Pow(Convert.ToDouble(rad), Convert.ToDouble(y));
                var downPart = 1;
                for (int fact = 1; fact <= y; fact++)
                {
                    downPart = downPart * fact;
                }
                var result = Convert.ToDecimal(Convert.ToDecimal(upPart) / Convert.ToDecimal(downPart)) * Convert.ToDecimal(-1 * Math.Pow(-1, i));
                sum = sum + result;
                Console.WriteLine(' ' + sum.ToString());
            }
            return sum;

        }
        static decimal CalculateCos(string CosValue)
        {
            decimal value = Convert.ToDecimal(CosValue);
            var PI = Convert.ToDecimal(Math.PI / 180);
            decimal radValue = PI * value;
            decimal sum = radValue;
            for (int i = 1; i < 18; i++)
            {
                var y = (i * 2);
                var upPart = Math.Pow(Convert.ToDouble(radValue), Convert.ToDouble(y));
                var downPart = 1;
                for (int fact = 1; fact <= y; fact++)
                {
                    downPart = downPart * fact;
                }
                var result = Convert.ToDecimal(Convert.ToDecimal(upPart) / Convert.ToDecimal(downPart)) * Convert.ToDecimal(Math.Pow(-1, i));
                sum = sum + result;
                Console.WriteLine(' ' + sum.ToString());
            }
            return sum;

        }




    }
}
