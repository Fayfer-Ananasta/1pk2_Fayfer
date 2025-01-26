namespace Task_02_02
{
    internal class Program
    {
        /*Найти значение выражения
         * при a = 8, b = 14, c = π/4
         * 
         */
        static void Main(string[] args)
        {
            double a = 8;
            double b = 14;
            double c = Math.PI / 4;

            double part1 = b + Math.Cbrt (a - 1);
            double part2 = Math.Pow(part1, 1.0 / 4.0);
            double part3 = Math.Abs(a - b); 
            double part4 = Math.Pow(Math.Sin(c),2) + Math.Tan(c);

            double result = part2 / (part3 * part4);
            Console.WriteLine(Math.Round(result, 2));

            Console.WriteLine(Math.PI);
        }
    }
}
