﻿using Syncfusion.JavaScript;
using Syncfusion.JavaScript.Models;
using Syncfusion.JavaScript.ReportViewerEnums;
using Syncfusion.EJ.ReportViewer;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;
using System.Net.Http;
using System.Web.Http;
namespace SFSample.Controllers
{
    public partial class ReportViewerController : Controller
    {
        //
        // GET: /Report/
        public ActionResult ReportViewerFeatures()
        {
            ViewData["Sales"] = SalesDetails.GetData();
            return View();
        }
    }
    public class ReportAPIController : ApiController, IReportController
    {
        public object PostReportAction(Dictionary<string, object> jsonResult)
        {
            return ReportHelper.ProcessReport(jsonResult, this);
        }
        [System.Web.Http.ActionName("GetResource")]
        [System.Web.Http.AcceptVerbs("GET")]
        public object GetResource(string key, string resourcetype, bool isPrint)
        {
            return ReportHelper.GetResource(key, resourcetype, isPrint);
        }
        public void OnInitReportOptions(ReportViewerOptions reportOption)
        {
        }
        public void OnReportLoaded(ReportViewerOptions reportOption)
        {
        }
    }
    #region Sales
    public class SalesDetails
    {
        public string ProdCat { get; set; }
        public string SubCat { get; set; }
        public double? OrderYear { get; set; }
        public string OrderQtr { get; set; }
        public double? Sales { get; set; }
        public static IList GetData()
        {
            List<SalesDetails> datas = new List<SalesDetails>();
            SalesDetails data = null;
            data = new SalesDetails()
            {
                ProdCat = "Accessories",
                SubCat = "Helmets",
                OrderYear = 2002,
                OrderQtr = "Q1",
                Sales = 4945.6925
            };
            datas.Add(data);
            data = new SalesDetails()
            {
                ProdCat = "Components",
                SubCat = "Road Frames",
                OrderYear = 2002,
                OrderQtr = "Q3",
                Sales = 957715.1942
            };
            datas.Add(data);
            data = new SalesDetails()
            {
                ProdCat = "Components",
                SubCat = "Forks",
                OrderYear = 2002,
                OrderQtr = "Q4",
                Sales = 23543.1060
            };
            datas.Add(data);
            data = new SalesDetails()
            {
                ProdCat = "Bikes",
                SubCat = "Road Bikes",
                OrderYear = 2002,
                OrderQtr = "Q1",
                Sales = 3171787.6112
            };
            datas.Add(data);
            data = new SalesDetails()
            {
                ProdCat = "Accessories",
                SubCat = "Helmets",
                OrderYear = 2002,
                OrderQtr = "Q3",
                Sales = 33853.1033
            };
            datas.Add(data);
            data = new SalesDetails()
            {
                ProdCat = "Components",
                SubCat = "Wheels",
                OrderYear = 2002,
                OrderQtr = "Q4",
                Sales = 163921.8870
            };
            datas.Add(data);
            data = new SalesDetails()
            {
                ProdCat = "Bikes",
                SubCat = "Road Bikes",
                OrderYear = 2003,
                OrderQtr = "Q2",
                Sales = 4119658.6506
            };
            datas.Add(data);
            data = new SalesDetails()
            {
                ProdCat = "Clothing",
                SubCat = "Socks",
                OrderYear = 2003,
                OrderQtr = "Q3",
                Sales = 6968.6884
            };
            datas.Add(data);
            data = new SalesDetails()
            {
                ProdCat = "Bikes",
                SubCat = "Road Bikes",
                OrderYear = 2003,
                OrderQtr = "Q4",
                Sales = 3734891.6389
            };
            datas.Add(data);
            data = new SalesDetails()
            {
                ProdCat = "Components",
                SubCat = "Mountain Frames",
                OrderYear = 2002,
                OrderQtr = "Q3",
                Sales = 608352.8754
            };
            datas.Add(data);
            data = new SalesDetails()
            {
                ProdCat = "Components",
                SubCat = "Handlebars",
                OrderYear = 2002,
                OrderQtr = "Q4",
                Sales = 18309.4452
            };
            datas.Add(data);
            data = new SalesDetails()
            {
                ProdCat = "Components",
                SubCat = "Road Frames",
                OrderYear = 2003,
                OrderQtr = "Q4",
                Sales = 286591.8208
            };
            datas.Add(data);
            data = new SalesDetails()
            {
                ProdCat = "Accessories",
                SubCat = "Tires and Tubes",
                OrderYear = 2003,
                OrderQtr = "Q3",
                Sales = 41940.3364
            };
            datas.Add(data);
            data = new SalesDetails()
            {
                ProdCat = "Components",
                SubCat = "Mountain Frames",
                OrderYear = 2003,
                OrderQtr = "Q2",
                Sales = 440260.9831
            };
            datas.Add(data);
            data = new SalesDetails()
            {
                ProdCat = "Components",
                SubCat = "Road Frames",
                OrderYear = 2003,
                OrderQtr = "Q2",
                Sales = 457688.8401
            };
            datas.Add(data);
            data = new SalesDetails()
            {
                ProdCat = "Clothing",
                SubCat = "Vests",
                OrderYear = 2003,
                OrderQtr = "Q4",
                Sales = 66882.6450
            };
            datas.Add(data);
            data = new SalesDetails()
            {
                ProdCat = "Accessories",
                SubCat = "Pumps",
                OrderYear = 2002,
                OrderQtr = "Q4",
                Sales = 3226.3860
            };
            datas.Add(data);
            data = new SalesDetails()
            {
                ProdCat = "Clothing",
                SubCat = "Tights",
                OrderYear = 2003,
                OrderQtr = "Q2",
                Sales = 51600.6190
            };
            datas.Add(data);
            data = new SalesDetails()
            {
                ProdCat = "Components",
                SubCat = "Chains",
                OrderYear = 2003,
                OrderQtr = "Q3",
                Sales = 3476.0176
            };
            datas.Add(data);
            data = new SalesDetails()
            {
                ProdCat = "Components",
                SubCat = "Handlebars",
                OrderYear = 2003,
                OrderQtr = "Q2",
                Sales = 17194.2146
            };
            datas.Add(data);
            data = new SalesDetails()
            {
                ProdCat = "Components",
                SubCat = "Mountain Frames",
                OrderYear = 2003,
                OrderQtr = "Q4",
                Sales = 565229.8810
            };
            datas.Add(data);
            data = new SalesDetails()
            {
                ProdCat = "Clothing",
                SubCat = "Tights",
                OrderYear = 2003,
                OrderQtr = "Q4",
                Sales = 243.7175
            };
            datas.Add(data);
            data = new SalesDetails()
            {
                ProdCat = "Components",
                SubCat = "Road Frames",
                OrderYear = 2002,
                OrderQtr = "Q2",
                Sales = 155311.4063
            };
            datas.Add(data);
            data = new SalesDetails()
            {
                ProdCat = "Components",
                SubCat = "Mountain Frames",
                OrderYear = 2002,
                OrderQtr = "Q2",
                Sales = 220935.1648
            };
            datas.Add(data);
            data = new SalesDetails()
            {
                ProdCat = "Accessories",
                SubCat = "Locks",
                OrderYear = 2003,
                OrderQtr = "Q4",
                Sales = 15.0000
            };
            datas.Add(data);
            data = new SalesDetails()
            {
                ProdCat = "Components",
                SubCat = "Mountain Frames",
                OrderYear = 2003,
                OrderQtr = "Q3",
                Sales = 827287.5234
            };
            datas.Add(data);
            data = new SalesDetails()
            {
                ProdCat = "Accessories",
                SubCat = "Bike Racks",
                OrderYear = 2003,
                OrderQtr = "Q3",
                Sales = 75920.4000
            };
            datas.Add(data);
            data = new SalesDetails()
            {
                ProdCat = "Components",
                SubCat = "Bottom Brackets",
                OrderYear = 2003,
                OrderQtr = "Q3",
                Sales = 17453.6400
            };
            datas.Add(data);
            data = new SalesDetails()
            {
                ProdCat = "Bikes",
                SubCat = "Touring Bikes",
                OrderYear = 2003,
                OrderQtr = "Q3",
                Sales = 3298006.2858
            };
            datas.Add(data);
            data = new SalesDetails()
            {
                ProdCat = "Components",
                SubCat = "Brakes",
                OrderYear = 2003,
                OrderQtr = "Q4",
                Sales = 18571.4700
            };
            datas.Add(data);
            data = new SalesDetails()
            {
                ProdCat = "Clothing",
                SubCat = "Tights",
                OrderYear = 2002,
                OrderQtr = "Q4",
                Sales = 56782.4280
            };
            datas.Add(data);
            data = new SalesDetails()
            {
                ProdCat = "Components",
                SubCat = "Pedals",
                OrderYear = 2003,
                OrderQtr = "Q3",
                Sales = 54185.2014
            };
            datas.Add(data);
            data = new SalesDetails()
            {
                ProdCat = "Clothing",
                SubCat = "Jerseys",
                OrderYear = 2003,
                OrderQtr = "Q3",
                Sales = 173041.0492
            };
            datas.Add(data);
            data = new SalesDetails()
            {
                ProdCat = "Clothing",
                SubCat = "Jerseys",
                OrderYear = 2002,
                OrderQtr = "Q2",
                Sales = 16931.2362
            };
            datas.Add(data);
            data = new SalesDetails()
            {
                ProdCat = "Components",
                SubCat = "Headsets",
                OrderYear = 2002,
                OrderQtr = "Q3",
                Sales = 19701.9001
            };
            datas.Add(data);
            data = new SalesDetails()
            {
                ProdCat = "Components",
                SubCat = "Road Frames",
                OrderYear = 2002,
                OrderQtr = "Q4",
                Sales = 458089.4246
            };
            datas.Add(data);
            data = new SalesDetails()
            {
                ProdCat = "Clothing",
                SubCat = "Shorts",
                OrderYear = 2003,
                OrderQtr = "Q1",
                Sales = 11230.1280
            };
            datas.Add(data);
            data = new SalesDetails()
            {
                ProdCat = "Bikes",
                SubCat = "Road Bikes",
                OrderYear = 2002,
                OrderQtr = "Q4",
                Sales = 4189621.8590
            };
            datas.Add(data);
            data = new SalesDetails()
            {
                ProdCat = "Components",
                SubCat = "Brakes",
                OrderYear = 2003,
                OrderQtr = "Q3",
                Sales = 26659.0800
            };
            datas.Add(data);
            data = new SalesDetails()
            {
                ProdCat = "Components",
                SubCat = "Wheels",
                OrderYear = 2003,
                OrderQtr = "Q4",
                Sales = 83.2981
            };
            datas.Add(data);
            data = new SalesDetails()
            {
                ProdCat = "Clothing",
                SubCat = "Vests",
                OrderYear = 2003,
                OrderQtr = "Q3",
                Sales = 81085.6900
            };
            datas.Add(data);
            data = new SalesDetails()
            {
                ProdCat = "Components",
                SubCat = "Cranksets",
                OrderYear = 2003,
                OrderQtr = "Q3",
                Sales = 80244.1372
            };
            datas.Add(data);
            data = new SalesDetails()
            {
                ProdCat = "Clothing",
                SubCat = "Socks",
                OrderYear = 2003,
                OrderQtr = "Q4",
                Sales = 6183.1422
            };
            datas.Add(data);
            data = new SalesDetails()
            {
                ProdCat = "Components",
                SubCat = "Wheels",
                OrderYear = 2003,
                OrderQtr = "Q2",
                Sales = 163929.9435
            };
            datas.Add(data);
            data = new SalesDetails()
            {
                ProdCat = "Clothing",
                SubCat = "Tights",
                OrderYear = 2002,
                OrderQtr = "Q3",
                Sales = 67088.3037
            };
            datas.Add(data);
            data = new SalesDetails()
            {
                ProdCat = "Clothing",
                SubCat = "Tights",
                OrderYear = 2003,
                OrderQtr = "Q3",
                Sales = 779.8960
            };
            datas.Add(data);
            data = new SalesDetails()
            {
                ProdCat = "Clothing",
                SubCat = "Socks",
                OrderYear = 2002,
                OrderQtr = "Q1",
                Sales = 1273.8550
            };
            datas.Add(data);
            data = new SalesDetails()
            {
                ProdCat = "Bikes",
                SubCat = "Road Bikes",
                OrderYear = 2002,
                OrderQtr = "Q3",
                Sales = 4930692.7825
            };
            datas.Add(data);
            data = new SalesDetails()
            {
                ProdCat = "Clothing",
                SubCat = "Shorts",
                OrderYear = 2003,
                OrderQtr = "Q4",
                Sales = 84192.3708
            };
            datas.Add(data);
            data = new SalesDetails()
            {
                ProdCat = "Clothing",
                SubCat = "Jerseys",
                OrderYear = 2002,
                OrderQtr = "Q3",
                Sales = 48901.7598
            };
            datas.Add(data);
            return datas;
        }
    }
    #endregion
}
