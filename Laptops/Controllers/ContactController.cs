using Microsoft.AspNetCore.Mvc;

namespace Laptops.Controllers;

public class ContactController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}