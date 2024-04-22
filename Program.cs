namespace CalculatorDemo;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the first number:");
        if (!double.TryParse(Console.ReadLine(), out double num1))
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
            return;
        }

        Console.WriteLine("Enter the second number:");
        if (!double.TryParse(Console.ReadLine(), out double num2))
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
            return;
        }

        // Console.WriteLine("Enter the operation (+, -, *, /):");
        // char operation = Console.ReadKey().KeyChar;
        Console.WriteLine(); // Move to the next line after reading the operation key
        char operation = '+';
        double result;
        switch (operation)
        {
            case '+':
                result = num1 + num2;
                Console.WriteLine($"Result: {num1} + {num2} = {result}");
                break;
            default:
                Console.WriteLine("Invalid operation. Please enter a valid operation (+, -, *, /).");
                break;
        }
    }
}

