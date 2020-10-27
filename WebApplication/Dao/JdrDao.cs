using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WebApplication.Model;

namespace WebApplication.Dao
{
    public class JdrDao
    {
        
        public JdrDao()
        {
            
        }
        // get all jdr model
        public IEnumerable<Jdr> GetJdr()
        {
            using (var _jdrContex = new JdrContext())
            {
                return _jdrContex.JdrTable.ToList();
            }
           
        }

        public IEnumerable<Jdr> GetJdr(int i)
        {
            using (var _jdrContex = new JdrContext())
            {
                return _jdrContex.JdrTable.Where(j => j.Id == i).ToList();
                
            }
        }

        public ActionResult postJdr(Jdr jdr)
        {
            using (var _jdrContex = new JdrContext())
            {
                _jdrContex.JdrTable.Add(jdr);
                _jdrContex.SaveChanges();
                
            }
            return new OkResult();
        }

    }
}