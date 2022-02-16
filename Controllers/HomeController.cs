using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using First.Models;

namespace First.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public JsonResult List()
    {
        var list = new List<string>(){"1","2","3","4","5"};
        list.ForEach(e => Int32.Parse(e));
        return Json(list);
    }
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

    public JsonResult GetJsonResult()
    {
        return Json(new ErrorViewModel{RequestId = "12"});
    }
    public IActionResult Element()
    {
        return View();
    }
    public IActionResult React()
    {
        return View();
    }
}
