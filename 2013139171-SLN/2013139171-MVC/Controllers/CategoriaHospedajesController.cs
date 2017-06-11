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
    public class CategoriaHospedajesController : Controller
    {
        private readonly IUnityOfWork unityOfWork;

        public CategoriaHospedajesController()
        {

        }

        public CategoriaHospedajesController(IUnityOfWork _unityOfWork)
        {
            unityOfWork = _unityOfWork;
        }
        // GET: CategoriaHospedajes
        public ActionResult Index()
        {
            return View(unityOfWork.CategoriaHospedaje.GetAll());
        }

        // GET: CategoriaHospedajes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CategoriaHospedaje categoriaHospedaje = unityOfWork.CategoriaHospedaje.Get(id);
            if (categoriaHospedaje == null)
            {
                return HttpNotFound();
            }
            return View(categoriaHospedaje);
        }

        // GET: CategoriaHospedajes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CategoriaHospedajes/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CategoriaHospedajeID,nombre")] CategoriaHospedaje categoriaHospedaje)
        {
            if (ModelState.IsValid)
            {
                unityOfWork.CategoriaHospedaje.Add(categoriaHospedaje);
                unityOfWork.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(categoriaHospedaje);
        }

        // GET: CategoriaHospedajes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CategoriaHospedaje categoriaHospedaje = unityOfWork.CategoriaHospedaje.Get(id);
            if (categoriaHospedaje == null)
            {
                return HttpNotFound();
            }
            return View(categoriaHospedaje);
        }

        // POST: CategoriaHospedajes/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CategoriaHospedajeID,nombre")] CategoriaHospedaje categoriaHospedaje)
        {
            if (ModelState.IsValid)
            {
                unityOfWork.StateModified(categoriaHospedaje);
                unityOfWork.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(categoriaHospedaje);
        }

        // GET: CategoriaHospedajes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CategoriaHospedaje categoriaHospedaje = unityOfWork.CategoriaHospedaje.Get(id);
            if (categoriaHospedaje == null)
            {
                return HttpNotFound();
            }
            return View(categoriaHospedaje);
        }

        // POST: CategoriaHospedajes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CategoriaHospedaje categoriaHospedaje = unityOfWork.CategoriaHospedaje.Get(id);
            unityOfWork.CategoriaHospedaje.Remove(categoriaHospedaje);
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
