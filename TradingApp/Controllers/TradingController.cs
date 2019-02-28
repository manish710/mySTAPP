using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TradingApp.Controllers
{
    public class TradingController : Controller
    {
        // GET: Trading
        public ActionResult Index()
        {
            return View();
        }

        // GET: Trading/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Trading/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Trading/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Trading/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Trading/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Trading/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Trading/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
