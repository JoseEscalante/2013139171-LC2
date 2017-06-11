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
    public class ServicioHospedajesController : Controller
    {
        private readonly IUnityOfWork unityOfWork;

        public ServicioHospedajesController()
        {

        }
        public ServicioHospedajesController(IUnityOfWork _unityOfWork)
        {
            unityOfWork = _unityOfWork;

        }

        // GET: ServicioHospedajes
        public ActionResult Index()
        {
            return View(unityOfWork.ServicioHospedaje.GetAll());
        }

        // GET: ServicioHospedajes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ServicioHospedaje servicioHospedaje = unityOfWork.ServicioHospedaje.Get(id);
            if (servicioHospedaje == null)
            {
                return HttpNotFound();
            }
            return View(servicioHospedaje);
        }

        // GET: ServicioHospedajes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ServicioHospedajes/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ServicioHospedajeID,nombre")] ServicioHospedaje servicioHospedaje)
        {
            if (ModelState.IsValid)
            {
                unityOfWork.ServicioHospedaje.Add(servicioHospedaje);
                unityOfWork.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(servicioHospedaje);
        }

        // GET: ServicioHospedajes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ServicioHospedaje servicioHospedaje = unityOfWork.ServicioHospedaje.Get
                (id);
            if (servicioHospedaje == null)
            {
                return HttpNotFound();
            }
            return View(servicioHospedaje);
        }

        // POST: ServicioHospedajes/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ServicioHospedajeID,nombre")] ServicioHospedaje servicioHospedaje)
        {
            if (ModelState.IsValid)
            {
                unityOfWork.ServicioHospedaje.Add(servicioHospedaje);
                unityOfWork.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(servicioHospedaje);
        }

        // GET: ServicioHospedajes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ServicioHospedaje servicioHospedaje = unityOfWork.ServicioHospedaje.Get(id);
            if (servicioHospedaje == null)
            {
                return HttpNotFound();
            }
            return View(servicioHospedaje);
        }

        // POST: ServicioHospedajes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ServicioHospedaje servicioHospedaje = unityOfWork.ServicioHospedaje.Get(id);
            unityOfWork.ServicioHospedaje.Remove(servicioHospedaje);
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
