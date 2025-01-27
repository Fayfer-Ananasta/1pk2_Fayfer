namespace Task_03_07
{
    internal class Program
    {
        /*Написать программу, которая выводит таблицу скорости (через каждые 0,5с) свободно падающего тела v = g * t
         * где 2 g = 9,8 м/с2 – ускорение свободного падения
        */
        static void Main(string[] args)
        {
            const double g = 9.8; 
            double timeStep = 0.5; 
            double currentTime = 0; // Начальное время
            double endTime = 10;    

            Console.WriteLine("Таблица скорости свободно падающего тела");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine(" Время (с) | Скорость (м/с)");
            Console.WriteLine("--------------------------------------");
            while (currentTime <= endTime)
            {
                double velocity = g * currentTime; 
                Console.WriteLine($"{currentTime}             |        {velocity}");

                currentTime += timeStep; 
            }
            Console.WriteLine("--------------------------------------");
        }
    
    }
}
