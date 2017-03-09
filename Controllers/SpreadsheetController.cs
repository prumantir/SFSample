using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SFSample.Spread;
using Syncfusion.JavaScript;
using Syncfusion.JavaScript.Models;
using Syncfusion.EJ.Export;
using Syncfusion.XlsIO;
namespace SFSample.Controllers
{
    public partial class SpreadsheetController : Controller
    {        
         public ActionResult SpreadsheetFeatures()
        {
            var dataSource = new NorthwindDataContext().Orders.Take(50).ToList();
            ViewBag.DataSource = dataSource;
            return View();
        }
        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Import(ImportRequest importRequest)
        {
            return importRequest.SpreadsheetActions();
        }
        [AcceptVerbs(HttpVerbs.Post)]
        public void ExcelExport(string sheetModel, string sheetData, string password)
        {
            if(String.IsNullOrEmpty(password))
                Spreadsheet.Save(sheetModel, sheetData, "sample", ExportFormat.XLSX, ExcelVersion.Excel2013);
            else
                Spreadsheet.Save(sheetModel, sheetData, "sample", ExportFormat.XLSX, ExcelVersion.Excel2013, password);
        }
        [AcceptVerbs(HttpVerbs.Post)]
        public void CsvExport(string sheetModel, string sheetData)
        {
            Spreadsheet.Save(sheetModel, sheetData, "sample", ExportFormat.CSV);
        }
        [AcceptVerbs(HttpVerbs.Post)]
        public void PdfExport(string sheetModel, string sheetData)
        {
            Spreadsheet.Save(sheetModel, sheetData, "sample", ExportFormat.PDF);
        }
    }
}
