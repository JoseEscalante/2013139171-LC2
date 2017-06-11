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
    public class TipoTransportesController : Controller
    {
        private readonly IUnityOfWork unityOfWork;

        public TipoTransportesController()
        {

        }

        public TipoTransportesController(IUnityOfWork _unityOfWork)
        {
            unityOfWork = _unityOfWork;
        }

        // GET: TipoTransportes
        public ActionResult Index()
        {
            return View(unityOfWork.TipoTransporte.GetAll());
        }

        // GET: TipoTransportes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoTransporte tipoTransporte = unityOfWork.TipoTransporte.Get(id);
            if (tipoTransporte == null)
            {
                return HttpNotFound();
            }
            return View(tipoTransporte);
        }

        // GET: TipoTransportes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TipoTransportes/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TipoTransporteID,nombre")] TipoTransporte tipoTransporte)
        {
            if (ModelState.IsValid)
            {
                unityOfWork.TipoTransporte.Add(tipoTransporte);
                unityOfWork.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tipoTransporte);
        }

        // GET: TipoTransportes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoTransporte tipoTransporte = unityOfWork.TipoTransporte.Get(id);
            if (tipoTransporte == null)
            {
                return HttpNotFound();
            }
            return View(tipoTransporte);
        }

        // POST: TipoTransportes/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TipoTransporteID,nombre")] TipoTransporte tipoTransporte)
        {
            if (ModelState.IsValid)
            {
                unityOfWork.TipoTransporte.Add(tipoTransporte);
                unityOfWork.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tipoTransporte);
        }

        // GET: TipoTransportes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoTransporte tipoTransporte = unityOfWork.TipoTransporte.Get(id);
            if (tipoTransporte == null)
            {
                return HttpNotFound();
            }
            return View(tipoTransporte);
        }

        // POST: TipoTransportes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TipoTransporte tipoTransporte = unityOfWork.TipoTransporte.Get(id);
            unityOfWork.TipoTransporte.Remove(tipoTransporte);
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
