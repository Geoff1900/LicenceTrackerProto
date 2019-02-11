using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace LicenceTrackerProto.Controllers
{
    public class LicenceController : Controller
    {
        public IActionResult Index()
        {
            return Content("Hello from Licence Tracker");
            //return View();
        }
    }
}