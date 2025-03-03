using MakeOrderWebApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MakeOrderWebApp.Controllers;

public class HomeController : Controller
{
    
    public IActionResult Index()
    {
        return View();
    }

}
