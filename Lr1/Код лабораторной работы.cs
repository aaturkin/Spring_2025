using System;

class Program
{
    static void Main()
    {
        // Ввод слова A
        Console.Write("Введите слово A: ");
        string wordA = Console.ReadLine();

        // Ввод слова B
        Console.Write("Введите слово B: ");
        string wordB = Console.ReadLine();

        // Инициализируем пустую строку для результата
        string result = "";

        // Для каждой буквы в слове A
        foreach (char letter in wordA)
        {
            // Если буква не в слове B
            if (!wordB.Contains(letter))
            {
                // Добавляем букву к результату
                result += letter;
            }
        }

        // Выводим результат
        Console.WriteLine($"Результат: {result}");
    }
}