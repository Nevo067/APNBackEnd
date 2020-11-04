using System.Collections;

namespace WebApplication.Model
{
    public class JdrMembre
    {
        public int JdrMembreId { get; set; }
        public int MembreId { get; set; }
        public Membre membres { get; set; }
        public int JdrsId { get; set; }
        public Jdr jdrs { get; set; }
    }
}