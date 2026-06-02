using Microsoft.AspNetCore.Mvc;

namespace Laptops.Controllers;

public class BrandController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}