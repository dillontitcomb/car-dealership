using System;
using System.Collections.Generic;

namespace CarDealership.Models
  {
  public class Car
    {
      private string _make;
      private int _cost;
      private int _year;
      private string _pic;

      private static List<Car> _instances = new Car<Car> {};

      public Car(string carMake, int carCost, int carYear string carPic)
      {
        _make = carMake;
        {
          if (carCost >= 0) {
            _cost = carCost;
          }
          else {
            _cost = -1;
          }
        }

        if (carYear >= 1980) {
          _year = carYear;
        }
        else {
          _year = -1;
        }
      }

    public void SetMake(string newMake)
    {
      _make = newMake;
    }

    public string GetMake()
    {
      return _make;
    }

    public string GetCost()
    {
      if (_cost == -1)
      {
        return "Price is invalid, please input correct price.";
      }
      return _cost.ToString();
    }

    public void SetYear(int newYear)
    {
      if (newYear >= 1980) {
        _year = newYear;
      }
      else {
        _year = -1;
      }
    }

    public string GetYear()
    {
      if (_year == -1)
      {
        return "Too old for us to sell";
      }
      return _year.ToString();
    }

    public void SetPic(string newPic)
    {
      _pic = newPic;
    }

    public string GetPic()
    {
      return _pic;
    }

    public static List<Car> GetAll()
    {
      return _instances;
    }

    public void Save()
    {
      _instances.Add(this);
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}
