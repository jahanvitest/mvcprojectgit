using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebGridExample.Models;

namespace WebGridExample.Controllers
{
    public class CountryController : Controller
    {
        // GET: Country
        databaseEntities db = new databaseEntities();
        tblCountry con = new tblCountry();
        public ActionResult Index()
        {
            return View(db.tblCountries.ToList());
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(tblCountry model)
        {
            db.tblCountries.Add(model);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public JsonResult Update(tblCountry data)
        {
            

            db.Entry(data).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return Json("Update done!!", JsonRequestBehavior.AllowGet);
        }
        public JsonResult Delete(int id)
        {
            tblCountry cid = db.tblCountries.Single(m => m.Con_id == id);
            db.tblCountries.Remove(cid);
            db.SaveChanges();
            return Json("Delete done!!", JsonRequestBehavior.AllowGet);
        }
        


    }
}