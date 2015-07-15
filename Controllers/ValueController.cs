using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication.Controllers
{
    public class ValueController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index(string value)
        {
            ViewBag.Value = value;
            Console.WriteLine(value);
            return View();
        }
    }
}
