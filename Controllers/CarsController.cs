using Microsoft.AspNetCore.Mvc;
using CarDealership.Models;
using System.Collections.Generic;

namespace CarDealership.Controllers
{
    public class CarsController : Controller
    {
        [HttpGet("/cars")]
        public ActionResult CarHome()
        {
          List<Car> allCars = Car.GetAll();
          return View(allCars);
        }

        [HttpGet("/cars/new")]
        public ActionResult Index()
        {
          return View();
        }

        [HttpPost("/cars")]
        public ActionResult Create()
        {
          Car newCar = new Car (Request.Form["car-make"], int.Parse(Request.Form["car-price"]), int.Parse(Request.Form["car-year"]), Request.Form["car-pic"]);
          newCar.Save();
          List<Car> allCars = Car.GetAll();
          return View("CarHome", allCars);
        }
      }
    }


// newCar.Save();
//           List<Car> allCars = Car.GetAll();
//           return View("Index", allCars);
