using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WebApplication.Model;

namespace WebApplication.Dao
{
    public class JdrMembreDao
    {
        public JdrMembreDao()
        {
            
        }
        public IEnumerable<JdrMembre> GetJdrMembre()
        {
            using (JdrContext _context = new JdrContext())
            {
                return _context.JdrMembres.ToList();
            }
        }

        public IEnumerable<JdrMembre> GetJdrMembres(int id)
        {
            using (JdrContext _context = new JdrContext())
            {
                return _context.JdrMembres.Where(x => x.JdrsId == id);
            }
        }

        public ActionResult PostJdrMembre(JdrMembre jm)
        {
            using (JdrContext _context = new JdrContext())
            {
                try
                {
                    _context.JdrMembres.Add(jm);
                    var i = -_context.SaveChanges();
                    return new OkResult();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    return new BadRequestResult();
                }
            }
        }
    }
}