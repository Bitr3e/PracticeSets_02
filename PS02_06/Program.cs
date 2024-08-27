namespace PracticeSets_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        bool isPalindrome = IsPalindrome(input);

        if (isPalindrome)
        {
            Console.WriteLine("The string is a palindrome.");
        }
        else
        {
            Console.WriteLine("The string is not a palindrome.");
        }
    }

    static bool IsPalindrome(string str)
    {
        string cleanedStr = new string(str
            .Select(c => char.ToLower(c))
            .ToArray());

        string reversedStr = new string(cleanedStr.Reverse().ToArray());

        return cleanedStr == reversedStr;
        }
    }
}