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

                int[] numbers2 = { 5, 10, 3, 8, 15 };
                int maxValue = FindMaxValue(numbers2);
                Console.WriteLine($"The maximum value in the array is: {maxValue}");
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

            int sumValue = 0;
            foreach (int num in array)
            {
                sumValue += num;
            }

            return (double)sumValue / array.Length;
        }
        static int FindMaxValue(int[] array)
        {
            if (array == null || array.Length == 0)
            {
                throw new ArgumentException("Array cannot be null or empty.");
            }

            int max = array[0]; // We assume the first element is the maximum

            foreach (int num in array)
            {
                if (num > max)
                {
                    max = num; // We update max if a greater element is found
                }
            }

            return max;
        }
    }
}