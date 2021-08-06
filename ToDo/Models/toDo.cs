using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace ToDo.Models
{
    public class toDo
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public Priority Priority { get; set; }
        public string Notes { get; set; }

        public DateTime DateCreated { get; set; }

       

        public toDo()
        {

        }

        public toDo(string description, Priority priority, string notes) :this()
        {
            this.Description = description;
            this.Priority = priority;
            this.Notes = notes;
            //this.DateCreated = DateTime.Now;
            
            
        }




    }
}
