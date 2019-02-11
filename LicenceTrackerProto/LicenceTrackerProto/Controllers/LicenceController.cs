using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LicenceTrackerProto.Models;
using LicenceTrackerProto.Services;
using Microsoft.AspNetCore.Mvc;

namespace LicenceTrackerProto.Controllers
{
    public class LicenceController : Controller
    {
        private readonly ILicenceService _licenceService;
        public LicenceController(ILicenceService licenceService)
        {
                _licenceService = licenceService;
        }
        
        public async Task<IActionResult> Index()
        {
            
            var licences = new LicenceViewModel();
            licences.items = await _licenceService.GetLicencesAsync();

            //return Content("Hello from Licence Tracker");
            return View(licences);
        }
    }
}