using System;
using System.Collections.Generic;

namespace MoneySumLibrary
{
    public class Money : IMoney
    {
        public double Sum { get; set; }
        public string Currency { get; set; }
        public double ExRate { get; set; }

        public Money()
        {
            Sum = 0;
            Currency = "USD";
            ExRate = 1;
        }

        public Money(double sum, string currency, double exRate)
        {
            Sum = currency == "USD" ? sum : sum * exRate;
            Currency = currency;
            ExRate = exRate;
        }

        public override string ToString()
        {
            return $"Sum: {Sum} USD (original currency: {Currency}, Exchange Rate: {ExRate})";
        }

        public override bool Equals(object obj)
        {
            return obj is Money money &&
                   Sum == money.Sum &&
                   Currency == money.Currency &&
                   ExRate == money.ExRate;
        }

        public override int GetHashCode()
        {
            int hashCode = 1506095576;
            hashCode = hashCode * -1521134295 + Sum.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Currency);
            hashCode = hashCode * -1521134295 + ExRate.GetHashCode();
            return hashCode;
        }

        public static Money operator +(Money a, Money b)
        {
            return new Money(a.Sum + b.Sum, "USD", 1);
        }

        public static Money operator +(Money a, double b)
        {
            return new Money(a.Sum + b, "USD", 1);
        }

        public static Money operator -(Money a, Money b)
        {
            return new Money(a.Sum - b.Sum, "USD", 1);
        }

        public static Money operator -(Money a, double b)
        {
            return new Money(a.Sum - b, "USD", 1);
        }

        public static bool operator true(Money a) => a.Sum > 0;

        public static bool operator false(Money a) => a.Sum <= 0;

        public static bool operator ==(Money a, Money b)
        {
            return a.Sum == b.Sum;
        }

        public static bool operator !=(Money a, Money b) => !(a == b);

        public static bool operator >(Money a, Money b)
        {
            return a.Sum > b.Sum;
        }

        public static bool operator <(Money a, Money b)
        {
            return a.Sum < b.Sum;
        }

        public static bool operator >=(Money a, Money b)
        {
            return a.Sum >= b.Sum;
        }

        public static bool operator <=(Money a, Money b)
        {
            return a.Sum <= b.Sum;
        }

        public static Money InputFromConsole()
        {
            Console.Write("Enter sum: ");
            double sum = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter currency (e.g., USD, EUR): ");
            string currency = Console.ReadLine();

            Console.Write("Enter exchange rate to USD: ");
            double exRate = Convert.ToDouble(Console.ReadLine());

            return new Money(sum, currency, exRate);
        }

        public static explicit operator double(Money m)
        {
            return m.Sum;
        }

        public static implicit operator Money(double value)
        {
            return new Money(value, "USD", 1);
        }
    }
}