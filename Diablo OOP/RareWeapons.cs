using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diablo_OOP
{
    public class RareWeapons : Weapons
    {
        int properties;

        public RareWeapons(string weaponType, string name, int damageHigh, int damageLow, double damagePerSecond, double attacksPerSecond, int properties)
          : base(weaponType, name, damageHigh, damageLow, damagePerSecond, attacksPerSecond)
        {
            Properties = properties;
        }
        public int Properties { get; private set; }

        public override string ToString()
        {
            return "Type: " + WeaponType + "\n" + Name + "\nHigh damage: " + DamageHigh + "\nLow damage: " + DamageLow + "\nDamage per second: " + DamagePerSecond + "\nAttacks per second: " + AttacksPerSecond + "\nProperties: " + Properties;
        }
    }
}
