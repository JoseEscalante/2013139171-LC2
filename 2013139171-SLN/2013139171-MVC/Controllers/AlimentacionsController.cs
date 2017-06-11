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
    public class AlimentacionsController : Controller
    {
        private readonly IUnityOfWork unityOfWork;

        public AlimentacionsController()
        {

        }

        public AlimentacionsController(IUnityOfWork _unityOfWork)
        {
            unityOfWork = _unityOfWork;
        }
        // GET: Alimentacions
        public ActionResult Index()
        {
            // return View(db.Comprobantes.ToList());
            return View(unityOfWork.Alimentacion.GetAll());
        }

        // GET: Alimentacions/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Alimentacion alimentacion = unityOfWork.Alimentacion.Get(id);
            if (alimentacion == null)
            {
                return HttpNotFound();
            }
            return View(alimentacion);
        }

        // GET: Alimentacions/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Alimentacions/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ServicioTuristicoID,nombre,PaqueteID,AlimentacionID,CategoriaAlimentacionID")] Alimentacion alimentacion)
        {
            if (ModelState.IsValid)
            {
                unityOfWork.Alimentacion.Add(alimentacion);
                unityOfWork.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(alimentacion);
        }

        // GET: Alimentacions/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Alimentacion alimentacion = unityOfWork.Alimentacion.Get(id);
            if (alimentacion == null)
            {
                return HttpNotFound();
            }
            return View(alimentacion);
        }

        // POST: Alimentacions/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ServicioTuristicoID,nombre,PaqueteID,AlimentacionID,CategoriaAlimentacionID")] Alimentacion alimentacion)
        {
            if (ModelState.IsValid)
            {
                unityOfWork.StateModified(alimentacion);
                unityOfWork.SaveChanges();
                return RedirectToAction("Index");
            }
           
            return View(alimentacion);
        }

        // GET: Alimentacions/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Alimentacion alimentacion = unityOfWork.Alimentacion.Get(id);
            if (alimentacion == null)
            {
                return HttpNotFound();
            }
            return View(alimentacion);
        }

        // POST: Alimentacions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Alimentacion alimentacion = unityOfWork.Alimentacion.Get(id);
           unityOfWork.Alimentacion.Remove(alimentacion);
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
