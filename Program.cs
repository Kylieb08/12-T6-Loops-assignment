namespace _12_T6_Loops_assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Prompter();
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
    }
}
