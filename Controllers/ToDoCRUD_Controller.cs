using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Notes_ToDoList.Models;

namespace Notes_ToDoList.Controllers
{
    public class ToDoCRUD_Controller : Controller
    {
        ToDoListDB db = new ToDoListDB();

        // GET: ToDoCRUD_
        public ActionResult Index()
        {
            return View(db.ToDoLists.ToList());
        }

        // GET: ToDoCRUD_/Details/5
        public ActionResult Details(int id = 0)
        {
            ToDoList ToDoList = db.ToDoLists.Find(id);
            if (ToDoList == null)
            {
                return HttpNotFound();
            }

            return View(ToDoList);
        }

        // GET: ToDoCRUD_/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ToDoCRUD_/Create
        [HttpPost]
        public ActionResult Create(ToDoList ToDoList)
        {
            if (ModelState.IsValid)
            {
                db.ToDoLists.Add(ToDoList);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(ToDoList);
        }

        //// GET: ToDoCRUD_/Edit/5
        //public ActionResult Edit(int id = 0)
        //{
        //    ToDoList ToDoList = db.ToDoLists.Find(id);
        //    if (ToDoList == null)
        //    {
        //        return HttpNotFound();
        //    }

        //    return View(ToDoList);
        //}

        // POST: ToDoCRUD_/Edit/5
        //[HttpPost]
        //public ActionResult Edit(int id)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Entry(ToDoList).State = EntityState.Modified;
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }

        //    return View(ToDoList);
        //}


        // GET: ToDoCRUD_/Delete/5
        public ActionResult Delete(int id = 0)
        {

            ToDoList ToDoList = db.ToDoLists.Find(id);
            if (ToDoList == null)
            {
                return HttpNotFound();
            }

            return View(ToDoList);
        }

        // POST: ToDoCRUD_/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            try
            {
                ToDoList ToDoList = db.ToDoLists.Find(id);
                db.ToDoLists.Remove(ToDoList);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (db != null)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
