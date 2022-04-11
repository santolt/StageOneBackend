using System;

namespace StageOneBackend
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Opcion1();
        }

        public static string RemoveSpecialCharacters(string phrase)
        {
            string newPhrase = string.Empty;

            foreach (var character in phrase)
            {
                if ((character >= '0' && character <= '9') || (character >= 'A' && character <= 'Z')
                    || (character >= 'a' && character <= 'z') || (character == '.') || (character == '_') || (character == ' ') || (character == '-') )
                {
                    newPhrase += character;

                }
            }
            return newPhrase;
        }

        public static void Opcion1()
        {
            string phrase;

            Console.Write("Write something and I will retorn without special caracters: ");
            phrase = Console.ReadLine();

            if (RemoveSpecialCharacters(phrase) == string.Empty)
            {
                Console.WriteLine("N/a");
            }
            else
            {
                Console.WriteLine(RemoveSpecialCharacters(phrase));
            }
        }
    }
}
