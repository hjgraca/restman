using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RestManager.Controllers
{
    public class MenuController : Controller
    {
        // GET: Menu
        public ActionResult Index()
        {
            return PartialView();
        }

        // GET: Menu/Details/5
        public ActionResult Details(int id)
        {
            return PartialView();
        }

        // GET: Menu/Create
        public ActionResult Create()
        {
            return PartialView();
        }

        // POST: Menu/Create
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
                return PartialView();
            }
        }

        // GET: Menu/Edit/5
        public ActionResult Edit(int id)
        {
            return PartialView();
        }

        // POST: Menu/Edit/5
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
                return PartialView();
            }
        }

        // GET: Menu/Delete/5
        public ActionResult Delete(int id)
        {
            return PartialView();
        }

        // POST: Menu/Delete/5
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
                return PartialView();
            }
        }
    }
}
