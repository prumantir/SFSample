﻿using System;
using System.Collections.Generic;
using System.Web.Mvc;
namespace SFSample
{
    public partial class AutocompleteController : Controller
    {
        List<CarsList> cars = new List<CarsList>();
        public ActionResult AutocompleteFeatures()
        {
            cars.Add(new CarsList { uniqueKey = 1, text = "Audi S6", company = "Audi" });
            cars.Add(new CarsList { uniqueKey = 2, text = "Austin-žHealey", company = "Austin" });
            cars.Add(new CarsList { uniqueKey = 3, text = "BMW š7", company = "BMW" });
            cars.Add(new CarsList { uniqueKey = 4, text = "Chevrolet Camarož", company = "Chevrolet" });
            cars.Add(new CarsList { uniqueKey = 6, text = "Ferrari š360", company = "Ferrari" });
            cars.Add(new CarsList { uniqueKey = 7, text = "Honda S2000", company = "Honda" });
            cars.Add(new CarsList { uniqueKey = 8, text = "Hyundai Santroš", company = "Hyundai" });
            cars.Add(new CarsList { uniqueKey = 9, text = "Isuzu Swift", company = "Isuzu" });
            cars.Add(new CarsList { uniqueKey = 10, text = "Jaguar XJS", company = "Jaguar" });
            cars.Add(new CarsList { uniqueKey = 11, text = "iLotus Esprit", company = "Lotus" });
            cars.Add(new CarsList { uniqueKey = 12, text = "Mercedes-Benz", company = "Mercedes" });
            cars.Add(new CarsList { uniqueKey = 13, text = "Toyota ž2000GT", company = "Toyota" });
            cars.Add(new CarsList { uniqueKey = 14, text = "Volvo P1800", company = "Volvo" });
            ViewBag.datasource = cars;
            return View();
         } 
    }
    public class CarsList
    {
          public int uniqueKey { get; set; }
          public string text { get; set; }
          public string company { get; set; }
    }
}
