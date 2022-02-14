using System;

namespace HW5
{
    class Program
    {

        public static string[] SplitInputedText(string inText)
        {
            return inText.Split(" ");
        }

        public static void PrintTextToRows()
        {
            string inTxt = Console.ReadLine().ToString();
            int s = 1;
            foreach (var sub in SplitInputedText(inTxt))
            {
                {
                    Console.WriteLine($"{s} слово: {sub}");
                    s++;
                }
            }
            
            Console.WriteLine();
        }

        public static void ReverseAndPrint()
        {
            string inTxt = Console.ReadLine().ToString();
            string[] subString = SplitInputedText(inTxt);
            int subStringLenght = subString.Length;
            string[] revString = new string[subStringLenght];

            for (int i = subString.Length - 1; i >= 0; i--)
            {
                revString[i] = subString[i];
                Console.Write($"{revString[i]} ");
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Введите предложение (оно будет разбито на отдельные слова): ");
            PrintTextToRows();

            Console.Write("Введите предложение (слова в нём будут стоять в обратном порядке): ");
            ReverseAndPrint();
        }
    }
}
