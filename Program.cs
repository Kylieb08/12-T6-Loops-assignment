namespace _12_T6_Loops_assignment
{
    using _12_T5._5_Classes;

    internal class Program
    {
        static void Main(string[] args)
        {
            int choice;
            bool done = false;

            while (!done)
            {
                Console.WriteLine("Which program would you like to run? (Enter the number)");
                Console.WriteLine("-------------------------------------------------------");
                Console.WriteLine("1. Prompter");
                Console.WriteLine("2. Banking");
                Console.WriteLine("3. Doubles Roller");
                Console.WriteLine("4. Quit");

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

                    case 3:
                        Console.Clear();
                        Doubles();
                        break;

                    case 4:
                        Console.WriteLine("Thank you for playing");
                        done = true;
                        break;
                }
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
            double balance = 150, deposit, withdrawl, payment;
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

                else
                {
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
                            Console.WriteLine("75 Blorbian cents have been subtracted from your account for this transaction");
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
                            Console.WriteLine("75 Blorbian cents have been subtracted from your account for this transaction");
                            Console.WriteLine("How much would you like to withdraw?");
                            while (!double.TryParse(Console.ReadLine(), out withdrawl) || withdrawl <= 0)
                            {
                                Console.WriteLine("Invalid input, please try again");
                            }

                            if (withdrawl > balance)
                            {
                                Console.WriteLine("You attempted to withdraw more than you have in your account");
                                Console.WriteLine("Your transaction ahs been canceled");
                                Console.WriteLine("Press ENTER to continue");
                                Console.ReadLine();
                                Console.Clear();
                            }

                            else
                            {
                                balance -= withdrawl;
                                Console.WriteLine($"You withdrew {withdrawl} Blorbian dollars from your account");
                                Console.WriteLine();
                                Console.WriteLine("Press ENTER to continue");
                                Console.ReadLine();
                                Console.Clear();

                            }
                            break;

                        case "bill payment":
                            Console.WriteLine();
                            Console.WriteLine("75 Blorbian cents have been subtracted from your account for this transaction");
                            Console.WriteLine("How much would you like to pay?");
                            while (!double.TryParse(Console.ReadLine(), out payment) || payment <= 0)
                            {
                                Console.WriteLine("Invalid input, please try again");
                            }

                            if (payment > balance)
                            {
                                Console.WriteLine("You attempted to pay more than you have in your account");
                                Console.WriteLine("Your transaction ahs been canceled");
                                Console.WriteLine("Press ENTER to continue");
                                Console.ReadLine();
                                Console.Clear();
                            }

                            else
                            {
                                balance -= payment;
                                Console.WriteLine($"You payed {payment} Blorbian dollars towards your bills");
                            }
                            break;

                        case "account balance update":
                            Console.WriteLine();
                            Console.WriteLine("75 Blorbian cents have been subtracted from your account for this transaction");
                            Console.WriteLine($"You have {balance} Blorbian dollars in your account");
                            Console.WriteLine();
                            Console.WriteLine("Press ENTER to continue");
                            Console.ReadLine();
                            Console.Clear();
                            break;

                        case "exit":
                            Console.WriteLine();
                            Console.WriteLine("75 Blorbian cents have been subtracted from your account for this transaction");
                            Console.WriteLine("Thank you for using BoB ATM");
                            doneBoB = true;
                            break;

                        default:
                            Console.WriteLine("Invalid input");
                            Console.WriteLine("75 Blorbian cents have been subtracted from your account for this transaction");
                            Console.WriteLine($"You have {balance} Blorbian dollars in your account");
                            Console.WriteLine();
                            Console.WriteLine("Press ENTER to continue");
                            Console.ReadLine();
                            Console.Clear();
                            break;
                    }
                }
            }
        }

        public static void Doubles()
        {
            Die die1;
            Die die2;
            bool doubles = false;
            int rollCount = 0;

            while (!doubles)
            {
                die1 = new Die();
                die2 = new Die();
                Console.WriteLine(die1.Roll);
                Console.WriteLine(die2.Roll);

                Console.WriteLine();
                if (die1.Roll == die2.Roll)
                    doubles = true;
                rollCount++;                
            }
            Console.WriteLine(rollCount);
        }
    }
}
