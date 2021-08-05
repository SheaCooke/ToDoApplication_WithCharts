using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDo.Data;
using ToDo.Models;
using ToDo.ViewModel;

namespace ToDo.Controllers
{
    public class UserController : Controller
    {
        private ToDoDbContext _context;

        public UserController(ToDoDbContext dbContext)
        {
            this._context = dbContext;
        }
        public IActionResult Index()
        {
            return View(_context.ToDos.ToList());
        }

        public IActionResult Add()
        {
            AddToDoViewModel addToDoViewModel = new AddToDoViewModel();

            return View(addToDoViewModel);
        }

        [HttpPost]
        public IActionResult AddPost(AddToDoViewModel addToDoViewModel)
        {
            if (ModelState.IsValid)
            {
                toDo newToDo = new toDo {
                    Description = addToDoViewModel.Description,
                    Priority = addToDoViewModel.Priority,
                    Notes = addToDoViewModel.Notes
                };

                _context.Add(newToDo);
                _context.SaveChanges();
                return Redirect("Add");

            }

            return View("add", addToDoViewModel);

        }

        [Route("Remove/{Id}")]
        public IActionResult Remove([FromRoute] int Id)
        {
          
            _context.ToDos.Remove(_context.ToDos.Find(Id));
            _context.SaveChanges();

            return Redirect("/User/Index");
        }
        


        
        


        


    }
}
