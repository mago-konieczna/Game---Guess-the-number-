internal class Program
{
    static void Main(string[] args)
    {
        Random rdn = new Random();
        int random = rdn.Next(1, 11);

        int user;
        bool valid = false;
        int i = 0;
        bool[] array = new bool[10];
        Console.WriteLine();

        Console.Title = "Guess the number!";
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Guess the number from 1 to 10!\n ");
        Console.ResetColor();

        do
        {
            do
            {
                Console.Write("Enter a number: ");
                valid = int.TryParse(Console.ReadLine(), out user);
                if (!valid)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Enter the correct number!");
                    Console.ResetColor();
                }

            } while (!valid);

            if (user < 1 || user > 10)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Enter a number from 1 to 10!");
                Console.ResetColor();
                continue;

            }

            if (array[user - 1])
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("The same number was given!");
                Console.ResetColor();
                continue;
            }
            else
            {
                array[user - 1] = true;
            }

            if (random < user)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("The drawn number is smaller than yours!");
                Console.ResetColor();
            }
            else if (random > user)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("The drawn number is greater than yours!");
                Console.ResetColor();
            }
            i++;

        } while (user != random);
    }
}