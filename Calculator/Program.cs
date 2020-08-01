using System;
using System.Collections.Generic;
using System.Linq;

namespace Calculator
{
    class Program
    {
        private static void Maths(string numbers)
        {
            char op = numbers[0]; // save the operator to determine type of operation to perform
            string[] numbs = numbers.Split(","); 
            numbs = numbs.Skip(1).ToArray(); //remove operator so you don't break the type conversions
            int[] nums = numbs.Select(int.Parse).ToArray();
            List<double> powers = new List<double>(); //List is variable in size vs. array. also, Math.Pow saves as double so make sure type is correct

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

            switch (op)
            {
                case '*':
                    Console.WriteLine($"The product of your numbers is: {prod}");
                    break;
                case '+':
                    Console.WriteLine($"The sum of your numbers is: {sum}");
                    break;
                case '^':
                    Console.WriteLine($"Your numbers raised to the second power: {powerList}");
                    break;
                default:
                    Console.WriteLine($"The sum of your numbers is: {sum}");
                    Console.WriteLine($"The product of your numbers is: {prod}");
                    Console.WriteLine($"Your numbers raised to the second power: {powerList}");
                    break;
            }
        }
        static void Main(string[] args)
        {
            string input;
            do
            {
                Console.WriteLine("Enter the operator, followed by the numbers you want to math:");
                input = Console.ReadLine();
                Maths(input);
            } while (input != "exit");
            
        }
    }
}
