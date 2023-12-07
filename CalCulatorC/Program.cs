using System;

class CalculatorC
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Simple Calculator");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.WriteLine("5. Exit");

            Console.Write("Enter your choice (1-5): ");
            string choice = Console.ReadLine();

            if (choice == "5")
            {
                Console.WriteLine("Exiting the calculator. Goodbye!");
                break;
            }

            Console.Write("Enter the first number: ");
            if (!double.TryParse(Console.ReadLine(), out double num1))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                continue;
            }

            Console.Write("Enter the second number: ");
            if (!double.TryParse(Console.ReadLine(), out double num2))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                continue;
            }

            double result = 0;

            switch (choice)
            {
                case "1":
                    result = num1 + num2;
                    Console.WriteLine($"Result: {num1} + {num2} = {result}");
                    break;
                case "2":
                    result = num1 - num2;
                    Console.WriteLine($"Result: {num1} - {num2} = {result}");
                    break;
                case "3":
                    result = num1 * num2;
                    Console.WriteLine($"Result: {num1} * {num2} = {result}");
                    break;
                case "4":
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                        Console.WriteLine($"Result: {num1} / {num2} = {result}");
                    }
                    else
                    {
                        Console.WriteLine("Error: Division by zero is not allowed.");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.");
                    break;
            }

            Console.WriteLine();
        }
    }
}

