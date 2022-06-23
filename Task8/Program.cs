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
            int minutesInHour = 60;

            Console.WriteLine("Введите количество людей в очереди");
            int numberPeopleInQueue = int.Parse(Console.ReadLine());

            int averageTimeToWaitInMinutes = numberPeopleInQueue * minutesForOnePatient;
            int hoursToWait = averageTimeToWaitInMinutes / minutesInHour;
            int minutesToWait = averageTimeToWaitInMinutes % minutesInHour;

            Console.WriteLine("Вы должны отстоять в очереди {0} часа и {1} минут", hoursToWait, minutesToWait);
            Console.ReadLine();
        }
    }
}
