using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            int minutesForOnePatient = 10;

            Console.WriteLine("Введите количество людей в очереди");
            int numberPeopleInQueue = int.Parse(Console.ReadLine());

            int hoursToWait = numberPeopleInQueue / (60 / minutesForOnePatient);
            int minutesToWait = numberPeopleInQueue * minutesForOnePatient - hoursToWait * 60;

            Console.WriteLine("Вы должны отстоять в очереди {0} часа и {1} минут", hoursToWait, minutesToWait);
            Console.ReadLine();
        }
    }
}
