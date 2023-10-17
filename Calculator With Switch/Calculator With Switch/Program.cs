internal class Program
{
    private static void Main(string[] args)
    {

        double? num1, num2, result = null;
        char? op;

        Console.WriteLine("Enter the first number:");
        string userInput = Console.ReadLine();
        num1 = string.IsNullOrEmpty(userInput) ? null : double.Parse(userInput);
        //num1 = double.TryParse(Console.ReadLine(), out double parsedNum1) ? (double?)parsedNum1 : null;
       


        Console.Write("Enter the operator (+, -, *, /): ");
        string opInput = Console.ReadLine();
        // op = opInput.Length == 1 ? (char?)opInput[0] : null;
        op = string.IsNullOrEmpty(opInput) ? null : char.Parse(opInput);


        Console.Write("\nEnter the second number: ");
        string userInput2 = Console.ReadLine();
        num2 = string.IsNullOrEmpty(userInput2) ? null : double.Parse(userInput2);
        //num2 = double.TryParse(Console.ReadLine(), out double parsedNum2) ? (double?)parsedNum2 : null;


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
                        return;
                    }
                    result = num1 / num2;
                    break;
                default:
                    Console.WriteLine("Invalid operator.");
                    return;
            }
            Console.WriteLine($"Result of : {num1} {op} {num2} = {result}");

        }
    }
}

