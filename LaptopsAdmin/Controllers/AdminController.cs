using Laptops.BLL.Interfaces;
using Laptops.Shared.DTOs.Laptops;
using Microsoft.AspNetCore.Mvc;

namespace Laptops.Controllers;

public class AdminController : Controller
{
    private readonly ILaptopService _service;

    public AdminController(ILaptopService service)
    {
        _service = service;
    }

    private bool IsLoggedIn()
    {
        return HttpContext.Session.GetString("Admin") != null;
    }

    public async Task<IActionResult> Index()
    {
        if (!IsLoggedIn())
            return RedirectToAction("Login", "Account");

        var laptops = await _service.GetAllAsync();

        return View(laptops);
    }

    [HttpGet]
    public IActionResult Create()
    {
        if (!IsLoggedIn())
            return RedirectToAction("Login", "Account");

        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Create(LaptopForCreateDto dto)
    {
        if (!IsLoggedIn())
            return RedirectToAction("Login", "Account");

        await _service.CreateAsync(dto);

        return RedirectToAction(nameof(Index));
    }

    [HttpGet]
    public async Task<IActionResult> Edit(long id)
    {
        if (!IsLoggedIn())
            return RedirectToAction("Login", "Account");

        var laptop = await _service.GetByIdAsync(id);

        if (laptop == null)
            return NotFound();

        var dto = new LaptopForUpdateDto
        {
            Name = laptop.Name,
            Brand = laptop.Brand,
            Price = laptop.Price
        };

        ViewBag.Id = id;

        return View(dto);
    }

    [HttpPost]
    public async Task<IActionResult> Edit(long id, LaptopForUpdateDto dto)
    {
        if (!IsLoggedIn())
            return RedirectToAction("Login", "Account");

        await _service.UpdateAsync(id, dto);

        return RedirectToAction(nameof(Index));
    }

    public async Task<IActionResult> Delete(long id)
    {
        if (!IsLoggedIn())
            return RedirectToAction("Login", "Account");

        await _service.DeleteAsync(id);

        return RedirectToAction(nameof(Index));
    }
}