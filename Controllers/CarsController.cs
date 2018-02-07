using Microsoft.AspNetCore.Mvc;
using ToDoList.Models;
using System.Collections.Generic;

namespace CarDealership.Controllers
{
    public class CarsController : Controller
    {
        [HttpGet("/cars")]
        public ActionResult Index()
        {
          List<Car> allCars = Car.GetAll();
          return View(allItems);
        }

        [HttpGet]("/cars/new")]
        public ActionResult Index()

        }
        [HttpGet("/carresults")]
        public ActionResult Results()
      }
    }
Car newCar = new Car (Request.Form["car-make"], Request.Form["car-price"], Request.Form["car-year"], Request.Form["car-pic"]);

newCar.Save();
          List<Car> allCars = Car.GetAll();
          return View("Index", allCars);
