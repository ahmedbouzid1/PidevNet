using Pidev.data;
using Pidev.Domain.Entities;
using Pidev.Presentation.Models;
using Pidev.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Web;
using System.Web.Mvc;

namespace Pidev.Presentation.Controllers
{
    public class MapController : Controller
    {
        MapService sb = new MapService();
        MyContext context = new MyContext();
        // GET: Map
        public ActionResult Index()
        {
            var Map = sb.GetMany();
            return View(Map);
        }

        // GET: Map/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Map/Create
        public ActionResult Create()
        {
            MapModel pm = new MapModel();
            return View(pm);
        }

        // POST: Map/Create
        [HttpPost]
        public ActionResult Create(MapModel pm)
        {
            map p = new map()
            {
                Nom = pm.Nom,
                Prenom = pm.Prenom,
                Lat = pm.Lat,
                Long = pm.Long,
                


            };



            sb.Add(p);
            /*      listproduct.Add(p);
                  Session["Products"] = listproduct;*/
            sb.Commit();

            return RedirectToAction("Index");
        }

        // GET: Map/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Map/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Map/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Map/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        public JsonResult GetAllLocation()
        {
            var data = context.map.ToList().Select(S => (

                Lat: S.Lat,
                Long: S.Long
            ));
            return Json(data, JsonRequestBehavior.AllowGet);
        }
        public ActionResult Map()
        {
            ViewBag.date = context.map.ToList().Select(S => new
            {
               
                Lat = S.Lat,
                Long = S.Long
            });
            return View();
        }
    }
}
