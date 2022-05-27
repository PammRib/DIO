namespace PROJETO_RPG.SRC.Entities
{
    public class Assassin : Hero
    {
        public Assassin (string Name, int Level, string HeroType) : base (Name, Level, HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

       public override string Attack(){
            return this.Name + " Arremessou uma Adaga no alvo!";}

        public string Attack(int Bonus) {

            if (Bonus > 6){
               return this.Name + " Atingiu o inimigo com uma chuva de espadas!! + "+ Bonus + " de ataque";
            }else
            {
                return this.Name + " Golpeou o inimigo em alta velocidade! + "+ Bonus + " de ataque";

            }
             
        }
           
    }
}
    
