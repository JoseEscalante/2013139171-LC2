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
    public class ComprobantePagoesController : Controller
    {
        private readonly IUnityOfWork unityOfWork;

        public ComprobantePagoesController()
        {

        }

        public ComprobantePagoesController(IUnityOfWork _unityOfWork)
        {
            unityOfWork = _unityOfWork;
        }

        // GET: ComprobantePagoes
        public ActionResult Index()
        {
            return View(unityOfWork.ComprobantePago.GetAll());
        }

        // GET: ComprobantePagoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ComprobantePago comprobantePago = unityOfWork.ComprobantePago.Get
                (id);
            if (comprobantePago == null)
            {
                return HttpNotFound();
            }
            return View(comprobantePago);
        }

        // GET: ComprobantePagoes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ComprobantePagoes/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ComprobantePagoID,nombre")] ComprobantePago comprobantePago)
        {
            if (ModelState.IsValid)
            {
                unityOfWork.ComprobantePago.Add(comprobantePago);
                unityOfWork.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(comprobantePago);
        }

        // GET: ComprobantePagoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ComprobantePago comprobantePago = unityOfWork.ComprobantePago.Get(id);
            if (comprobantePago == null)
            {
                return HttpNotFound();
            }
            return View(comprobantePago);
        }

        // POST: ComprobantePagoes/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ComprobantePagoID,nombre")] ComprobantePago comprobantePago)
        {
            if (ModelState.IsValid)
            {
                unityOfWork.ComprobantePago.Add(comprobantePago);
                unityOfWork.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(comprobantePago);
        }

        // GET: ComprobantePagoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ComprobantePago comprobantePago = unityOfWork.ComprobantePago.Get(id);
            if (comprobantePago == null)
            {
                return HttpNotFound();
            }
            return View(comprobantePago);
        }

        // POST: ComprobantePagoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ComprobantePago comprobantePago = unityOfWork.ComprobantePago.Get(id);
            unityOfWork.ComprobantePago.Remove(comprobantePago);
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
