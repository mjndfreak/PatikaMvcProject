using Microsoft.AspNetCore.Mvc;

namespace PatikaMvcProject.Controllers;

public class User : Controller
{
    // GET
    public IActionResult Login()
    {
        return View();
    }

    public IActionResult SignUp()
    {
        return View();
    }
}