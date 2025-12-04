using Microsoft.AspNetCore.Mvc;
using WebApplication1.Properties.Models;
using WebApplication1.Properties.Views.ViewModels;

namespace WebApplication1.Properties.Controllers;
public class HomeController : Controller
{
    
    Car car = new Car()
    {
        Id = 1,
        Name = "BMW",
        Model = "M5"
    };
    
    List<Student> _students = new List<Student>()
    {
        new Student() { Id = 1, FirstName = "Alice", Age = 20 },
        new Student() { Id = 2, FirstName = "Bob", Age = 22 },
        new Student() { Id = 3, FirstName = "Charlie", Age = 23 }
    };

    HomeVm vm = new HomeVm()
    {
        Car = new Car()
        {
            Id = 1,
            Name = "BMW",
            Model = "M5"
        },
        Students = new List<Student>()
        {
            new Student() { Id = 1, FirstName = "Alice", Age = 20 },
            new Student() { Id = 2, FirstName = "Bob", Age = 22 },
            new Student() { Id = 3, FirstName = "Charlie", Age = 23 }
        }
    };
    public IActionResult Index()
    {
        return View(vm);
    }
}
