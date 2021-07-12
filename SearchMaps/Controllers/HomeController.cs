using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SearchMaps.Models;
using SearchMaps.Models.Domain;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using static SearchMaps.Models.DataBase;

namespace SearchMaps.Controllers
{
    public class HomeController : Controller
    {
        DBContext db = new DBContext();

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        //public IActionResult Index()
        //{
        //    var result = db.maintable.Join(db.regions,
        //                                    m => m.RegionID,
        //                                    r => r.ID,
        //                                    (m, r) => new MainTableView { Id = m.ID, City = m.City, District = m.District, Locality = m.Locality, Region = r });



        //    return View(result);
        //}

        public ActionResult Index()
        {
            List<Region> result = new List<Region>();
            result = db.regions.ToList();

            return View(result);

        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
