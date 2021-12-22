using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SQL_Task.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SQL_Task.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public ActionResult Index()
        {
            //Group group = _context.Groups.Include(g => g.Pupils).FirstOrDefault(g => g.Id == id);
            //if (group == null)
            //{
            //    return Content("Unfortunately!The group you were looking for could not be found");
            //}
            List<Group> group = _context.Groups.Include(g => g.Pupils).ToList();

            return View(group);
        }
    }
}

