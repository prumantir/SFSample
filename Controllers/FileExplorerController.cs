using System;
using System.Web.Mvc;
using Syncfusion.JavaScript;
namespace SFSample
{
     public partial class FileExplorerController: Controller
    {
        public ActionResult FileExplorerFeatures()
        {
              return View();
        }
	public ActionResult FileActionDefault(FileExplorerParams args)
        {
	    FileExplorerOperations opeartion = new FileExplorerOperations();
            switch (args.ActionType)
            {
                case "Read":
                    return Json(opeartion.Read(args.Path, args.ExtensionsAllow));
                case "CreateFolder":
                    return Json(opeartion.CreateFolder(args.Path, args.Name));
                case "Paste":
                    return Json(opeartion.Paste(args.LocationFrom, args.LocationTo, args.Names, args.Action, args.CommonFiles));
                case "Remove":
                    return Json(opeartion.Remove(args.Names, args.Path));
                case "Rename":
                    return Json(opeartion.Rename(args.Path, args.Name, args.NewName, args.CommonFiles));
                case "GetDetails":
                    return Json(opeartion.GetDetails(args.Path, args.Names));
                case "Download":
                    opeartion.Download(args.Path, args.Names);
                    break;               
                case "Upload":
                    opeartion.Upload(args.FileUpload, args.Path);
                    break;
                case "Search":
                    return Json(opeartion.Search(args.Path, args.ExtensionsAllow, args.SearchString, args.CaseSensitive));
            }
            return Json("");
        } 
    }
}
