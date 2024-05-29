using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Weapons
{
    public class MjolnirHammer : IWeapon
    {
        public string Name { get; set; }

        public double AttackDamage { get; private set; }

        public double BlockingPower { get; private set; }

        private Random random;

        public MjolnirHammer(string name)
        {
            Name = name;
            AttackDamage = 50;
            BlockingPower = 10;
            random = new Random();
        }

        public double LightingStrike()
        {
            return random.Next(5, 10);
        }
    }
}