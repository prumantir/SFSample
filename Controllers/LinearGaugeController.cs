using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace SFSample.Controllers.LinearGauge
{
    public partial class LinearGaugeController : Controller
    {
            List<ScaleOrientation> OrientationType = new List<ScaleOrientation>();
            List<PointerPlacementl> placement = new List<PointerPlacementl>();
            List<MarkerStyle> style = new List<MarkerStyle>();
            List<GaugeRange> Gaugerange = new List<GaugeRange>();
            List<PointerPlacementr> placementr = new List<PointerPlacementr>();
         List<FileFormat> fileType = new List<FileFormat>();
         public ActionResult LinearGaugeFeatures()
        {        
            OrientationType.Add(new ScaleOrientation { OrientationType = "Clockwise" });
            OrientationType.Add(new ScaleOrientation { OrientationType = "CounterClockwise" });
            ViewBag.datasource5 = OrientationType;
             placement.Add(new PointerPlacementl { Placement = "Far" });
            placement.Add(new PointerPlacementl { Placement = "Near" });
            placement.Add(new PointerPlacementl { Placement = "Center" });
            ViewBag.datasource1 = placement;
            style.Add(new MarkerStyle { markerStyle = "Diamond" });
            style.Add(new MarkerStyle { markerStyle = "Rectangle" });
            style.Add(new MarkerStyle { markerStyle = "Triangle" });
            style.Add(new MarkerStyle { markerStyle = "Ellipse" });
            style.Add(new MarkerStyle { markerStyle = "Pentagon" });
            style.Add(new MarkerStyle { markerStyle = "Circle" });
            style.Add(new MarkerStyle { markerStyle = "star" });
            style.Add(new MarkerStyle { markerStyle = "Slider" });
            style.Add(new MarkerStyle { markerStyle = "Pointer" });
            style.Add(new MarkerStyle { markerStyle = "Wedge" });
            style.Add(new MarkerStyle { markerStyle = "Trapezoid" });
            style.Add(new MarkerStyle { markerStyle = "Rounded Rect" });
            ViewBag.datasource2 = style;
           placementr.Add(new PointerPlacementr { Placementr = "Far" });
            placementr.Add(new PointerPlacementr { Placementr = "Near" });
            placementr.Add(new PointerPlacementr { Placementr = "Center" });
            ViewBag.datasource4 = placementr;
            Gaugerange.Add(new GaugeRange { Gaugerange = "Range1" });
            Gaugerange.Add(new GaugeRange { Gaugerange = "Range2" });
            ViewBag.datasource3 = Gaugerange;
            fileType.Add(new FileFormat { fileType = "JPEG" });
            fileType.Add(new FileFormat { fileType = "PNG" });
            ViewBag.datasource = fileType;
            return View();
         }
    }
            public class ScaleOrientation
    {
        public string OrientationType { set; get; }
    }
              public class PointerPlacementl
               {
                       public string Placement { set; get; }
                 }
            public class MarkerStyle
                {
                   public string markerStyle { set; get; }
                 }
                         public class GaugeRange
                            {
                             public string Gaugerange { set; get; }
                             }
                        public class PointerPlacementr
                             {
                          public string Placementr { set; get; }
                             }
   public class FileFormat
    {
        public string fileType{ set; get; }
    }
}
