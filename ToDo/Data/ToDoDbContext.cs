using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDo.Models;

namespace ToDo.Data
{
    public class ToDoDbContext : DbContext
    {

        public DbSet<toDo> ToDos { get; set; }

        public ToDoDbContext(DbContextOptions<ToDoDbContext> options) :base(options)
        {

        }
    }
}
