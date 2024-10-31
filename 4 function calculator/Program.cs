namespace _4_function_calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my simple calculator app");
            String choice;
            do
            {
                Console.Write("Please enter a number: ");
                double entryA = double.Parse(Console.ReadLine());
                Console.Write("Please enter your second number: ");
                double entryB = double.Parse(Console.ReadLine());
                Console.Write("Would you like to ADD, SUBTRACT, MULTIPY, or DIVIDE: ");
                string operation = Console.ReadLine().ToUpper();
                switch (operation)
                {
                    case "ADD":
                        entryA += entryB;
                        Console.Write($"The sum is: {entryA}");
                        break;
                    case "SUBTRACT":
                        entryA -= entryB;
                        Console.Write($"The difference is: {Math.Abs(entryA)}");
                        break;
                    case "MULTIPLY":
                        entryA *= entryB;
                        Console.Write($"The product is: {entryA}");
                        break;
                    case "DIVIDE":
                        entryA /= entryB;
                        Console.Write($"The quotient is: {entryA}");
                        break;

                }
                Console.Write("\n\nWould you like to go again? (y/n): ");
                choice = Console.ReadLine().ToLower();
            }while(choice == "y");
            Console.WriteLine("Bye!");
        }
    }
}
