using System;

class Program
{
    public static void Main(string[] args)
    {
        
        Random random = new Random();

        int[] numbersArray = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        String[] lettersArray = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", 
            "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
        char[] charsArray = { '!', '"', '^', '+', '%', '&', '/', '(', ')', '{', '[', ']',
            '}', '=', '?', '*', '-', '_', ',', ';', '.', ':' };


        String password = "";
        int passwordLength = 10;

        for (int i = 0; i <= passwordLength; i++)
        {
            int randomNumberIndex = random.Next(numbersArray.Length);
            int randomNumber = numbersArray[randomNumberIndex];

            int randomLetterIndex = random.Next(lettersArray.Length);
            String randomLetter = lettersArray[randomLetterIndex];

            int randomCharIndex = random.Next(charsArray.Length);
            char randomChar = charsArray[randomCharIndex];

            int choice = random.Next(3);
            if (choice == 0)
            {
                password += randomLetter;
            }
            else if (choice == 1)
            {
                password += randomNumber;
            }
            else
            {
                password += randomChar;
            }
        }

        Console.WriteLine(password);

        Console.ReadKey();
    }
}