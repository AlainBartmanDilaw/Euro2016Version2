using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Euro2016.EntityFramework;

namespace Euro2016.Controllers
{
    public class ResultatsController : Controller
    {
        private Euro2016BetsEntities db = new Euro2016BetsEntities();

        //
        // GET: /Resultat/
        [HttpGet]
        public ActionResult Index()
        {
            List<MatchsList> model = new List<MatchsList>();
            model = db.MatchsList.OrderBy(a => a.Number).ToList();
            return View(model);
        }

    }
}
