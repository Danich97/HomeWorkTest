// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введіть слово:");
        string word = Console.ReadLine(); // Зчитування введеного користувачем слова

        string image = ""; // Змінна для збереження псевдографічного зображення

        // Формування псевдографічного зображення на основі введеного слова
        foreach (char c in word)
        {
            switch (c)
            {
                case 'A':
                    image += "  A  \n A A \nAAAAA\nA   A\nA   A\n\n";
                    break;
                case 'B':
                    image += "BBBB \nB   B\nBBBB \nB   B\nBBBB \n\n";
                    break;
                // Додайте інші символи за необхідністю
                default:
                    image += "Невідомий символ\n\n";
                    break;
            }
        }

        Console.WriteLine(image);
    }
}
