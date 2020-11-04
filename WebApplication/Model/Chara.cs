using System.Collections;
using System.Collections.Generic;

namespace WebApplication.Model
{
    public class Chara
    {
        public int CharaId { get; set; }
        public string Nom { get; set; }
        public int MembreId { get; set; }
        public Membre mb { get; set; }
        public int JdrId { get; set; }
        public Jdr jdr { get; set; }
        
        public ICollection<Objet>objet {get; set; }
        
    }
}