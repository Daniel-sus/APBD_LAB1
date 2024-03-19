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
                int[] numbers = { 5, 10, 15, 20, 25 };
                double average = CalculateAverage(numbers);
                Console.WriteLine($"The average of the numbers is: {average}");
            }
            else
            {
                Console.WriteLine("Access denied");
            }
        }

        static double CalculateAverage(int[] array)
        {
            if (array == null || array.Length == 0)
            {
                throw new ArgumentException("Array cannot be null or empty.");
            }

            int sum = 0;
            foreach (int num in array)
            {
                sum += num;
            }

            return (double)sum / array.Length;
        }
    }
}