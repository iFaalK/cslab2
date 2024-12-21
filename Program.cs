using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoneySumLibrary;

namespace MoneyClientProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Money money1 = new Money(100, "USD", 1);
            Money money2 = new Money(200, "EUR", 1.1);
            Money money3 = new Money(150, "USD", 1);

            Console.WriteLine("Creating Money objects:");
            Console.WriteLine($"Money 1: {money1}");
            Console.WriteLine($"Money 2: {money2}");
            Console.WriteLine($"Money 3: {money3}");
            Console.WriteLine();

            Money sum = money1 + money2;
            Money difference = money1 - money3;

            Console.WriteLine("Addition and Subtraction operations:");
            Console.WriteLine($"Money 1 + Money 2: {sum}");
            Console.WriteLine($"Money 1 - Money 3: {difference}");
            Console.WriteLine();

            Money sumWithNumber = money1 + 50;
            Money differenceWithNumber = money2 - 30;

            Console.WriteLine("Operations with numbers:");
            Console.WriteLine($"Money 1 + 50: {sumWithNumber}");
            Console.WriteLine($"Money 2 - 30: {differenceWithNumber}");
            Console.WriteLine();

            Console.WriteLine("Comparison operations:");
            Console.WriteLine($"Money 1 == Money 3: {money1 == money3}");
            Console.WriteLine($"Money 1 != Money 2: {money1 != money2}");
            Console.WriteLine($"Money 1 > Money 3: {money1 > money3}");
            Console.WriteLine($"Money 2 < Money 1: {money2 < money1}");
            Console.WriteLine($"Money 1 >= Money 3: {money1 >= money3}");
            Console.WriteLine($"Money 2 <= Money 3: {money2 <= money3}");
            Console.WriteLine();

            double moneyValue = (double)money1;
            Console.WriteLine($"Money 1 as double: {moneyValue}");
            Console.WriteLine();

            Money userMoney = Money.InputFromConsole();
            Console.WriteLine("Entered money: " + userMoney);
        }
    }
}
