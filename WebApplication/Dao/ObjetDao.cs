using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WebApplication.Model;

namespace WebApplication.Dao
{
    public class ObjetDao
    {
        public ObjetDao()
        {
            
        }
        // get all Objet model
        public IEnumerable<Objet> GetObjet()
        {
            using (var _ObjetContex = new JdrContext())
            {
                return _ObjetContex.ObjetTable.ToList();
            }
           
        }

        public IEnumerable<Objet> GetObjet(int i)
        {
            using (var _ObjetContex = new JdrContext())
            {
                return _ObjetContex.ObjetTable.Where(j => j.ObjetId== i).ToList();
                
            }
        }

        public ActionResult postObjet(Objet Objet)
        {
            using (var _ObjetContex = new JdrContext())
            {
                _ObjetContex.ObjetTable.Add(Objet);
                _ObjetContex.SaveChanges();
                
            }
            return new OkResult();
        }

    
    }
}