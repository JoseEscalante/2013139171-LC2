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
    public class TransportesController : Controller
    {
        private readonly IUnityOfWork unityOfWork;

        public TransportesController()
        {

        }

        public TransportesController(IUnityOfWork _unityOfWork)
        {
            unityOfWork = _unityOfWork;
        }

        // GET: Transportes
        public ActionResult Index()
        {
            
            return View(unityOfWork.Transporte.GetAll());
        }

        // GET: Transportes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Transporte transporte = unityOfWork.Transporte.Get(id);
            if (transporte == null)
            {
                return HttpNotFound();
            }
            return View(transporte);
        }

        // GET: Transportes/Create
        public ActionResult Create()
        {
           
            return View();
        }

        // POST: Transportes/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ServicioTuristicoID,nombre,PaqueteID,TransporteID,TipoTransporteID,CategoriaTransporteID")] Transporte transporte)
        {
            if (ModelState.IsValid)
            {
                unityOfWork.ServicioTuristico.Add(transporte);
                unityOfWork.SaveChanges();
                return RedirectToAction("Index");
            }

           
            return View(transporte);
        }

        // GET: Transportes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Transporte transporte = unityOfWork.Transporte.Get(id);
            if (transporte == null)
            {
                return HttpNotFound();
            }
           
            return View(transporte);
        }

        // POST: Transportes/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ServicioTuristicoID,nombre,PaqueteID,TransporteID,TipoTransporteID,CategoriaTransporteID")] Transporte transporte)
        {
            if (ModelState.IsValid)
            {
                unityOfWork.Transporte.Add(transporte);
                unityOfWork.SaveChanges();
                return RedirectToAction("Index");
            }
            
            return View(transporte);
        }

        // GET: Transportes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Transporte transporte = unityOfWork.Transporte.Get(id);
            if (transporte == null)
            {
                return HttpNotFound();
            }
            return View(transporte);
        }

        // POST: Transportes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Transporte transporte = unityOfWork.Transporte.Get(id);
            unityOfWork.ServicioTuristico.Remove(transporte);
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
