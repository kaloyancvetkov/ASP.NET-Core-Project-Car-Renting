using CarRentingSystem.Models.Cars;
using Microsoft.AspNetCore.Mvc;

namespace CarRentingSystem.Controllers
{
    public class CarsController : Controller
    {
        public IActionResult Add() => View();

        [HttpPost]
        public IActionResult Add(AddCarViewModel car)
        {


            return View(car);
        }
    }
}
