using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Euro2016.EntityFramework;

namespace Euro2016.Controllers
{
    public class UsrMatchController : Controller
    {
        private Euro2016BetsEntities db = new Euro2016BetsEntities();

        [HttpGet]
        public ActionResult Index()
        {
            List<UsrMatch> model = new List<UsrMatch>();
            model = db.UsrMatch.Where(a => a.Usr_Name == User.Identity.Name).OrderBy(a => a.Number).ToList();
            return View(model);
        }

        public ActionResult Details(int id = 0)
        {
            UsrMatch usrmatch = db.UsrMatch.Find(id);
            if (usrmatch == null)
            {
                return HttpNotFound();
            }
            return View(usrmatch);
        }

        //
        // GET: /UsrMatch/Create

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(List<UsrMatch> list)
        {
            if (ModelState.IsValid)
            {
                foreach (var i in list)
                {
                    var c = db.UsrMatch.Where(a => a.Idt.Equals(i.Idt) && a.Usr_Name == User.Identity.Name).Single();
                    if (c != null && c.Finished == 0)
                    {
                        db.PostBetFull(c.Idt, User.Identity.Name, i.HomeScore, i.AwayScore, "0");
                    }
                    db.SaveChanges();
                }
                ViewBag.Message = "Mise à jour effectuée...";
                return Index();
            }
            else
            {
                ViewBag.Message = "Anomalie de mise à jour ! Essayez de nouveau.";
                return View(list);
            }
        }
        
        //
        // POST: /UsrMatch/Create

        // [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(UsrMatch usrmatch)
        {
            if (ModelState.IsValid)
            {
                db.UsrMatch.Add(usrmatch);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(usrmatch);
        }

        //
        // GET: /UsrMatch/Edit/5

        public ActionResult Edit(int pIdt, int pScoreHome, int pScoreAway)
        {
            db.PostBetFull(pIdt, User.Identity.Name, pScoreHome, pScoreAway, "0");
            return RedirectToAction("Index");
        }

        //
        // POST: /UsrMatch/Edit/5

        //[HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(UsrMatch usrmatch)
        {
            if (ModelState.IsValid)
            {
                db.Entry(usrmatch).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(usrmatch);
        }

        //
        // GET: /UsrMatch/Delete/5

        public ActionResult Delete(int id = 0)
        {
            UsrMatch usrmatch = db.UsrMatch.Find(id);
            if (usrmatch == null)
            {
                return HttpNotFound();
            }
            return View(usrmatch);
        }

        //
        // POST: /UsrMatch/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int pidt)
        {
            UsrMatch usrmatch = db.UsrMatch.Find(pidt);
            db.UsrMatch.Remove(usrmatch);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}