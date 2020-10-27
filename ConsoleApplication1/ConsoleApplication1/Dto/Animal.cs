using System;

namespace ConsoleApplication1.Dto
{
    public class Animal
    {
        private int pv;
        private int vie;

        public Animal(int pv = 0, int vie = 0)
        {
            this.pv = pv;
            this.vie = vie;
        }

        public int Pv
        {
            get => pv;
            set => pv = value; 
        }

        public int Vie
        {
            get => vie;
            set => vie = value;
        }

        public virtual void parler()
        {
            Console.WriteLine("je parle");
        }
    }
    
}