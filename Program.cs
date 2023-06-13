using System;

class Program
{
    static void Main(string[] args)
    {
        string sentence = "";
        bool isValid = false;

        while (!isValid)
        {
            Console.Write("Kérem adjon meg egy mondatot: ");
            sentence = Console.ReadLine();

            isValid = CheckSentence(sentence);
            if (!isValid)
            {
                Console.WriteLine("A megadott mondat nem felel meg a kritériumoknak. Kérjük próbálja újra.");
            }
        }

        Console.WriteLine("A megadott mondat megfelel a feltételeknek.");
        Console.ReadLine();
    }

    static bool CheckSentence(string sentence)
    {
        if (sentence.Length < 3)
        {
            return false;
        }

        if (!char.IsUpper(sentence[0]))
        {
            return false;
        }

        char lastChar = sentence[sentence.Length - 1];
        if (lastChar != '.' && lastChar != '!' && lastChar != '?')
        {
            return false;
        }

        return true;
    }
}
