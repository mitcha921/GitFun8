using GitFun8.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace GitFun8.Controllers
{
    public class HomeController : Controller
    {
     

        public HomeController()
        {
            
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
