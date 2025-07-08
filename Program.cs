namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Welcome to the Calculator!");

                Console.WriteLine("Enter your first number:");
                float firstNumber = float.Parse(Console.ReadLine().Trim());
                Console.WriteLine("Enter your operation:");
                string operation = Console.ReadLine().Trim();
                Console.WriteLine("Enter your second number:");
                float secondNumber = float.Parse(Console.ReadLine().Trim());

                switch (operation)
                {
                    case "+":
                        Console.WriteLine($"Result: {firstNumber + secondNumber}");
                        break;
                    case "-":
                        Console.WriteLine($"Result: {firstNumber - secondNumber}");
                        break;
                    case "*":
                        Console.WriteLine($"Result: {firstNumber * secondNumber}");
                        break;
                    case "/":
                        if (secondNumber != 0)
                        {
                            Console.WriteLine($"Result: {firstNumber / secondNumber}");
                        }
                        else
                        {
                            Console.WriteLine("Error: Division by zero is not allowed.");
                        }
                        break;
                    default:
                        Console.WriteLine("Error: Invalid operation. Please use +, -, *, or /.");
                        break; ;
                }
            }
            


            




        }
    }
}

