namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // My title in C# console app
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("|  Welcome to Upskill C-Sharp Calculator |");
            Console.WriteLine("------------------------------------------");

            // Declare variables
            double operand1 = 0;
            double operand2 = 0;

            string runCalculator = "";

            // Start a do-while loop for the calculator to run repeatedly
            do
            {

                // Added declaration for invalid for non-numeric input
                int invalidInput = 0;

                // Use a while loop for input validation (accept only numeric input)
                while (invalidInput == 0)
                    try
                    {
                        Console.Write("Enter the first number: ");
                        operand1 = Convert.ToDouble(Console.ReadLine());
                       
                        Console.Write("Enter the second number: ");
                        operand2 = Convert.ToDouble(Console.ReadLine());
                        invalidInput = 1;
                        
                    }
                    catch
                    {
                        invalidInput = 0;
                        Console.WriteLine("Invalid input!");
                    }

                // Display available arithmetic operations
                Console.WriteLine("Choose an option from the following arithmetic  operations below:");
                Console.WriteLine("\t1 - Addition");
                Console.WriteLine("\t2 - Subtraction");
                Console.WriteLine("\t3 - Multiplication");
                Console.WriteLine("\t4 - Division");
                Console.Write("Choose the operation number (1-4): ");

                // Use a switch statement to perform the selected arithmetic operation
                switch (Console.ReadLine())
                {
                    case "1":
                        Console.WriteLine("Result of Addition: " + (operand1 + operand2));
                        break;
                    case "2":
                        Console.WriteLine("Result of Subtraction: " + (operand1 - operand2));
                        break;
                    case "3":
                        Console.WriteLine("Result of Multiplication: " + (operand1 * operand2));
                        break;
                    case "4":
                        while (operand2 == 0)
                        {
                            Console.WriteLine("Invalid! Please enter a non-zero divisor.");
                            Console.Write("Enter the second number: ");
                            operand2 = Convert.ToDouble(Console.ReadLine());

                        }
                        Console.WriteLine("Result of Division: " + (operand1 / operand2));
                        break;
                    default:
                        Console.WriteLine("Invalid arithmetic operation.");
                        break;
                }

                // Prompt the user to continue or exit
                Console.Write("Enter 'y' to continue, press 'Enter' twice to exit.: ");                        
                runCalculator = Console.ReadLine();

            } while (runCalculator == "y" || runCalculator == "Y");
        }
    }
}
