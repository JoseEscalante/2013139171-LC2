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
    public class CategoriaTransportesController : Controller
    {
        private readonly IUnityOfWork unityOfWork;

        public CategoriaTransportesController()
        {

        }

        public CategoriaTransportesController(IUnityOfWork _unityOfWork)
        {
            unityOfWork = _unityOfWork;
        }

        // GET: CategoriaTransportes
        public ActionResult Index()
        {
            return View(unityOfWork.CategoriaTransporte.GetAll());
        }

        // GET: CategoriaTransportes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CategoriaTransporte categoriaTransporte = unityOfWork.CategoriaTransporte.Get(id);
            if (categoriaTransporte == null)
            {
                return HttpNotFound();
            }
            return View(categoriaTransporte);
        }

        // GET: CategoriaTransportes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CategoriaTransportes/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CategoriaTransporteID,nombre")] CategoriaTransporte categoriaTransporte)
        {
            if (ModelState.IsValid)
            {
                unityOfWork.CategoriaTransporte.Add(categoriaTransporte);
                unityOfWork.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(categoriaTransporte);
        }

        // GET: CategoriaTransportes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CategoriaTransporte categoriaTransporte = unityOfWork.CategoriaTransporte.Get(id);
            if (categoriaTransporte == null)
            {
                return HttpNotFound();
            }
            return View(categoriaTransporte);
        }

        // POST: CategoriaTransportes/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CategoriaTransporteID,nombre")] CategoriaTransporte categoriaTransporte)
        {
            if (ModelState.IsValid)
            {
                unityOfWork.CategoriaTransporte.Add(categoriaTransporte);
                unityOfWork.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(categoriaTransporte);
        }

        // GET: CategoriaTransportes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CategoriaTransporte categoriaTransporte = unityOfWork.CategoriaTransporte.Get(id);
            if (categoriaTransporte == null)
            {
                return HttpNotFound();
            }
            return View(categoriaTransporte);
        }

        // POST: CategoriaTransportes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CategoriaTransporte categoriaTransporte = unityOfWork.CategoriaTransporte.Get(id);
            unityOfWork.CategoriaTransporte.Remove(categoriaTransporte);
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
