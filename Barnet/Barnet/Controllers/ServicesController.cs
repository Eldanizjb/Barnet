using Barnet.Data;
using Barnet.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Barnet.Controllers
{
    public class ServicesController : Controller
    {
        private readonly AppDbContext _context;

     
        public ServicesController(AppDbContext context)
        {
            _context = context;

        }


        public IActionResult Index()
        {
            VmServices model = new VmServices
            {
                Banner = _context.Banner.FirstOrDefault(b => b.Page == "Services"),
                Service = _context.Service.OrderByDescending(p=>p.CreateDate).ToList(),
                ServicesCategories = _context.ServicesCategories.ToList(),
                Solution = _context.Solution.OrderByDescending(p => p.CreateDate).ToList(),
                SolutionCategories = _context.SolutionCategories.ToList(),
                Feedback = _context.Feedback.ToList()
            };
            return View(model);
        }
    }
}
