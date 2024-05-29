using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Weapons
{
    public class CapAmericaShield
    {
        public string Name { get; set; }

        public double AttackDamage { get; private set; }

        public double BlockingPower { get; private set; }

        public CapAmericaShield(string name)
        {
            Name = name;
            AttackDamage = 15;
            BlockingPower = 30;
        }
    }
}