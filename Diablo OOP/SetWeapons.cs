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

        public SetWeapons(string name, int damageHigh, int damageLow, double damagePerSecond, double attacksPerSecond, int properties, string setBonus)
          : base(name, damageHigh, damageLow, damagePerSecond, attacksPerSecond)
        {
            Properties = properties;
            SetBonus = setBonus;
        }
        public int Properties { get; private set; }

        public string SetBonus { get; set; }

    }
}
