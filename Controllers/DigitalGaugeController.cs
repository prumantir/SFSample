using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace SFSample.Controllers
{
    public partial class DigitalGaugeController : Controller
    {
        List<Types> charactertype = new List<Types>();
        List<NeedleStyle> needleStyle = new List<NeedleStyle>();
        List<FileFormat> fileType = new List<FileFormat>();
        public ActionResult DigitalGaugeFeatures()
        {
            fileType.Add(new FileFormat { fileType = "JPEG" });
            fileType.Add(new FileFormat { fileType = "PNG" });
            ViewBag.datasource = fileType;
            charactertype.Add(new Types { Type = "sevensegment" });
            charactertype.Add(new Types { Type = "fourteensegment" });
            charactertype.Add(new Types { Type = "sixteensegment" });
            charactertype.Add(new Types { Type = "eightcrosseightdotmatrix" });
            charactertype.Add(new Types { Type = "eightcrosseightsquarematrix" });
            ViewBag.datasource1 = charactertype;
            needleStyle.Add(new NeedleStyle { Style = "Triangle" });
            needleStyle.Add(new NeedleStyle { Style = "Trapezoid" });
            needleStyle.Add(new NeedleStyle { Style = "Arrow" });
            ViewBag.datasource2 = needleStyle;
            return View();
        }
    }
    public class Types
    {
        public string Type { set; get; }
    }
    public class FileFormat
    {
        public string fileType { set; get; }
    }
    public class NeedleStyle
    {
        public string Style { set; get; }
    }
}
