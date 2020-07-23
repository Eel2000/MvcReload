using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MvcReload.Controllers
{
    public class SchoolController : Controller
    {
        public IActionResult Index()
        {
            return View("New");
        }
    }
}
