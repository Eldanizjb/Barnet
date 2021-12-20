using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Barnet.Controllers
{
    public class ServiceDetailsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
