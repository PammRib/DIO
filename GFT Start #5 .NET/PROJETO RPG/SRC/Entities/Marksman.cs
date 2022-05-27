namespace PROJETO_RPG.SRC.Entities
{
    public class Marksman : Hero
    {
        public Marksman (string Name, int Level, string HeroType) : base (Name, Level, HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
         public override string Attack(){
            return this.Name + " Fez um disparo penetrante de rifle!";
    }
    public string Attack(int Bonus) {

            if (Bonus > 6){
               return this.Name + " Causou dano drástico em um único alvo a uma longa distância!! + "+ Bonus + " de ataque";
            }else
            {
                return this.Name + " Lançou armadilhas e imobilizou o inimigo! + " + Bonus + " de ataque";

            }
    }
}
}