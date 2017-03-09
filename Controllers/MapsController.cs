using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using Syncfusion.JavaScript.DataVisualization.Maps;
using Syncfusion.JavaScript.DataVisualization.Models;
namespace SFSample
{
    public partial class MapsController : Controller
    {
        //
        // GET: /DaraMarker/
        public ActionResult MapsFeatures()
        {
            ViewData["datasource"] = Syncfusion_LocationData.GetSyncfusionLocationData();
            ViewData["mapdata"] = this.GetWroldMap();
            return View();
        }
        public object GetWroldMap()
        {
            string allText = System.IO.File.ReadAllText(Server.MapPath("~/App_Data/WorldMap.json"));
            JavaScriptSerializer ser = new JavaScriptSerializer();
            ser.MaxJsonLength = int.MaxValue;
            return new MapData(allText);
        }
    }
  public class Syncfusion_LocationData
    {
        public static List<MapMarker> GetSyncfusionLocationData()
        {
            List<MapMarker> syncfusionLocationData = new List<MapMarker>
            {
                new LocationData {Name = "Chennai", Country = "India", Latitude =13.0839 , Longitude = 80.27 , Description = "Syncfusion's branch office is located in AnnaNagar, Chennai", Address ="EYMARD Complex AJ 217 4th Avenue Shanthi Colony Anna Nagar Chennai-40 India" },
                new LocationData {Name = "North Carolina", Country = "United States", Latitude =35.5 , Longitude = -80 , Description = "Syncfusion's corporate office is located in Research Triangle Park North Carolina", Address ="Company Headquarters 2501 Aerial Center Parkway Suite 200 Morrisville NC 27560 USA" },
            };
            return syncfusionLocationData;
        }
    }
    public class LocationData : MapMarker
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string country;
        public string Country
        {
            get { return country; }
            set { country = value; }
        }
        private string description;
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        private string address;
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
    }
 }
