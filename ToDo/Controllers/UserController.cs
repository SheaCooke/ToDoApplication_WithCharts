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

        private DateTime _dayCompleted;

        private Dictionary<string, int> _completedByDay= new Dictionary<string, int> { { "friday", 3 } };

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
                    Notes = addToDoViewModel.Notes,
                    DateCreated = DateTime.Now
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
            _dayCompleted = DateTime.Now;
            if (_dayCompleted.DayOfWeek == DayOfWeek.Friday)
            {
                _completedByDay["friday"] += 1;
            }


            _context.ToDos.Remove(_context.ToDos.Find(Id));
            _context.SaveChanges();

            return Redirect("/User/Index");
        }


        [Route("Edit/{Id}")]
        public IActionResult Edit(int Id)
        {
            ViewBag.edit = _context.ToDos.Find(Id);

            AddToDoViewModel addToDoViewModel = new AddToDoViewModel();
            

            return View(addToDoViewModel);

        }

        [HttpPost]
        [Route("Edit/{id}")]
        public IActionResult Edit(AddToDoViewModel addToDoViewModel, int Id)
        {
            if(ModelState.IsValid)
            {
                _context.ToDos.Where(x => x.Id == Id).ToList().ForEach(x => x.Description = addToDoViewModel.Description);
                _context.ToDos.Where(x => x.Id == Id).ToList().ForEach(x => x.Notes = addToDoViewModel.Notes);
                _context.ToDos.Where(x => x.Id == Id).ToList().ForEach(x => x.Priority = addToDoViewModel.Priority);
                
                _context.SaveChanges();
                return Redirect("/User/Index");
            }

            ViewBag.edit = _context.ToDos.Find(Id);
            return View(addToDoViewModel);
        }

        

        public IActionResult Chart()
        {
            ViewBag.HighPri = _context.ToDos.Where(x => x.Priority == Priority.High).ToArray();
            ViewBag.LowPri = _context.ToDos.Where(x => x.Priority == Priority.Low).ToArray();
            ViewBag.DataPoints = _context.ToDos.ToArray();

            List<toDo> listFriday = new List<toDo>();
            foreach (var i in _context.ToDos)
            {
                if (i.DateCreated.DayOfWeek == DayOfWeek.Friday)
                {
                    listFriday.Add(i);
                }
            }

            List<toDo> listSaturday = new List<toDo>();
            foreach (var i in _context.ToDos)
            {
                if (i.DateCreated.DayOfWeek == DayOfWeek.Saturday)
                {
                    listSaturday.Add(i);
                }
            }





            ViewBag.Friday = listFriday;
            ViewBag.Saturday = listSaturday;

            ViewBag.completedByDay = _completedByDay;
            return View();
        }
        


        
        


        


    }
}
