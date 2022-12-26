using AspNetDB_Skattesøk.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNetDB_Skattesøk.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly Database _db;
        public HomeController(Database db)
        {
            _db = db;
        }


        [HttpGet]
        [Route("retur")]
        public string retur()
        {
       
            return "HEI";
        }
        [HttpPost]
        [Route("lagre")]
        public void lagre(Person p)
        {
            _db.Add(p);
            _db.SaveChanges();

        }
    }
}
