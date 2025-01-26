namespace Task_03_04
{
    internal class Program
    {
        /* Пользователь вводит в консоли произвольный текст.
         * После каждого ввода консоль очищается.
         * Когда пользователь вводить слово «exit» или пустую строку – ввод останавливается и выводиться количество строк
введенных пользователем
        */
        static void Main(string[] args)
        {
                int inputCount = 0;

                while (true)
                {
                    Console.Write("Введите текст: ");
                    string input = Console.ReadLine();

                    // Очистка консоли
                    Console.Clear();

                    if (string.IsNullOrWhiteSpace(input) || input == "exit")
                    {
                        Console.WriteLine($"Вы ввели {inputCount} строк.");
                        break; // Выход из цикла
                    }

                    inputCount++;
                }
           
        }

    }
   
}
