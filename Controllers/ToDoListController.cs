using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Notes_ToDoList.Models;

namespace Notes_ToDoList.Controllers
{
    public class ToDoListController : Controller
    {
        ToDoListDB _db= new ToDoListDB();

        // GET: ToDoList
        public ActionResult Index()
        {
            //var model = _db.ToDoLists.ToList();

            var model =
                from t in _db.ToDoLists
                orderby t.Id ascending
                select new ToDoListViewModel
                {
                   Id= t.Id,
                   TaskName= t.TaskName,
                    Description=  t.Description,
                    Priority = t.Priority,
                    Status = t.Status,
                    Owner= t.Owner
                };
                

            return View(model);
        }

        protected override void Dispose(bool disposing)
        {
            if (_db != null)
            {
                _db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}