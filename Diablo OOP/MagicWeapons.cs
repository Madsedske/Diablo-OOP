using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diablo_OOP
{
    public class MagicWeapons : Weapons
    {
        int properties;


        public MagicWeapons(string name, int damageHigh, int damageLow, double damagePerSecond, double attacksPerSecond, int properties)
          : base(name, damageHigh, damageLow, damagePerSecond, attacksPerSecond)
        {
            Properties = properties;
        }

        public int Properties { get; private set; }
    }
}
