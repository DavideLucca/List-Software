using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Aparel_List.Models;

namespace Aparel_List.Controllers
{
    public class AparelhosController : Controller
    {
        private Aparel_ListContext db = new Aparel_ListContext();

        // GET: Aparelhos
        public ActionResult Index()
        {
            return View(db.Aparelhos.ToList());
        }

        // GET: Aparelhos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Aparelhos aparelhos = db.Aparelhos.Find(id);
            if (aparelhos == null)
            {
                return HttpNotFound();
            }
            return View(aparelhos);
        }

        // GET: Aparelhos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Aparelhos/Create
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Linha,Usuario,Cargo,Time,Gerente,Aparelho,NS,IMEI1,IMEI2,MacAddress,TermoRecebimento,Obs")] Aparelhos aparelhos)
        {
            if (ModelState.IsValid)
            {
                db.Aparelhos.Add(aparelhos);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(aparelhos);
        }

        // GET: Aparelhos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Aparelhos aparelhos = db.Aparelhos.Find(id);
            if (aparelhos == null)
            {
                return HttpNotFound();
            }
            return View(aparelhos);
        }

        // POST: Aparelhos/Edit/5
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Linha,Usuario,Cargo,Time,Gerente,Aparelho,NS,IMEI1,IMEI2,MacAddress,TermoRecebimento,Obs")] Aparelhos aparelhos)
        {
            if (ModelState.IsValid)
            {
                db.Entry(aparelhos).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(aparelhos);
        }

        // GET: Aparelhos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Aparelhos aparelhos = db.Aparelhos.Find(id);
            if (aparelhos == null)
            {
                return HttpNotFound();
            }
            return View(aparelhos);
        }

        // POST: Aparelhos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Aparelhos aparelhos = db.Aparelhos.Find(id);
            db.Aparelhos.Remove(aparelhos);
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
