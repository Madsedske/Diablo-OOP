using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diablo_OOP
{
    public class SetWeapons : Weapons
    {
        int properties;
        string setBonus;

        public SetWeapons(string weaponType, string name, int damageHigh, int damageLow, double damagePerSecond, double attacksPerSecond, int properties, string setBonus)
          : base(weaponType, name, damageHigh, damageLow, damagePerSecond, attacksPerSecond)
        {
            Properties = properties;
            SetBonus = setBonus;
        }
        public int Properties { get; private set; }

        public string SetBonus { get; set; }

        public override string ToString()
        {
            return "Type: " + WeaponType + "\n" + Name + "\nHigh damage: " + DamageHigh + "\nLow damage: " + DamageLow + "\nDamage per second: " + DamagePerSecond + "\nAttacks per second: " + AttacksPerSecond + "\nProperties: " + Properties + "\nSetBonus: " + SetBonus;
        }

        public int GetProperties()
        {
            return properties;
        }

    }
}
