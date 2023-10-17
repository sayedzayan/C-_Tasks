

using System;

internal class Program
{
    private static void Main(string[] args)
    {
        double? num1, num2, result = null;
        char? op;

        Console.WriteLine("Enter the first number:");
        string userInput = Console.ReadLine();
        num1 = string.IsNullOrEmpty(userInput) ? null : double.Parse(userInput);

        Console.Write("Enter the operator (+, -, *, /): ");
        string opInput = Console.ReadLine();
        op = string.IsNullOrEmpty(opInput) ? null : char.Parse(opInput);

        Console.Write("Enter the second number: ");
        string userInput2 = Console.ReadLine();
        num2 = string.IsNullOrEmpty(userInput2) ? null : double.Parse(userInput2);


        if (num1 == null || num2 == null)
        {
            Console.WriteLine("Focus and assign The Two Numbers.");

        }
        else if (op == null)
        {
            Console.WriteLine("Shit!!Where is The Operator");
        }

        else
        {
            Calculate(ref num1, ref num2, ref op, ref result);
            Console.WriteLine($"Result of : {num1} {op} {num2} = {result}");
        }
    }

    public static void Calculate(ref double? num1, ref double? num2, ref char? op, ref double? result)
    {
        result = null;

        switch (op)
        {
            case '+':
                result = num1 + num2;
                break;

            case '-':
                result = num1 - num2;
                break;

            case '*':
                result = num1 * num2;
                break;

            case '/':
                if (num2 == 0)
                {
                    Console.WriteLine("Division by zero is not allowed.");
                }
                else
                {
                    result = num1 / num2;
                }
                break;

            default:
                Console.WriteLine("Invalid operator.");
                break;
        }
    }
}

