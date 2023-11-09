using Microsoft.AspNetCore.Mvc;

namespace AplikacjaZaliczeniowa.Controllers;

public class CarController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}