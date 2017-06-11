using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using _2013139171_ENT;
using _2013139171_PER;
using _2013139171_PER.Repositories;
using _2013139171_ENT.IRepositories;

namespace _2013139171_MVC.Controllers
{
    public class CalificacionHospedajesController : Controller
    {
        private readonly IUnityOfWork unityOfWork;

        public CalificacionHospedajesController()
        {

        }

        public CalificacionHospedajesController(IUnityOfWork _unityOfWork)
        {
            unityOfWork = _unityOfWork;
        }


        // GET: CalificacionHospedajes
        public ActionResult Index()
        {
            return View(unityOfWork.CalificacionHospedaje.GetAll());
        }

        // GET: CalificacionHospedajes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CalificacionHospedaje calificacionHospedaje = unityOfWork.CalificacionHospedaje.Get(id);
            if (calificacionHospedaje == null)
            {
                return HttpNotFound();
            }
            return View(calificacionHospedaje);
        }

        // GET: CalificacionHospedajes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CalificacionHospedajes/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CalificacionHospedajeID,nombre")] CalificacionHospedaje calificacionHospedaje)
        {
            if (ModelState.IsValid)
            {
                unityOfWork.CalificacionHospedaje.Add(calificacionHospedaje);
                unityOfWork.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(calificacionHospedaje);
        }

        // GET: CalificacionHospedajes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CalificacionHospedaje calificacionHospedaje = unityOfWork.CalificacionHospedaje.Get(id);
            if (calificacionHospedaje == null)
            {
                return HttpNotFound();
            }
            return View(calificacionHospedaje);
        }

        // POST: CalificacionHospedajes/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CalificacionHospedajeID,nombre")] CalificacionHospedaje calificacionHospedaje)
        {
            if (ModelState.IsValid)
            {
                unityOfWork.StateModified(calificacionHospedaje);
                unityOfWork.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(calificacionHospedaje);
        }

        // GET: CalificacionHospedajes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CalificacionHospedaje calificacionHospedaje = unityOfWork.CalificacionHospedaje.Get(id);
            if (calificacionHospedaje == null)
            {
                return HttpNotFound();
            }
            return View(calificacionHospedaje);
        }

        // POST: CalificacionHospedajes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CalificacionHospedaje calificacionHospedaje = unityOfWork.CalificacionHospedaje.Get(id);
            unityOfWork.CalificacionHospedaje.Remove(calificacionHospedaje);
            unityOfWork.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                unityOfWork.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
