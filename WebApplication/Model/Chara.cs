namespace WebApplication.Model
{
    public class Chara
    {
        public int CharaId { get; set; }
        public string Nom { get; set; }
        public Membre mb { get; set; }
        public Jdr jdr { get; set; }
        
    }
}