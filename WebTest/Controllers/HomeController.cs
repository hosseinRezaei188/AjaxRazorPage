using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebTest.Models;

namespace WebTest.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(StateModel stateModel)
        {
            if (stateModel.states == null)
            {
                stateModel.states = new SelectList(new List<SelectListItem>()
                {

                    new SelectListItem() { Text = "AAA", Value = "1" }, new SelectListItem() { Text = "BBB", Value = "2" }

                }, "Value", "Text");
            }
            return View(stateModel);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
