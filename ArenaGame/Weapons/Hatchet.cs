namespace ArenaGame.Weapons
{
    public class Hatchet : IWeapon
    {
        public string Name { get; set; }

        public double AttackDamage { get; private set; }

        public double BlockingPower { get; private set; }

        private Random random;
        public Hatchet(string name)
        {
            Name = name;
            AttackDamage = 44;
            BlockingPower = 2;
            random = new Random();
        }

        public double HatchetThrow()
        {
            return random.Next(5, 15);
        }
    }
}