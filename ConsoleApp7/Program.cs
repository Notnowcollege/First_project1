namespace ConsoleApp7
{
    using System;
    using System.Linq;
    internal class Program
    {
        static void Main(string[] args)
        {

            {
                Console.Write("Введіть текст:");
                string text = Console.ReadLine();

                int totalChars = text.Length;

                int wordsCount = text.Split(new char[] { ' ', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries).Length;

                int spacesCount = text.Count(c => c == ' ');

                int punctuationCount = text.Count(c => char.IsPunctuation(c));

                Console.WriteLine($"Текст: \"{text}\"\n");
                Console.WriteLine($"Загальна кількість символів: {totalChars}");
                Console.WriteLine($"Кількість слів: {wordsCount}");
                Console.WriteLine($"Кількість пробілів: {spacesCount}");
                Console.WriteLine($"Кількість знаків пунктуації: {punctuationCount}");
            }
        }
    
    }
}
