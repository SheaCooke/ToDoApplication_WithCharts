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
            DayOfWeek today = DateTime.Today.DayOfWeek;

            AddToDoViewModel addToDoViewModel = new AddToDoViewModel(today);

            return View(addToDoViewModel);
        }

        [HttpPost]
        public IActionResult AddPost(AddToDoViewModel addToDoViewModel)
        {
            if (ModelState.IsValid)
            {
                Day newDay = new Day();



                toDo newToDo = new toDo {
                    Description = addToDoViewModel.Description,
                    Priority = addToDoViewModel.Priority,
                    Notes = addToDoViewModel.Notes,
                    DateCreated = DateTime.Now,
                    Day = newDay
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

            Day removed = new Day($"Removed {DateTime.Today.DayOfWeek.ToString()}");
       

            _context.ToDos.Remove(_context.ToDos.Find(Id));
            _context.Days.Add(removed);
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

            ViewBag.Monday = _context.Days.Where(x => x.DayModified == "Monday").ToArray();
            ViewBag.Tuesday = _context.Days.Where(x => x.DayModified == "Tuesday").ToArray();
            ViewBag.Wednesday = _context.Days.Where(x => x.DayModified == "Wednesday").ToArray();
            ViewBag.Thursday = _context.Days.Where(x => x.DayModified == "Thursday").ToArray();
            ViewBag.Friday = _context.Days.Where(x => x.DayModified == "Friday").ToArray();
            ViewBag.Saturday = _context.Days.Where(x => x.DayModified == "Saturday").ToArray();
            ViewBag.Sunday = _context.Days.Where(x => x.DayModified == "Sunday").ToArray();

            ViewBag.RemovedMon = _context.Days.Where(x => x.DayModified.Contains("Removed") && x.DayModified.Contains("Monday")).ToArray();
            ViewBag.RemovedTue = _context.Days.Where(x => x.DayModified.Contains("Removed") && x.DayModified.Contains("Tuesday")).ToArray();
            ViewBag.RemovedWed = _context.Days.Where(x => x.DayModified.Contains("Removed") && x.DayModified.Contains("Wednesday")).ToArray();
            ViewBag.RemovedThu = _context.Days.Where(x => x.DayModified.Contains("Removed") && x.DayModified.Contains("Thursday")).ToArray();
            ViewBag.RemovedFri = _context.Days.Where(x => x.DayModified.Contains("Removed") && x.DayModified.Contains("Friday")).ToArray();
            ViewBag.RemovedSat = _context.Days.Where(x => x.DayModified.Contains("Removed") && x.DayModified.Contains("Saturday")).ToArray();
            ViewBag.RemovedSun = _context.Days.Where(x => x.DayModified.Contains("Removed") && x.DayModified.Contains("Sunday")).ToArray();


            return View();
        }


        [HttpPost]
        public IActionResult ResetHistory()
        {
            foreach (var i in _context.Days.ToArray())
            {
                _context.Days.Remove(_context.Days.Find(i.DayId));
                
            }
            _context.SaveChanges();

            return Redirect("/User/Chart");
        }
        


        
        


        


    }
}
