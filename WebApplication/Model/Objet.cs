namespace WebApplication.Model
{
    public class Objet
    {
        public int ObjetId { get; set; }
        public string nom { get; set; }
        public string val { get; set; }
        public Membre Membre { get; set; }
    }
}