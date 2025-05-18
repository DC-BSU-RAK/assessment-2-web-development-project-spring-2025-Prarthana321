using System;

class Calculator
{
    static void Main()
    {
        Console.WriteLine("==== Simple Calculator ====");
        Console.WriteLine("Choose operation:");
        Console.WriteLine("1. Addition");
        Console.WriteLine("2. Subtraction");
        Console.WriteLine("3. Multiplication");
        Console.WriteLine("4. Division");
        Console.WriteLine("5. Modulus");

        Console.Write("Enter your choice (1-5): ");
        int choice = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        double result = 0;
        bool valid = true;

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
                if (num2 != 0)
                    result = num1 / num2;
                else
                {
                    Console.WriteLine("Cannot divide by zero.");
                    valid = false;
                }
                break;
            case 5:
                result = num1 % num2;
                break;
            default:
                Console.WriteLine("Invalid choice.");
                valid = false;
                break;
        }

        if (valid)
            Console.WriteLine("Result: " + result);

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}