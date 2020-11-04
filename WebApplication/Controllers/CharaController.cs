using System;
using System.Collections;
using Microsoft.AspNetCore.Mvc;
using WebApplication.Dao;
using WebApplication.Model;

namespace WebApplication.Controllers
{
    [ApiController]
    [Route("api/chara")]
    public class CharaController
    {
        [HttpGet]
        public IEnumerable GetChara()
        {
            CharaDao dao = new CharaDao();
            return dao.getChara();
        }
        [HttpPost]
        public ActionResult post(Chara ca)
        {
            Console.WriteLine(ca.Nom);
            CharaDao dao = new CharaDao();
            dao.post(ca);
            return new OkResult();
        }

        [HttpGet("membre/{id}")]
        public IEnumerable GetCharaByMembre(int id)
        {
            CharaDao dao = new CharaDao();
            return dao.GetCharaByMembre(id);
        }
        [HttpGet("jdr/{id}")]
        public IEnumerable GetCharaByjDR(int id)
        {
            CharaDao dao = new CharaDao();
            return dao.GetCharaByJdr(id);
        }
        
    }
}