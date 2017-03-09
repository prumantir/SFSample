using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace SFSample.Controllers.RadialGauge
{
    public partial class RadialGaugeController : Controller
    {
         List<Directionr> scaleDirection = new List<Directionr>();
          List<NeedleStyle> needleStyle = new List<NeedleStyle>();
            List<Ranges> range = new List<Ranges>();
         List<FileFormat> fileType = new List<FileFormat>();
         public ActionResult RadialGaugeFeatures()
        {        
            scaleDirection.Add(new Directionr { Direction = "Clockwise" });
            scaleDirection.Add(new Directionr { Direction = "CounterClockwise" });
            ViewBag.datasource4 = scaleDirection;
             needleStyle.Add(new NeedleStyle { Style = "Triangle" });
            needleStyle.Add(new NeedleStyle { Style = "Trapezoid" });
            needleStyle.Add(new NeedleStyle { Style = "Arrow" });
            ViewBag.datasource1 = needleStyle;
             range.Add(new Ranges { Range = "Range1" });
            range.Add(new Ranges { Range = "Range2" });
            range.Add(new Ranges { Range = "Range3" });
            ViewBag.datasource2 = range;
            fileType.Add(new FileFormat { fileType = "JPEG" });
            fileType.Add(new FileFormat { fileType = "PNG" });
            ViewBag.datasource = fileType;
            return View();
         }
    }
  public class Directionr
    {
        public string Direction { set; get; }
    }
  public class NeedleStyle
    {
        public string Style { set; get; }
    }
 public class Ranges
    {
       public string Range { set; get; }
     }
  public class FileFormat
    {
        public string fileType { set; get; }
    }
}
