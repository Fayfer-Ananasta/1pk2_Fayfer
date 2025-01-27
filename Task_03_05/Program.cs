namespace Task_03_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Написать программу, которая выводит на экран таблицу соответствия температуры 
             * в градусах Цельсия и Фаренгейта (F = C*1,8 + 32). 
             * Диапазон изменения температуры в градусах Цельсия и шаг должны вводиться во время работы программы
            */
            {
                Console.Write("Введите начальное значение температуры в Цельсиях: ");
                double startCelsius;

                Console.Write("Введите конечное значение температуры в Цельсиях: ");
                double endCelsius;

                Console.Write("Введите шаг изменения температуры в Цельсиях: ");
                double stepCelsius;

                Console.WriteLine("Таблица соответствия температуры:");
                Console.WriteLine("----------------------------------");
                Console.WriteLine("Цельсии | Фаренгейты");
                Console.WriteLine("----------------------------------");

                {
                    double fahrenheit = celsius * 1.8 + 32;
                    Console.WriteLine($"{celsius} | {fahrenheit}");
                }


            }
        }
    }
}
