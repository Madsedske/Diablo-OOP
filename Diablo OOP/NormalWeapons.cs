using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diablo_OOP
{
    public class NormalWeapons : Weapons
    {

        public NormalWeapons(string weaponType, string name, int damageHigh, int damageLow, double damagePerSecond, double attacksPerSecond)
          : base(weaponType, name, damageHigh, damageLow, damagePerSecond, attacksPerSecond)
        {

        }
    }
}
