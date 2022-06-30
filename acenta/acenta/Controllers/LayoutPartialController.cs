using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace acenta.Controllers
{
    public class LayoutPartialController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
