using ArenaGame.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Heroes
{
    public class Hulk : Hero
    {
        private double hitCount;
        private Hatchet hatchet;

        public Hulk(string name, double armor, double strenght, Hatchet weapon) : base(name, armor, strenght, weapon)
        {
            hitCount = 0;
            hatchet = weapon;
        }

        public override double Defend(double damage)
        {
            hitCount++;
            double realDamage = base.Defend(damage);

            if (hitCount == 2)
            {
                realDamage += hatchet.HatchetThrow();
                hitCount = 0;
            }

            return realDamage;
        }

        public override double Attack()
        {
            double damage = base.Attack();
            return damage;
        }
    }
}
