using System;
using System.Collections.Generic;
using System.Linq;

namespace Calculator
{
    class Program
    {
        private static void Operator(string numbers)
        {
            string[] numbs = numbers.Split(",");
            int[] nums = numbs.Select(int.Parse).ToArray();
            List<double> powers = new List<double>();

            int sum = nums.Sum();
            int prod = 1;
            double power = 0;
            
            foreach (int value in nums)
            {
                prod *= value;
                power = Math.Pow(value, 2);
                powers.Add(power);
                
            }

            string powerList = String.Join(", ", powers);

            Console.WriteLine($"The sum of your numbers is: {sum}");
            Console.WriteLine($"The product of your numbers is: {prod}");
            Console.WriteLine($"Your numbers raised to the second power: {powerList}");

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the numbers you would like to multiply:");
            var input = Console.ReadLine();
            Operator(input);
        }
    }
}
