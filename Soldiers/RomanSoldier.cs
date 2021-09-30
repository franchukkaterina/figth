namespace Soldiers{
    public class RomanSoldier : Soldier{
        public RomanSoldier(string name) : base (name, 100, 12, new Shields.Shield()){

        }

        public  override void Atack(Soldier enemy){
          this.Defend(enemy);
        }
        public  override void Defend(Soldier enemy){
            this.SoldierShield?.Defend(this, enemy.Damage);
        }
    }
}