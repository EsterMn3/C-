using System;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Simple Calculator\n");

            while (true) //the cycle goes on till the user presses 5 and the cycle breaks
            {
                Console.WriteLine("Choose an operation:");
                Console.WriteLine("1. Addition (+)");
                Console.WriteLine("2. Subtraction (-)");
                Console.WriteLine("3. Multiplication (*)");
                Console.WriteLine("4. Division (/)");
                Console.WriteLine("5. Exit");

                Console.Write("Enter your choice (1-5): ");
                int choice;
                if (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 5)
                //checks if the input is an int or smaller than 1 or bigger than 5
                {
                    Console.WriteLine("Invalid choice. Please enter a number from 1 to 5.");
                    continue;
                }

                if (choice == 5)
                {
                    Console.WriteLine("Exiting the calculator. Goodbye!");
                    break;
                }

                try
                {
                    double num1, num2;
                    Console.Write("Enter the first number: ");
                    num1 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Enter the second number: ");
                    num2 = Convert.ToDouble(Console.ReadLine());

                    double result = 0;

                    switch (choice)
                    {
                        case 1:
                            result = num1 + num2;
                            break;
                        case 2:
                            result = num1 - num2;
                            break;
                        case 3:
                            result = num1 * num2;
                            break;
                        case 4:
                            if (num2 == 0)
                            {
                                Console.WriteLine("Error: Division by zero");
                                continue;
                            }
                            result = num1 / num2;
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                            continue;
                    }

                    Console.WriteLine("Result: " + result);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred: " + ex.Message);
                }
                
            }
        }
    }
}
