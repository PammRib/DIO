namespace PROJETO_RPG.SRC.Entities
{
    public class Tank : Hero
    {
         public Tank (string Name, int Level, string HeroType) : base (Name, Level, HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
         public override string Attack(){
            return this.Name + " Atacou com seu broquel!";
    }
    public string Attack(int Bonus) {

            if (Bonus > 6){
               return this.Name + " Canalizou um golpe com seu martelo e empurrou os inimigos para muito longe!! + "+ Bonus + " de ataque";
            }else
            {
                return this.Name + " Golpeou o inimigo com seu martelo, deixando-o lento! + "+ Bonus + " de ataque";

            }
}
}
}