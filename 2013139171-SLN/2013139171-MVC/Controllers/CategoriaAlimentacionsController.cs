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
    public class CategoriaAlimentacionsController : Controller
    {
        private readonly IUnityOfWork unityOfWork;

        public CategoriaAlimentacionsController()
        {

        }

        public CategoriaAlimentacionsController(IUnityOfWork _unityOfWork)
        {
            unityOfWork = _unityOfWork;
        }

        // GET: CategoriaAlimentacions
        public ActionResult Index()
        {
            return View(unityOfWork.CategoriaAlimentacion.GetAll());
        }

        // GET: CategoriaAlimentacions/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CategoriaAlimentacion categoriaAlimentacion = unityOfWork.CategoriaAlimentacion.Get(id);
            if (categoriaAlimentacion == null)
            {
                return HttpNotFound();
            }
            return View(categoriaAlimentacion);
        }

        // GET: CategoriaAlimentacions/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CategoriaAlimentacions/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CategoriaAlimentacionID,nombre")] CategoriaAlimentacion categoriaAlimentacion)
        {
            if (ModelState.IsValid)
            {
                unityOfWork.CategoriaAlimentacion.Add(categoriaAlimentacion);
                unityOfWork.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(categoriaAlimentacion);
        }

        // GET: CategoriaAlimentacions/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CategoriaAlimentacion categoriaAlimentacion = unityOfWork.CategoriaAlimentacion.Get(id);
            if (categoriaAlimentacion == null)
            {
                return HttpNotFound();
            }
            return View(categoriaAlimentacion);
        }

        // POST: CategoriaAlimentacions/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CategoriaAlimentacionID,nombre")] CategoriaAlimentacion categoriaAlimentacion)
        {
            if (ModelState.IsValid)
            {
                unityOfWork.StateModified(categoriaAlimentacion);
                unityOfWork.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(categoriaAlimentacion);
        }

        // GET: CategoriaAlimentacions/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CategoriaAlimentacion categoriaAlimentacion = unityOfWork.CategoriaAlimentacion.Get(id);
            if (categoriaAlimentacion == null)
            {
                return HttpNotFound();
            }
            return View(categoriaAlimentacion);
        }

        // POST: CategoriaAlimentacions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CategoriaAlimentacion categoriaAlimentacion = unityOfWork.CategoriaAlimentacion.Get(id);
            unityOfWork.CategoriaAlimentacion.Remove(categoriaAlimentacion);
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
