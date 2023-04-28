using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HelloWorld.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HelloWorld.Controllers
{
    public class ReportController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            ViewData["Message"] = "This is the message from Controller";
            return View();
        }

        public IActionResult Message()
        {
            MessageViewModel msg = new MessageViewModel();
            msg.Message = "Hello view";
            msg.From = "Controller Message action";
            ViewBag.Message = msg;
            
            return View(msg);
        }
    }
}

