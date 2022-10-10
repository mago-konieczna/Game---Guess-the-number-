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
    }
}