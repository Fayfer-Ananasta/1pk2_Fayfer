using System.Globalization;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Tast_02_04
{
    internal class Program
    {
        /*
         Пользователь вводит свою дату рождения построчно (сначала год, потом месяц и в конце дату) 
        произведите расчет является ли пользователь совершеннолетним на текущую дату
        выведите соответствующее сообщение об этом
        */
        static void Main(string[] args)
        {

            Console.WriteLine("Введите вашу дату рождения:");

            Console.Write("Год: ");
            int year;
           

            Console.Write("Месяц: ");
            int month;

            Console.Write("День: ");
            int day;

            DateTime birthDate = new DateTime(year, month, day);


            int age = DateTime.Now.Year - birthDate.Year;

            if (DateTime.Now.Month < birthDate.Month || (DateTime.Now.Month == birthDate.Month && DateTime.Now.Day < birthDate.Day))
            {
                age--;
            }

            if (age >= 18)
            {
                Console.WriteLine("Вы совершеннолетний.");
            }
            else
            {
                Console.WriteLine("Вы несовершеннолетний.");
            }
        }
    }


}
            


