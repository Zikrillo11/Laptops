using Microsoft.AspNetCore.Mvc;

namespace Laptops.Controllers;

public class BlogController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}