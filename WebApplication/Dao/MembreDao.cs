using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WebApplication.Model;

namespace WebApplication.Dao
{
    public class MembreDao
    {
        public MembreDao()
        {
            
        }
        // get all Membre model
        public IEnumerable<Membre> GetMembre()
        {
            using (var _MembreContex = new JdrContext())
            {
                List<Membre>cc =_MembreContex.MembreTable.ToList();
                return cc;
            }
           
        }

        public IEnumerable<Membre> GetMembre(int i)
        {
            using (var _MembreContex = new JdrContext())
            {
                return _MembreContex.MembreTable.Where(j => j.id == i).ToList();
                
            }
        }
        public IEnumerable<Membre> GetMembreById(string t)
        {
            using (var _jdrContext = new JdrContext())
            {
                return _jdrContext.MembreTable.Where(x => x.ps == t).ToList();
            }
        }

        public ActionResult postMembre(Membre Membre)
        {
            using (var _MembreContex = new JdrContext())
            {
                _MembreContex.MembreTable.Add(Membre);
                _MembreContex.SaveChanges();
                
            }
            return new OkResult();
        }

    }
    
}