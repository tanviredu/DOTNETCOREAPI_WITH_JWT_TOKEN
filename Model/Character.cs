namespace DOTNETCOREAPI_WITH_JWT_TOKEN.Model
{
    public class Character
    {
        public int Id {get;set;}
        public string Name {get;set;} = "Frodo";
        public int HitPoints {get;set;} = 100;
        public int Strength {get;set;} = 10;
        public int Defense {get;set;} = 10;
        public int Inteligence {get;set;} = 10;

        public RPGClass Class {get;set;} = RPGClass.Knight;
    }
}