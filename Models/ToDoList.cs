using System;
using System.Collections.Generic;
using System.Web.Profile;
using System.Linq;
using System.Web;

namespace Notes_ToDoList.Models
{
    public class ToDoList
    {
        public int? Id { get; set; }
        public string TaskName { get; set; }
        public string Description { get; set; }
        public string Priority { get; set; }

        public string Status { get; set; }
        public string Owner { get; set; }
    }
}