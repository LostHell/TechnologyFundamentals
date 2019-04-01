using System;
using System.Numerics;

namespace Multiply_Big_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger firstNumber = BigInteger.Parse(Console.ReadLine());
            int secNumber = int.Parse(Console.ReadLine());

            BigInteger result = firstNumber * secNumber;

            Console.WriteLine(result);

        }
    }
}
