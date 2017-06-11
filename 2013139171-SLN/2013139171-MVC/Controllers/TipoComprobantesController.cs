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
    public class TipoComprobantesController : Controller
    {
        private readonly IUnityOfWork unityOfWork;

        public TipoComprobantesController()
        {

        }

        public TipoComprobantesController(IUnityOfWork _unityOfWork)
        {
            unityOfWork = _unityOfWork;
        }

        // GET: TipoComprobantes
        public ActionResult Index()
        {
            return View(unityOfWork.TipoComprobante.GetAll());
        }

        // GET: TipoComprobantes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoComprobante tipoComprobante = unityOfWork.TipoComprobante.Get(id);
            if (tipoComprobante == null)
            {
                return HttpNotFound();
            }
            return View(tipoComprobante);
        }

        // GET: TipoComprobantes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TipoComprobantes/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TipoComprobanteID,nombre")] TipoComprobante tipoComprobante)
        {
            if (ModelState.IsValid)
            {
                unityOfWork.TipoComprobante.Add(tipoComprobante);
                unityOfWork.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tipoComprobante);
        }

        // GET: TipoComprobantes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoComprobante tipoComprobante = unityOfWork.TipoComprobante.Get(id);
            if (tipoComprobante == null)
            {
                return HttpNotFound();
            }
            return View(tipoComprobante);
        }

        // POST: TipoComprobantes/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TipoComprobanteID,nombre")] TipoComprobante tipoComprobante)
        {
            if (ModelState.IsValid)
            {
                unityOfWork.TipoComprobante.Add(tipoComprobante);
                unityOfWork.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tipoComprobante);
        }

        // GET: TipoComprobantes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoComprobante tipoComprobante = unityOfWork.TipoComprobante.Get(id);
            if (tipoComprobante == null)
            {
                return HttpNotFound();
            }
            return View(tipoComprobante);
        }

        // POST: TipoComprobantes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TipoComprobante tipoComprobante = unityOfWork.TipoComprobante.Get(id);
            unityOfWork.TipoComprobante.Remove(tipoComprobante);
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
