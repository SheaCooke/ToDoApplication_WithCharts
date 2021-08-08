using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDo.Models
{
    public class Day
    {

        public /*DayOfWeek*/string DayModified { get; set; }

        public int DayId { get; set; }

        public List<toDo> toDos { get; set; }

        public Day()
        {
            this.DayModified = DateTime.Today.DayOfWeek.ToString();
        }


    }

}