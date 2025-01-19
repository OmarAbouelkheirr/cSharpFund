namespace CSharpFund.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Word:");
            string word = Console.ReadLine();

            bool palindrome = true;
            for (int i = 0; i < word.Length / 2; i++)
            {
                if (word[i] != word[word.Length - i - 1]) 
                {
                    palindrome = false;
                    break; 
                }
            }

            string result = palindrome ? "Palindrome" : "Not palindrome";

            Console.WriteLine($"{word} is {result}");
        }
    }
}
