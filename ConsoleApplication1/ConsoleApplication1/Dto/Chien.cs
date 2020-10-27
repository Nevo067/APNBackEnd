using System;

namespace ConsoleApplication1.Dto
{
    public class Chien:Animal
    {
        private int taillePate;
        public Chien(int taillePate,int pv = 0,int vie = 0):base(pv,vie)
        {
            this.taillePate = taillePate;
        }

        public override void parler()
        {
            Console.WriteLine("Woaf");
        }
    }
}