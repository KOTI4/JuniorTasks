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
            string name = "Куджо";
            string surname = "Джотаро";

            Console.WriteLine("Имя - {0}. Фамилия - {1}.", name, surname);

            string temp = name;
            name = surname;
            surname = temp;

            Console.WriteLine("Имя - {0}. Фамилия - {1}.", name, surname);

            Console.ReadLine();
        }
    }
}
