using ConsoleApplication1.Dto;

namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Chien bouba = new Chien(1, 1);
            Chat zelda = new Chat(1,1,1);
            bouba.parler();
            zelda.parler();
        }
    }
}