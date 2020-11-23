using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using Loja.Instrumentos.Business;
using Loja.Instrumentos.Data.Entity.Context;
using Loja.Instrumentos.Repository.Entity;
using Loja.Instrumentos.RepositoryCommon;
using Loja.Instrumentos.Web.ViewModels.Particulars;

namespace Loja.Instrumentos.Web.Controllers
{
    public class ParticularsController : Controller
    {
        private IGenericRepository<Particulars, int>
                repositoryParticulars = new ParticularsRepository(new InstrumentoDbContext());

        // GET: Particulars
        public ActionResult Index()
        {
            return View(Mapper.Map<List<Particulars>, List<ParticularsIndexViewModel>>(repositoryParticulars.Select()));
        }

        // GET: Particulars/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Particulars particulars = repositoryParticulars.SelectForId(id.Value);
            if (particulars == null)
            {
                return HttpNotFound();
            }
            return View(Mapper.Map<Particulars, ParticularsIndexViewModel>(particulars));
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
        public ActionResult Create([Bind(Include = "Id,Marca,Nome,Corda,Descricao")] ParticularsViewModel ViewModel)
        {
            if (ModelState.IsValid)
            {
                Particulars particulars = Mapper.Map<ParticularsViewModel, Particulars>(ViewModel);
                repositoryParticulars.Insert(particulars);
                return RedirectToAction("Index");
            }

            return View(ViewModel);
        }

        // GET: Particulars/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Particulars particulars = repositoryParticulars.SelectForId(id.Value);
            if (particulars == null)
            {
                return HttpNotFound();
            }
            return View(Mapper.Map<Particulars, ParticularsViewModel>(particulars));
        }

        // POST: Particulars/Edit/5
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Marca,Nome,Corda,Descricao")] ParticularsViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                Particulars particulars = Mapper.Map<ParticularsViewModel, Particulars>(viewModel);
                repositoryParticulars.Alter(particulars);
                return RedirectToAction("Index");
            }
            return View(viewModel);
        }

        // GET: Particulars/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Particulars particulars = repositoryParticulars.SelectForId(id.Value);
            if (particulars == null)
            {
                return HttpNotFound();
            }
            return View(Mapper.Map<Particulars, ParticularsIndexViewModel>(particulars));
        }

        // POST: Particulars/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            repositoryParticulars.ExcludeForId(id);
            return RedirectToAction("Index");
        }

    }
}
