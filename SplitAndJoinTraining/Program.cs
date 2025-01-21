namespace CSharpFund.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Split

            Console.Write("Enter numbers (1 2 3): ");
            string numStr = Console.ReadLine();

            string[] numbers = numStr.Split(" "); // Split by " " -> by spaces
            int sum = 0;

            foreach (string number in numbers)
            {
                sum += int.Parse(number);
            }
            Console.WriteLine($"Sum of numbers: {sum}");
            Console.WriteLine($"Avg of numbers: {sum / numbers.Length}");

            Console.WriteLine("---------------------------------------------");

            // Join

            string[] words = { "Omar" , "Lol" };

            string statment = string.Join(" ", words);

            Console.WriteLine(statment);

        }
    }
}
