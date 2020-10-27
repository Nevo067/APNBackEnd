using System;

namespace ConsoleApplication1.Dto
{
    public class Chat:Animal
    {
        //taille des poille du chat
        private int taillePoille;

        /// <summary>
        /// constructeur
        /// </summary>
        public Chat(int taillePoille, int pv, int vie):base(pv,vie)
        {
            this.taillePoille = taillePoille;
        }

        public int TaillePoille
        {
            get => taillePoille;
            set => taillePoille = value;
        }

        public override void parler()
        {
            Console.WriteLine(this.taillePoille);
            Console.WriteLine("miou");
        }
    }
}