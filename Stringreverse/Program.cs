namespace Stringreverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write the string name");
            string word = Console.ReadLine();
            string reverse = string.Empty;

            for (int i = word.Length - 1; i >= 0; i--)
            {
                reverse += word[i];
            }

            Console.WriteLine("Reverse string is: " + reverse);

            //calling method to check palindrome
            IsPalindrome(word);
            Console.WriteLine("The string is palindrome: " + IsPalindrome(word));

        }
        public static bool IsPalindrome(string word)
        {
            string reverse = string.Empty;

            for (int i = word.Length - 1; i >= 0; i--)
            {
                reverse += word[i];
            }

            return word == reverse;
        }
    }
}
