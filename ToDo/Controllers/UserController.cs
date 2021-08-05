using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDo.Models;
using ToDo.ViewModel;

namespace ToDo.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(AddToDoViewModel addToDoViewModel)
        {
            if(ModelState.IsValid)
            {
                toDo newToDo = new toDo { 
                    Description = addToDoViewModel.Description,
                    Priority = addToDoViewModel.Priority,
                    Notes = addToDoViewModel.Notes
                };


            }

        }
        


        
        


        


    }
}
