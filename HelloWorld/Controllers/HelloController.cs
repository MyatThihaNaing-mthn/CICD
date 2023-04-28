using System;
using HelloWorld.Models;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
namespace HelloWorld.Controllers
{
	public class HelloController: Controller
	{
        private readonly ILogger<HelloController> _logger;

        public HelloController(ILogger<HelloController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        
    }
}

