using System.Collections;
using System.Collections.Generic;
using K4os.Compression.LZ4.Internal;

namespace WebApplication.Model
{
    public class Jdr
    {
        public int Id {get; set;}
        public string Nom{get;set;}


        public IEnumerable<JdrMembre> jdrMembresList { get; set; }
        public IEnumerable<Chara> jdrsList { get; set; }
        
    }
}