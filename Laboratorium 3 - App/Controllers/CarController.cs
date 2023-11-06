using Laboratorium_3___App.Models;
using Microsoft.AspNetCore.Mvc;

namespace Laboratorium_3___App.Controllers;

public class CarController : Controller
{
    private readonly ICarService _carService;        
    
    public CarController(ICarService carService)
    {
        _carService = carService;
    }
    public IActionResult Index()
            {
                return View(_car.Values.ToList());
            }
    
            [HttpGet]
            public IActionResult Create()
            {
                return View();
            }
    
            [HttpGet]
            public IActionResult Update(int id)
            {
                return View(_car[id]);
            }
    
            [HttpGet]
            public IActionResult Details(int id)
            {
                return View(_car[id]);
            }
    
            [HttpGet]
            public IActionResult Delete(int id)
            {
                return View(_car[id]);
            }
    
            [HttpPost]
            public IActionResult Create(Car model) 
            { 
                if(ModelState.IsValid) 
                {
                    model.Id = index++;
                    _car[model.Id] = model;
                    return RedirectToAction("Index");
                }
                return View();
            }
    
            [HttpPost]
            public IActionResult Update(Car model)
            {
                if (ModelState.IsValid)
                {
                    _car[model.Id] = model;
                    return RedirectToAction("Index");
                }
                return View();
            }
}