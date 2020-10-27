using System.Collections.Generic;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Mvc;
using WebApplication.Dao;
using WebApplication.Model;


namespace WebApplication.Controllers
{
    [ApiController]
    [Route("api/jdr")]
    public class JdrController:ControllerBase
    {
        [HttpGet]
        public IEnumerable<Jdr> getJdr()
        {
            JdrDao jdrDao = new JdrDao();
            return jdrDao.GetJdr();
        }
        

        [HttpPost]
        public ActionResult postjdr(Jdr jdr)
        {
            JdrDao jdrDao = new JdrDao();
            return jdrDao.postJdr(jdr);
        }
    }
}