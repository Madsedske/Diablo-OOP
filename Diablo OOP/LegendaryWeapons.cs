﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diablo_OOP
{
    public class LegendaryWeapons : Weapons
    {
        int properties;
        string secondary;

        public LegendaryWeapons(string name, int damageHigh, int damageLow, double damagePerSecond, double attacksPerSecond, int properties, string secondary)
          : base(name, damageHigh, damageLow, damagePerSecond, attacksPerSecond)
        {
            Properties = properties;
            Secondary = secondary;
        }
        public int Properties { get; private set; }

        public string Secondary { get; private set; }

    }
}