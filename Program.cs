namespace _12_T6_Loops_assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice;

            Console.WriteLine("Which program would you like to run? (Enter the number)");
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("1. Prompter");
            Console.WriteLine("2. Banking");
            Console.WriteLine("3. Doubles Roller");
            
            while (!Int32.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 3)
            {
                Console.WriteLine("Invalid input, please try again");
            }

            switch (choice)
            {
                case 1:
                    Console.Clear();
                    Prompter();
                    break;

                case 2:
                    Console.Clear();
                    Banking();
                    break;
            }
        }

        public static void Prompter()
        {
            int min, max, num;

            Console.WriteLine("Please enter an integer for a minimum value");
            while (!Int32.TryParse(Console.ReadLine(), out min))
                Console.WriteLine("Invalid input, please try again");

            Console.WriteLine();
            Console.WriteLine("Please enter an integer for a maximum value");
            while (!Int32.TryParse(Console.ReadLine(),out max) || max <= min)
                Console.WriteLine("Invalid input, please try again");

            Console.WriteLine();
            Console.WriteLine($"Please enter an integer in between {min} and {max}");
            while (!Int32.TryParse(Console.ReadLine(), out num) || num < min || num > max)
                Console.WriteLine("Invalid input, please try again");

            Console.WriteLine();
            Console.WriteLine($"You entered {num}, which is between {min} and {max}");
        }

        public static void Banking()
        {
            double balance = 150;
            string transaction;
            bool done = false;

            while (!done)
            {
                Console.WriteLine("Welcome to Bank of Blorb ATM");
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("Please enter the name, not the number");
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("1. Deposit");
                Console.WriteLine("2. Withdrawl");
                Console.WriteLine("3. Bill Payment");
                Console.WriteLine("4. Account Balance Update");
                transaction = Console.ReadLine();
                transaction = transaction.ToLower();

                switch (transaction)
                {
                    case "deposit":
                        Console.WriteLine();
                        Console.WriteLine("how much would you like to deposit?");
                        break;

                    case "withdrawl":
                        Console.WriteLine();
                        break;

                    case "bill payment":
                        Console.WriteLine();
                        break;

                    case "account balance update":
                        Console.WriteLine();
                        break;

                    default:
                        Console.WriteLine("Invalid input, please try again");
                        break;
                }
            }
            
        }
    }
}
