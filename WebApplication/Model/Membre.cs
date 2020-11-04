using System.Collections;
using System.Collections.Generic;

namespace WebApplication.Model
{
    public class Membre
    {
        public int id { get; set; }
        public string login { get; set; }
        public string ps { get; set; }
        
        public IEnumerable<JdrMembre> ListMembre { get; set; }
        public IEnumerable<Chara>ListCharas { get; set; }
        
    }
}