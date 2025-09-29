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
                    Prompter();
                    break;

                case 2:
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

            Console.WriteLine("Welcome to Bank of Blorb ATM");
            Console.WriteLine(" What would you like to do?");
            Console.WriteLine("----------------------------");
        }
    }
}
