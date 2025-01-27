namespace Task_03_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Написать программу, которая выводит таблицу значений функции: 𝑦=|𝑥|для -4≤x≤4, с шагом h = 0,5
             */
            double startX = -4;
            double endX = 4;
            double step = 0.5;

            Console.WriteLine("Таблица значений функции y = |x|");
            Console.WriteLine("-----------------------");
            Console.WriteLine("   x   |    y = |x| ");
            Console.WriteLine("-----------------------");

            for (double x = startX; x <= endX; x += step)
            {
                double y = Math.Abs(x);
                Console.WriteLine($"{x}      |     {y}");
            }
            Console.WriteLine("-----------------------");
        }
    }
}
