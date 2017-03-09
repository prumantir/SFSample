using System;
using System.Web.Mvc;
using System.Collections.Generic; 
namespace SFSample.Controllers.BulletGraph
{
    public partial class BulletGraphController: Controller
    {
	 List<BulletLocalDataBind> lclbnd = new List<BulletLocalDataBind>();
            List<BulletGraphProperties> bulletGraphPropertiesOrientation = new List<BulletGraphProperties>();
        List<BulletGraphProperties> bulletGraphPropertiesDirection = new List<BulletGraphProperties>();
        List<BulletGraphProperties> bulletGraphPropertiesStroke = new List<BulletGraphProperties>();
        public ActionResult BulletGraphFeatures()
        {  lclbnd.Add(new BulletLocalDataBind { catagory = "2001", value = "9.5", comparitiveMeasureValue = "7.5" });
            lclbnd.Add(new BulletLocalDataBind { catagory = "2002", value = "9.5", comparitiveMeasureValue = "5" });
            lclbnd.Add(new BulletLocalDataBind { catagory = "2003", value = "9.5", comparitiveMeasureValue = "6" });
            lclbnd.Add(new BulletLocalDataBind { catagory = "2004", value = "9.5", comparitiveMeasureValue = "8" });
            lclbnd.Add(new BulletLocalDataBind { catagory = "2005", value = "9.5", comparitiveMeasureValue = "5" });
            lclbnd.Add(new BulletLocalDataBind { catagory = "2006", value = "9.5", comparitiveMeasureValue = "6" });
            ViewBag.datasource = lclbnd;
           bulletGraphPropertiesOrientation.Add(new BulletGraphProperties { Orientation = "--Select--" });
            bulletGraphPropertiesOrientation.Add(new BulletGraphProperties { Orientation = "horizontal" });
            bulletGraphPropertiesOrientation.Add(new BulletGraphProperties { Orientation = "vertical" });
            bulletGraphPropertiesDirection.Add(new BulletGraphProperties { Direction = "--Select--" });
            bulletGraphPropertiesDirection.Add(new BulletGraphProperties { Direction = "backward" });
            bulletGraphPropertiesDirection.Add(new BulletGraphProperties { Direction = "forward" });
            bulletGraphPropertiesStroke.Add(new BulletGraphProperties { RangeStroke = "--Select--" });
            bulletGraphPropertiesStroke.Add(new BulletGraphProperties { RangeStroke = "red" });
            bulletGraphPropertiesStroke.Add(new BulletGraphProperties { RangeStroke = "yellow" });
            bulletGraphPropertiesStroke.Add(new BulletGraphProperties { RangeStroke = "green" });
            ViewBag.datasourceOrientation = bulletGraphPropertiesOrientation;
            ViewBag.datasourceDirection = bulletGraphPropertiesDirection;
            ViewBag.datasourceStroke = bulletGraphPropertiesStroke;
              return View();
         } 
    }
          public class BulletLocalDataBind
             {
               public string catagory { set; get; }
               public string value { set; get; }
               public string comparitiveMeasureValue { set; get; }
             }
         public class BulletGraphProperties
              {
                public string Orientation { set; get; }
                public string RangeStroke { set; get; }
                public string Direction { set; get; }
              }
}
