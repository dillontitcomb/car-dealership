using System;
using System.Collections.Generic;

class Car
  {
    private string _make;
    private int _cost;
    private int _year;

    public Car(string carMake, int carCost, int carYear)
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
}

class Program
  {
  public static void Main()
  {



    Car firstCar = new Car("Hyundai Sonata", 26500, 2015);

    Car secondCar = new Car("Toyota Prius", 31250, 2018);

    Car thirdCar = new Car("Lamborghini Aventador", 420000, 2017);

    Car fourthCar = new Car("Lincoln Navigator", 49500, 2016);

    Car fifthCar = new Car("Mazda Miata", 17500, 2008);

    Car sixthCar = new Car("Tesla Model 3", 35000, 1800);

    Car seventhCar = new Car("Ford Fiesta", 15000, 1969);

    Car eighthCar = new Car("Porsche 911 Turbo", -1000, 2017);

    Car ninthCar = new Car("Bugatti Chiron", 2650000, 2018);

    Car tenthCar = new Car("Cadillac Escalade", 12000, 1999);

    List<Car> Cars = new List<Car>() {firstCar, secondCar, thirdCar, fourthCar, fifthCar, sixthCar, seventhCar, eighthCar, ninthCar, tenthCar};

    foreach (Car sticker in Cars)
    {
      Console.WriteLine(sticker.GetMake());
      Console.WriteLine(sticker.GetCost());
      Console.WriteLine(sticker.GetYear());

    }
  }
}
