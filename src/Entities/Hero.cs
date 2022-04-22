namespace Heros_Dio.src.Entities
{
    public class Hero
    {
        public Hero(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;

        }
        public Hero(){


        }
        public string Name;
        public int Level;
        public string HeroType;

        public override string ToString(){
            return this.Name + " " + this.Level +  " " + this.HeroType;
        }

        public virtual string protects (){
            return this.Name + " Faz um escudo com sua aura de 5M";
        }
        
    }
}