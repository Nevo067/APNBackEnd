using System.Collections;
using System.Collections.Generic;
using System.Linq;
using WebApplication.Model;

namespace WebApplication.Dao
{
    public class CharaDao
    {
        public IEnumerable<Chara> getChara()
        {
            using (var _JdrContext = new JdrContext())
            {
               return _JdrContext.Charactere.ToList();
            }
        }

        public IEnumerable<Chara> GetCharaByMembre(int member)
        {
            using (var _JdrContext = new JdrContext())
            {
                Membre mb = _JdrContext.MembreTable.Find(member);
                return _JdrContext.Charactere.Where(x =>  x.mb.id == mb.id ).ToList();
            }
        }

        public IEnumerable<Chara> GetCharaByJdr(int Jdr)
        {
            using (var _JdrContext = new JdrContext())
            {
                Jdr mb = _JdrContext.JdrTable.Find(Jdr);
                return _JdrContext.Charactere.Where(x =>  x.jdr.Id == mb.Id ).ToList();
            }
        }
        public void post(Chara ca)
        {
            using (var _jdrContext = new JdrContext())
            {
                _jdrContext.Charactere.Add(ca);
                
            }
        }
    }
}