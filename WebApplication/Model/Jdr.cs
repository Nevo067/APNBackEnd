using K4os.Compression.LZ4.Internal;

namespace WebApplication.Model
{
    public class Jdr
    {
        public int Id {get; set;}
        public string Nom{get;set;}
        public int IdMenber{get;set;}
        
        public Membre Membre { get; set; }
        public int MembreId { get; set; }
    }
}