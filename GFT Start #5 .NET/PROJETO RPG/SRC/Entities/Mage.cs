namespace PROJETO_RPG.SRC.Entities
{
    public class Mage : Hero
    {
        
        public Mage (string Name, int Level, string HeroType) : base (Name, Level, HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
        
        public override string Attack(){
            return this.Name + " Arremessou uma bola de fogo infundida em Mana!";}
       

        public string Attack(int Bonus) {

            if (Bonus > 6){
               return this.Name + " Invocou Tibbers, o Urso!! + "+ Bonus + " de ataque";
            }else
            {
                return this.Name + " Conjurou um ardente cone de fogo! + "+ Bonus + " de ataque";

            }
             
        }
           
    }
}