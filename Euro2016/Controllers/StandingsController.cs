using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Euro2016.EntityFramework;
using Euro2016.Models;

namespace Euro2016.Controllers
{
    public class StandingsController : Controller
    {
        private Euro2016BetsEntities db = new Euro2016BetsEntities();

        //
        // GET: /Standings/
        [HttpGet]
        public ActionResult Index()
        {
            Standings model = new Standings();

            model.FullUserStandings = (from o in db.FullUserStanding select o).ToList();
            model.Pools = (from o in db.Pool select o).ToList();

            return View(model);
        }

        public ActionResult SelectPool()
        {
            SetViewBagPool("");
            return View();
        }

        private void SetViewBagPool(string selectedPool)
        {
            IEnumerable<Pool> values = (from val in db.Pool select val).ToList();
            values = values.Concat(new[] { new Pool { Cod="",Idt=-1,Lib="" } });
            values = values.OrderBy(a => a.Cod);

            IEnumerable<SelectListItem> items =
                from value in values
                select new SelectListItem { Text = value.Lib.ToString(), Value = value.Idt.ToString(), Selected = value.Cod.ToString() == selectedPool };

            ViewBag.PoolList = items;
        }

    }
}
