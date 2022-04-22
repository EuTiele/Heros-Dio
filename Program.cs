using System;

namespace Heros_Dio
{
    class Program
  {
        static void Main(string[] args)
        {
            Hero Alok = new Hero("Alok", 6, "Mágia");
            Wizard Misha = new Wizard("Misha", 6, "Velociadade");


            Console.WriteLine(Alok.protects());
            Console.WriteLine(Misha.protects());

        }
    }
}