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
            string ageInput = Console.ReadLine();

            int.TryParse(ageInput, out int age);
            Console.WriteLine($"Your age is: {age}!");

            if (age >= 18)
            {
                Console.WriteLine("Access granted");
            }
            else
            {
                Console.WriteLine("Access denied");
            }
        }
    }
}