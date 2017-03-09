﻿using System;
using System.Web.Mvc;
using System.Collections.Generic;
namespace SFSample
{
    public partial class DropdownlistController: Controller
    {
        List<groups> group = new List<groups>();
        List<Countries> country = new List<Countries>();
        public ActionResult DropdownlistFeatures()
        {
            group.Add(new groups { parentId = "a", text = "Group A" });
            group.Add(new groups { parentId = "b", text = "Group B" });
            group.Add(new groups { parentId = "c", text = "Group C" });
            group.Add(new groups { parentId = "d", text = "Group D" });
            group.Add(new groups { parentId = "e", text = "Group E" });
            ViewBag.datasource = group;
            country.Add(new Countries { value = 11, parentId = "a", text = "Algeria", sprite = "flag-dz" });
            country.Add(new Countries { value = 12, parentId = "a", text = "Armenia", sprite = "flag-am" });
            country.Add(new Countries { value = 13, parentId = "a", text = "Bangladesh", sprite = "flag-bd" });
            country.Add(new Countries { value = 14, parentId = "a", text = "Cuba", sprite = "flag-cu" });
            country.Add(new Countries { value = 15, parentId = "b", text = "Denmark", sprite = "flag-dk" });
            country.Add(new Countries { value = 16, parentId = "b", text = "Egypt", sprite = "flag-eg" });
            country.Add(new Countries { value = 17, parentId = "c", text = "Finland", sprite = "flag-fi" });
            country.Add(new Countries { value = 18, parentId = "c", text = "India", sprite = "flag-in" });
            country.Add(new Countries { value = 19, parentId = "c", text = "Malaysia", sprite = "flag-my" });
            country.Add(new Countries { value = 20, parentId = "d", text = "New Zealand", sprite = "flag-nz" });
            country.Add(new Countries { value = 21, parentId = "d", text = "Norway", sprite = "flag-no" });
            country.Add(new Countries { value = 22, parentId = "d", text = "Romania", sprite = "flag-ro" });
            country.Add(new Countries { value = 23, parentId = "e", text = "Singapore", sprite = "flag-sg" });
            country.Add(new Countries { value = 24, parentId = "e", text = "Thailand", sprite = "flag-th" });
            country.Add(new Countries { value = 25, parentId = "e", text = "Ukraine", sprite = "flag-ua" });
            ViewBag.datasource1 = country;
              return View();
         } 
    }
    public class groups
    {
        public string text { get; set; }
        public string parentId { get; set; }
        public int id { get; set; }
        public int parent { get; set; }
    }
    public class Countries
    {
        public string text { get; set; }
        public string category { get; set; }
        public int value { get; set; }
        public string parentId { get; set; }
        public string sprite { get; set; }
        public string country { get; set; }
        public int id { get; set; }
        public int parent { get; set; }
    }
}
