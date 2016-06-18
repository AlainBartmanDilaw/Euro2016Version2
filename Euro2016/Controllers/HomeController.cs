using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Euro2016.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Liste des matchs.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Bets()
        {
            ViewBag.Message = "Faites vos jeux !";

            return View();
        }

        public ActionResult Resultats()
        {
            ViewBag.Message = "Résultats";

            return View();
        }

        public ActionResult Presentation()
        {
            ViewBag.Message = "Présentation des paris sportifs entre amis...";

            return View();
        }
    }
}
