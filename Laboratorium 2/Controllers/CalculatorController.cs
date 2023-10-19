﻿using Microsoft.AspNetCore.Mvc;
using Laboratorium_2.Models;

namespace Laboratorium_2.Controllers
{   
    public class CalculatorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Form()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Result([FromForm] CalculatorViewModel model)
        {
            if (!model.IsValid())
            {
                return View("Error");
            }
            return View(model);
        }
    }
}
