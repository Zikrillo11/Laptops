using Microsoft.AspNetCore.Mvc;

namespace Laptops.Controllers;

public class AdminController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}