using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WebApplication.Dao;
using WebApplication.Model;

namespace WebApplication.Controllers
{
    [ApiController]
    [Route("api/membre")]
    public class MembreController:ControllerBase
    {
        [HttpGet]
        public IEnumerable<Membre> getMembre()
        {
            MembreDao membreDao = new MembreDao();
            return membreDao.GetMembre();
        }

        [HttpGet("ps/{id}")]    
        public IEnumerable<Membre> GetMembreByPs(string id)
        {
            Console.WriteLine(id);
            MembreDao membreDao = new MembreDao();
            return membreDao.GetMembreById(id);
        }

        [HttpPost]
        public ActionResult postMembre(Membre Membre)
        {
            MembreDao membreDao = new MembreDao();
            return membreDao.postMembre(Membre);
        }
    }
}