using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace SFSample
{
    public partial class ListViewController: Controller
    {
        public ActionResult ListViewFeatures()
        {
              return View();
        } 
	public ActionResult DataBindingLocal()
        {
            ListDataModal.clearSource();
            return View(ListDataModal.setListDataSource());
        }
        public ActionResult CheckList()
        {
            return View();
        }
    }
    public class ListData
    {
        public string texts { get; set; }
    }
    public static class ListDataModal
    {
        public static List<ListData> listTempSource = new List<ListData>();
        public static List<ListData> setListDataSource()
        {
            listTempSource.Add(new ListData { texts = "Discover Music" });
            listTempSource.Add(new ListData { texts = "Sales and Events" });
            listTempSource.Add(new ListData { texts = "Categories" });
            listTempSource.Add(new ListData { texts = "MP3 Albums" });
            listTempSource.Add(new ListData { texts = "More in Music" });
            return listTempSource;
        }
        public static void clearSource()
        {
            listTempSource.Clear();
        }
    }
}
