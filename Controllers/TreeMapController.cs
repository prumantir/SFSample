﻿using Syncfusion.JavaScript.DataVisualization.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
namespace SFSample
{
    public partial class TreeMapController : Controller
    {
        //
        // GET: /TreeMapFeatures/
        public ActionResult TreeMapFeatures()
        {
            ViewData["Population"] = TreeMapPopulationData.GetData();
          List<string> data = new List<string>();
          data.Add("Squarified");
          data.Add("SliceAndDiceH");
          data.Add("SliceAndDiceV");
          data.Add("SliceAndDiceAuto");
          ViewBag.datasource = data;
            return View();
        }
    public class TreeMapPopulationData
    {
        public string Continent { get; set; }
        public string Country { get; set; }
        public int Growth { get; set; }
        public long Population { get; set; }
        public static List<TreeMapPopulationData> GetData()
        {
            List<TreeMapPopulationData> pop = new List<TreeMapPopulationData>();
            pop.Add(new TreeMapPopulationData() { Continent = "Asia", Country = "Indonesia", Growth = 3, Population = 237641326 });
            pop.Add(new TreeMapPopulationData() { Continent = "Asia", Country = "Russia", Growth = 2, Population = 152518015 });
            pop.Add(new TreeMapPopulationData() { Continent = "Asia", Country = "Mal", Growth = 1, Population = 29672000 });
            pop.Add(new TreeMapPopulationData() { Continent = "North America", Country = "United States", Growth = 4, Population = 315645000 });
            pop.Add(new TreeMapPopulationData() { Continent = "North America", Country = "Mexico", Growth = 2, Population = 112336538 });
            pop.Add(new TreeMapPopulationData() { Continent = "North America", Country = "Canada", Growth = 1, Population = 39056064 });
            pop.Add(new TreeMapPopulationData() { Continent = "South America", Country = "Colombia", Growth = 1, Population = 47000000 });
            pop.Add(new TreeMapPopulationData() { Continent = "South America", Country = "Brazil", Growth = 3, Population = 193946886 });
            pop.Add(new TreeMapPopulationData() { Continent = "Africa", Country = "Nigeria", Growth = 2, Population = 170901000 });
            pop.Add(new TreeMapPopulationData() { Continent = "Africa", Country = "Egypt", Growth = 1, Population = 83661000 });
            pop.Add(new TreeMapPopulationData() { Continent = "Europe", Country = "Germany", Growth = 1, Population = 81993000 });
            pop.Add(new TreeMapPopulationData() { Continent = "Europe", Country = "France", Growth = 1, Population = 65605000 });
            pop.Add(new TreeMapPopulationData() { Continent = "Europe", Country = "UK", Growth = 1, Population = 63181775 });
            return pop;
        }
    }
    }
}
