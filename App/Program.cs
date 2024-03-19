namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");

            Console.WriteLine("What's your name?");
            string name = Console.ReadLine();

            Console.WriteLine($"Hello, {name}!");

            Console.WriteLine("What's your age?");
            string age = Console.ReadLine();
        }
    }
}