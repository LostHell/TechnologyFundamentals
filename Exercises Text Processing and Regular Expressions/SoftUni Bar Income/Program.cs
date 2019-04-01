using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace SoftUni_Bar_Income
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\%(?<customer>[A-Z][a-z]+)\%\<(?<products>\w+)\>\w*\|(?<quantity>[0-9]+)\|[a-z]*(?<price>[0-9]+.[0-9]*)\$";

            string input = Console.ReadLine();
            double totalIncome = 0.0;

            while (input != "end of shift")
            {
                Regex order = new Regex(pattern);
                double sum = 0.0;
                if (order.IsMatch(input))
                {
                    string name = order.Match(input).Groups["customer"].Value;
                    string product = order.Match(input).Groups["products"].Value;
                    int quantity = int.Parse(order.Match(input).Groups["quantity"].Value);
                    double price = double.Parse(order.Match(input).Groups["price"].Value);
                    sum = quantity * price;
                    Console.WriteLine($"{name}: {product} - {sum:F2}");
                    totalIncome += sum;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Total income: {totalIncome:F2}");
        }
    }
}
