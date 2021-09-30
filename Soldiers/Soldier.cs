namespace Soldiers{
    public abstract class Soldier{
        public string Name { get; set; }
        public int HP { get; set; }
        public int Damage { get; set; }
        public Shields.Shield SoldierShield { get; set; }
        
        
        
        private Soldier(){}
        protected  Soldier(string name, int hp, int damage) {
            this.Damage = damage;
            this.Name = name;
            this.HP = hp;
        }
        protected  Soldier(string name, int hp, int damage, Shields.Shield SoldierShield ) {
            this.Damage = damage;
            this.Name = name;
            this.HP = hp;
            this.SoldierShield = SoldierShield;
        }

        public  abstract void Atack(Soldier enemy);
        public  abstract void Defend(Soldier enemy);

        public override string ToString()
        {
            return $"{this.Name} has {this.HP} hp and send {this.Damage} dm!";
        }

    }
}