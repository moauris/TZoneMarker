using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TZoneMarker.Models;

namespace TZoneMarker.Controllers
{
    public class HomeController : Controller
    {
        private IAppRepository repository;
        public HomeController(IAppRepository repo)
        {
            repository = repo;
        }
        public IActionResult Index()
        {
            return View(repository.TimeZones);
        }
    }
}
