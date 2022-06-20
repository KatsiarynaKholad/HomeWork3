using System;

namespace HomeWork3.Fractions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a whole part for first number:");
            var isFirstPartFirstNumber = int.TryParse(Console.ReadLine(), out int firstPartFirstNumber);

            Console.WriteLine("Please enter a fractional part (but value must be positive) for first number:");
            var isSecondPartFirstNumber = uint.TryParse(Console.ReadLine(), out uint secondPartFirstNumber);

            var number = new Fraction();

            double firstNumber = number.ConvertToDouble(firstPartFirstNumber, secondPartFirstNumber);

            Console.WriteLine("Please enter a whole part for second number:");
            var isFirstPartSecondNumber = int.TryParse(Console.ReadLine(), out int firstPartSecondNumber);

            Console.WriteLine("Please enter a fractional part (but value must be positive) for second number:");
            var isSecondPartSecondNumber = uint.TryParse(Console.ReadLine(), out uint secondPartSecondNumber);

            double secondNumber = number.ConvertToDouble(firstPartSecondNumber, secondPartSecondNumber);

            Console.WriteLine("please enter operations:");
            Console.WriteLine("1 -  X + Y");
            Console.WriteLine("2 -  X - Y");
            Console.WriteLine("3 -  X * Y");
            Console.WriteLine("4 - Comparison operation");

            var isOperation = int.TryParse(Console.ReadLine(), out var operation);

            if (operation <= 4 && operation > 0)
            {

                var result = DoOperation(operation, firstNumber, secondNumber);
                if (operation == 4)
                {
                    if (result == 0)
                    {
                        Console.WriteLine($"The first number = {firstNumber} equals the second number = {secondNumber}");
                    }
                    else if (result == 1)
                    {
                        Console.WriteLine($"The first number = {firstNumber} more than the second number = {secondNumber}");
                    }
                    else
                    {
                        Console.WriteLine($"The first number = {firstNumber} less than the second number = {secondNumber}");
                    }
                }
                else
                {
                    Console.WriteLine($"firstNumber = {firstNumber}\nsecondNumber= {secondNumber}\nresult = {result}");
                }
            }

            else
            {
                Console.WriteLine("You enter a wrong number");
            }
        }
        static double DoOperation(int a, double firstNumber, double secondNumber)
        {
            var obj1 = new Fraction { A = firstNumber };
            var obj2 = new Fraction { A = secondNumber };

            switch (a)
            {
                case 1:
                    var result = obj1.DoSum(firstNumber, secondNumber);
                    return result;
                case 2:
                    result = obj1.DoSubtraction(firstNumber, secondNumber);
                    return result;
                case 3:
                    result = obj1.DoMyltiplication(firstNumber, secondNumber);
                    return result;
                case 4:
                    result = obj1.CompareTo(obj2);
                    return result;
            }
            return 0;
        }
    }
}