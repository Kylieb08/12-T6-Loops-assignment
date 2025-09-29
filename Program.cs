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
            double balance = 150, deposit;
            string transaction;
            bool doneBoB = false;

            Console.WriteLine("Welcome to Bank of Blorb ATM");

            while (!doneBoB)
            {
                balance -= 0.75;

                if (balance < 0.75)
                {
                    Console.WriteLine("You cannot afford to use this ATM");
                    doneBoB = true;
                }
                
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("Please enter the name, not the number");
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("1. Deposit");
                Console.WriteLine("2. Withdrawl");
                Console.WriteLine("3. Bill Payment");
                Console.WriteLine("4. Account Balance Update");
                Console.WriteLine("5. Exit");
                transaction = Console.ReadLine().ToLower();

                switch (transaction)
                {
                    case "deposit":
                        Console.WriteLine();
                        Console.WriteLine("how much would you like to deposit?");
                        while (!double.TryParse(Console.ReadLine(), out deposit) || deposit <= 0)
                        {
                            Console.WriteLine("Invalid input, please try again");
                        }
                        balance += deposit;
                        Console.WriteLine($"You deposited {deposit} Blorbian dollars into your account");
                        Console.WriteLine();
                        Console.WriteLine("Press ENTER to continue");
                        Console.ReadLine();
                        Console.Clear();
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


                    case "exit":
                        Console.WriteLine("Thank you for using BoB ATM");
                        doneBoB = true;
                        break;

                    default:
                        Console.WriteLine("Invalid input, please try again");
                        Console.WriteLine("Press ENTER to continue");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                }
            }
            
        }
    }
}
