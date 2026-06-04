using Laptops.Shared.DTOs.Laptops;
using Microsoft.AspNetCore.Mvc;

namespace Laptops.Controllers;

public class AccountController : Controller
{
    [HttpGet]
    public IActionResult Login()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Login(LoginDto dto)
    {
        if (dto.Username == "admin" &&
            dto.Password == "12345")
        {
            HttpContext.Session.SetString(
                "Admin",
                dto.Username);

            return RedirectToAction(
                "Index",
                "Admin");
        }

        ViewBag.Error = "Login yoki parol xato";

        return View();
    }

    public IActionResult Logout()
    {
        HttpContext.Session.Clear();

        return RedirectToAction(
            "Login",
            "Account");
    }
}