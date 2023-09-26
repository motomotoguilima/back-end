using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using _17_CRUD.Models;

namespace _17_CRUD.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
