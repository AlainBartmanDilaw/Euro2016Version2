using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Euro2016.Controllers
{
    public class UsrMatchController : Controller
    {
        private Euro2016BetsEntities db = new Euro2016BetsEntities();

        ////
        //// GET: /UsrMatch/
        //public ActionResult Index(string pUserName)
        //{
        //    var um = from s in db.UsrMatch
        //             where s.Usr_Name == User.Identity.Name
        //             select s;
        //    return View(um.ToList());
        //}

        [HttpGet]
        public ActionResult Index()
        {
            List<UsrMatch> model = new List<UsrMatch>();
            model = db.UsrMatch.Where(a => a.Usr_Name == User.Identity.Name).OrderBy(a => a.Number).ToList();
            return View(model);
        }
        //[HttpGet]
        //public ActionResult Index()
        //{
        //    List<UsrMatch> model = new List<UsrMatch>();
        //    model = db.UsrMatch.Where(a => a.Usr_Name == User.Identity.Name).ToList();
        //    return View(model);
        //}
        
        //
        // GET: /UsrMatch/Details/5

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

        //
        // POST: /UsrMatch/Index

        //[HttpPost]
        //public ActionResult Index(List<Euro2016.UsrMatch> list)
        //{

        //    if (ModelState.IsValid)
        //    {

        //        foreach (var m in list)
        //        {
        //            UsrMatch x = db.UsrMatch.Where(a => a.Idt.Equals(m.Idt)).Single();
        //            if (x != null)
        //            {
        //                db.PostBetFull(x.Idt, m.Usr_Name, m.HomeScore, m.AwayScore);
        //            }
        //        }
        //        db.SaveChanges();

        //        ViewBag.UpdateMessage = "Mise à jour effectée...";
        //    }
        //    return View(list);
        //}

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
                        db.PostBetFull(c.Idt, User.Identity.Name, i.HomeScore, i.AwayScore);
                    }
                    db.SaveChanges();
                }
                ViewBag.Message = "Successfully Updated.";
                return Index();
                //return View(list);
            }
            else
            {
                ViewBag.Message = "Failed ! Please try again.";
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
            // UsrMatch usrmatch = db.UsrMatch.Find(pIdt);
            //UsrMatch usrmatch = (UsrMatch)db.UsrMatch.Where(t => t.Idt == pIdt);
            //if (usrmatch == null)
            //{
            //    return HttpNotFound();
            //}
            db.PostBetFull(pIdt, User.Identity.Name, pScoreHome, pScoreAway);
            return RedirectToAction("Index");
            //return View(usrmatch);
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