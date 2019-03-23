using System;
using System.Linq;

namespace currency_format_converter
{
    class Converter
    {
        public static void Main()
        {
            // Array to hold dollar amounts
            double[] amounts = new double[3];
            Console.WriteLine("Enter a dollar amount:");
            int i = 0;

            while (amounts.Contains(0)) 
            {
                Console.Write("$");
                try
                {
                    double amount = Convert.ToDouble(Console.ReadLine());
                    amounts[i] = amount;
                    i += 1;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter a dollar amount formatted as: 1.00");
                    continue;
                }
            }

            // New instance of CurrencyCalculator 
            CurrencyCalculator calculator = new CurrencyCalculator(amounts);

            // Call ReturnTotal method
            double total = calculator.ReturnTotal();
            // Call ReturnMean method
            double mean = calculator.ReturnMean();
            // Call ReturnLargest method
            double largest = calculator.ReturnLargest();
            // Call ReturnSmallest method
            double smallest = calculator.ReturnSmallest();

            Console.WriteLine("The total cost is: $" + total);
            Console.WriteLine("The average cost of the items is: $" + Math.Round(mean, 2));
            Console.WriteLine("The most expensive item is: $" + largest);
            Console.WriteLine("The least expensive item is: $" + smallest);
        }
    }
}
