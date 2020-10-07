using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Loja.Instrumentos.Business;
using Loja.Instrumentos.Data.Entity.Context;

namespace Loja.Instrumentos.Web.Controllers
{ 
    public class ParticularsController : Controller
    {
        private InstrumentoDbContext db = new InstrumentoDbContext();

        // GET: Particulars
        public ActionResult Index()
        {
            return View(db.Particulars.ToList());
        }

        // GET: Particulars/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Particulars particulars = db.Particulars.Find(id);
            if (particulars == null)
            {
                return HttpNotFound();
            }
            return View(particulars);
        }

        // GET: Particulars/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Particulars/Create
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Marca,Nome,Corda,Descricao")] Particulars particulars)
        {
            if (ModelState.IsValid)
            {
                db.Particulars.Add(particulars);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(particulars);
        }

        // GET: Particulars/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Particulars particulars = db.Particulars.Find(id);
            if (particulars == null)
            {
                return HttpNotFound();
            }
            return View(particulars);
        }

        // POST: Particulars/Edit/5
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Marca,Nome,Corda,Descricao")] Particulars particulars)
        {
            if (ModelState.IsValid)
            {
                db.Entry(particulars).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(particulars);
        }

        // GET: Particulars/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Particulars particulars = db.Particulars.Find(id);
            if (particulars == null)
            {
                return HttpNotFound();
            }
            return View(particulars);
        }

        // POST: Particulars/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Particulars particulars = db.Particulars.Find(id);
            db.Particulars.Remove(particulars);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
