using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;

namespace Notes_ToDoList.Models
{
    public class ToDoListDB: DbContext
    {
        public ToDoListDB(): base("name=DefaultConnection")
        {
                 
        }

        public DbSet<ToDoList> ToDoLists { get; set; }

    }
}