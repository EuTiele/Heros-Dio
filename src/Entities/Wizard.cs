namespace Heros_Dio.src.Entities
{
    public class Wizard : Hero
    {
        
         public Wizard (string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        public override string protects (){
            return this.Name + " Protegeu ao aumentar a velociadade do carro";
        }
            
        
        
    }
}