namespace Soldiers{
    public class SamuraiSoldier : Soldier{
        protected System.Random r;
        public SamuraiSoldier(string name) : base (name, 70, 44){ this.r = new System.Random(); }

        public  override void Atack(Soldier enemy){
            // enemy?.Defend(this);
            this.Defend(enemy);
        }
        public  override void Defend(Soldier enemy){
            System.Console.WriteLine($"Text");
            var a = r.Next(0, enemy.Damage);
            System.Console.WriteLine($"{a}");
            
            this.HP -= (enemy.Damage - a);   
        }
    }
}