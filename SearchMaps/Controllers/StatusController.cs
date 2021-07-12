using Microsoft.AspNetCore.Mvc;
using System.Linq;
using static SearchMaps.Models.DataBase;

namespace SearchMaps.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatusController : Controller
    {
        DBContext db = new DBContext();

        [Route("UpdateStatus")]
        [HttpGet]

        public void UpdateStatus(int id, int status)
        {
            var mt = db.maintable.FirstOrDefault(s => s.ID == id);
            mt.StatusID = status;
            db.maintable.Update(mt);
            db.SaveChangesAsync();
        }
    }
}
