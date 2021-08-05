using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using ToDo.Models;

namespace ToDo.ViewModel
{
    public class AddToDoViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="This field is required")]
        public string Description { get; set; }

        [Required(ErrorMessage = "This field is required")]
        public Priority Priority { get; set; }
        public string Notes { get; set; }

        public List<SelectListItem> PriorityList = new List<SelectListItem>
        {
            new SelectListItem(Priority.High.ToString(), ((int)Priority.High).ToString()),
            new SelectListItem(Priority.Low.ToString(), ((int)Priority.Low).ToString())
        };
    }
}
