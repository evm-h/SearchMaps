using Microsoft.AspNetCore.Mvc;
using SearchMaps.Models.Poco;
using System.Collections.Generic;
using System.Linq;
using static SearchMaps.Models.DataBase;

namespace SearchMaps.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InfoController : Controller
    {
        DBContext db = new DBContext();

        [Route("GetInfo")]
        [HttpGet]

        public IActionResult GetInfo(int id)
        {


            var result = db.maintable.FirstOrDefault(s => s.ID == id);

            return PartialView("~/Views/Home/_InfoPartView.cshtml", result);

        }

        [Route("GetCompany")]
        [HttpGet]
        public IActionResult GetCompany(int id)
        {
            var result = db.maintable.Where(s => s.RegionID == id).Join(db.regions,
                                                m => m.RegionID,
                                                r => r.ID,
                                                (m, r) => new MainTableView { Id = m.ID, City = m.City, District = m.District, Locality = m.Locality, Region = r }).ToList();



            return PartialView("~/Views/Home/_RegionsPartView.cshtml", result);

        }
    }
}
