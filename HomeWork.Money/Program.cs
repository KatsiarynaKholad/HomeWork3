using System;

namespace HomeWork.Money
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintMenu();

        }
        static void PrintMenu()
        {
            Console.WriteLine("please entar a operation:");
            Console.WriteLine("1: X+Y");
            Console.WriteLine("2: X-Y");
            Console.WriteLine("3: X/Y");
            Console.WriteLine("4: (X+Y)/Z (when Z is a fractional number");
            Console.WriteLine("5: X*Z (when Z is a fractional number");
            Console.WriteLine("6: Comparison operation");

            var isChoice = int.TryParse(Console.ReadLine(), out var operation);
            if (isChoice && operation <= 6)
            {
                SelectedBlock(operation);
            }
            else
            {
                Console.WriteLine("You entar a wrong number");
            }
        }

        static void SelectedBlock(int operation)
        {
            Console.WriteLine("Please enter rubles 1:");
            var isRublFirstNumber = long.TryParse(Console.ReadLine(), out long rublFirstNumber);

            Console.WriteLine("Please enter pennies 1:");
            var isPenFirstNumber = byte.TryParse(Console.ReadLine(), out byte penniesFirstNumber);

            var money = new Money();

            if (isRublFirstNumber && isPenFirstNumber)
            {
                double firstMoney = money.ConvertToDouble(rublFirstNumber, penniesFirstNumber);

                if (operation != 5)
                {
                    Console.WriteLine("Please enter rubles 2:");
                    var isRublSecondNumber = long.TryParse(Console.ReadLine(), out long rublSecondNumber);

                    Console.WriteLine("Please enter pennies 2:");
                    var isPenSecondNumber = byte.TryParse(Console.ReadLine(), out byte penniesSecondNumber);

                    if (isRublSecondNumber && isPenSecondNumber)
                    {
                        double secondMoney = money.ConvertToDouble(rublSecondNumber, penniesSecondNumber);
                        if (operation == 4)
                        {
                            Console.WriteLine("Please enter a fractional number:");
                            var isFractionalNumber = double.TryParse(Console.ReadLine(), out double fractionalNumber);
                            if (isFractionalNumber)
                            {
                                money.DoDivisionOnFractionNumber(firstMoney, secondMoney, fractionalNumber);
                            }
                            else
                            {
                                Console.WriteLine("You don't enter a number or you enter a wrong number");
                            }

                        }
                        else
                        {
                            switch (operation)
                            {
                                case 1:
                                    money.DoSum(firstMoney, secondMoney);
                                    break;
                                case 2:
                                    money.DoSubstraction(firstMoney, secondMoney);
                                    break;
                                case 3:
                                    money.DoDivision(firstMoney, secondMoney);
                                    break;
                                case 6:
                                    money.A = firstMoney;
                                    var money2 = new Money { A = secondMoney };
                                    var result = money.CompareTo(money2);
                                    if (result == 0)
                                    {
                                        Console.WriteLine($"The first number = {firstMoney} equals the second number = {secondMoney}");
                                    }
                                    else if (result == 1)
                                    {
                                        Console.WriteLine($"The first number = {firstMoney} more than the second number = {secondMoney}");
                                    }
                                    else
                                    {
                                        Console.WriteLine($"The first number = {firstMoney} less than the second number = {secondMoney}");
                                    }
                                    break;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("You don't enter a number or you enter a wrong number");
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a fractional number:");
                    var isFractionalNumber = double.TryParse(Console.ReadLine(), out double fractionalNumber);
                    if (isFractionalNumber)
                    {
                        money.DoMyltiplicationOnFractionNumber(firstMoney, fractionalNumber);
                    }
                    else
                    {
                        Console.WriteLine("You don't enter a number or you enter a wrong number");
                    }
                }
            }
            else
            {
                Console.WriteLine("You don't enter a number or you enter a wrong number");
            }


        }
    }
}

