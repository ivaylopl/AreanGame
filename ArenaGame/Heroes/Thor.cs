using ArenaGame.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Heroes
{
    public class Thor : Hero
    {
        public double damageTaken;
        public Thor(string name, double armor, double strenght, IWeapon weapon) : base(name, armor, strenght, weapon)
        {
            int damageTaken = 0;
        }

        public override double Attack()
        {
            double baseDamage = base.Attack();
            MjolnirHammer hammer = (MjolnirHammer)Weapon;
            double lightingStrikeDamage = hammer.LightingStrike();
            return baseDamage + lightingStrikeDamage;
        }

        public override double Defend(double damage)
        {
            double realDamage = base.Defend(damage);
            damageTaken += damage;
            if (damageTaken > 30)
            {
                realDamage *= 1.2;
            }
            return realDamage;
        }
    }
}