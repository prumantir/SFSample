using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Syncfusion.JavaScript;
using SFSample.Kanban;
namespace SFSample
{
    public partial class KanbanController : Controller
    {
        //
        // GET: /Kanban/
        public ActionResult KanbanFeatures()
        {
            var DataSource = new NorthwindDataContext().Tasks.Take(30).ToList();
            ViewBag.datasource = DataSource;
            return View();
        }
    }
}
