using Barnet.Data;
using Barnet.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Barnet.Areas.Admin.Controllers
{
        [Area("Admin")]
        public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            VmLayout model = new VmLayout()
            {
                Setting = _context.Setting.FirstOrDefault(),
                Articles = _context.Articles.ToList(),
                Sosial = _context.Sosial.ToList(),
                Subscribe = _context.Subscribe.ToList(),
                Twitter = _context.Twitter.ToList()
            };
            return View(model);
        }
    }
}
