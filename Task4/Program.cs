using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ваше имя");
            string name = Console.ReadLine();

            Console.WriteLine("Введите вашу фамилию");
            string surname = Console.ReadLine();

            Console.WriteLine("Укажите вас возвраст");
            string age = Console.ReadLine();

            Console.WriteLine("Укажите ваш знак зодиака");
            string zodiacSign = Console.ReadLine();

            Console.WriteLine("Вас зовут {0} {1}. Вам {2}. Ваш знак зодиака - это {3}", surname, name, age, zodiacSign);
            Console.ReadLine();
        }
    }
}
