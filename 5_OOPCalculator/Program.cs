using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_OOPCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the OOP Calculator!");

            while (true)
            {
                try
                {
                    Console.WriteLine("\nChoose an operation:");
                    Console.WriteLine("1. Addition");
                    Console.WriteLine("2. Subtraction");
                    Console.WriteLine("3. Multiplication");
                    Console.WriteLine("4. Division");
                    Console.WriteLine("5. Exit");

                    Console.Write("Enter your choice: ");
                    int choice = int.Parse(Console.ReadLine());

                    if (choice == 5)
                    {
                        Console.WriteLine("Thank you for using the calculator. Goodbye!");
                        break;
                    }

                    Console.Write("Enter the first number: ");
                    double number1 = double.Parse(Console.ReadLine());

                    Console.Write("Enter the second number: ");
                    double number2 = double.Parse(Console.ReadLine());

                    Calculator calculator;

                    switch (choice)
                    {
                        case 1:
                            calculator = new Addition();
                            break;
                        case 2:
                            calculator = new Subtraction();
                            break;
                        case 3:
                            calculator = new Multiplication();
                            break;
                        case 4:
                            calculator = new Division();
                            break;
                        default:
                            throw new InvalidOperationException("Invalid choice. Please select a valid operation.");
                    }

                    calculator.Number1 = number1;
                    calculator.Number2 = number2;

                    calculator.DisplayOperation();
                    double result = calculator.Calculate();

                    Console.WriteLine($"Result: {result}");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter numeric values.");
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }
    }
}

