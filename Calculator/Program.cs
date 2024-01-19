namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // My title in C# console app
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("   Welcome to Upskill C-Sharp Calculator  ");
            Console.WriteLine("------------------------------------------");

            // Declare variables
            int num1 = 0;
            int num2 = 0;

            //  Input the first number and second number.
            string p = "press enter";

            Console.WriteLine($"Enter the first number, and then {p}.");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Enter the second number, and then {p}.");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Choose an option from the following list of mathematical operations below:");
            Console.WriteLine("\tEnter sign '+' => Addition");
            Console.WriteLine("\tEnter sign '-' => Subtract");
            Console.WriteLine("\tEnter sign '*' => Multiplication");
            Console.WriteLine("\tEnter sign '/' => Division");
            Console.Write($"Choose mathematical operation then {p}? ");

            switch (Console.ReadLine())
            {
                case "+":
                    Console.WriteLine("Result : " + (num1 + num2));
                    break;
                case "-":
                    Console.WriteLine("Result : " + (num1 - num2));
                    break;
                case "*":
                    Console.WriteLine("Result : " + (num1 * num2));
                    break;
                case "/":
                    Console.WriteLine("Result : " + (num1 / num2));
                    break;
                default: Console.WriteLine("Invalid operation");
                  break;
            }
        }
    }
}
