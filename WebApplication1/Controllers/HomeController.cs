using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        Phone [] arrayOfPhones = { 
            new Phone
            {
                Id = 1,
                Model = "Xiaomi Redmi Note 11 Pro",
                OperatingSystem = "Android",
                RAM = 6,
                BuiltInMemory = 128,
                NumberOfCores = 8,
                BatteryCapacity = 5000,
                ScreenDiagonal = 6.67F,
                Price = 11999
            },
            new Phone
            {
                Id = 2,
                Model = "iPhone 14",
                OperatingSystem = "iOS",
                RAM = 16,
                BuiltInMemory = 128,
                NumberOfCores = 8,
                BatteryCapacity = 6000,
                ScreenDiagonal = 6.1F,
                Price = 41499
            },
            new Phone
            {
                Id = 3,
                Model = "Samsung Galaxy S22",
                OperatingSystem = "Android",
                RAM = 8,
                BuiltInMemory = 128,
                NumberOfCores = 8,
                BatteryCapacity = 3700,
                ScreenDiagonal = 6.1F,
                Price = 33199
            },
            new Phone
            {
                Id = 4,
                Model = "Xiaomi Poco C40",
                OperatingSystem = "Android",
                RAM = 3,
                BuiltInMemory = 32,
                NumberOfCores = 8,
                BatteryCapacity = 6000,
                ScreenDiagonal = 6.71F,
                Price = 6169
            }
            ,
            new Phone
            {
                Id = 5,
                Model = "Samsung Galaxy A12",
                OperatingSystem = "Android",
                RAM = 4,
                BuiltInMemory = 64,
                NumberOfCores = 8,
                BatteryCapacity = 5000,
                ScreenDiagonal = 6.71F,
                Price = 8925
            }
        };


        [HttpGet]
        public ActionResult Index()
        {
            return View(arrayOfPhones);
        }

        [HttpGet("Characteristics")]
        public ActionResult Characteristics()
        {
            return View(arrayOfPhones);
        }
    }
}
