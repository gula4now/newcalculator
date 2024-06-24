using System;

namespace calculatorCsharp
{
   
        class Program
        {
            static void Main(string[] args)
            {
                Calculator calculator = new Calculator();

                while (true)
                {
                    Console.WriteLine("Enter 'q' to quit");
                    Console.Write("Enter expression: ");
                    string input = Console.ReadLine();

                    if (input.ToLower() == "q")
                    {
                        break;
                    }

                    try
                    {
                        double result = calculator.EvaluateExpression(input);
                        Console.WriteLine("Result: " + result);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Error: " + e.Message);
                    }
                }
            }
        }
    }