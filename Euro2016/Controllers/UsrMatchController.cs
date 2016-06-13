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

        //
        // GET: /UsrMatch/

        public ActionResult Index(string pUserName)
        {
            var um = from s in db.UsrMatch
                     where s.Usr_Name == User.Identity.Name
                     select s;
            return View(um.ToList());
        }

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
        // POST: /UsrMatch/Create

        [HttpPost]
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

        public ActionResult Edit(int id = 0)
        {
            UsrMatch usrmatch = db.UsrMatch.Find(id);
            if (usrmatch == null)
            {
                return HttpNotFound();
            }
            return View(usrmatch);
        }

        //
        // POST: /UsrMatch/Edit/5

        [HttpPost]
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
        public ActionResult DeleteConfirmed(int id)
        {
            UsrMatch usrmatch = db.UsrMatch.Find(id);
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