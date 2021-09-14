using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diablo_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            {
                Console.WindowWidth = 130;
                Console.WriteLine("Diablo 3 random weaponbox:");
                Console.WriteLine("-----------------------------");
                Console.WriteLine("Weapon classes: Axes - Daggers - Maces - Spears - Swords - Ceremonial Knives - Fist Weapons - Flails - Mighty Weapons - Scythes");
                Console.WriteLine("\nPress a key to get a random weapon.");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine(new WeaponFactory().CreateWeapons().ToString());
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
