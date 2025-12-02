using Microsoft.AspNetCore.Mvc;
using WebApplication1.Properties.Models;

namespace WebApplication1.Properties.Controllers;
public class HomeController : Controller
{
    public IActionResult Index()
    {
        Car car = new Car();
        car.Id = 15;
        car.Name = "Test";
        car.Model = "TestLover";
        return View(car);
    }
}
