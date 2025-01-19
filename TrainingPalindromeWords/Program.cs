namespace CSharpFund.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of array elements: ");
            int numberOfElements = int.Parse(Console.ReadLine());
            int[] Array = new int[numberOfElements];

            for (int i = 0; i < numberOfElements; i++)
            {
                Console.WriteLine($"Enter element {i+1}: ");
                Array[i] = int.Parse(Console.ReadLine());
            }


            Console.WriteLine("-.--.--.--.--.--.--.--.--.--.--.--.--.--.--.--.--.-");

            for (int i = 0; i < numberOfElements; i++)
            {
                Console.WriteLine($"Element number {i + 1} is {Array[i]}");
            }

            Console.WriteLine("-.--.--.--.--.--.--.--.--.--.--.--.--.--.--.--.--.-");

            int sum = 0 , smallestNumber = int.MaxValue , greatestNumber = 0 ;

            foreach (int x in Array)
            {
                sum += x;
                if (x < smallestNumber)
                    smallestNumber = x;
             
                if (x >  greatestNumber)
                    greatestNumber = x;
            }

            double avg = sum / numberOfElements;
            Console.WriteLine($"Avg: {avg}");
            Console.WriteLine($"Smallest Number: {smallestNumber}");
            Console.WriteLine($"Greatest Number: {greatestNumber}");
        }
    }
}
