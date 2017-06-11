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
    public class TipoHospedajesController : Controller
    {
        private readonly IUnityOfWork unityOfWork;

        public TipoHospedajesController()
        {

        
        }

        public TipoHospedajesController(IUnityOfWork _unityOfWork)
        {
            unityOfWork = _unityOfWork;
        }

        // GET: TipoHospedajes
        public ActionResult Index()
        {
            return View(unityOfWork.TipoHospedaje.GetAll());
        }

        // GET: TipoHospedajes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoHospedaje tipoHospedaje = unityOfWork.TipoHospedaje.Get(id);
            if (tipoHospedaje == null)
            {
                return HttpNotFound();
            }
            return View(tipoHospedaje);
        }

        // GET: TipoHospedajes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TipoHospedajes/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "tipoHospedajeID,nombre")] TipoHospedaje tipoHospedaje)
        {
            if (ModelState.IsValid)
            {
                unityOfWork.TipoHospedaje.Add(tipoHospedaje);
                unityOfWork.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tipoHospedaje);
        }

        // GET: TipoHospedajes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoHospedaje tipoHospedaje = unityOfWork.TipoHospedaje.Get(id);
            if (tipoHospedaje == null)
            {
                return HttpNotFound();
            }
            return View(tipoHospedaje);
        }

        // POST: TipoHospedajes/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "tipoHospedajeID,nombre")] TipoHospedaje tipoHospedaje)
        {
            if (ModelState.IsValid)
            {
                unityOfWork.TipoHospedaje.Add(tipoHospedaje);
                unityOfWork.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tipoHospedaje);
        }

        // GET: TipoHospedajes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoHospedaje tipoHospedaje = unityOfWork.TipoHospedaje.Get(id);
            if (tipoHospedaje == null)
            {
                return HttpNotFound();
            }
            return View(tipoHospedaje);
        }

        // POST: TipoHospedajes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TipoHospedaje tipoHospedaje = unityOfWork.TipoHospedaje.Get(id);
            unityOfWork.TipoHospedaje.Remove(tipoHospedaje);
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
