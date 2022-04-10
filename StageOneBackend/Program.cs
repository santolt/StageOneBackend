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
            char[] arrayPhrase = new char[phrase.Length];
            int index = 0;

            foreach (char character in phrase)
            {
                if ((character >= '0' && character <= '9') || (character >= 'A' && character <= 'Z')
                    || (character >= 'a' && character <= 'z'))
                {
                    arrayPhrase[index] = character;
                    index++;
                }
            }
            return new string(arrayPhrase, 0, index);
        }

        public static void Opcion1()
        {
            string phrase;

            Console.Write("Write something and I will retorn without special caracters: ");
            phrase = Console.ReadLine();

            Console.WriteLine(RemoveSpecialCharacters($"Without Special Caracteres: {phrase}"));

        }
    }
}
