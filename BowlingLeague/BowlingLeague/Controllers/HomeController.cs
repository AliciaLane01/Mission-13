using BowlingLeague.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace BowlingLeague.Controllers
{
    public class HomeController : Controller
    {
        private IBowlerDBRepository _repo { get; set; }

        public HomeController(IBowlerDBRepository repo)
        {
            _repo = repo;
        }

        public IActionResult Index()
        {
            var bowlers = _repo.Bowlers.ToList();

            return View(bowlers);
        }
    }
}
