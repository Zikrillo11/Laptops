using Laptops.BLL.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Laptops.Controllers;

public class HomeController : Controller
{
    private readonly ILaptopService _service;

    public HomeController(ILaptopService service)
    {
        _service = service;
    }

    public async Task<IActionResult> Index()
    {
        var laptops = await _service.GetAllAsync();

        return View(laptops);
    }
}