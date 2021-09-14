using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diablo_OOP
{
    public abstract class Weapons
    {
        string weaponType;
        string name;
        int damageHigh;
        int damageLow;
        double damagePerSecond;
        double attacksPerSecond;


        protected Weapons(string weaponType, string name, int damageHigh, int damageLow, double damagePerSecond, double attacksPerSecond)
        {
            WeaponType = weaponType;
            Name = name;
            DamageHigh = damageHigh;
            DamageLow = damageLow;
            DamagePerSecond = damagePerSecond;
            AttacksPerSecond = attacksPerSecond;
        }

        public string WeaponType { get; private set; }
        public string Name { get; private set; }
        public int DamageHigh { get; private set; }
        public int DamageLow { get; private set; }
        public double DamagePerSecond { get; private set; }
        public double AttacksPerSecond { get; private set; }



        public override string ToString()
        {
            return "Type: " + WeaponType + "\n" + Name + "\nHigh damage: " + DamageHigh + "\nLow damage: " + DamageLow + "\nDamage per second: " + DamagePerSecond + "\nAttacks per second: " + AttacksPerSecond;
        }
    }
}
