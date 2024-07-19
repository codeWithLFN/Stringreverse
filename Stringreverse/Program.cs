namespace Stringreverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //loop to run the program again
            while(true)
            {
                //taking input from user
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

                //asking user to run the program again
                Console.WriteLine("Do you want to run the program again? (yes/no)");
                string answer = Console.ReadLine();
                if (answer.ToLower() != "yes")
                {
                    break;
                }
            }
           
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
