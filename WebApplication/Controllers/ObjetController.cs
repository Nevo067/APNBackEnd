using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WebApplication.Dao;
using WebApplication.Model;

namespace WebApplication.Controllers
{
    [ApiController]
    [Route("api/objet")]
    public class ObjetController:ControllerBase
    {
        [HttpGet]
        public IEnumerable<Objet> getObjet()
        {
            ObjetDao ObjetDao = new ObjetDao();
            return ObjetDao.GetObjet();
        }

        [HttpPost]
        public ActionResult postObjet(Objet Objet)
        {
            ObjetDao ObjetDao = new ObjetDao();
            return ObjetDao.postObjet(Objet);
        }
    }
    
}