using Microsoft.AspNetCore.Mvc;

namespace ControleDeMedicamentos.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}