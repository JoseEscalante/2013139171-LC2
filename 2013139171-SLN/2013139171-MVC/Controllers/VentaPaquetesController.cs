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
    public class VentaPaquetesController : Controller
    {
        private readonly IUnityOfWork unityOfWork;

        public VentaPaquetesController()
        {

        }

        public VentaPaquetesController(IUnityOfWork _unityOfWork)
        {
            unityOfWork = _unityOfWork;
        }
        // GET: VentaPaquetes
        public ActionResult Index()
        {
           
            return View(unityOfWork.VentaPaquete.GetAll());
        }

        // GET: VentaPaquetes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VentaPaquete ventaPaquete = unityOfWork.VentaPaquete.Get(id);
            if (ventaPaquete == null)
            {
                return HttpNotFound();
            }
            return View(ventaPaquete);
        }

        // GET: VentaPaquetes/Create
        public ActionResult Create()
        {
           
            return View();
        }

        // POST: VentaPaquetes/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "VentaPaqueteID,nombre,MedioPagoID,ComprobantePagoID,PaqueteId")] VentaPaquete ventaPaquete)
        {
            if (ModelState.IsValid)
            {
                unityOfWork.VentaPaquete.Add(ventaPaquete);
                unityOfWork.SaveChanges();
                return RedirectToAction("Index");
            }

           
            return View(ventaPaquete);
        }

        // GET: VentaPaquetes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VentaPaquete ventaPaquete = unityOfWork.VentaPaquete.Get(id);
            if (ventaPaquete == null)
            {
                return HttpNotFound();
            }
            
            return View(ventaPaquete);
        }

        // POST: VentaPaquetes/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "VentaPaqueteID,nombre,MedioPagoID,ComprobantePagoID,PaqueteId")] VentaPaquete ventaPaquete)
        {
            if (ModelState.IsValid)
            {
                unityOfWork.VentaPaquete.Add(ventaPaquete);
                unityOfWork.SaveChanges();
                return RedirectToAction("Index");
            }
           
            return View(ventaPaquete);
        }

        // GET: VentaPaquetes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VentaPaquete ventaPaquete = unityOfWork.VentaPaquete.Get(id);
            if (ventaPaquete == null)
            {
                return HttpNotFound();
            }
            return View(ventaPaquete);
        }

        // POST: VentaPaquetes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            VentaPaquete ventaPaquete = unityOfWork.VentaPaquete.Get(id);
            unityOfWork.VentaPaquete.Remove(ventaPaquete);
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
