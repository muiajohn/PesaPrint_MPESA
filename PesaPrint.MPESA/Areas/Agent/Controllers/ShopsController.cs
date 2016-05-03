using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;


namespace PesaPrint.MPESA.Areas.Agent.Controllers
{
    public class ShopsController : Controller
    {
        private PesaPrintDatabaseEntities db = new PesaPrintDatabaseEntities();

        // GET: Agent/Shops
        public ActionResult Index()
        {
            var shops = db.Shops.Include(s => s.Merchant);
            return View(shops.ToList());
        }

        // GET: Agent/Shops/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Shop shop = db.Shops.Find(id);
            if (shop == null)
            {
                return HttpNotFound();
            }
            return View(shop);
        }

        // GET: Agent/Shops/Create
        public ActionResult Create()
        {
            ViewBag.MerchantId = new SelectList(db.Merchants, "Id", "Name");
            return View();
        }

        // POST: Agent/Shops/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,AgentNumber,MerchantId")] Shop shop)
        {
            if (ModelState.IsValid)
            {
                db.Shops.Add(shop);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MerchantId = new SelectList(db.Merchants, "Id", "Name", shop.MerchantId);
            return View(shop);
        }

        // GET: Agent/Shops/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Shop shop = db.Shops.Find(id);
            if (shop == null)
            {
                return HttpNotFound();
            }
            ViewBag.MerchantId = new SelectList(db.Merchants, "Id", "Name", shop.MerchantId);
            return View(shop);
        }

        // POST: Agent/Shops/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,AgentNumber,MerchantId")] Shop shop)
        {
            if (ModelState.IsValid)
            {
                db.Entry(shop).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MerchantId = new SelectList(db.Merchants, "Id", "Name", shop.MerchantId);
            return View(shop);
        }

        // GET: Agent/Shops/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Shop shop = db.Shops.Find(id);
            if (shop == null)
            {
                return HttpNotFound();
            }
            return View(shop);
        }

        // POST: Agent/Shops/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Shop shop = db.Shops.Find(id);
            db.Shops.Remove(shop);
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
