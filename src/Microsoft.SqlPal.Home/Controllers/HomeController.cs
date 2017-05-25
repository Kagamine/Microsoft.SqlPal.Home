using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Microsoft.SqlPal.Home.Models;

namespace Microsoft.SqlPal.Home.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(JsonConvert.DeserializeObject<HomeJson>(System.IO.File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "Content", "home.json"))));
        }

        [Route("/About")]
        public IActionResult About()
        {
            ViewBag.Layout = JsonConvert.DeserializeObject<HomeJson>(System.IO.File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "Content", "home.json")));
            ViewBag.Content = System.IO.File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "Content", "about.md"));
            return View();
        }

        [Route("/Support")]
        public IActionResult Support()
        {
            ViewBag.Layout = JsonConvert.DeserializeObject<HomeJson>(System.IO.File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "Content", "home.json")));
            ViewBag.Content = System.IO.File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "Content", "support.md"));
            return View();
        }
    }
}
