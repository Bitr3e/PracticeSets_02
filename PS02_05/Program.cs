namespace PracticeSets_02
{
    class Program //RiTVent Test
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any character: ");
            char letter = char.Parse(Console.ReadLine());

            if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u')
            {
                Console.WriteLine($"The letter {letter} is a vowel.");
            }

            else if (Char.IsLetter(letter))
            {
                Console.WriteLine($"The letter {letter} is a consonant.");
            }

            else
            {
                Console.WriteLine("Invalid Input");
            }
        }
    }
}
