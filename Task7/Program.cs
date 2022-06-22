using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            float priceForCrystalInGold = 3.5f;

            Console.WriteLine("Ваше количество золота?");
            float playerGold = float.Parse(Console.ReadLine());

            Console.WriteLine("Сколько кристалов вы бы хотели приобрести по цене один кристал за {0} золотых?", 
                priceForCrystalInGold);
            int boughtCrystalsCount = int.Parse(Console.ReadLine());

            playerGold = playerGold - boughtCrystalsCount * priceForCrystalInGold;

            Console.WriteLine("Баланс кристалов {0}, баланс золотых {1}", boughtCrystalsCount, playerGold);
            Console.ReadLine();
        }
    }
}
